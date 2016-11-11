using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDownloadImageOLongVien
{

    public partial class Form1 : Form
    {
        List<Chapter> olongvien = new List<Chapter>();
        public WebBrowser webTruyen = new WebBrowser();
        string logic = "img src=" + '"' + "http://st.vechai.info";
        string urlMain = "http://truyentranh.net/o-long-vien/chap-0";//"http://truyentranh.net/o-long-vien/chap-005";
        string pathImage = @"D:\Hoc Tap\O Long Vien\";
        string linkDownloadSource, sourceWeb = "";
        int start = 1, end = 36;
        int current = 0;

        public Form1()
        {
            InitializeComponent();

            current = start;

            //Chapter ads = new Chapter();
            //olongvien.Add(ads);
            //SaveJson(olongvien);

            //Download("http://st.vechai.info/2014/12/2120/O-Long-Vien-chap-4-18138-html-0.jpg");
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            //Tạo đường dẫn
            //if (!System.IO.Directory.Exists(pathImage))
            //{
            //    System.IO.Directory.CreateDirectory(pathImage);
            //}

            // Add link chapter 6-9 của trang sach.info
            //AddLinkSachInfo(); 

            // Download chapter 6-9 của trang sach.info
            //DownLoadIsachInfo();

            //Đọc file json sao đó download
            ReadJson();
            ForDownload();

            //Tiến hành lên trang truyện tranh lấy link
            //linkDownloadSource = "http://truyentranh.net/o-long-vien/chap-001";
            //webTruyen.Navigate(linkDownloadSource);
            //txtLinkWeb.Text = linkDownloadSource;
            //webTruyen.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webTruyen_DocumentCompleted);
        }

        //Tập hợp hàm lấy danh sách các chapter của truyện
        //cap65 nhat65 link moi
        public void GetLinkChapter(int start)
        {
            if (start < 10)
                linkDownloadSource = urlMain + "0" + start.ToString();////"http://truyentranh.net/o-long-vien/chap-005";
            else
                linkDownloadSource = urlMain + start.ToString();

            webTruyen.Navigate(linkDownloadSource);
        }

        private void webTruyen_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (current <= end)
            {
                while (webTruyen.ReadyState == WebBrowserReadyState.Complete)
                {
                    sourceWeb = webTruyen.DocumentText;
                    txtSource.Text = sourceWeb;
                    txtLinkWeb.Text = linkDownloadSource;
                    txtResult.Text = "Download thành công source: " + txtLinkWeb + txtResult.Text;
                    txtResult.Text = Environment.NewLine + txtResult.Text;
                    GetLinkImage();

                    current++;
                    GetLinkChapter(current);
                }
            }
            else
            {
                ForDownload();
            }
        }

        //Nguồn trang: http://isach.info/comic.php?list=comic&series=o_long_vien
        //http://isach.info/comic.php?comic=o_long_vien__003_hoa_da_toc_vang

        public void DownLoadIsachInfo()
        {
            urlMain = "http://khosach.space/data/comic/o_long_vien/o_long_vien__003_hoa_da_toc_vang/o_long_vien__003_hoa_da_toc_vang_";
            int i = 6, fNameEnd;
            string imageUrl;

            for (int j = 1; j < 45; j++)
            {
                fNameEnd = j - 1;
                if (j < 10)
                {
                    imageUrl = urlMain + "00" + j + ".jpg";
                }
                else
                    imageUrl = urlMain + "0" + j + ".jpg";

                Download(imageUrl, i, fNameEnd);
            }
            olongvien[6].listImage = new List<string>();
            i = 7;
            for (int j = 45; j < 86; j++)
            {
                fNameEnd = j - 45;
                imageUrl = urlMain + "0" + j + ".jpg";
                Download(imageUrl, i, fNameEnd);
            }
            i = 8;
            for (int j = 86; j < 126; j++)
            {
                fNameEnd = j - 86;
                if (j < 100)
                    imageUrl = urlMain + "0" + j + ".jpg";
                else
                    imageUrl = urlMain + j + ".jpg";
                Download(imageUrl, i, fNameEnd);
            }
        }

        public void AddLinkSachInfo()
        {
            ReadJson();
            urlMain = "http://khosach.space/data/comic/o_long_vien/o_long_vien__003_hoa_da_toc_vang/o_long_vien__003_hoa_da_toc_vang_";
            int i = 6;
            int fNameEnd;
            string imageUrl;

            for (i = 6; i < 9; i++)
            {
                olongvien[i].listImage = new List<string>();
            }
            List<String> listStringImage = new List<string>();
            for (int j = 1; j < 45; j++)
            {
                fNameEnd = j - 1;
                if (j < 10)
                {
                    imageUrl = urlMain + "00" + j + ".jpg";
                }
                else
                    imageUrl = urlMain + "0" + j + ".jpg";

                listStringImage.Add(imageUrl);
            }
            olongvien[6].listImage = listStringImage;

            listStringImage = new List<string>();
            i = 7;
            for (int j = 45; j < 86; j++)
            {
                fNameEnd = j - 45;
                imageUrl = urlMain + "0" + j + ".jpg";
                listStringImage.Add(imageUrl);
            }
            olongvien[7].listImage = listStringImage;

            listStringImage = new List<string>();
            i = 8;
            for (int j = 86; j < 126; j++)
            {
                fNameEnd = j - 86;
                if (j < 100)
                    imageUrl = urlMain + "0" + j + ".jpg";
                else
                    imageUrl = urlMain + j + ".jpg";
                listStringImage.Add(imageUrl);
            }
            olongvien[8].listImage = listStringImage;

            //olong.nameChapter = "Chapter " + current.ToString();
            //for (int i = 0; i < 36; i++)
            //{
            //    fNameEnd = i + 1;
            //    olongvien[i].nameChapter= "Chapter " + fNameEnd.ToString();
            //}



            SaveJson(olongvien);
            // SaveJson();
        }

        public void ForDownload()
        {
            for (int i = 0; i < olongvien.Count(); i++)
            {
                for (int j = 0; j < olongvien[i].listImage.Count(); j++)
                {
                    Download(olongvien[i].listImage[j], i, j);
                }
            }

            SaveJson(olongvien);
            txtResult.Text = "Hoàn thành toàn bộ" + txtResult.Text;
            txtResult.Text = Environment.NewLine + txtResult.Text;
            txtResult.Text = Environment.NewLine + txtResult.Text;
            MessageBox.Show("Đã hoàn thành", "Thông báo");
        }

        //Dựa vào điều kiện để lấy link image
        public void GetLinkImage()
        {
            int iIndex;
            string linkImage;
            Chapter olong = new Chapter();
            olong.nameChapter = "Chapter " + current.ToString();
            // while()
            while (sourceWeb.IndexOf(logic) != -1)
            {
                iIndex = sourceWeb.IndexOf(logic);
                sourceWeb = sourceWeb.Substring(iIndex);//bỏ thằng đầu

                iIndex = sourceWeb.IndexOf("http");
                sourceWeb = sourceWeb.Substring(iIndex);//bỏ đến http

                iIndex = sourceWeb.IndexOf(".jpg");
                linkImage = sourceWeb.Substring(0, iIndex + 4);//lấy link ảnh

                olong.listImage.Add(linkImage);
                sourceWeb = sourceWeb.Substring(linkImage.Count());//bỏ đến http
                txtResult.Text = "Add link image: " + linkImage + txtResult.Text;
                txtResult.Text = Environment.NewLine + txtResult.Text;
                txtResult.Text = Environment.NewLine + txtResult.Text;
            }
            olongvien.Add(olong);
            txtResult.Text = "Thêm thành công chapter: " + current + txtResult.Text;
            txtResult.Text = Environment.NewLine + txtResult.Text;
            txtResult.Text = Environment.NewLine + txtResult.Text;
        }

        //Dựa vào link image download image
        public void Download(string imageUrl, int i, int j)
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(imageUrl);
                Bitmap bitmap = new Bitmap(stream);
                stream.Flush();

                string iPath = i.ToString(), jPath = j.ToString();
                stream.Close();
                if (i < 10)
                    iPath = "0" + iPath;
                if (j < 10)
                    jPath = "0" + jPath;
                string filename = iPath + "_" + jPath;
                txtResult.Text = "Download thành công file: " + filename + txtResult.Text;
                txtResult.Text = Environment.NewLine + txtResult.Text;
                txtResult.Text = Environment.NewLine + txtResult.Text;

                SaveImage(bitmap, pathImage + filename + ".jpg", filename + ".jpg", ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //SaveImage vào ổ đĩa
        public void SaveImage(Bitmap bitmap, string filePath, string fileName, ImageFormat format)
        {
            if (bitmap != null)
            {
                if (File.Exists(filePath))
                {
                    MessageBox.Show(fileName, "FILE ĐÃ TỒN TẠI");
                }
                else
                {
                    bitmap.Save(filePath, format);
                    txtResult.Text = "Save thành công file: " + fileName + txtResult.Text;
                    txtResult.Text = Environment.NewLine + txtResult.Text;
                    txtResult.Text = Environment.NewLine + txtResult.Text;
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //00_00
            WorkFileImage workFile = new WorkFileImage();
            for (int i = 0; i < 36; i++)
            {
                string iPath = i.ToString(), jPath = "00";//j.ToString();
                if (i < 10)
                    iPath = "0" + iPath;
                string filename = iPath + "_" + jPath + ".jpg";
                workFile.CopyFile(filename, filename,@"E:\Pictures\O Long Vien", @"E:\Pictures\Hinh");
            }
        }

        public void SaveJson(Object fSource)
        {
            try
            {
                if (File.Exists(pathImage + "olong.json"))
                    if (MessageBox.Show("File " + "'" + "olong.json" + "'" + " đã tồn tại bạn có muốn xóa. Nhấn OK để tiếp tục", "Bạn có muốn xóa file", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        System.IO.File.Delete(pathImage + "olong.json");

                        using (FileStream fs = File.Open(pathImage + "olong.json", FileMode.CreateNew))
                        using (StreamWriter sw = new StreamWriter(fs))
                        using (JsonWriter jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Formatting.Indented;

                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(jw, fSource);
                        }

                    }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        public void ReadJson()
        {
            // read file into a string and deserialize JSON to a type
            olongvien = JsonConvert.DeserializeObject<List<Chapter>>(File.ReadAllText(pathImage + "olong.json"));
            
            //// deserialize JSON directly from a file
            //using (StreamReader file = File.OpenText(pathImage + "olong.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    olongvien = (List<Chapter>)serializer.Deserialize(file, typeof(List<Chapter>));
            //}
        }

    }
}
