using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-L8IHJCU\\SQLEXPRESS01;Initial Catalog=KodlamaDünyasıDB;Integrated Security=True;Encrypt=False");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadRecord();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("INSERT INTO Kullanıcılar (AdSoyad, Eposta, Şifre, Rol, OluşturulmaTarihi) " +
      "VALUES (@AdSoyad, @Eposta, @Sifre, @Rol, @Tarih)", con);

        comm.Parameters.AddWithValue("@AdSoyad", TextBoxAdSoyad.Text);
        comm.Parameters.AddWithValue("@Eposta", TextBoxEposta.Text);
        comm.Parameters.AddWithValue("@Sifre", TextBoxŞifre.Text);
        comm.Parameters.AddWithValue("@Rol", TextBoxRol.Text);
        comm.Parameters.AddWithValue("@Tarih", DateTime.Parse(TextBoxTarih.Text));  // Tarih

        comm.ExecuteNonQuery();
        con.Close();

        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kayıt başarıyla eklendi');", true);
        LoadRecord();
    }

    void LoadRecord()
    {
        con.Open();
        SqlCommand comm = new SqlCommand("SELECT * FROM Kullanıcılar", con);
        SqlDataAdapter d = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();
    }






    protected void Button2_Click(object sender, EventArgs e)
    {
        int kullanıcıId = Convert.ToInt32(TextBoxID.Text);  // Güncellenecek kullanıcının ID'sini alıyoruz

        con.Open();
        SqlCommand comm = new SqlCommand("UPDATE Kullanıcılar SET " +
            "AdSoyad = @AdSoyad, " +
            "Eposta = @Eposta, " +
            "Şifre = @Şifre, " +
            "Rol = @Rol, " +
            "OluşturulmaTarihi = @OluşturulmaTarihi " +
            "WHERE KullanıcıID = @KullanıcıID", con); // KullanıcıID'yi kullanıyoruz

        // Parametreleri ekliyoruz
        comm.Parameters.AddWithValue("@AdSoyad", TextBoxAdSoyad.Text);
        comm.Parameters.AddWithValue("@Eposta", TextBoxEposta.Text);
        comm.Parameters.AddWithValue("@Şifre", TextBoxŞifre.Text);
        comm.Parameters.AddWithValue("@Rol", TextBoxRol.Text);
        comm.Parameters.AddWithValue("@OluşturulmaTarihi", DateTime.Parse(TextBoxTarih.Text));  // Tarih
        comm.Parameters.AddWithValue("@KullanıcıID", kullanıcıId);  // Güncellemek istediğimiz kullanıcının ID'si

        // SQL komutunu çalıştırıyoruz
        comm.ExecuteNonQuery();
        con.Close();

        // Kullanıcıya başarılı bir şekilde güncellendiğini bildiriyoruz
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kullanıcı başarıyla güncellendi');", true);

        // Güncellenmiş verileri GridView'a tekrar yükleyelim
        LoadRecord();

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int kullanıcıId = Convert.ToInt32(TextBoxID.Text);  // Silinecek kullanıcının ID'sini alıyoruz

        con.Open();
        SqlCommand comm = new SqlCommand("DELETE FROM Kullanıcılar WHERE KullanıcıID = @KullanıcıID", con); // KullanıcıID'yi kullanıyoruz

        // Parametreyi ekliyoruz
        comm.Parameters.AddWithValue("@KullanıcıID", kullanıcıId);  // Silmek istediğimiz kullanıcının ID'si

        // SQL komutunu çalıştırıyoruz
        comm.ExecuteNonQuery();
        con.Close();

        // Kullanıcıya başarılı bir şekilde silindiğini bildiriyoruz
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kullanıcı başarıyla silindi');", true);

        // Silme işlemi sonrası verileri tekrar yükleyelim
        LoadRecord();

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string aramaAdSoyad = TextBoxAdSoyad.Text.Trim();  // AdSoyad ile arama
        string aramaEposta = TextBoxEposta.Text.Trim();    // Eposta ile arama

        // Arama kriterlerine göre SQL sorgusunu hazırlıyoruz
        string query = "SELECT * FROM Kullanıcılar WHERE 1=1";

        // Eğer AdSoyad verilmişse, sorguya ekliyoruz
        if (!string.IsNullOrEmpty(aramaAdSoyad))
        {
            query += " AND AdSoyad LIKE @AdSoyad";
        }

        // Eğer Eposta verilmişse, sorguya ekliyoruz
        if (!string.IsNullOrEmpty(aramaEposta))
        {
            query += " AND Eposta LIKE @Eposta";
        }

        con.Open();
        SqlCommand comm = new SqlCommand(query, con);

        // Parametreleri ekliyoruz
        if (!string.IsNullOrEmpty(aramaAdSoyad))
        {
            comm.Parameters.AddWithValue("@AdSoyad", "%" + aramaAdSoyad + "%");  // AdSoyad'ı % ile arıyoruz (partial match)
        }

        if (!string.IsNullOrEmpty(aramaEposta))
        {
            comm.Parameters.AddWithValue("@Eposta", "%" + aramaEposta + "%");  // Eposta'yı % ile arıyoruz (partial match)
        }

        SqlDataAdapter d = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        d.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();

        con.Close();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string adSoyad = TextBoxAdSoyad.Text.Trim();  // Kullanıcıdan alınan AdSoyad değeri

        // AdSoyad'a göre SQL sorgusu hazırlanıyor
        string query = "SELECT * FROM Kullanıcılar WHERE AdSoyad = @AdSoyad";

        con.Open();
        SqlCommand comm = new SqlCommand(query, con);

        // AdSoyad parametresi ekleniyor
        comm.Parameters.AddWithValue("@AdSoyad", adSoyad);

        // Verileri alıyoruz
        SqlDataAdapter da = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        da.Fill(dt);

        // Eğer sonuç varsa, GridView'de gösteriyoruz
        if (dt.Rows.Count > 0)
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            // Eğer hiç sonuç yoksa, kullanıcıyı bilgilendiriyoruz
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kayıt bulunamadı');", true);
        }

        con.Close();

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBoxAdSoyad.Text = "";
        TextBoxEposta.Text = "";
        TextBoxŞifre.Text = "";
        TextBoxRol.Text = "";
        TextBoxTarih.Text = "";
    }
}


