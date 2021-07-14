namespace HPQ_Project
{
    partial class Main
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
            this.top = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.logError = new System.Windows.Forms.TextBox();
            this.loginUnameBox = new System.Windows.Forms.TextBox();
            this.loginUnameLabel = new System.Windows.Forms.Label();
            this.loginPwordLabel = new System.Windows.Forms.Label();
            this.loginPwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.regError = new System.Windows.Forms.TextBox();
            this.regEmailBox = new System.Windows.Forms.TextBox();
            this.regEmailLabel = new System.Windows.Forms.Label();
            this.regUnameBox = new System.Windows.Forms.TextBox();
            this.regUnameLabel = new System.Windows.Forms.Label();
            this.regPwordLabel = new System.Windows.Forms.Label();
            this.regPwordBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.logPanelB = new System.Windows.Forms.Button();
            this.regPanelB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.close);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(707, 24);
            this.top.TabIndex = 0;
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.title.Location = new System.Drawing.Point(12, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(252, 22);
            this.title.TabIndex = 1;
            this.title.Text = "HPQ Project - Login System";
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(644, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(63, 24);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.logError);
            this.loginPanel.Controls.Add(this.loginUnameBox);
            this.loginPanel.Controls.Add(this.loginUnameLabel);
            this.loginPanel.Controls.Add(this.loginPwordLabel);
            this.loginPanel.Controls.Add(this.loginPwordBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(16, 78);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(666, 430);
            this.loginPanel.TabIndex = 2;
            // 
            // logError
            // 
            this.logError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.logError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logError.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.logError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logError.Location = new System.Drawing.Point(25, 231);
            this.logError.Name = "logError";
            this.logError.Size = new System.Drawing.Size(636, 26);
            this.logError.TabIndex = 22;
            this.logError.Text = "Sample Error Message";
            this.logError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logError.Visible = false;
            // 
            // loginUnameBox
            // 
            this.loginUnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginUnameBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginUnameBox.Location = new System.Drawing.Point(250, 121);
            this.loginUnameBox.Name = "loginUnameBox";
            this.loginUnameBox.Size = new System.Drawing.Size(285, 33);
            this.loginUnameBox.TabIndex = 10;
            // 
            // loginUnameLabel
            // 
            this.loginUnameLabel.AutoSize = true;
            this.loginUnameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginUnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginUnameLabel.Location = new System.Drawing.Point(131, 124);
            this.loginUnameLabel.Name = "loginUnameLabel";
            this.loginUnameLabel.Size = new System.Drawing.Size(113, 24);
            this.loginUnameLabel.TabIndex = 9;
            this.loginUnameLabel.Text = "Username";
            // 
            // loginPwordLabel
            // 
            this.loginPwordLabel.AutoSize = true;
            this.loginPwordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginPwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginPwordLabel.Location = new System.Drawing.Point(131, 183);
            this.loginPwordLabel.Name = "loginPwordLabel";
            this.loginPwordLabel.Size = new System.Drawing.Size(104, 24);
            this.loginPwordLabel.TabIndex = 8;
            this.loginPwordLabel.Text = "Password";
            // 
            // loginPwordBox
            // 
            this.loginPwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginPwordBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.loginPwordBox.Location = new System.Drawing.Point(250, 180);
            this.loginPwordBox.Name = "loginPwordBox";
            this.loginPwordBox.PasswordChar = '*';
            this.loginPwordBox.Size = new System.Drawing.Size(285, 33);
            this.loginPwordBox.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(279, 275);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 43);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerPanel
            // 
            this.registerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPanel.Controls.Add(this.regError);
            this.registerPanel.Controls.Add(this.regEmailBox);
            this.registerPanel.Controls.Add(this.regEmailLabel);
            this.registerPanel.Controls.Add(this.regUnameBox);
            this.registerPanel.Controls.Add(this.regUnameLabel);
            this.registerPanel.Controls.Add(this.regPwordLabel);
            this.registerPanel.Controls.Add(this.regPwordBox);
            this.registerPanel.Controls.Add(this.regButton);
            this.registerPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.registerPanel.Location = new System.Drawing.Point(16, 78);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(666, 430);
            this.registerPanel.TabIndex = 3;
            // 
            // regError
            // 
            this.regError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.regError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regError.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.regError.Location = new System.Drawing.Point(25, 231);
            this.regError.Name = "regError";
            this.regError.Size = new System.Drawing.Size(636, 26);
            this.regError.TabIndex = 21;
            this.regError.Text = "Sample Error Message";
            this.regError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regError.Visible = false;
            // 
            // regEmailBox
            // 
            this.regEmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.regEmailBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regEmailBox.Location = new System.Drawing.Point(250, 59);
            this.regEmailBox.Name = "regEmailBox";
            this.regEmailBox.Size = new System.Drawing.Size(285, 33);
            this.regEmailBox.TabIndex = 20;
            // 
            // regEmailLabel
            // 
            this.regEmailLabel.AutoSize = true;
            this.regEmailLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regEmailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.regEmailLabel.Location = new System.Drawing.Point(171, 62);
            this.regEmailLabel.Name = "regEmailLabel";
            this.regEmailLabel.Size = new System.Drawing.Size(64, 24);
            this.regEmailLabel.TabIndex = 19;
            this.regEmailLabel.Text = "Email";
            // 
            // regUnameBox
            // 
            this.regUnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.regUnameBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regUnameBox.Location = new System.Drawing.Point(250, 121);
            this.regUnameBox.Name = "regUnameBox";
            this.regUnameBox.Size = new System.Drawing.Size(285, 33);
            this.regUnameBox.TabIndex = 17;
            // 
            // regUnameLabel
            // 
            this.regUnameLabel.AutoSize = true;
            this.regUnameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regUnameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.regUnameLabel.Location = new System.Drawing.Point(131, 124);
            this.regUnameLabel.Name = "regUnameLabel";
            this.regUnameLabel.Size = new System.Drawing.Size(113, 24);
            this.regUnameLabel.TabIndex = 16;
            this.regUnameLabel.Text = "Username";
            // 
            // regPwordLabel
            // 
            this.regPwordLabel.AutoSize = true;
            this.regPwordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regPwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.regPwordLabel.Location = new System.Drawing.Point(131, 183);
            this.regPwordLabel.Name = "regPwordLabel";
            this.regPwordLabel.Size = new System.Drawing.Size(104, 24);
            this.regPwordLabel.TabIndex = 15;
            this.regPwordLabel.Text = "Password";
            // 
            // regPwordBox
            // 
            this.regPwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.regPwordBox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.regPwordBox.Location = new System.Drawing.Point(250, 180);
            this.regPwordBox.Name = "regPwordBox";
            this.regPwordBox.PasswordChar = '*';
            this.regPwordBox.Size = new System.Drawing.Size(285, 33);
            this.regPwordBox.TabIndex = 14;
            // 
            // regButton
            // 
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regButton.Location = new System.Drawing.Point(279, 275);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(155, 43);
            this.regButton.TabIndex = 13;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // logPanelB
            // 
            this.logPanelB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.logPanelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logPanelB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPanelB.ForeColor = System.Drawing.SystemColors.Control;
            this.logPanelB.Location = new System.Drawing.Point(16, 44);
            this.logPanelB.Name = "logPanelB";
            this.logPanelB.Size = new System.Drawing.Size(118, 35);
            this.logPanelB.TabIndex = 21;
            this.logPanelB.Text = "Login";
            this.logPanelB.UseVisualStyleBackColor = true;
            this.logPanelB.Click += new System.EventHandler(this.logPanelB_Click);
            // 
            // regPanelB
            // 
            this.regPanelB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.regPanelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regPanelB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPanelB.ForeColor = System.Drawing.SystemColors.Control;
            this.regPanelB.Location = new System.Drawing.Point(134, 44);
            this.regPanelB.Name = "regPanelB";
            this.regPanelB.Size = new System.Drawing.Size(118, 35);
            this.regPanelB.TabIndex = 22;
            this.regPanelB.Text = "Register";
            this.regPanelB.UseVisualStyleBackColor = true;
            this.regPanelB.Click += new System.EventHandler(this.regPanelB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(12, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Made by Sean Hendrick for HPQ.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(707, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.regPanelB);
            this.Controls.Add(this.logPanelB);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox loginUnameBox;
        private System.Windows.Forms.Label loginUnameLabel;
        private System.Windows.Forms.Label loginPwordLabel;
        private System.Windows.Forms.TextBox loginPwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.TextBox regEmailBox;
        private System.Windows.Forms.Label regEmailLabel;
        private System.Windows.Forms.TextBox regUnameBox;
        private System.Windows.Forms.Label regUnameLabel;
        private System.Windows.Forms.Label regPwordLabel;
        private System.Windows.Forms.TextBox regPwordBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button logPanelB;
        private System.Windows.Forms.Button regPanelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regError;
        private System.Windows.Forms.TextBox logError;

    }
}

