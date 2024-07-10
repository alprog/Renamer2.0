using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace Renamer2
{
    public class FileRecord
    {
        public FileInfo OriginFileInfo;
        public string NewFileName;
        public bool Use;

        public FileRecord(FileInfo originFileInfo)
        {
            this.OriginFileInfo = originFileInfo;
            this.NewFileName = originFileInfo.Name;
            this.Use = true;
        }

        public void Rename(string format, int index)
        {
            var extension = Path.GetExtension(NewFileName);
            NewFileName = String.Format(format, index) + extension;
        }
    }
}
