using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace KiemTraMonHoc
{
    public partial class Download : Form
    {
        string PathSave, PathWeb;//biến chứa đường dẫn lưu files
        WebClient Wc = new WebClient();//Để tải file về dùng cái này
        string HttpGet(string URL, string username, string password)
        {
            Stream stream;
            StreamReader reader;
            String response = null;
            WebClient webClient = new WebClient();
            WebClient webClient2 = new WebClient();
            using (webClient)
            {
                // Check our auth details
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    webClient.Credentials = new NetworkCredential(username, password);
                }

                try
                {
                    // open and read from the supplied URI
                    stream = webClient.OpenRead(URL);
                    reader = new StreamReader(stream);
                    response = reader.ReadToEnd();
                }
                catch (WebException ex)
                {
                    if (ex.Response is HttpWebResponse)
                    {
                        // Add you own error handling as required
                        switch (((HttpWebResponse)ex.Response).StatusCode)
                        {
                            case HttpStatusCode.NotFound:
                            case HttpStatusCode.Unauthorized:
                                response = null;
                                break;

                            default:
                                throw ex;
                        }
                    }
                }
            }
            MessageBox.Show(response, "Unable to open file from URL");
            return response;
        }
        public Download()
        {
            InitializeComponent();
        }

        public string downloads(string URL)
        {
            try
            {
                //Get channel ID and date
                //Set up a request object
                WebRequest request = WebRequest.Create(URL);

                //Specify the method: POST or GET
                request.Method = "POST";

                //data we want to send is included here
                string data = string.Format("name={0}&pass={1}&form_build_id=form-qLm5-X-jtJ0SUagSUnedAgZq58XQhCvwU0AWo_iA6M8&form_id=user_login&op=Log+in","12520324", "ngoc quyen");

                string cookieHeader;
                WebRequest req = WebRequest.Create(URL);
                req.ContentType = "application/x-www-form-urlencoded";
                req.Method = "POST";
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                req.ContentLength = bytes.Length;
                using (Stream os = req.GetRequestStream())
                {
                    os.Write(bytes, 0, bytes.Length);
                }
                WebResponse resp = req.GetResponse();
                cookieHeader = resp.Headers["Set-cookie"];

                MessageBox.Show(cookieHeader, "Unable to open file from URL");
                return cookieHeader;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "error";
            ////convert the data into byte array
            //byte[] byteArray = Encoding.UTF8.GetBytes(data);

            ////set Content-Length and Content-Type 
            //request.ContentLength = byteArray.Length;
            //request.ContentType = "application/x-www-form-urlencoded";

            ////get the request stream and write data to it and close it
            //Stream dataStream = request.GetRequestStream();
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //dataStream.Close();

            ////Now the real request is called here when we call the GetResponse method
            //WebResponse response = request.GetResponse();

            ////Get the data from the Response
            //dataStream = response.GetResponseStream();

            ////Open stream using XMLTextReader
        }
        public void DieuKienThucHien()
        {
            bool a=true;
            while(a)
            try
            {
                PathWeb = txtPathWebDown.Text;
                string iSource = downloads(txtPathWebDown.Text);
                string iTemp = "SE102.G13</td><td>Nhập môn phát triển game</td><td>CNPM</td><td>2</td><td>Thứ 3, Tiết 45, P.C305<br /></td><td>Nguyễn Phương Anh-80008</td><td>100</td><td>";
                int iIndex = iSource.IndexOf(iTemp);
                string Sl=iSource.Substring(iIndex, 3);
                MessageBox.Show(Sl, "Thông báo");
                if (iIndex > 0)
                {
                    if (int.Parse(Sl) < 100)
                        MessageBox.Show("Thông báo", "Số lượng đã ít");
                }
            }
            catch(Exception e) {
                a = false;
                MessageBox.Show(e.Message);
            }
        }
        private void down_Click(object sender, EventArgs e)
        {
            DieuKienThucHien();

          //  PathSave = txtpathSave.Text;
          //  PathWeb = txtPathWebDown.Text;

          ////  this.txtSoureWeb.Text = ReadHTMLCode(txtPathWebDown.Text);

          //  Wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Wc_DownloadProgressChange);//Hiển thị phần trăm tải về bằng progressBar

          //  //Cach lay link anh
          //  int lan = 0;

          //  try
          //  {
          //      //dk rieng cua web nay: dow nhieu trang

          //      for (int ii = 1; ii <= 26; ii++)
          //      {
          //          this.txtSoureWeb.Text = ReadHTMLCode(txtPathWebDown.Text + ii.ToString());

                    
          //          int n = txtSoureWeb.Text.Count();
          //          int sizeDieuKien = txtDieuKien.Text.Count();
          //          string pathtruoc = txtpathSave.Text;
          //          string ipath, iname, test;


          //          for (int i = 0; i < n; i++)
          //          {
          //              try
          //              {
          //                  test = txtSoureWeb.Text.Substring(i, sizeDieuKien);//cat chuoi voi kich thuoc cua dieu kien
          //                  if (test == txtDieuKien.Text)
          //                  {
          //                      try
          //                      {
          //                          i = i + sizeDieuKien;   //bat dau tu day lay link cho den khi gap "
          //                          for (int j = i; j < n; j++)
          //                          {
          //                              if (txtSoureWeb.Text[j] == 34)//"
          //                              {
          //                                  ipath = txtSoureWeb.Text.Substring(j - 3, 3);
          //                                  if (ipath == "jpg") //ipath == "png" || ipath == "jpg")
          //                                  {
          //                                      ipath = txtSoureWeb.Text.Substring(i, j - i);
          //                                      ipath = txtSoureWeb.Text.Substring(i, j - i);
          //                                      for (int k = j; k > 0; k--)
          //                                      {
          //                                          if (txtSoureWeb.Text[k] == '/')
          //                                          {
          //                                              iname = txtpathSave.Text + txtSoureWeb.Text.Substring(k + 1, j - k - 1);
          //                                              //MessageBox.Show(ipath, iname);
          //                                              try
          //                                              {
          //                                                  DownLoad(ipath, iname);
          //                                                  lan++;
          //                                              }
          //                                              catch { }
          //                                              break;
          //                                          }
          //                                      }
          //                                      i = j;// png"=4 kí tự
          //                                      break;
          //                                  }
          //                                  else
          //                                  {
          //                                      break;
          //                                  }
          //                              }
          //                          }
          //                      }
          //                      catch (Exception es){ // MessageBox.Show(es.Message);
          //                      }
          //                  }
          //              }
          //              catch (Exception es){ // MessageBox.Show(es.Message);
          //              }
          //          }
          //      }
          //  }
          //  catch (Exception es){  //MessageBox.Show(es.Message);
          //  }
          //  MessageBox.Show(lan.ToString());
        }
    
     private void DownLoad(string ipath, string iname)
        {
            Uri FileUrl = new Uri(ipath);//Uri để tạo đầu vào cho Wc tải về, Trim để xóa kí tự rỗng ở 2 đầu           
            Wc.DownloadFileAsync(FileUrl, iname);//Bắt đầu tải về Cú pháp: TênBiếnWebclient.DownloadFileAsync(Uri chứa đường dẫn tải về, Địa điểm lưu file)
                
        }
        private void Save_File(int count)//chọn đường dẫn lưu file
        {
            try
            {
                txtpathSave.Text = txtpathSave.Text + count + ".jpg";
            }catch{
                 open_Click(new Object(), new EventArgs());
            }
        }
        private void run_Click(object sender, EventArgs e)
        {
            this.txtSoureWeb.Text = ReadHTMLCode(txtPathWebDown.Text);
        }
        void Wc_DownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            prdownload.Value = e.ProgressPercentage;//Gán phần trăm tải về vào ProgressBar
            lbComplete.Text = prdownload.Value.ToString() + "%";
        }

        private string ReadHTMLCode(string URL)
        {
            try
            {

                WebClient webClient = new WebClient();
                byte[] reqHTML;
                webClient.Credentials = new NetworkCredential("12520324", "ngocquyen");
                reqHTML = webClient.DownloadData(URL);
                UTF8Encoding objUTF8 = new UTF8Encoding();
                return objUTF8.GetString(reqHTML);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Unable to open file from URL");
            }
            return "error";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Lấy đường dẫn muốn download

            string sUrl = txtPathWebDown.Text.Trim();

            //Đường dẫn lưu xuống ổ cứng

            string sSave = txtpathSave.Text.Trim();

            // Xác định dung lượng tập tin

            Uri url = new Uri(sUrl);

            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();

            response.Close();

            // Lấy dung lượng tập tin

            Int64 iSize = response.ContentLength;

            // Khởi tạo dung lượng download được từ URL

            Int64 iRunningByteTotal = 0;

            // Dùng Webclient để download

            WebClient client = new WebClient();

            // Mở URL để download

            Stream streamRemote = client.OpenRead(new Uri(sUrl));

            // Vừa đọc vừa lưu

            Stream streamLocal = new FileStream(sSave, FileMode.Create, FileAccess.Write, FileShare.None);

            // Tiến hành loop quá trình download, vừa load vừa lưu

            int iByteSize = 0;

            byte[] byteBuffer = new byte[iSize];

            while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
            {

                // Lưu byte xuống đường dẫn chỉ định

                streamLocal.Write(byteBuffer, 0, iByteSize);

                iRunningByteTotal += iByteSize;//cập nhập số byte đã load được

                // Chuyển đổi ra tỉ lệ 100%

                double dIndex = (double)(iRunningByteTotal);

                double dTotal = (double)byteBuffer.Length;

                double dProgressPercentage = (dIndex / dTotal);

                int iProgressPercentage = (int)(dProgressPercentage * 100);

                // Cập nhập progressbar

                backgroundWorker1.ReportProgress(iProgressPercentage);
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prdownload.Value = e.ProgressPercentage;
            lbComplete.Text = e.ProgressPercentage + "%";
          //  lblPercentage.Text = e.ProgressPercentage + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Đã download xong!");
        }

        private void open_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDial = new SaveFileDialog();//Hộp thoại tạo file lưu trữ
            saveDial.Title = "Lưu file";//tên hộp thoại
            saveDial.Filter = "Tất cả|*.*";//Định dạnh file lưu
            if (saveDial.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)//Nếu không ấn hủy thì sẽ lấy đường dẫn lưu file
            {
                txtpathSave.Text = saveDial.FileName;//Lấy đường dẫn để lưu file
            }
        }

    }
}
