using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDownloadImageOLongVien
{
    class WorkFileImage
    {
        //E:\Pictures\Hinh
        public void CopyFile(string iReFileName,string iNowFileName, string iReSoure, string iNowSoure)
        {

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(iReSoure, iReFileName);
            string destFile = System.IO.Path.Combine(iNowSoure, iNowFileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(iNowSoure))
            {
                System.IO.Directory.CreateDirectory(iNowSoure);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            try
            {
                if (File.Exists(destFile))
                    if (MessageBox.Show("File " + "'" + iNowFileName + "'" + " đã tồn tại bạn có muốn xóa. Nhấn OK để tiếp tục", "Bạn có muốn xóa file", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        System.IO.File.Delete(destFile);
                        System.IO.File.Copy(sourceFile, destFile);
                    }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            
            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            //if (System.IO.Directory.Exists(iReSoure))
            //{
            //    //string[] files = System.IO.Directory.GetFiles(iReSoure);

            //    //// Copy the files and overwrite destination files if they already exist.
            //    //foreach (string s in files)
            //    //{
            //    //    // Use static Path methods to extract only the file name from the path.
            //    //    iReFileName = System.IO.Path.GetFileName(s);
            //    //    destFile = System.IO.Path.Combine(iNowSoure, iNowFileName);
            //    //    System.IO.File.Copy(s, destFile, true);
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("Source path does not exist!");
            //}

            // Keep console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }
    }
}
