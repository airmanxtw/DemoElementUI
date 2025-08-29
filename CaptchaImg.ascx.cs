using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoElementUI
{
    
    public partial class CaptchaImg : System.Web.UI.UserControl
    {

        private string CaptchaText
        {
            get { return (string)(ViewState["CaptchaText"] ?? ""); }
            set { ViewState["CaptchaText"] = value; }
        }

        public void SetCaptcha(string number)
        {
            CaptchaText = number;
            Session["CaptchaNumber"] = number;
            using (var bmp = new Bitmap(100, 40))
            using (var g = Graphics.FromImage(bmp))
            using (var ms = new MemoryStream())
            {
                g.Clear(Color.White);
                using (var font = new Font("Arial", 20, FontStyle.Bold))
                {
                    g.DrawString(number.ToString(), font, Brushes.Black, 10, 5);
                }
                bmp.Save(ms, ImageFormat.Png);
                string base64 = Convert.ToBase64String(ms.ToArray());
                Image1.ImageUrl = "data:image/png;base64," + base64;
            }
        }

        public bool ValidateCaptcha(string userInput)
        {
            string expected = CaptchaText ?? string.Empty;
            return userInput == expected.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}