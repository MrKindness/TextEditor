using System;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class FindReplaceForm : Form
    {
        public FindReplaceForm()
        {
            InitializeComponent();
        }

        public event Action<string> FindButtonClick;
        public event Action<string, string> ReplaceButtonClick;
        public event Action FindTextChanged;
        public int FindAmount { get { return int.Parse(FoundTextAm.Text); } set { FoundTextAm.Text = value.ToString(); } }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindButtonClick(FindText.Text);
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceButtonClick(FindText.Text, ReplaceText.Text);
        }

        private void FindText_TextChanged(object sender, EventArgs e)
        {
            FindTextChanged();
            FindAmount = 0;
        }
    }
}
