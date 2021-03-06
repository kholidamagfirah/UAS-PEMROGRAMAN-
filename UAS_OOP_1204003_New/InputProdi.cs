using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204003_New
{

    public partial class InputProdi : Form
    {
        Decimal rupiah;
        public InputProdi()
        {
            InitializeComponent();
            string getLastIdSql = "SELECT kode_prodi FROM ms_prodi ORDER BY kode_prodi DESC";

            string connection = "integrated security=true; data source=.; initial catalog=UAS";
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sc = new SqlCommand(getLastIdSql, conn);
            SqlDataReader result;

            result = sc.ExecuteReader();

            string newKode = "";
            if (result.HasRows)
            {
                int newKodeProdi = 0;
                while (result.Read())
                {
                    newKode = result["kode_prodi"].ToString();
                    string angkaKode = Regex.Match(newKode, @"\d+").Value;
                    newKodeProdi = Int16.Parse(angkaKode) + 1;
                    if (newKodeProdi >= 10)
                    {
                        newKode = "PRD" + newKodeProdi;
                    }
                    else
                    {
                        newKode = "PRD0" + newKodeProdi;
                    }
                    break;
                }
            }
            else
            {
                newKode = "PRD01";
            }
            kode_prodi.Text = newKode;
        }

        private void SubmitProdi_Click(object sender, EventArgs e)
        {

            int i;
            if (nama_prodi.Text != "" && !nama_prodi.Text.ToString().Any(char.IsDigit))
            {
                if (singkatan.Text != "")
                {
                    if (biaya_kuliah.Text != "" && int.TryParse(biaya_kuliah.Text.ToString(), out i))
                    {
                        string sql = "INSERT INTO ms_prodi VALUES('"
                                + kode_prodi.Text + "','"
                                + nama_prodi.Text + "','"
                                + singkatan.Text + "','"
                                + biaya_kuliah.Text + "')";

                        UpdateDB(sql);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Kolom biaya kuliah tidak boleh kosong !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Kolom singkatan Prodi tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kolom nama Prodi tidak boleh kosong ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=KHOLIDAMAGFIRAH;Initial Catalog=UAS;Integrated Security=True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception z)
            {
                MessageBox.Show(z.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            kode_prodi.Text = "";
            nama_prodi.Text = "";
            singkatan.Text = "";
            biaya_kuliah.Text = "";

        }

        private void biaya_kuliah_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(biaya_kuliah.Text))
            {
                rupiah = 0;
            }
            else
            {
                rupiah = decimal.Parse(biaya_kuliah.Text);
            }
            indo.Text = rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));


        }

        private void biaya_kuliah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nama_prodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void singkatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
