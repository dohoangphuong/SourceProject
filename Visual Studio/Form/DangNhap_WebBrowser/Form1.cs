using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap_WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DieuKienThucHien()
        {
            try
            {
                //Lấy thông tin từ web về và kiểm tra số lượng
                webBrowser1.Navigate("http://online1.buh.edu.vn/Portlets/UIS_MySpace/Student/Register/RegisterClassStudyUnit.aspx?ID=iPxjdl1xMsN8PwyXSLvpZSFyyZGG3MdPrhj9kLWTDRB9Pq60bPTsgwTh+ekhwoti");
                string iSource = webBrowser1.DocumentText;
                //string iTemp = "Nhập môn phát triển game</td><td>CNPM</td><td>2</td><td>Thứ 3, Tiết 45, P.C205<br /></td><td>Đinh Nguyễn Anh Dũng-80028</td><td>100</td><td>";
                string iTemp = txtDieuKien.Text;
                int iIndex = iSource.IndexOf(iTemp) + iTemp.Count();
                string Sl1 = iSource.Substring(iIndex, 2);
                string Sl2 = iSource.Substring(iIndex + txtDieuKien2.Text.Count(), 2);
                int sldk = int.Parse(Sl1);
                txtSoLuong.Text = Sl2;

                if (iIndex > 0)
                {
                    if (sldk != 80)
                    {
                        try
                        {
                            if (A)
                            {
                                A = false;
                                music.URL = "abc.mp3";
                            }
                        }
                        catch { }
                        txtSoLuong.Text = sldk.ToString();
                        MessageBox.Show("Thông báo số lượng mở lớp", Sl1);
                    }
                    else
                    {
                        int sldk2 = 0;
                        try
                        {
                            sldk2 = int.Parse(Sl2);
                        }
                        catch
                        {
                            MessageBox.Show("Thông báo", "Lỗi con mẹ nó convert sang số lương người dk");
                        }
                        if (sldk2 != 80)
                        {
                            try
                            {
                                if (A)
                                {
                                    A = false;
                                    music.URL = "abc.mp3";
                                }
                            }
                            catch { }
                            txtSoLuong.Text = sldk.ToString();
                            MessageBox.Show("Thông báo số lượng đăng ký", Sl2);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Trang không thể tải", "Thông báo");
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("edit-name").SetAttribute("value", txtUser.Text); //user
            webBrowser1.Document.GetElementById("edit-pass").SetAttribute("value", txtPass.Text); //password
            webBrowser1.Document.GetElementById("edit-submit").InvokeMember("Click");           //Click
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        bool A = true;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (txtChiTiet.BackColor == Color.Blue)
            {
                txtChiTiet.BackColor = Color.Red;
                txtChiTiet.Text = "of";
            }
            else
            {
                txtChiTiet.BackColor = Color.Blue;
                txtChiTiet.Text = "on";
            }
            DieuKienThucHien();

            timer1.Interval += 100;
        }
    }
}
