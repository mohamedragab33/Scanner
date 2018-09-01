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

namespace Full_application
{
    public partial class sittingForm : Form
    {
        
       public  DataSet dataset1 = new DataSet();
      
        public sittingForm()
        {
            InitializeComponent();
           
            
           
    
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                DataRow datarow1 = dataset1.Tables[0].Rows[0];
                datarow1[0] = txtserver.Text;
                datarow1[1] = txtserverUserName.Text;
                datarow1[2] = txtServerPassword.Text;
                datarow1[3] = txtdbserver.Text;
                datarow1[4] = txtdbname.Text;
                datarow1[5] = txtdbusername.Text;
                datarow1[6] = txtdbuserpassword.Text;
                dataset1.WriteXml("patient.xml");
                MessageBox.Show("your data is updated sucessfully");
                this.Close();
            }
            catch
            {

                MessageBox.Show("error in update");

            }
          
            
           
        }
    
        private void sittingForm_Load(object sender, EventArgs e)
        {
            
            dataset1.ReadXml("patient.xml");
            txtserver.Text = dataset1.Tables[0].Rows[0][0].ToString();
            txtserverUserName.Text = dataset1.Tables[0].Rows[0][1].ToString();
            txtServerPassword.Text = dataset1.Tables[0].Rows[0][2].ToString();
            txtdbserver.Text = dataset1.Tables[0].Rows[0][3].ToString();
            txtdbname.Text = dataset1.Tables[0].Rows[0][4].ToString();
            txtdbusername.Text = dataset1.Tables[0].Rows[0][5].ToString();
            txtdbuserpassword.Text = dataset1.Tables[0].Rows[0][6].ToString();


        }

        private void txtserver_TextChanged(object sender, EventArgs e)
        {
           
            
        
            
            
           
        }

        private void txtserver_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
       

    }
}
