using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using LSH.Infrastructure.Extensions;

namespace LSH.APP.Infrastructure.Helpers
{
    public class FileHelper
    {
        /// <summary>
        /// 压缩Zip
        /// </summary>
        /// <param name="bufferMap"></param>
        /// <param name="zipName">文件夹+文件名</param>
        /// <returns></returns>
        public static bool Zip(Dictionary<string, byte[]> bufferMap, string zipName)
        {
            try
            {

                string path = Path.GetDirectoryName(zipName);
                Directory.CreateDirectory(path);

                using (ZipFile zipFile = ZipFile.Create(zipName))
                {
                    zipFile.BeginUpdate();
                    bufferMap.ForEach((ele, i) => {
                        StreamDataSource dataSource = new StreamDataSource(ele.Value);
                        zipFile.Add(dataSource, ele.Key);
                    });
                    zipFile.CommitUpdate();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
           
        }

    }


   public class StreamDataSource : IStaticDataSource
    {
        public byte[] Buffer { get; private set; }
        public StreamDataSource(byte[] buffer)
        {
            Buffer = buffer;
        }
        public Stream GetSource()
        {
            return new MemoryStream(Buffer);
        }

       
    }
}
