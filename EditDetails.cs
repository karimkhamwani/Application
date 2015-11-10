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
    public partial class EditDetails : Form
    {
        public EditDetails()
        {
            InitializeComponent();
        }

        private void EditDetails_Load(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            int ORDERID = od.orderid;
            getEditDetails(ORDERID);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void getEditDetails(int Orderid)
        {
            
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string query = "select Categories.CategoryName , FoodItems.ItemName ,FoodItems.UnitPrice as Price, OrderDetails.Quantity from Orders inner join OrderDetails on Orders.OrderId=OrderDetails.OrderId inner join FoodItems on FoodItems.ItemID=OrderDetails.ItemId inner join Categories on Categories.CategoryID = FoodItems.CategoryId where OrderDetails.OrderId = " + Orderid;
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {

                while (sd.Read())
                {
                    EditDetails_Orderid.Text = Orderid.ToString();
                    EditDetails_Categoryname.Items.Add(sd.GetString(0));
                    

                }

            }



        }

        private void EditDetails_Categoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            int ORDERID = od.orderid;
            GetItemsNameandQuanity(ORDERID);

        }
        public void GetItemsNameandQuanity(int Orderid)
        {
            SqlConnection con = new SqlConnection(Program.CONSTR);
            con.Open();
            string Editdetails_category = EditDetails_Categoryname.Text;
                                                                                                                                                                     //string query = "Select id,username,password from Login where UserName = '" + username + "' and password = '" + pass + "'";
            string query = "select FoodItems.ItemName ,OrderDetails.Quantity from FoodItems inner join Categories on FoodItems.CategoryId=Categories.CategoryID inner join OrderDetails on OrderDetails.ItemId=FoodItems.ItemID where Categories.CategoryName='"+Editdetails_category+"' and OrderDetails.OrderId='"+Orderid+"'";
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader sd = sc.ExecuteReader();
            if (sd.HasRows)
            {
                while (sd.Read())
                {
                    EditDetails_Quantity.Items.Clear();
                    EditDetails_ItemName.Items.Clear();
                    EditDetails_ItemName.Items.Add(sd.GetString(0));
                    EditDetails_Quantity.Items.Add(sd.GetInt32(1).ToString());


                }

            }

        }
      
    }
}
