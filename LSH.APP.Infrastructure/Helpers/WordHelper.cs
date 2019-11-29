
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace LSH.APP.Infrastructure.Helpers
{
    public class WordHelper
    {
        public static bool CreateTable(List<WordTableOption> options, string fullPath)
        {

            try
            {
                //创建Word文档 
                using (DocX document = DocX.Create(fullPath))
                {
                    options.ForEach(ele =>
                    {
                        //添加表格
                        Table table = document.AddTable(ele.Rows.Count + 1, ele.Headers.Count);
                        table.Design = TableDesign.TableGrid;    //表格样式
                        table.Alignment = Alignment.center;      //设置表格居中
                        //填充头
                        for (int i = 0; i < ele.Headers.Count; i++)
                        {
                            var cell = table.Rows[0].Cells[i];
                            cell.FillColor=Color.Black;
                            cell.Paragraphs[0].Append(ele.Headers[i]).Bold().Color(Color.White);
                        }
                        //填充主体
                        for (int i = 0; i < ele.Rows.Count; i++)
                        {
                            for (int j = 0; j < ele.Headers.Count; j++)
                            {
                                table.Rows[i+1].Cells[j].Paragraphs[0].Append(ele.Rows[i][j]);
                               
                            }
                        }

                        Paragraph h = document.InsertParagraph();
                        h.Alignment = Alignment.center;
                        h.Append(ele.Title).Bold();
                        h.InsertTableAfterSelf(table);
                        h.LineSpacingBefore = 2;
                        h.LineSpacingAfter = 1;
                    });
                    document.Save();
                }

                
              
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }


    public class WordTableOption
    {
        public WordTableOption()
        {
            Headers = new List<string>();
            Rows = new List<List<string>>();
        }

        public string Title { get; set; }
        public List<string> Headers { get; set; }

        public List<List<string>> Rows { get; set; }
    }
}
