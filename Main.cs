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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }


       

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee a1 = new AddEmployee();
            a1.Show();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence a1 = new Attendence();
            a1.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee d1 = new DeleteEmployee();
            d1.Show();
        }

        private void updateEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployee u1 = new UpdateEmployee();
            u1.Show();
        }

        private void orderInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDelivered o1 = new OrderDelivered();
            o1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderInPendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderinpending op = new Orderinpending();
            this.Hide();
            op.Show();
        }

        private void orderDeliveredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDelivered Od = new OrderDelivered();
            this.Hide();
            Od.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orderinpending op = new Orderinpending();
            this.Hide();
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderDelivered od = new OrderDelivered();
            this.Hide();
            od.Show();
        }

        
    }
}
