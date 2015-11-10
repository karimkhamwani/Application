using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace FlamingoWF{
            

            

    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
         }


       
        private void button2_Click(object sender, EventArgs e)
        {
            
            Main m1 = new Main();
            m1.Show();
               
        }

       
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
