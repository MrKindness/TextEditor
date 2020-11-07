namespace TextEditor
{
    partial class Interface
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.SaveSign = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintFile = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ItalicButton = new System.Windows.Forms.Button();
            this.UnderLineButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.NumericUpDown();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.TextContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.CutContext = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContext = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindReplaceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TextContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSign,
            this.toolStripStatusLabel1,
            this.SymbCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 627);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(896, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // SaveSign
            // 
            this.SaveSign.Name = "SaveSign";
            this.SaveSign.Size = new System.Drawing.Size(33, 20);
            this.SaveSign.Text = "test";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 20);
            this.toolStripStatusLabel1.Text = "Колличество символов:";
            // 
            // SymbCount
            // 
            this.SymbCount.Name = "SymbCount";
            this.SymbCount.Size = new System.Drawing.Size(58, 20);
            this.SymbCount.Text = "testtext";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.HelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(896, 31);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile,
            this.SaveAsFile,
            this.PrintFile});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(224, 28);
            this.OpenFile.Text = "Открыть";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(224, 28);
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // SaveAsFile
            // 
            this.SaveAsFile.Name = "SaveAsFile";
            this.SaveAsFile.Size = new System.Drawing.Size(224, 28);
            this.SaveAsFile.Text = "Сохранить как...";
            this.SaveAsFile.Click += new System.EventHandler(this.SaveAsFile_Click);
            // 
            // PrintFile
            // 
            this.PrintFile.Name = "PrintFile";
            this.PrintFile.Size = new System.Drawing.Size(224, 28);
            this.PrintFile.Text = "Печать";
            this.PrintFile.Click += new System.EventHandler(this.PrintFile_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(83, 27);
            this.HelpMenuItem.Text = "Помощь";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // BoldButton
            // 
            this.BoldButton.Location = new System.Drawing.Point(530, 24);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(40, 40);
            this.BoldButton.TabIndex = 2;
            this.BoldButton.Text = "Ж";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.Location = new System.Drawing.Point(576, 24);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(40, 40);
            this.ItalicButton.TabIndex = 7;
            this.ItalicButton.Text = "К";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderLineButton
            // 
            this.UnderLineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderLineButton.Location = new System.Drawing.Point(622, 24);
            this.UnderLineButton.Name = "UnderLineButton";
            this.UnderLineButton.Size = new System.Drawing.Size(40, 40);
            this.UnderLineButton.TabIndex = 8;
            this.UnderLineButton.Text = "Ч\r\n";
            this.UnderLineButton.UseVisualStyleBackColor = true;
            this.UnderLineButton.Click += new System.EventHandler(this.UnderLineButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton.Location = new System.Drawing.Point(105, 24);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(40, 40);
            this.RightButton.TabIndex = 8;
            this.RightButton.Text = "П";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(55, 24);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(40, 40);
            this.CenterButton.TabIndex = 7;
            this.CenterButton.Text = "Ц";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(5, 24);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(40, 40);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "Л";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorBox);
            this.groupBox1.Controls.Add(this.UnderLineButton);
            this.groupBox1.Controls.Add(this.FontSize);
            this.groupBox1.Controls.Add(this.ItalicButton);
            this.groupBox1.Controls.Add(this.FontBox);
            this.groupBox1.Controls.Add(this.BoldButton);
            this.groupBox1.Location = new System.Drawing.Point(5, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шрифт";
            // 
            // ColorBox
            // 
            this.ColorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(314, 25);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(210, 28);
            this.ColorBox.TabIndex = 9;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(227, 25);
            this.FontSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.FontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(81, 27);
            this.FontSize.TabIndex = 4;
            this.FontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.FontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // FontBox
            // 
            this.FontBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FontBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Location = new System.Drawing.Point(5, 25);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(216, 28);
            this.FontBox.TabIndex = 3;
            this.FontBox.SelectedIndexChanged += new System.EventHandler(this.FontBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightButton);
            this.groupBox2.Controls.Add(this.CenterButton);
            this.groupBox2.Controls.Add(this.LeftButton);
            this.groupBox2.Location = new System.Drawing.Point(689, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 70);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выравнивание";
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.ContextMenuStrip = this.TextContext;
            this.TextBox.Location = new System.Drawing.Point(5, 110);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(886, 513);
            this.TextBox.TabIndex = 10;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TextContext
            // 
            this.TextContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TextContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContext,
            this.CutContext,
            this.PasteContext});
            this.TextContext.Name = "TextContext";
            this.TextContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TextContext.Size = new System.Drawing.Size(163, 76);
            // 
            // CopyContext
            // 
            this.CopyContext.Name = "CopyContext";
            this.CopyContext.Size = new System.Drawing.Size(162, 24);
            this.CopyContext.Text = "Копировать";
            this.CopyContext.Click += new System.EventHandler(this.CopyContext_Click);
            // 
            // CutContext
            // 
            this.CutContext.Name = "CutContext";
            this.CutContext.Size = new System.Drawing.Size(162, 24);
            this.CutContext.Text = "Вырезать";
            this.CutContext.Click += new System.EventHandler(this.CutContext_Click);
            // 
            // PasteContext
            // 
            this.PasteContext.Name = "PasteContext";
            this.PasteContext.Size = new System.Drawing.Size(162, 24);
            this.PasteContext.Text = "Вставить";
            this.PasteContext.Click += new System.EventHandler(this.PasteContext_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindReplaceMenu});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // FindReplaceMenu
            // 
            this.FindReplaceMenu.Name = "FindReplaceMenu";
            this.FindReplaceMenu.Size = new System.Drawing.Size(224, 26);
            this.FindReplaceMenu.Text = "Поиск и замена";
            this.FindReplaceMenu.Click += new System.EventHandler(this.FindReplaceMenu_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 653);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(860, 260);
            this.Name = "Interface";
            this.Text = "TextEditor";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.TextContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SymbCount;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem PrintFile;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button ItalicButton;
        private System.Windows.Forms.Button UnderLineButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.NumericUpDown FontSize;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ContextMenuStrip TextContext;
        private System.Windows.Forms.ToolStripMenuItem CopyContext;
        private System.Windows.Forms.ToolStripMenuItem CutContext;
        private System.Windows.Forms.ToolStripMenuItem PasteContext;
        private System.Windows.Forms.ToolStripStatusLabel SaveSign;
        private System.Windows.Forms.ToolStripMenuItem SaveAsFile;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindReplaceMenu;
    }
}

