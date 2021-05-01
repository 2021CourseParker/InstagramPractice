namespace instagram
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameListBox = new System.Windows.Forms.ListBox();
            this.SwitchUserButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.NextImageButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.TagsTextBox = new System.Windows.Forms.TextBox();
            this.CommentsListBox = new System.Windows.Forms.ListBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.AddCommentsTextBox = new System.Windows.Forms.TextBox();
            this.AddCommentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameListBox
            // 
            this.UserNameListBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserNameListBox.Font = new System.Drawing.Font("Liberation Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameListBox.FormattingEnabled = true;
            this.UserNameListBox.ItemHeight = 30;
            this.UserNameListBox.Location = new System.Drawing.Point(12, 28);
            this.UserNameListBox.Name = "UserNameListBox";
            this.UserNameListBox.Size = new System.Drawing.Size(417, 514);
            this.UserNameListBox.TabIndex = 0;
            // 
            // SwitchUserButton
            // 
            this.SwitchUserButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SwitchUserButton.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SwitchUserButton.Location = new System.Drawing.Point(12, 559);
            this.SwitchUserButton.Name = "SwitchUserButton";
            this.SwitchUserButton.Size = new System.Drawing.Size(417, 60);
            this.SwitchUserButton.TabIndex = 1;
            this.SwitchUserButton.Text = "Switch User";
            this.SwitchUserButton.UseVisualStyleBackColor = false;
            this.SwitchUserButton.Click += new System.EventHandler(this.SwitchUserButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(513, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(586, 534);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // NextImageButton
            // 
            this.NextImageButton.BackColor = System.Drawing.Color.ForestGreen;
            this.NextImageButton.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextImageButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NextImageButton.Location = new System.Drawing.Point(513, 559);
            this.NextImageButton.Name = "NextImageButton";
            this.NextImageButton.Size = new System.Drawing.Size(586, 60);
            this.NextImageButton.TabIndex = 3;
            this.NextImageButton.Text = "Next Image";
            this.NextImageButton.UseVisualStyleBackColor = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(1143, 28);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(93, 36);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "User Name";
            // 
            // LikesLabel
            // 
            this.LikesLabel.AutoSize = true;
            this.LikesLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikesLabel.Location = new System.Drawing.Point(1143, 64);
            this.LikesLabel.Name = "LikesLabel";
            this.LikesLabel.Size = new System.Drawing.Size(54, 36);
            this.LikesLabel.TabIndex = 5;
            this.LikesLabel.Text = "Likes";
            // 
            // TagsTextBox
            // 
            this.TagsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TagsTextBox.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagsTextBox.Location = new System.Drawing.Point(1145, 93);
            this.TagsTextBox.Multiline = true;
            this.TagsTextBox.Name = "TagsTextBox";
            this.TagsTextBox.Size = new System.Drawing.Size(331, 156);
            this.TagsTextBox.TabIndex = 6;
            // 
            // CommentsListBox
            // 
            this.CommentsListBox.BackColor = System.Drawing.SystemColors.Control;
            this.CommentsListBox.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsListBox.FormattingEnabled = true;
            this.CommentsListBox.ItemHeight = 62;
            this.CommentsListBox.Location = new System.Drawing.Point(1145, 289);
            this.CommentsListBox.Name = "CommentsListBox";
            this.CommentsListBox.Size = new System.Drawing.Size(331, 128);
            this.CommentsListBox.TabIndex = 7;
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLabel.Location = new System.Drawing.Point(1143, 252);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(86, 36);
            this.CommentsLabel.TabIndex = 8;
            this.CommentsLabel.Text = "comments";
            this.CommentsLabel.Click += new System.EventHandler(this.CommentsLabel_Click);
            // 
            // AddCommentsTextBox
            // 
            this.AddCommentsTextBox.BackColor = System.Drawing.Color.White;
            this.AddCommentsTextBox.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCommentsTextBox.Location = new System.Drawing.Point(1145, 458);
            this.AddCommentsTextBox.Multiline = true;
            this.AddCommentsTextBox.Name = "AddCommentsTextBox";
            this.AddCommentsTextBox.Size = new System.Drawing.Size(331, 104);
            this.AddCommentsTextBox.TabIndex = 9;
            // 
            // AddCommentsButton
            // 
            this.AddCommentsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.AddCommentsButton.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCommentsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddCommentsButton.Location = new System.Drawing.Point(1145, 559);
            this.AddCommentsButton.Name = "AddCommentsButton";
            this.AddCommentsButton.Size = new System.Drawing.Size(331, 60);
            this.AddCommentsButton.TabIndex = 10;
            this.AddCommentsButton.Text = "Add Comments";
            this.AddCommentsButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 663);
            this.Controls.Add(this.AddCommentsButton);
            this.Controls.Add(this.AddCommentsTextBox);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.CommentsListBox);
            this.Controls.Add(this.TagsTextBox);
            this.Controls.Add(this.LikesLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.NextImageButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SwitchUserButton);
            this.Controls.Add(this.UserNameListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserNameListBox;
        private System.Windows.Forms.Button SwitchUserButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button NextImageButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label LikesLabel;
        private System.Windows.Forms.TextBox TagsTextBox;
        private System.Windows.Forms.ListBox CommentsListBox;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.TextBox AddCommentsTextBox;
        private System.Windows.Forms.Button AddCommentsButton;
    }
}

