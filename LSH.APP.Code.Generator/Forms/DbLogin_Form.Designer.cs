namespace LSH.APP.Code.Generator.Forms
{
    partial class DbLogin_Form
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
            this.cb_db_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_default_db = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库选择：";
            // 
            // cb_db_type
            // 
            this.cb_db_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_db_type.FormattingEnabled = true;
            this.cb_db_type.Location = new System.Drawing.Point(197, 78);
            this.cb_db_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_db_type.Name = "cb_db_type";
            this.cb_db_type.Size = new System.Drawing.Size(205, 23);
            this.cb_db_type.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名：";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(197, 194);
            this.txt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(205, 25);
            this.txt_login.TabIndex = 3;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(197, 240);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(205, 25);
            this.txt_pwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(179, 341);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 40);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(197, 120);
            this.txt_server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(205, 25);
            this.txt_server.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(197, 162);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(205, 25);
            this.txt_port.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PORT:";
            // 
            // txt_default_db
            // 
            this.txt_default_db.Location = new System.Drawing.Point(197, 282);
            this.txt_default_db.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_default_db.Name = "txt_default_db";
            this.txt_default_db.Size = new System.Drawing.Size(205, 25);
            this.txt_default_db.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "默认库名：";
            // 
            // DbLogin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.txt_default_db);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_db_type);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbLogin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库登录";
            this.Load += new System.EventHandler(this.DbLogin_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_db_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_default_db;
        private System.Windows.Forms.Label label6;
    }
}