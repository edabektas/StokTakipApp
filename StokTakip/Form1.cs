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
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            filldatagrid();
           
          
        }

        void filldatagrid()
        {
             con = new SqlConnection("server=.; Initial Catalog=Products;Integrated Security=SSPI");
             da = new SqlDataAdapter("Select *From stok1", con);
             ds = new DataSet();
             con.Open();
             da.Fill(ds, "stok1");
             data_stokTakip.DataSource = ds.Tables["stok1"];
             data_stokTakip.Columns["id"].Visible = false;
             con.Close();
           
        }

        private void data_stokTakip_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_kayitNo.Text = data_stokTakip.CurrentRow.Cells[0].Value.ToString();
            txb_stokAdi.Text = data_stokTakip.CurrentRow.Cells[1].Value.ToString();
            txb_stokModeli.Text = data_stokTakip.CurrentRow.Cells[2].Value.ToString();
            txb_stokSeriNo.Text = data_stokTakip.CurrentRow.Cells[3].Value.ToString();
            cmb_stokBedeni.Text = data_stokTakip.CurrentRow.Cells[4].Value.ToString();
            txb_stokAdedi.Text = data_stokTakip.CurrentRow.Cells[5].Value.ToString();
            dateTime_stokTarihi.Text = data_stokTakip.CurrentRow.Cells[6].Value.ToString();
            txb_kayıtYapan.Text = data_stokTakip.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
           
            string sorgu = "Insert into stok1 (StokAdi,StokModeli,StokSeriNo,StokBedeni,StokAdedi,StokTarihi,KayitYapan) values (@StokAdi,@StokModeli,@StokSeriNo,@StokBedeni,@StokAdedi,@StokTarihi,@KayitYapan)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@StokAdi", txb_stokAdi.Text);
            cmd.Parameters.AddWithValue("@StokModeli", txb_stokModeli.Text);
            cmd.Parameters.AddWithValue("@StokSeriNo", txb_stokSeriNo.Text);
            cmd.Parameters.AddWithValue("@StokBedeni", cmb_stokBedeni.Text);
            cmd.Parameters.AddWithValue("@StokAdedi", txb_stokAdedi.Text);
            cmd.Parameters.AddWithValue("@StokTarihi", dateTime_stokTarihi.Value);
            cmd.Parameters.AddWithValue("@KayitYapan",txb_kayıtYapan.Text);
         
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            filldatagrid();
        }

        private void btn_stokGüncelle_Click(object sender, EventArgs e)
        {

            string sorgu = "Update stok1 Set StokAdi=@StokAdi,StokModeli=@StokModeli,StokSeriNo=@StokSeriNo,StokBedeni=@StokBedeni,StokAdedi=@StokAdedi,StokTarihi=@StokTarihi,KayitYapan=@KayitYapan Where id=@id";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txb_kayitNo.Text));
            cmd.Parameters.AddWithValue("@StokAdi", txb_stokAdi.Text);
            cmd.Parameters.AddWithValue("@StokModeli", txb_stokModeli.Text);
            cmd.Parameters.AddWithValue("@StokSeriNo", txb_stokSeriNo.Text);
            cmd.Parameters.AddWithValue("@StokBedeni", cmb_stokBedeni.Text);
            cmd.Parameters.AddWithValue("@StokAdedi", txb_stokAdedi.Text);
            cmd.Parameters.AddWithValue("@StokTarihi", dateTime_stokTarihi.Value);
            cmd.Parameters.AddWithValue("@KayitYapan", txb_kayıtYapan.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            filldatagrid();
        }

        private void btn_stokSil_Click(object sender, EventArgs e)
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
            }


        }

        private void btn_stokAra_Click(object sender, EventArgs e)
        {
            SearchData(txb_stokAra.Text);
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

    }
}


