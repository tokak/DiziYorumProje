using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entitiy;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {
                var valuesTur = (from x in db.TBLTUR
                                 select new
                                 {
                                     x.TURAD,
                                     x.TURID
                                 }).ToList();
                DropDownList1.DataSource = valuesTur;
                DropDownList1.DataBind();
                var valuesKategori = (from x in db.TBLKATEGORI
                                      select new
                                      {
                                          x.KATEGORIAD,
                                          x.KATEGORIID
                                      }).ToList();
                DropDownList2.DataSource = valuesKategori;
                DropDownList2.DataBind();

                var deger = db.TBLBLOG.Find(y);
                TextBox1.Text = deger.BLOGBASLIK;
                TextBox2.Text = deger.BLOGTARIH.ToString();
                TextBox3.Text = deger.BLOGGORSER;
                TextBox4.Text = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(y);
            blog.BLOGBASLIK = TextBox1.Text;
            blog.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            blog.BLOGGORSER = TextBox3.Text;
            blog.BLOGICERIK = TextBox4.Text;
            blog.BLOGTUR = int.Parse(DropDownList1.SelectedValue);
            blog.BLOGKATEGORI = int.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}