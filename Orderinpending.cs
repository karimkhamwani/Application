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
namespace FlamingoWF
{
    public partial class Orderinpending : Form
    {
        public Orderinpending()
        {
            InitializeComponent();
        }

        private void Orderinpending_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.websiteProjectFlamingoDataSet1.Orders);

            GetItemsinpending();
        }

        public void GetItemsinpending(/*int ORDERID*/)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select * from Orders where HasBeenShipped='false'";

            SqlCommand sc = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

                OrderDelivered o1 = new OrderDelivered();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                o1.orderid = int.Parse(row.Cells["orderIdDataGridViewTextBoxColumn"].Value.ToString());
                OrderDetails OD = new OrderDetails();
                this.Hide();
                OD.Show();
            }
        }



       
    }
}
