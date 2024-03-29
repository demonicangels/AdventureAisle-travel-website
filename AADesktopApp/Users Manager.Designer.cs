﻿namespace DesktopApp
{
    partial class CRUDusers
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
            label1 = new Label();
            usernameUsertxt = new TextBox();
            emailUsertxt = new TextBox();
            passwordUsertxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userScreen = new ListBox();
            insert_btn = new Button();
            delete_btn = new Button();
            getAll_btn = new Button();
            get_btn = new Button();
            searchByIdtxt = new TextBox();
            label5 = new Label();
            birthdayDtp = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 64);
            label1.TabIndex = 6;
            label1.Text = "ADD USER";
            // 
            // usernameUsertxt
            // 
            usernameUsertxt.Location = new Point(98, 71);
            usernameUsertxt.Margin = new Padding(2, 2, 2, 2);
            usernameUsertxt.Name = "usernameUsertxt";
            usernameUsertxt.Size = new Size(121, 27);
            usernameUsertxt.TabIndex = 7;
            // 
            // emailUsertxt
            // 
            emailUsertxt.Location = new Point(98, 103);
            emailUsertxt.Margin = new Padding(2, 2, 2, 2);
            emailUsertxt.Name = "emailUsertxt";
            emailUsertxt.Size = new Size(121, 27);
            emailUsertxt.TabIndex = 8;
            // 
            // passwordUsertxt
            // 
            passwordUsertxt.Location = new Point(98, 134);
            passwordUsertxt.Margin = new Padding(2, 2, 2, 2);
            passwordUsertxt.Name = "passwordUsertxt";
            passwordUsertxt.Size = new Size(121, 27);
            passwordUsertxt.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 134);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // userScreen
            // 
            userScreen.FormattingEnabled = true;
            userScreen.ItemHeight = 20;
            userScreen.Location = new Point(293, 84);
            userScreen.Margin = new Padding(2, 2, 2, 2);
            userScreen.Name = "userScreen";
            userScreen.Size = new Size(362, 284);
            userScreen.TabIndex = 17;
            userScreen.Click += userScreen_Click;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(34, 280);
            insert_btn.Margin = new Padding(2, 2, 2, 2);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(90, 51);
            insert_btn.TabIndex = 18;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            insert_btn.Click += insert_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(137, 280);
            delete_btn.Margin = new Padding(2, 2, 2, 2);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(90, 51);
            delete_btn.TabIndex = 19;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // getAll_btn
            // 
            getAll_btn.Location = new Point(34, 336);
            getAll_btn.Margin = new Padding(2, 2, 2, 2);
            getAll_btn.Name = "getAll_btn";
            getAll_btn.Size = new Size(90, 51);
            getAll_btn.TabIndex = 20;
            getAll_btn.Text = "GetAll";
            getAll_btn.UseVisualStyleBackColor = true;
            getAll_btn.Click += getAll_btn_Click;
            // 
            // get_btn
            // 
            get_btn.Location = new Point(137, 336);
            get_btn.Margin = new Padding(2, 2, 2, 2);
            get_btn.Name = "get_btn";
            get_btn.Size = new Size(90, 51);
            get_btn.TabIndex = 21;
            get_btn.Text = "Get by email";
            get_btn.UseVisualStyleBackColor = true;
            get_btn.Click += get_btn_Click;
            // 
            // searchByIdtxt
            // 
            searchByIdtxt.Location = new Point(137, 392);
            searchByIdtxt.Margin = new Padding(2, 2, 2, 2);
            searchByIdtxt.Name = "searchByIdtxt";
            searchByIdtxt.Size = new Size(90, 27);
            searchByIdtxt.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 214);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 23;
            label5.Text = "Birthday";
            // 
            // birthdayDtp
            // 
            birthdayDtp.Location = new Point(23, 237);
            birthdayDtp.Margin = new Padding(2, 2, 2, 2);
            birthdayDtp.Name = "birthdayDtp";
            birthdayDtp.Size = new Size(239, 27);
            birthdayDtp.TabIndex = 24;
            // 
            // CRUDusers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 436);
            Controls.Add(birthdayDtp);
            Controls.Add(label5);
            Controls.Add(searchByIdtxt);
            Controls.Add(get_btn);
            Controls.Add(getAll_btn);
            Controls.Add(delete_btn);
            Controls.Add(insert_btn);
            Controls.Add(userScreen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordUsertxt);
            Controls.Add(emailUsertxt);
            Controls.Add(usernameUsertxt);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CRUDusers";
            Text = "CRUDusers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameUsertxt;
        private TextBox emailUsertxt;
        private TextBox passwordUsertxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox userScreen;
        private Button insert_btn;
        private Button delete_btn;
        private Button getAll_btn;
        private Button get_btn;
        private TextBox searchByIdtxt;
        private Label label5;
        private DateTimePicker birthdayDtp;
    }
}