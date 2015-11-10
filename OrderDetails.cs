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
    public partial class OrderDetails : Form
    {
        
      
        
        public OrderDetails()
        {
            InitializeComponent();
         
           
            
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            OrderDelivered n = new OrderDelivered();
            int Orderid = n.orderid;
           GetCustomerdetails(Orderid);
           GetItemsDetails(Orderid);
        
           Gettotalwithrespectivetoquantity(Orderid);
          
            
        }

        public void GetCustomerdetails(int ORDERID)
        {

            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "Select * from Orders where OrderID = " + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    OrderDetails_Name.Text = sd.GetString(2);
                    OrderDetails_Address.Text = sd.GetString(3);
                    OrderDetails_Phonenumber.Text = sd.GetString(4);
                    OrderDetails_Email.Text = sd.GetString(5);
                    OrderDetails_Orderid.Text = sd.GetInt32(0).ToString();
                    OrderDetails_Orderdate.Text = sd.GetDateTime(1).ToString();

                }
            }
            sd.Close();
            con.Close();

        }

        public void GetItemsDetails(int ORDERID)
        {

            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select Categories.CategoryName , FoodItems.ItemName ,FoodItems.UnitPrice as Price, OrderDetails.Quantity from Orders inner join OrderDetails on Orders.OrderId=OrderDetails.OrderId inner join FoodItems on FoodItems.ItemID=OrderDetails.ItemId inner join Categories on Categories.CategoryID = FoodItems.CategoryId where OrderDetails.OrderId = "+ ORDERID;

            SqlCommand sc = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }



        public void Gettotalwithrespectivetoquantity(int ORDERID)
        {
            int temp=0;
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select OrderDetails.UnitPrice as price , OrderDetails.Quantity from OrderDetails where OrderDetails.OrderId=" + ORDERID;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    temp = Convert.ToInt32( temp + (sd.GetDouble(0) * sd.GetInt32(1)));

                }

            }
            OrderDetails_totalamount.Text = temp.ToString(); 
        }

        public void SetStatusOfItemdelivered(int ORDERID)
        {
           
            string status = Orderdetails_status.Text;
          
            //string value = OrderDetails_status.SelectedValue.ToString();
           if (status == "Item Delivered")
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();

                string query = "UPDATE Orders Set HasBeenShipped='true' where Orders.OrderId=" + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have changed Status of Orderid :" + ORDERID.ToString() + " to " + status, "OrderDetails");

            }}
           
        public void SetStatusOfIteminPending(int ORDERID){
               string status = Orderdetails_status.Text;
        if (status == "Item in pending")
            {
                SqlConnection con = new SqlConnection(Program.CONSTR);
                con.Open();

                string query = "UPDATE Orders Set HasBeenShipped='false' where Orders.OrderId=" + ORDERID;
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have changed Status of Orderid :" + ORDERID.ToString()+" to "+status, "OrderDetails");

            }}

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            OrderDelivered n = new OrderDelivered();
            int Orderid = n.orderid;
            SetStatusOfItemdelivered(Orderid);
            SetStatusOfIteminPending(Orderid);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            EditDetails e1 = new EditDetails();
           
            e1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteItem di = new DeleteItem();
            this.Hide();
            di.Show();
        }

      







    }

        
}
