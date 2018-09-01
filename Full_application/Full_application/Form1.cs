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
     
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnsitting_Click(object sender, EventArgs e)
        {
            sittingForm sittingform1 = new sittingForm();
            sittingform1.Show();

        }
     
        private void btnuploadForm_Click(object sender, EventArgs e)
        {
            UploadForm uploadform1 = new UploadForm();
            uploadform1.Show();
            

        }
    }
}
