using LSH.APP.Code.Generator.Common;
using LSH.APP.Code.Generator.Models;
using LSH.APP.Infrastructure.Extensions;
using LSH.APP.Infrastructure.Helpers.Database;
using LSH.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSH.APP.Code.Generator.Forms
{
    public partial class DbLogin_Form : Form
    {
        public DbLogin_Form()
        {
            InitializeComponent();
        }

        public Action<DataTable> _buildDbsShow;
        private void btn_login_Click(object sender, EventArgs e)
        {
            DatabaseConnectionOption databaseInfo = new DatabaseConnectionOption()
            {
                DatabaseType = (DatabaseTypeEnum)Enum.Parse(typeof(DatabaseTypeEnum), cb_db_type.SelectedValue.ToString()),
                Server = txt_server.Text,
                Port = txt_port.Text,
                Pwd = txt_pwd.Text,
                DefaultDatabase=txt_default_db.Text,
                Login=txt_login.Text
            };
            try
            {
                //查询所有数据库名称
                var dbs = Utils.GetDatabases(databaseInfo);
                _buildDbsShow(BuildDbs(dbs));
                AppContext.DatabaseInfo = databaseInfo;
                this.Close();
                MessageBox.Show("链接成功");

            }
            catch (Exception ex)
            {

                MessageBox.Show("链接失败。。。");
            }
           
        }

        private void DbLogin_Form_Load(object sender, EventArgs e)
        {
            cb_db_type.DisplayMember = "key";
            cb_db_type.ValueMember = "value";
            cb_db_type.DataSource = BuildTypes();


            txt_login.Text = "sa";
            txt_server.Text = "127.0.0.1";
            txt_port.Text = "1434";
            txt_pwd.Text = "1308956271";
            txt_default_db.Text = "CTFApp";
            cb_db_type.SelectedValue = DatabaseTypeEnum.SqlServer.GetHashCode();
        }

        private DataTable BuildTypes()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("key");
            dt.Columns.Add("value");
            foreach (DatabaseTypeEnum item in Enum.GetValues(typeof(DatabaseTypeEnum)))
            {
                var row = dt.NewRow();
                row["key"] = item.FindDescr();
                row["value"] = Convert.ToInt32(item);
                dt.Rows.Add(row);
            }
            return dt;

        }

        private DataTable BuildDbs(IEnumerable<string>dbs)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dbs.ForEach((ele,i)=> {
                var row = dt.NewRow();
                row["value"] = ele;
                dt.Rows.Add(row);
            });
           
            return dt;

        }
    }
}
