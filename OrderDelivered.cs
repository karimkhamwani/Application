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
    public partial class OrderDelivered : Form
    {
        private static int Orderid = 0;
        public int orderid
        {
            get { return Orderid; }
            set { Orderid = value; }
        }
        public OrderDelivered()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.websiteProjectFlamingoDataSet3.Orders);
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet.Orders' table. You can move, or remove it, as needed.
           // this.ordersTableAdapter.Fill(this.websiteProjectFlamingoDataSet.Orders);
            getitemDelivered();

        }



        public void getitemDelivered()
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select * from Orders where HasBeenProcessed='true'";

            SqlCommand sc = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();


        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {


                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Orderid = int.Parse(row.Cells["orderIdDataGridViewTextBoxColumn"].Value.ToString());
                OrderDetails OD = new OrderDetails();
                this.Hide();
                OD.Show();
            }
        }
    }
}
