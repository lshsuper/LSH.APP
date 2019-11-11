namespace LSH.APP.Code.Generator
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_auth = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsi_login = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.db_tb_show = new System.Windows.Forms.GroupBox();
            this.lb_tbs = new System.Windows.Forms.ListBox();
            this.gb_db_show = new System.Windows.Forms.GroupBox();
            this.lb_dbs = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gb_operator = new System.Windows.Forms.GroupBox();
            this.btn_export_all_model = new System.Windows.Forms.Button();
            this.txt_export_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_export_model = new System.Windows.Forms.Button();
            this.txt_namespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_create_model = new System.Windows.Forms.Button();
            this.rtb_model_show = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.db_tb_show.SuspendLayout();
            this.gb_db_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gb_operator.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_auth,
            this.tmsi_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1107, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "ms";
            // 
            // tsmi_auth
            // 
            this.tsmi_auth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsi_login});
            this.tsmi_auth.Name = "tsmi_auth";
            this.tsmi_auth.Size = new System.Drawing.Size(51, 24);
            this.tsmi_auth.Text = "授权";
            // 
            // tmsi_login
            // 
            this.tmsi_login.Name = "tmsi_login";
            this.tmsi_login.Size = new System.Drawing.Size(114, 26);
            this.tmsi_login.Text = "登录";
            this.tmsi_login.Click += new System.EventHandler(this.tmsi_login_Click);
            // 
            // tmsi_about
            // 
            this.tmsi_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于软件ToolStripMenuItem});
            this.tmsi_about.Name = "tmsi_about";
            this.tmsi_about.Size = new System.Drawing.Size(51, 24);
            this.tmsi_about.Text = "关于";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.db_tb_show);
            this.splitContainer1.Panel1.Controls.Add(this.gb_db_show);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 563);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // db_tb_show
            // 
            this.db_tb_show.Controls.Add(this.lb_tbs);
            this.db_tb_show.Location = new System.Drawing.Point(16, 216);
            this.db_tb_show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.db_tb_show.Name = "db_tb_show";
            this.db_tb_show.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.db_tb_show.Size = new System.Drawing.Size(317, 328);
            this.db_tb_show.TabIndex = 1;
            this.db_tb_show.TabStop = false;
            this.db_tb_show.Text = "数据表展示";
            // 
            // lb_tbs
            // 
            this.lb_tbs.FormattingEnabled = true;
            this.lb_tbs.ItemHeight = 15;
            this.lb_tbs.Location = new System.Drawing.Point(8, 25);
            this.lb_tbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_tbs.Name = "lb_tbs";
            this.lb_tbs.Size = new System.Drawing.Size(300, 289);
            this.lb_tbs.TabIndex = 0;
            // 
            // gb_db_show
            // 
            this.gb_db_show.Controls.Add(this.lb_dbs);
            this.gb_db_show.Location = new System.Drawing.Point(16, 24);
            this.gb_db_show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_db_show.Name = "gb_db_show";
            this.gb_db_show.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_db_show.Size = new System.Drawing.Size(317, 168);
            this.gb_db_show.TabIndex = 0;
            this.gb_db_show.TabStop = false;
            this.gb_db_show.Text = "数据库展示";
            // 
            // lb_dbs
            // 
            this.lb_dbs.FormattingEnabled = true;
            this.lb_dbs.ItemHeight = 15;
            this.lb_dbs.Location = new System.Drawing.Point(8, 30);
            this.lb_dbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_dbs.Name = "lb_dbs";
            this.lb_dbs.Size = new System.Drawing.Size(300, 124);
            this.lb_dbs.TabIndex = 0;
            this.lb_dbs.Click += new System.EventHandler(this.lb_dbs_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gb_operator);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtb_model_show);
            this.splitContainer2.Size = new System.Drawing.Size(753, 563);
            this.splitContainer2.SplitterDistance = 159;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // gb_operator
            // 
            this.gb_operator.Controls.Add(this.btn_export_all_model);
            this.gb_operator.Controls.Add(this.txt_export_path);
            this.gb_operator.Controls.Add(this.label2);
            this.gb_operator.Controls.Add(this.btn_export_model);
            this.gb_operator.Controls.Add(this.txt_namespace);
            this.gb_operator.Controls.Add(this.label1);
            this.gb_operator.Controls.Add(this.btn_create_model);
            this.gb_operator.Location = new System.Drawing.Point(4, 4);
            this.gb_operator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_operator.Name = "gb_operator";
            this.gb_operator.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_operator.Size = new System.Drawing.Size(724, 149);
            this.gb_operator.TabIndex = 0;
            this.gb_operator.TabStop = false;
            this.gb_operator.Text = "操作栏";
            // 
            // btn_export_all_model
            // 
            this.btn_export_all_model.AutoSize = true;
            this.btn_export_all_model.Location = new System.Drawing.Point(322, 92);
            this.btn_export_all_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_export_all_model.Name = "btn_export_all_model";
            this.btn_export_all_model.Size = new System.Drawing.Size(283, 39);
            this.btn_export_all_model.TabIndex = 6;
            this.btn_export_all_model.Text = "导出全部模型（当前数据库）";
            this.btn_export_all_model.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btn_export_all_model.Click += new System.EventHandler(this.btn_export_all_model_Click);
=======
            this.btn_export_all_model.Click += new System.EventHandler(this.Btn_export_all_model_Click);
>>>>>>> 8dbee34abb6013f6ebb9ff30c9de5dc3ebba7a66
            // 
            // txt_export_path
            // 
            this.txt_export_path.Location = new System.Drawing.Point(141, 59);
            this.txt_export_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_export_path.Name = "txt_export_path";
            this.txt_export_path.Size = new System.Drawing.Size(208, 25);
            this.txt_export_path.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "导出文件路径:";
            // 
            // btn_export_model
            // 
            this.btn_export_model.AutoSize = true;
            this.btn_export_model.Location = new System.Drawing.Point(171, 92);
            this.btn_export_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_export_model.Name = "btn_export_model";
            this.btn_export_model.Size = new System.Drawing.Size(143, 39);
            this.btn_export_model.TabIndex = 3;
            this.btn_export_model.Text = "导出数据模型";
            this.btn_export_model.UseVisualStyleBackColor = true;
            this.btn_export_model.Click += new System.EventHandler(this.btn_export_model_Click);
            // 
            // txt_namespace
            // 
            this.txt_namespace.Location = new System.Drawing.Point(141, 25);
            this.txt_namespace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_namespace.Name = "txt_namespace";
            this.txt_namespace.Size = new System.Drawing.Size(208, 25);
            this.txt_namespace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "命名空间名称:";
            // 
            // btn_create_model
            // 
            this.btn_create_model.AutoSize = true;
            this.btn_create_model.Location = new System.Drawing.Point(20, 92);
            this.btn_create_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_create_model.Name = "btn_create_model";
            this.btn_create_model.Size = new System.Drawing.Size(143, 39);
            this.btn_create_model.TabIndex = 0;
            this.btn_create_model.Text = "生成数据模型";
            this.btn_create_model.UseVisualStyleBackColor = true;
            this.btn_create_model.Click += new System.EventHandler(this.btn_create_model_Click);
            // 
            // rtb_model_show
            // 
            this.rtb_model_show.Location = new System.Drawing.Point(4, 4);
            this.rtb_model_show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_model_show.Name = "rtb_model_show";
            this.rtb_model_show.Size = new System.Drawing.Size(740, 385);
            this.rtb_model_show.TabIndex = 0;
            this.rtb_model_show.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 591);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.Text = "代码生成器";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.db_tb_show.ResumeLayout(false);
            this.gb_db_show.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gb_operator.ResumeLayout(false);
            this.gb_operator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_auth;
        private System.Windows.Forms.ToolStripMenuItem tmsi_login;
        private System.Windows.Forms.ToolStripMenuItem tmsi_about;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gb_db_show;
        private System.Windows.Forms.ListBox lb_dbs;
        private System.Windows.Forms.GroupBox db_tb_show;
        private System.Windows.Forms.ListBox lb_tbs;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gb_operator;
        private System.Windows.Forms.Button btn_create_model;
        private System.Windows.Forms.RichTextBox rtb_model_show;
        private System.Windows.Forms.TextBox txt_namespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_export_model;
        private System.Windows.Forms.TextBox txt_export_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.Button btn_export_all_model;
    }
}

