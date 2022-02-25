using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204003_New
{

    public partial class ViewProdi : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;

        public ViewProdi()
        {
            InitializeComponent();
        }

        private void ViewProdi_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=KHOLIDAMAGFIRAH;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_prodi";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "ms_prodi");
            dgProdi.DataSource = ds;
            dgProdi.DataMember = "ms_prodi";
            dgProdi.Refresh();
            conn.Close();
        }

    }
}
