using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Interface : Form
    {
        string filePath = "";
        string Filter = "Текстовые файлы (*.txt)|*.txt | Мощные текстовые файлы (*.rtf)|*.rtf";
        string LastSelected = "";
        FindReplaceForm FRForm = null;
        HelpForm HForm = null;
        public Interface()
        {
            InitializeComponent();

            Array colors = Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor knowColor in colors)
                ColorBox.Items.Add(Color.FromKnownColor(knowColor));
            ColorBox.SelectedItem = Color.Black;

            foreach (FontFamily family in FontFamily.Families)
                FontBox.Items.Add(family.Name);
            FontBox.SelectedItem = "Arial";

            SymbCount.Text = TextBox.Text.Length.ToString();
            SaveSign.Text = "Изменено";

            TextBox.Font = new Font((string)FontBox.SelectedItem, (int)FontSize.Value, TextBox.Font.Style);
            TextBox.Text = "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore";
        }

        #region FontParam

        private void FontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox.Font = new Font((string)FontBox.SelectedItem, (int)FontSize.Value, TextBox.Font.Style);
            SaveSign.Text = "Изменено";
        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length == 0)
                TextBox.SelectAll();
            TextBox.SelectionFont = new Font(TextBox.SelectionFont.Name, (int)FontSize.Value, TextBox.SelectionFont.Style);
            SaveSign.Text = "Изменено";
            TextBox.DeselectAll();
        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length == 0)
                TextBox.SelectAll();

            TextBox.SelectionColor = (Color)ColorBox.SelectedItem;
            TextBox.DeselectAll();
            SaveSign.Text = "Изменено";
        }

        #endregion

        #region FontAttrs

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length == 0)
                TextBox.SelectAll();

            if (TextBox.SelectionFont.Bold)
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & ~FontStyle.Bold);
            else
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, FontStyle.Bold | TextBox.SelectionFont.Style);
            TextBox.DeselectAll();
            SaveSign.Text = "Изменено";
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length == 0)
                TextBox.SelectAll();

            if (TextBox.SelectionFont.Italic)
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & ~FontStyle.Italic);
            else
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, FontStyle.Italic | TextBox.SelectionFont.Style);
            TextBox.DeselectAll();
            SaveSign.Text = "Изменено";
        }

        private void UnderLineButton_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length == 0)
                TextBox.SelectAll();

            if (TextBox.SelectionFont.Underline)
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style & ~FontStyle.Underline);
            else
                TextBox.SelectionFont = new Font(TextBox.SelectionFont, FontStyle.Underline | TextBox.SelectionFont.Style);
            TextBox.DeselectAll();
            SaveSign.Text = "Изменено";
        }

        #endregion

        #region FontAlign

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
                TextBox.SelectionAlignment = HorizontalAlignment.Left;
            SaveSign.Text = "Изменено";
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
                TextBox.SelectionAlignment = HorizontalAlignment.Center;
            SaveSign.Text = "Изменено";
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
                TextBox.SelectionAlignment = HorizontalAlignment.Right;
            SaveSign.Text = "Изменено";
        }

        #endregion

        #region TextBox_ToolStrip

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(SymbCount.Text) != TextBox.Text.Length) 
            {
                SaveSign.Text = "Изменено";
                SymbCount.Text = TextBox.Text.Length.ToString();
            }
        }

        private void PrintFile_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog()) 
            {
                PrintDocument docToPrint = new PrintDocument();
                printDialog.AllowSomePages = true;
                printDialog.ShowHelp = true;

                printDialog.Document = docToPrint;

                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    docToPrint.Print();
                }
            }
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            TextBox.SelectAll();
            Font printFont = new Font(TextBox.SelectionFont.FontFamily, (int)FontSize.Value, TextBox.SelectionFont.Style);
            e.Graphics.DrawString(TextBox.Text, printFont, Brushes.Black, 10, 10);
            TextBox.DeselectAll();
        }

        private void SaveAsFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.Filter = Filter;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    if (filePath.IndexOf(".txt") == -1)
                        TextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    else
                        File.WriteAllText(filePath, TextBox.Text);
                    SaveSign.Text = "Сохранено";
                }
            }
            
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (filePath == "")
                SaveAsFile_Click(sender, e);
            else
            {
                if (filePath.IndexOf(".txt") == -1)
                    TextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                else
                    File.WriteAllText(filePath, TextBox.Text);
                SaveSign.Text = "Сохранено";
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = Filter;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    if (filePath.IndexOf(".txt") == -1)
                        TextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    else
                        TextBox.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void FindReplaceMenu_Click(object sender, EventArgs e)
        {
            if (FRForm == null)
            {
                FRForm = new FindReplaceForm();
                FRForm.FormClosed += (object s, FormClosedEventArgs evargs) =>
                { FRForm = null; FRForm_FindTextChanged(); };
                FRForm.FindButtonClick += FRForm_FindButtonClick;
                FRForm.ReplaceButtonClick += FRForm_ReplaceButtonClick;
                FRForm.FindTextChanged += FRForm_FindTextChanged;
                FRForm.Show();
            }
        }

        private void FRForm_FindTextChanged()
        {
            if (LastSelected.Length > 0)
            {
                int i = 0;
                while (TextBox.Text.Length > i && TextBox.Text.IndexOf(LastSelected, i) != -1)
                {
                    TextBox.Select(TextBox.Text.IndexOf(LastSelected, i), LastSelected.Length);
                    TextBox.SelectionBackColor = Color.White;
                    i = TextBox.Text.IndexOf(LastSelected, i) + LastSelected.Length;
                }
                LastSelected = "";
            }
        }

        private void FRForm_FindButtonClick(string obj)
        {
            LastSelected = obj;
            int i = 0, am = 0;
            while (TextBox.Text.Length > i && TextBox.Text.IndexOf(LastSelected, i) != -1) 
            {
                TextBox.Select(TextBox.Text.IndexOf(LastSelected, i), LastSelected.Length);
                TextBox.SelectionBackColor = Color.Goldenrod;
                i = TextBox.Text.IndexOf(LastSelected, i) + LastSelected.Length;    
                am++;
            }

            if (am == 0)
                LastSelected = "";
            FRForm.FindAmount = am;
        }

        private void FRForm_ReplaceButtonClick(string OldVal, string NewVal)
        {
            TextBox.Text = TextBox.Text.Replace(OldVal, NewVal);
            SaveSign.Text = "Изменено";
            MessageBox.Show("Операция завершена!");
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            if (HForm == null) 
            {
                HForm = new HelpForm();
                HForm.FormClosed += (object s, FormClosedEventArgs evargs) => { HForm = null; };
                HForm.Show();
            }
        }

        #endregion

        #region Context

        private void CopyContext_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length > 0)
                Clipboard.SetText(TextBox.SelectedText);
        }

        private void CutContext_Click(object sender, EventArgs e)
        {
            if (TextBox.SelectedText.Length > 0)
            {
                Clipboard.SetText(TextBox.SelectedText);
                TextBox.SelectedText = "";
            } 
        }

        private void PasteContext_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                TextBox.Text = TextBox.Text.Insert(TextBox.SelectionStart, Clipboard.GetText());
        }

        #endregion
    }
}
