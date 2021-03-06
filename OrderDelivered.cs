﻿using System;
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
            credentials();
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.websiteProjectFlamingoDataSet3.Orders);
            // TODO: This line of code loads data into the 'websiteProjectFlamingoDataSet.Orders' table. You can move, or remove it, as needed.
            // this.ordersTableAdapter.Fill(this.websiteProjectFlamingoDataSet.Orders);
            getitemDelivered();

        }
        public void credentials()
        {
            Login l1 = new Login();
            if (l1.role == "Regular")
            {
               // dataGridView1.Columns[12].Visible = false;
                staffToolStripMenuItem.Enabled = false;
            }

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
            /* if (e.ColumnIndex == 12)
             {
                
                 DialogResult Result = MessageBox.Show("Are you sure to delete order", "Delete order", MessageBoxButtons.YesNo);
                 if (Result == DialogResult.Yes)
                 {
                     DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                     Orderid = int.Parse(row.Cells["orderIdDataGridViewTextBoxColumn"].Value.ToString());
                     /*OrderDetails OD = new OrderDetails();
                     this.Hide();
                     OD.Show();
                     deleteorder(orderid);
                     deletedetailsfromOrderDetails(orderid);
                 }
            
             }

         }

         public void deletedetailsfromOrderDetails(int ORDERID)
         {
             SqlConnection con = new SqlConnection(Program.CONSTR);
             con.Open();
             string query = "delete from OrderDetails where OrderDetails.OrderId=" + ORDERID;
             SqlCommand sc = new SqlCommand(query, con);
             sc.ExecuteNonQuery();
             con.Close();
         }
         public void deleteorder(int ORDERID) //delete order from database
         {
             SqlConnection con = new SqlConnection(Program.CONSTR);
             con.Open();
             string query = "delete from Orders where Orders.OrderId=" + ORDERID;
             SqlCommand sc = new SqlCommand(query, con);
             sc.ExecuteNonQuery();
             con.Close();
         }*/

        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            this.Hide();
            f.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee a1 = new AddEmployee();
            a1.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee d1 = new DeleteEmployee();
            d1.Show();
        }

        private void markAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence a1 = new Attendence();
            a1.Show();

        }

        private void viewAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAttendence va = new ViewAttendence();
            va.Show();
        }

        private void itemInPendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderinpending op = new Orderinpending();
            this.Hide();
            op.Show();
        }

        private void itemDeliveredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDelivered Od = new OrderDelivered();
            this.Hide();
            Od.Show();

        }
    }
}
