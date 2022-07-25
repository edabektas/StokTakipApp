using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;  //sql conneciton sınıfından con adında bir nesne türetilir, bu veri ltabanına bağlantı yapabilmen için yani bir conneciton string değeri verip db ye bağlanabilmek için kullandığın sınıf
        SqlDataAdapter da; //sqldatadapter sınıfından da adında bir nesn türettik
        SqlCommand cmd;  //swqle bağlandıktan sonra kod kısmında bir sorgumuz varsa onu çalıştırabilmek için kullandığımız sınıf
        DataSet ds; //dataset db ye göndereceğin (yani kayıt, update, delete vs gibi işlemleri yaparken bu işlemlerde kullanılan verileri tuttuğumuz datasetler )
        DataTable dt;  //form kısmında verileri listelerken db den gelen verileri bir datatable'a atar ve kodda istediğimiz yerde yani verileri listelemek istediğimiz yerde bu datatable sınıfını kullanırız

        private void Form1_Load(object sender, EventArgs e) //form start edildiğinde bu metot default olarak çalışır ve içeriswindeki kodları çalıştırır
        {
            filldatagrid();
            

        }

        void filldatagrid()
        {
          con = new SqlConnection("server=.; Initial Catalog=Products;Integrated Security=SSPI");  //daha önceden yazılan bir classtan örnek alma işlemi
                                                                                                         //yapma sebebimiz ise bu class içerisindeki metot, property vb şeyleri burada kullanabilmek için, içindeki şey connection string  
                                                                                                         //server name: ., bağlanmak istediğim dbyi b belirtiyorum :products, ıntegrated security: veri tabanlarında dıaşrdan bir bağlantı 
                                                                                                         //geldiğinde güvenli bağlantı sağlamak için kullanılan bir güvenlik protoklu
                da = new SqlDataAdapter("Select *From stok1", con);
                ds = new DataSet();
                con.Open(); //sql bağlantısını başlatır
                da.Fill(ds, "stok1"); //fata adfapter sınıfı içerisindeki fill metodu ile datasetimizi ve kaynak(soruce) datamızı parametre olarak veriyoruz
                data_stokTakip.DataSource = ds.Tables["stok1"];  //formda en latta bulunan datagrid view içerisine verileri doldurmak için bu datagrid view'in datasource 
                                                                 //propertysine  bir atama yaptık. ds şyani datasetin tables properyysinden gelen verileri kullandığımız datagrid view'a datasource oalrak verdik ve doldurduk
                data_stokTakip.Columns["id"].Visible = false;
                con.Close(); //sql bağlantsını sonlandırdık.
                       //sql bağlanrtısını sonlandırmazsak stok1 adlı tabloya başka herhangi bir kaynak select sorgusu çektiği zaman sql tarafında lock oluşur bu lock oluşmaması
                         //veri tabanına olan bağlantıyı sonlandırırız. yani kısacası transaction yapısını korumak için başlattığımız bağlantıyı sonlandırırız.
                         //commit ve rollback işlemi de aynı şeyi sağlar
        
       
        }



        private void data_stokTakip_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid viewda üzerinde bulunduğumuz satırın ilgili indexinin değerini alıp stringe çevirdikten sonra yine ilgili textbox'un text öxelliğine atıyoruz.
            txb_kayitNo.Text = data_stokTakip.CurrentRow.Cells[0].Value.ToString();
            txb_stokAdi.Text = data_stokTakip.CurrentRow.Cells[1].Value.ToString();
            txb_stokModeli.Text = data_stokTakip.CurrentRow.Cells[2].Value.ToString();
            txb_stokSeriNo.Text = data_stokTakip.CurrentRow.Cells[3].Value.ToString();
            cmb_stokBedeni.Text = data_stokTakip.CurrentRow.Cells[4].Value.ToString();
            txb_stokAdedi.Text = data_stokTakip.CurrentRow.Cells[5].Value.ToString();
            dateTime_stokTarihi.Text = data_stokTakip.CurrentRow.Cells[6].Value.ToString();
            txb_kayıtYapan.Text = data_stokTakip.CurrentRow.Cells[7].Value.ToString();
            txb_magaza.Text = data_stokTakip.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
            if (karsilastir(txb_stokSeriNo.Text))
            {
                string sorgu = "Insert into stok1 (StokAdi,StokModeli,StokSeriNo,StokBedeni,StokAdedi,StokTarihi,KayitYapan,Magaza) values (@StokAdi,@StokModeli,@StokSeriNo,@StokBedeni,@StokAdedi,@StokTarihi,@KayitYapan,@Magaza)";
                //stok ekle butonunun click metoduna yazılan bu kodda yukardaki sorgu bir insert işlemi yapmakta.
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@StokAdi", txb_stokAdi.Text);
                cmd.Parameters.AddWithValue("@StokModeli", txb_stokModeli.Text);
                cmd.Parameters.AddWithValue("@StokSeriNo", txb_stokSeriNo.Text);
                cmd.Parameters.AddWithValue("@StokBedeni", cmb_stokBedeni.Text);
                cmd.Parameters.AddWithValue("@StokAdedi", txb_stokAdedi.Text);
                cmd.Parameters.AddWithValue("@StokTarihi", dateTime_stokTarihi.Value);
                cmd.Parameters.AddWithValue("@KayitYapan", txb_kayıtYapan.Text);
                cmd.Parameters.AddWithValue("@Magaza", txb_magaza.Text);

                con.Open();
                cmd.ExecuteNonQuery(); //dml yani insert update deleet gibi geriye değer dödnürmeyen ve belli kayıt sayısını işleme sokmaya yarayan sql deyinmlerinde kullandığımız
                                       //sqlcommand sınıfı içerisinden gelen hazır bir metot
                con.Close();
            }
            else
            {
                MessageBox.Show("Bu seri numarasında bir stok bulunmaktadır.Yeni bir kayıt oluşturunuz.", "STOK MEVCUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
                     
            filldatagrid();
            data_stokTakip.ClearSelection();

        }

        private void btn_stokGüncelle_Click(object sender, EventArgs e)
        {


                string sorgu = "Update stok1 Set StokAdi=@StokAdi,StokModeli=@StokModeli,StokSeriNo=@StokSeriNo,StokBedeni=@StokBedeni,StokAdedi=@StokAdedi,StokTarihi=@StokTarihi,KayitYapan=@KayitYapan,Magaza=@Magaza Where id=@id";
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txb_kayitNo.Text));
                cmd.Parameters.AddWithValue("@StokAdi", txb_stokAdi.Text);
                cmd.Parameters.AddWithValue("@StokModeli", txb_stokModeli.Text);
                cmd.Parameters.AddWithValue("@StokSeriNo", txb_stokSeriNo.Text);
                cmd.Parameters.AddWithValue("@StokBedeni", cmb_stokBedeni.Text);
                cmd.Parameters.AddWithValue("@StokAdedi", (txb_stokAdedi.Text));
                cmd.Parameters.AddWithValue("@StokTarihi", dateTime_stokTarihi.Value);
                cmd.Parameters.AddWithValue("@KayitYapan", txb_kayıtYapan.Text);
                cmd.Parameters.AddWithValue("@Magaza", txb_magaza.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                filldatagrid();
                data_stokTakip.ClearSelection();

        }




        private void btn_stokSil_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bu stok silinsin mi?", "Stok Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sorgu = "Delete From stok1 Where id=@id";
                    cmd = new SqlCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txb_kayitNo.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    filldatagrid();
                    data_stokTakip.ClearSelection();
                    data_stokTakip[0, data_stokTakip.RowCount - 1].Selected = true;


                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen silmek için bir stok seçiniz", "StokTakip Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_stokAra_Click(object sender, EventArgs e)
        {
            SearchData(txb_stokAra.Text);
            data_stokTakip.ClearSelection();
            Temizle();
        }

        public void SearchData(string search)
        {
            con.Open();
            string query = "select *from stok1 where StokSeriNo Like '%" + search + "%'";
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            data_stokTakip.DataSource = dt;
            con.Close();
        }

        private void txb_stokAra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }


        public bool karsilastir(string data)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IE5CNNN;Initial Catalog=Products;Integrated Security=True");
            con.Open();
            SqlCommand sorgu = new SqlCommand("select StokSeriNo from stok1 where StokSeriNo = @StokSeriNo",con);
            sorgu.Parameters.AddWithValue("@StokSeriNo", data);

            SqlDataReader varmi = sorgu.ExecuteReader();
           
            if (varmi.Read())
            {
                con.Close();
                return false; // veri tabanında var
            }
            else
            {
                con.Close();
                return true; //veri tabanında yok
            }
         }


        public void Temizle()
        {
            txb_kayitNo.Clear();
            txb_stokAdi.Clear();
            txb_stokModeli.Clear();
            txb_stokSeriNo.Clear();
            txb_stokAdedi.Clear();
            cmb_stokBedeni.Text = "";
            dateTime_stokTarihi.Value = DateTimePicker.MinimumDateTime;
            txb_kayıtYapan.Clear();
            txb_magaza.Clear();
        }

      

        private void txb_stokAra_stokAdi_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }

        private void txb_stokAra_stokModeli_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }

        private void txb_stokAra_stokBedeni_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }

        private void txb_stokAra_kayitYapan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }

        private void txb_stokAra_magaza_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_stokAra_Click(sender, e);
            }
        }
    }
}


