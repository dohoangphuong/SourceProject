﻿using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TNPA.Model;
using UIKit;

namespace TNPA.iOS
{
    public partial class TraCuuController : UIViewController
    {
        private LinhVucService _service = new LinhVucService();
        private List<DmLinhVuc> _items;
        public TraCuuController(IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            OnPostExecute();
        }

        protected async Task<ListResult> RunInBackground()
        {
            return _service.GetListLinhVuc().Result;
        }
        protected async void OnPostExecute()
        {
            var result = await RunInBackground();
            if (result != null)
            {
                _items = (List<DmLinhVuc>)result.ClassResult;
                foreach (DmLinhVuc item in _items)
                {
                    string a= item.TenLinhVuc;
                    string b = item.GetImageFromDB;
                    string c = item.GhiChu;
                }
            }
            else
            {

                UIAlertView alert = new UIAlertView()
                {
                    Title = "Cảnh báo",
                    Message = "this is a simple alert"
                };
                alert.AddButton("OK");
                alert.Show();
                //Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(_activity);
                //alert.SetTitle(_activity.Resources.GetString(Resource.String.loi));
                //alert.SetMessage(_activity.Resources.GetString(Resource.String.loidata));
                //alert.SetNegativeButton(_activity.Resources.GetString(Resource.String.dongy), (senderAlert, args) =>
                //{
                //    Dispose();
                //});
                //Dialog dialog = alert.Create();
                //dialog.Show();

            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}