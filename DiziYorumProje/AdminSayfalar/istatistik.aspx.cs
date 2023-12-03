using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class istatistik : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLBLOG.Count().ToString();
            Label2.Text = db.TBLYORUM.Count().ToString();
            Label3.Text = db.TBLBLOG.Where(x=>x.BLOGTUR==2).Count().ToString();//Toplam Film Sayısı
            Label4.Text = db.TBLBLOG.Where(x=>x.TBLTUR.TURAD=="Belgesel").Count().ToString();//Toplam belgesel Sayısı
            Label5.Text = db.TBLYORUM.GroupBy(x => x.YORUMBLOG).OrderByDescending(x=>x.Count()).Select(x=>x.Key).FirstOrDefault().ToString();
        }
    }
}