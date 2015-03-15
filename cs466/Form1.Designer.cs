namespace cs466
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintLink = new System.Windows.Forms.LinkLabel();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chapterTreeView = new System.Windows.Forms.TreeView();
            this.currentProgressBar = new System.Windows.Forms.ProgressBar();
            this.questionType = new System.Windows.Forms.Label();
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.chapterComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.questionLabel);
            this.groupBox1.Controls.Add(this.answerLabel);
            this.groupBox1.Controls.Add(this.hintLabel);
            this.groupBox1.Controls.Add(this.hintLink);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.answerBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.chapterTreeView);
            this.groupBox1.Controls.Add(this.currentProgressBar);
            this.groupBox1.Controls.Add(this.questionType);
            this.groupBox1.Controls.Add(this.questionTypeComboBox);
            this.groupBox1.Controls.Add(this.chapterLabel);
            this.groupBox1.Controls.Add(this.chapterComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Review";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(22, 318);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(310, 48);
            this.questionLabel.TabIndex = 12;
            this.questionLabel.Text = "Silence will fall when the question is asked.";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(19, 427);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(42, 13);
            this.answerLabel.TabIndex = 11;
            this.answerLabel.Text = "Answer";
            // 
            // hintLabel
            // 
            this.hintLabel.Location = new System.Drawing.Point(58, 375);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(274, 34);
            this.hintLabel.TabIndex = 10;
            // 
            // hintLink
            // 
            this.hintLink.AutoSize = true;
            this.hintLink.Location = new System.Drawing.Point(19, 375);
            this.hintLink.Name = "hintLink";
            this.hintLink.Size = new System.Drawing.Size(26, 13);
            this.hintLink.TabIndex = 9;
            this.hintLink.TabStop = true;
            this.hintLink.Text = "Hint";
            this.hintLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hintLink_LinkClicked);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(348, 422);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.FormattingEnabled = true;
            this.answerBox.Location = new System.Drawing.Point(61, 424);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(271, 21);
            this.answerBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 220);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // chapterTreeView
            // 
            this.chapterTreeView.Location = new System.Drawing.Point(348, 27);
            this.chapterTreeView.Name = "chapterTreeView";
            this.chapterTreeView.Size = new System.Drawing.Size(208, 382);
            this.chapterTreeView.TabIndex = 5;
            // 
            // currentProgressBar
            // 
            this.currentProgressBar.Location = new System.Drawing.Point(22, 54);
            this.currentProgressBar.Name = "currentProgressBar";
            this.currentProgressBar.Size = new System.Drawing.Size(310, 23);
            this.currentProgressBar.TabIndex = 4;
            // 
            // questionType
            // 
            this.questionType.AutoSize = true;
            this.questionType.Location = new System.Drawing.Point(128, 31);
            this.questionType.Name = "questionType";
            this.questionType.Size = new System.Drawing.Size(76, 13);
            this.questionType.TabIndex = 3;
            this.questionType.Text = "Question Type";
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.FormattingEnabled = true;
            this.questionTypeComboBox.Location = new System.Drawing.Point(212, 27);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(120, 21);
            this.questionTypeComboBox.TabIndex = 2;
            this.questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.questionTypeComboBox_SelectedIndexChanged);
            // 
            // chapterLabel
            // 
            this.chapterLabel.AutoSize = true;
            this.chapterLabel.Location = new System.Drawing.Point(19, 31);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(44, 13);
            this.chapterLabel.TabIndex = 1;
            this.chapterLabel.Text = "Chapter";
            // 
            // chapterComboBox
            // 
            this.chapterComboBox.FormattingEnabled = true;
            this.chapterComboBox.Location = new System.Drawing.Point(70, 27);
            this.chapterComboBox.Name = "chapterComboBox";
            this.chapterComboBox.Size = new System.Drawing.Size(45, 21);
            this.chapterComboBox.TabIndex = 0;
            this.chapterComboBox.SelectedIndexChanged += new System.EventHandler(this.chapterComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.registerLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 67);
            this.panel1.TabIndex = 1;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(351, 40);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(46, 13);
            this.registerLabel.TabIndex = 5;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Register";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(337, 9);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(231, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(231, 12);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(168, 40);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(168, 14);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS466";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.LinkLabel hintLink;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox answerBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView chapterTreeView;
        private System.Windows.Forms.ProgressBar currentProgressBar;
        private System.Windows.Forms.Label questionType;
		private System.Windows.Forms.ComboBox questionTypeComboBox;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.ComboBox chapterComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label questionLabel;
    }
}

