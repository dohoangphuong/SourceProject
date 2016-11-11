
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDownloadImageOLongVien
{
    public class Chapter
    {
        public string nameChapter;
        public List<string> listImage { get; set; }
        public Chapter()
        {
            listImage = new List<string>();
        }
    }
}