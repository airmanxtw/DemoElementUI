using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoElementUI
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GenElementUIMenu(SiteMapNode siteNode)
        {
            
            if (siteNode.ChildNodes.Count ==0)
            {
                return $"<el-menu-item index='{siteNode["id"]}'><a href='{siteNode.Url}'>{siteNode.Title}</a></el-menu-item>";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (SiteMapNode node in siteNode.ChildNodes)
                {
                    sb.Append(GenElementUIMenu(node));
                }
                return $"<el-submenu index='{siteNode["id"]}'><template slot='title'>{siteNode.Title}</template>{sb}</el-submenu>";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = new Random().Next(1000, 9999).ToString();
        }
    }
}