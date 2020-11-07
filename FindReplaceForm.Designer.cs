namespace TextEditor
{
    partial class FindReplaceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FindText = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FoundTextAm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceText = new System.Windows.Forms.TextBox();
            this.FindReplaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти";
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(13, 35);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(488, 27);
            this.FindText.TabIndex = 1;
            this.FindText.TextChanged += new System.EventHandler(this.FindText_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(507, 30);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(105, 37);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во совпадений:";
            // 
            // FoundTextAm
            // 
            this.FoundTextAm.AutoSize = true;
            this.FoundTextAm.Location = new System.Drawing.Point(203, 80);
            this.FoundTextAm.Name = "FoundTextAm";
            this.FoundTextAm.Size = new System.Drawing.Size(0, 20);
            this.FoundTextAm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заменить на";
            // 
            // ReplaceText
            // 
            this.ReplaceText.Location = new System.Drawing.Point(13, 145);
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(488, 27);
            this.ReplaceText.TabIndex = 6;
            // 
            // FindReplaceButton
            // 
            this.FindReplaceButton.Location = new System.Drawing.Point(507, 140);
            this.FindReplaceButton.Name = "FindReplaceButton";
            this.FindReplaceButton.Size = new System.Drawing.Size(105, 37);
            this.FindReplaceButton.TabIndex = 7;
            this.FindReplaceButton.Text = "Заменить";
            this.FindReplaceButton.UseVisualStyleBackColor = true;
            this.FindReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 194);
            this.Controls.Add(this.FindReplaceButton);
            this.Controls.Add(this.ReplaceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FoundTextAm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FindReplaceForm";
            this.Text = "FindReplaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindText;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FoundTextAm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReplaceText;
        private System.Windows.Forms.Button FindReplaceButton;
    }
}