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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Узел16");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Вкладка \"Правка\"", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Меню - полоса", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Шрифт");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Панель редактирования", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Узел12");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Зона редактирования", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Узел13");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Узел14");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Строка состояния", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(1, 1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел15";
            treeNode1.Text = "Кнопка \"Открыть\"";
            treeNode2.Name = "Узел17";
            treeNode2.Text = "Кнопка \"Сохранить\"";
            treeNode3.Name = "Узел18";
            treeNode3.Text = "Кнопка \"Сохранить как\"";
            treeNode4.Name = "Узел19";
            treeNode4.Text = "Кнопка \"Печать\"";
            treeNode5.Name = "FileMenuStrip";
            treeNode5.Text = "Вкладка \"Файл\"";
            treeNode6.Name = "Узел16";
            treeNode6.Text = "Узел16";
            treeNode7.Name = "Узел6";
            treeNode7.Text = "Вкладка \"Правка\"";
            treeNode8.Name = "MenuStrip";
            treeNode8.Text = "Меню - полоса";
            treeNode9.Name = "Узел7";
            treeNode9.Text = "Шрифт";
            treeNode10.Name = "RedactPanel";
            treeNode10.Text = "Панель редактирования";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "Узел12";
            treeNode12.Name = "RedactZone";
            treeNode12.Text = "Зона редактирования";
            treeNode13.Name = "Узел13";
            treeNode13.Text = "Узел13";
            treeNode14.Name = "Узел14";
            treeNode14.Text = "Узел14";
            treeNode15.Name = "StatusStrip";
            treeNode15.Text = "Строка состояния";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(790, 428);
            this.treeView1.TabIndex = 0;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 429);
            this.Controls.Add(this.treeView1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}