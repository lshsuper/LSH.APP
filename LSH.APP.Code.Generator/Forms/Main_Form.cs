using Client.Win.App.Common;
using LSH.APP.Code.Generator.Common;
using LSH.APP.Code.Generator.Forms;
using LSH.APP.Code.Generator.Models;
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
using System.Linq;
using System.IO;

namespace LSH.APP.Code.Generator
{
    public partial class Main_Form : Form
    {


        private DbLogin_Form _dbLogin_Form;


        public Main_Form()
        {
            InitializeComponent();
        }

        private void tmsi_login_Click(object sender, EventArgs e)
        {
            _dbLogin_Form = new DbLogin_Form();
            _dbLogin_Form._buildDbsShow = new Action<DataTable>((dt) =>
            {
                //清除上次操作记录下的数据库名称
                lb_dbs.Items.Clear();
                lb_dbs.DisplayMember = "value";
                lb_dbs.ValueMember = "value";
                lb_dbs.DataSource = dt;
            });
            _dbLogin_Form.ShowDialog();




        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void lb_dbs_Click(object sender, EventArgs e)
        {
            if (lb_dbs.SelectedValue == null)
                return;
            string db = lb_dbs.SelectedValue.ToString();
            var tbs = Utils.GetTables(AppContext.DatabaseInfo, db);
            lb_tbs.DisplayMember = "key";
            lb_tbs.ValueMember = "value";
            lb_tbs.DataSource = BuildTbs(tbs);
            AppContext.CurrentDatabase = new DatabaseInfoExt()
            {
                DatabaseName = db,
                TableInfos = tbs
            };

        }


        public DataTable BuildTbs(IEnumerable<TableInfo> tbs)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("value");
            dt.Columns.Add("key");
            tbs.ForEach((ele, i) =>
            {
                var row = dt.NewRow();
                row["key"] = ele.TableName;
                row["value"] = JsonHelper.ToJson(ele);
                dt.Rows.Add(row);
            });
            return dt;
        }
        /// <summary>
        /// 生成数据库模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_model_Click(object sender, EventArgs e)
        {
            if (lb_dbs.SelectedValue == null)
            {
                MessageBox.Show("请选择一个数据库");
                return;
            }

            if (lb_tbs.SelectedValue == null)
            {
                MessageBox.Show("请选择一个表");
                return;
            }
            string db = lb_dbs.SelectedValue.ToString();
            TableInfo tb = JsonHelper.ToObject<TableInfo>(lb_tbs.SelectedValue.ToString());
            var columns = Utils.GetColumns(AppContext.DatabaseInfo, db, tb.TableName);
            //持久化
            AppContext.CurrentTable = new TableInfoExt()
            {
                TableColumnInfos = columns,
                TableInfo = tb
            };
            rtb_model_show.Text = BuildModelTmpl(columns, tb);
            Utils.ChangeColor(rtb_model_show);

        }
        /// <summary>
        /// 导出数据模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_export_model_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_export_path.Text))
                {
                    MessageBox.Show("请设置文件输出路径");
                    return;
                }
                File.WriteAllText($"{txt_export_path.Text}\\{AppContext.CurrentTable.TableInfo.TableName}.cs", rtb_model_show.Text);
                MessageBox.Show("模型文件生成成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show("模型文件生成失败");
            }

        }

        private void Btn_export_all_model_Click(object sender, EventArgs e)
        {

            if (!txt_export_path.Text.IsPath())
            {
                MessageBox.Show("导出文件路径有误");
                return;
            }
            Dictionary<string, byte[]> bufferMap = new Dictionary<string, byte[]>();
            AppContext.CurrentDatabase.TableInfos.ForEach((ele, i) =>
            {
                var columns = Utils.GetColumns(AppContext.DatabaseInfo, AppContext.CurrentDatabase.DatabaseName, ele.TableName);
                string tmpl = BuildModelTmpl(columns,ele);
                bufferMap.Add($"{ele.TableName}.cs",Encoding.UTF8.GetBytes(tmpl));
            });

            //打包
           bool result=FileHelper.Zip(bufferMap,$"{txt_export_path.Text}\\{AppContext.CurrentDatabase.DatabaseName}.zip");
            if (!result)
            {
                MessageBox.Show("打包失败");
                return;
            }
            MessageBox.Show("打包成功");
        }


        private string BuildModelTmpl(IEnumerable<TableColumnInfo> columns, TableInfo tb)
        {
            StringBuilder tmpl = new StringBuilder();
            tmpl.AppendLine("using System;");
            tmpl.AppendLine("using System.Collections.Generic;");
            tmpl.AppendLine("using System.Runtime.Serialization;");
            tmpl.AppendFormat("namespace {0} \r\n", txt_namespace.Text);
            tmpl.AppendLine("{");
            tmpl.AppendLine($"{" ".Repeat(2)}///<summary>");
            tmpl.AppendFormat("{0}///{1}\r\n", " ".Repeat(2), tb.TableComment);
            tmpl.AppendLine($"{" ".Repeat(2)}///<summary>");
            tmpl.AppendLine($"{" ".Repeat(2)}[DataContract]");
            tmpl.AppendFormat("{0}public class {1}\r\n", " ".Repeat(2), tb.TableName);
            tmpl.AppendLine($"{" ".Repeat(2)}{"{"}");

            columns.ForEach((ele, i) =>
            {
                tmpl.AppendLine($"{" ".Repeat(6)}///<summary>");
                tmpl.AppendFormat("{0}///{1}\r\n", " ".Repeat(6), ele.ColumnComment);
                tmpl.AppendLine($"{" ".Repeat(6)}///<summary>");
                tmpl.AppendLine($"{" ".Repeat(6)}[DataMember]");
                tmpl.AppendFormat("{0}public {1} {2} {3}\r\n", " ".Repeat(6), Utils.ChangeDbType(ele.DataType), ele.ColumnName, "{get;set;}");
            });
            tmpl.AppendLine($"{" ".Repeat(4)}{"}"}");
            tmpl.AppendLine("}");
            return tmpl.ToString();
        }
    }
}
