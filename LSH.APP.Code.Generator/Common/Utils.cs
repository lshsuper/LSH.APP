using LSH.APP.Code.Generator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSH.APP.Infrastructure.Extensions;
using LSH.APP.Infrastructure.Helpers.Database;

namespace LSH.APP.Code.Generator.Common
{
  public  class Utils
    {
        /// <summary>
        /// 着色改变
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        private  static void ChangeKeyColor(string key, Color color, RichTextBox richTextBox)
        {
            Regex regex = new Regex(key);
            MatchCollection matchCollection = regex.Matches(richTextBox.Text);
            foreach (Match match in matchCollection)
            {
                richTextBox.SelectionStart = match.Index;
                richTextBox.SelectionLength = key.Length;
                richTextBox.SelectionColor = color;
            }
        }

        /// <summary>
        /// 着色
        /// </summary>
        public static void ChangeColor(RichTextBox richTextBox)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.SelectionColor = Color.Black;

            ChangeKeyColor("using", Color.Blue, richTextBox);
            ChangeKeyColor("namespace", Color.Blue, richTextBox);
            ChangeKeyColor("public", Color.Blue, richTextBox);
            ChangeKeyColor("class", Color.Blue, richTextBox);
            ChangeKeyColor("/// <summary>", Color.Gray, richTextBox);
            ChangeKeyColor("///", Color.Gray, richTextBox);
            ChangeKeyColor("/// </summary>", Color.Gray, richTextBox);
            ChangeKeyColor("int", Color.Blue, richTextBox);
            ChangeKeyColor("double", Color.Blue, richTextBox);
            ChangeKeyColor("float", Color.Blue, richTextBox);
            ChangeKeyColor("char", Color.Blue, richTextBox);
            ChangeKeyColor("string", Color.Blue, richTextBox);
            ChangeKeyColor("bool", Color.Blue, richTextBox);
            ChangeKeyColor("decimal", Color.Blue, richTextBox);
            ChangeKeyColor("enum", Color.Blue, richTextBox);
            ChangeKeyColor("const", Color.Blue, richTextBox);
            ChangeKeyColor("struct", Color.Blue, richTextBox);
            ChangeKeyColor("DateTime", Color.CadetBlue, richTextBox);
            ChangeKeyColor("get", Color.Blue, richTextBox);
            ChangeKeyColor("byte", Color.Blue, richTextBox);
            ChangeKeyColor("set", Color.Blue, richTextBox);
            ChangeKeyColor("DataContract", Color.Green, richTextBox);
            ChangeKeyColor("DataMember", Color.Green, richTextBox);
        }

        /// <summary>
        /// 修正数据类型
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string ChangeDbType(string content)
        {
            content = Regex.Replace(content, "varchar", "string");
            content = Regex.Replace(content, "nvarchar", "string");
            content = Regex.Replace(content, "bit", "bool");
            content = Regex.Replace(content, "text", "string");
            content = Regex.Replace(content, "nchar", "string");
            content = Regex.Replace(content, "char", "string");
            content = Regex.Replace(content, "tinyint", "byte");
            content = Regex.Replace(content, "smallint", "short");
            content = Regex.Replace(content, "bigint", "long");
            content = Regex.Replace(content, "decimal", "decimal");
            content = Regex.Replace(content, "datetime", "DateTime");
            return content;
        }

        public  static IEnumerable<string> GetDatabases(DatabaseConnectionOption databaseInfo)
        {
            switch (databaseInfo.DatabaseType)
            {
                case DatabaseTypeEnum.Mysql:
                   return DapperContext.Query<string>(databaseInfo, "show databases");
                case DatabaseTypeEnum.SqlServer:
                    return DapperContext.Query<string>(databaseInfo, " select name from master.dbo.SysDatabases");
                 default:
                    throw new NotSupportedException("未支持");
            }
        }
        /// <summary>
        /// 获取数据库的表信息
        /// </summary>
        /// <param name="databaseInfo"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public  static IEnumerable<TableInfo> GetTables(DatabaseConnectionOption databaseInfo,string db)
        {
           
            switch (databaseInfo.DatabaseType)
            {
                case DatabaseTypeEnum.Mysql:
                    return DapperContext.Query<TableInfo>(databaseInfo, $"select table_name TableName,table_comment  TableComment from information_schema.tables where table_schema='{db}' and table_type='base table'");
                case DatabaseTypeEnum.SqlServer:
                    return DapperContext.Query<TableInfo>(databaseInfo, $"use {db} select  a.name AS 'TableName', g.[value] AS 'TableComment' from sys.tables a left join sys.extended_properties g on (a.object_id = g.major_id AND g.minor_id = 0)");
                default:
                    throw new NotSupportedException("未支持");
                          
            }
        }
        /// <summary>
        ///获取指定表的结构信息
        /// </summary>
        /// <param name="databaseInfo"></param>
        /// <param name="db"></param>
        /// <param name="tb"></param>
        /// <returns></returns>
        public static IEnumerable<TableColumnInfo> GetColumns(DatabaseConnectionOption databaseInfo, string db,string  tb)
        {

            switch (databaseInfo.DatabaseType)
            {
                case DatabaseTypeEnum.Mysql:
                    return DapperContext.Query<TableColumnInfo>(databaseInfo, $"select column_comment ColumnComment,data_type DataType,column_name  ColumnName from information_schema.columns where table_schema='{db}' and table_name='{tb}'");
                case DatabaseTypeEnum.SqlServer:
                    return DapperContext.Query<TableColumnInfo>(databaseInfo,$"use {db} select syscolumns.name as 'ColumnName',systypes.name as 'DataType',sys.extended_properties.value as 'ColumnComment'  from syscolumns inner join sysobjects on syscolumns.id=sysobjects.id inner join systypes on syscolumns.xtype=systypes.xtype left join sys.extended_properties on sys.extended_properties.major_id=syscolumns.id and sys.extended_properties.minor_id=syscolumns.colorder where sysobjects.name='{tb}' and systypes.name<>'sysname' order by sys.extended_properties.minor_id asc");
                default:
                    throw new NotSupportedException("未支持");

            }
        }
    }
}
