namespace TextEditor
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Кнопка \"Открыть\"");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Кнопка \"Сохранить\"");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Кнопка \"Сохранить как\"");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Кнопка \"Печать\"");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Вкладка \"Файл\"", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Поиск и замена");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Вкладка \"Правка\"", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Меню - полоса", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Шрифт");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Форматирование текста");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Панель редактирования", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Зона редактирования");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Строка состояния");
            this.InfoContainer = new System.Windows.Forms.TreeView();
            this.InfoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InfoContainer
            // 
            this.InfoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoContainer.Location = new System.Drawing.Point(1, 1);
            this.InfoContainer.Name = "InfoContainer";
            treeNode1.Name = "Open";
            treeNode1.Text = "Кнопка \"Открыть\"";
            treeNode2.Name = "Save";
            treeNode2.Text = "Кнопка \"Сохранить\"";
            treeNode3.Name = "SaveAs";
            treeNode3.Text = "Кнопка \"Сохранить как\"";
            treeNode4.Name = "Print";
            treeNode4.Text = "Кнопка \"Печать\"";
            treeNode5.Name = "FileMenuStrip";
            treeNode5.Text = "Вкладка \"Файл\"";
            treeNode6.Name = "FindReplace";
            treeNode6.Text = "Поиск и замена";
            treeNode7.Name = "Узел6";
            treeNode7.Text = "Вкладка \"Правка\"";
            treeNode8.Name = "MenuStrip";
            treeNode8.Text = "Меню - полоса";
            treeNode9.Name = "Font";
            treeNode9.Text = "Шрифт";
            treeNode10.Name = "FontFormat";
            treeNode10.Text = "Форматирование текста";
            treeNode11.Name = "RedactPanel";
            treeNode11.Text = "Панель редактирования";
            treeNode12.Name = "RedactZone";
            treeNode12.Text = "Зона редактирования";
            treeNode13.Name = "StatusStrip";
            treeNode13.Text = "Строка состояния";
            this.InfoContainer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode11,
            treeNode12,
            treeNode13});
            this.InfoContainer.Size = new System.Drawing.Size(277, 722);
            this.InfoContainer.TabIndex = 0;
            this.InfoContainer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.InfoContainer_AfterSelect);
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBox.Location = new System.Drawing.Point(284, 0);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(669, 723);
            this.InfoBox.TabIndex = 1;
            this.InfoBox.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 723);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.InfoContainer);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView InfoContainer;
        private System.Windows.Forms.RichTextBox InfoBox;
    }
}