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
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml;
using Dynamsoft.TWAIN;
using Dynamsoft;
using Dynamsoft.Common;
using Dynamsoft.DotNet;
using Dynamsoft.TWAIN.Enums;
using Dynamsoft.TWAIN.Interface;

namespace Full_application
{
    public partial class UploadForm : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
       
        SqlDataReader datareader;
        string fileToUpload;
        string id ;
        string path;
        string linq;
        int pictype;


        DataSet dataset1 = new DataSet();


       






      



        

        public UploadForm()
        {
            InitializeComponent();
            dataset1.ReadXml("patient.xml");
            //sittingform2.dataset1.ReadXml("patient.xml");
            cn = new SqlConnection(@"Server='" + dataset1.Tables[0].Rows[0][3].ToString() + "'; DataBase='" + dataset1.Tables[0].Rows[0][4].ToString() + "'; User Id='" + dataset1.Tables[0].Rows[0][5].ToString() + "'; Password='" + dataset1.Tables[0].Rows[0][6].ToString() + "';MultipleActiveResultSets=True;");


            //dr = sittingform2.dataset1.Tables[0].Rows[0];

        }

        private void btnscan_Click(object sender, EventArgs e)
        {
        }
        private void UploadForm_Load(object sender, EventArgs e)
        {
            this.pictype = 1;

        }


        private void btnupload_Click(object sender, EventArgs e)
        {



        }



        // up load function 
        public void upload(string fileuploading)
        {
            //cheackIFPatientExist();
            try
            {

                

                this.linq = dataset1.Tables[0].Rows[0][0].ToString();
                //this.linq = dr["serverName"].ToString();


                FileInfo touplod = new FileInfo(fileuploading);


                // link 
                Random rnd = new Random();
                int rndnumber = rnd.Next();
               
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.linq+rndnumber.ToString() + touplod.Name);

                this.path = "../Attachment/" +rndnumber.ToString() +touplod.Name;
             
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // userName                      password


                request.Credentials = new NetworkCredential(dataset1.Tables[0].Rows[0][1].ToString(),dataset1.Tables[0].Rows[0][2].ToString());
                Stream ftpstream = request.GetRequestStream();
                FileStream file = File.OpenRead(fileuploading);
                int lenght = 1024;
                byte[] buffer = new byte[lenght];
                int byteread = 0;
                do
                {

                    byteread = file.Read(buffer, 0, lenght);
                    ftpstream.Write(buffer, 0, byteread);

                } while (byteread != 0);
                MessageBox.Show("uploaded successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                file.Close();
                ftpstream.Close();
                //upload_to_attachment();
             


            }
            catch
            {
                MessageBox.Show("Error connecting to server to upload", "error", MessageBoxButtons.OK);
            }


            
           
         
            cheackIFPatientExist();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void btnscan_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                //t0068UwAAAJjaiZJ3UoD1qJl9nnviA / tgMhgQAGaZdvNCWkAILzVHWJmKCgmM4OHHcVUKQjp1MO7 + aO3Lw6fyprnSr9ymRp4 =
                
                    dynamicDotNetTwain1.LicenseKeys = "D404B4E4FF24D03A1A305A18248369D1";
                    //                dynamicDotNetTwain1.SelectSource(); 
                    //dynamicDotNetTwain1.OpenSource();//Open the source before doing any configuration 
                    //dynamicDotNetTwain1.IfShowUI = false; //Hide the User Interface of the scanner 
                    //dynamicDotNetTwain1.IfFeederEnabled = true; //Use the document feeder for batch scan 
                    //dynamicDotNetTwain1.IfDuplexEnabled = false; //Scan in Simplex mode 
                    ////dynamicDotNetTwain1.PixelType =1; //Scan pages in Grey 
                    //dynamicDotNetTwain1.Resolution = 200; //Scan pages in 200 DPI  


                    //dynamicDotNetTwain1.AcquireImage();//Start scanning 



                    dynamicDotNetTwain1.SelectSource();

                    dynamicDotNetTwain1.CloseSource();

                    dynamicDotNetTwain1.OpenSource();
                    //dynamicDotNetTwain1.ScanInNewProcess = dynamicDotNetTwain1.AcquireImage();
                    dynamicDotNetTwain1.Update();
                 
                    dynamicDotNetTwain1.AcquireImage();
                    dynamicDotNetTwain1.Refresh();
                    dynamicDotNetTwain1.Update();
                
                    //dynamicDotNetTwain1.SaveAsMultiPagePDF(Application.StartupPath + "\\" + "test.jpg", dynamicDotNetTwain1.CurrentSelectedImageIndicesInBuffer); 

                    //dynamicDotNetTwain1.Refresh();
                    dynamicDotNetTwain1.SaveAsJPEG(Application.StartupPath + "\\" + "test.jpg", 0);

                    fileToUpload = Application.StartupPath + "\\" + "test.jpg";
                   

                    MessageBox.Show("Scanned succesfully", "scanned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dynamicDotNetTwain1.CloseSourceManager();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "warning");

            }



        }
        Form1 si = new Form1();
        private void btnupload_Click_1(object sender, EventArgs e)
        {

         
            upload(fileToUpload);

            this.Close();
          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn = new SqlConnection(@"Server='" + dataset1.Tables[0].Rows[0][3].ToString() + "'; DataBase='" + dataset1.Tables[0].Rows[0][4].ToString() + "'; User Id='" + dataset1.Tables[0].Rows[0][5].ToString() + "'; Password='" + dataset1.Tables[0].Rows[0][6].ToString() + "';MultipleActiveResultSets=True;");
            try
            {
                cmd = new SqlCommand("select ID,name,code from patientData where code='" + txtpatientcode.Text + "'", cn);
                 cn.Open();
                 datareader = cmd.ExecuteReader();
                 datareader.Read();
                  this.id=datareader["ID"].ToString();
                txtpatientName.Text = datareader["name"].ToString();
                MessageBox.Show("founded");
            

            }

            catch
            {
                MessageBox.Show("this patient isn't found in data base");

            }
            finally { cn.Close();

            datareader.Close();
            }

        }





        public void cheackIFPatientExist() {
            decimal pid = decimal.Parse(this.id);

            try
            {

                int X;
                int flag = 0;

                cmd = new SqlCommand("select PicType from PationAttachment where PationId='" + pid + "'", cn);
                cn.Open();
                datareader = cmd.ExecuteReader();
                

                while (datareader.Read())
                {
                    X = Convert.ToInt32(datareader["PicType"]);
                    

                    if (this.pictype == X)
                    {
                        ////MessageBox.Show("this patient is all ready have pic");

                        cmd = new SqlCommand("Update PationAttachment Set src='" + this.path + "' where PationId='" + pid + "' and PicType='"+this.pictype+"' ", cn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("updated");
                        
                       
                        flag = 1;


                    }


                } datareader.Close();
                




                if (flag != 1 )
                {

                    cmd = new SqlCommand("insert into PationAttachment (PationId,src,PicType) values ('" + pid + "' ,'" + this.path + "','" + this.pictype + "') ", cn);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("added to patient attachment");


                }



            
            }

            catch(Exception ex)
            
            {
                MessageBox.Show(ex.Message);
                //datareader.Close();

                //cmd = new SqlCommand("insert into PationAttachment (PationId,src,PicType) values ('" + pid + "' ,'" + this.path + "','" + this.pictype + "') ", cn);


                //cmd.ExecuteNonQuery();

                //MessageBox.Show("added to patient attachment");

               
            
            }
            finally {

                datareader.Close();
                cn.Close();
            }
            
        
        
        
        
        }


        public void upload_to_attachment()
        {
           

            decimal pid = decimal.Parse(this.id);
            
            try {
                // select with patientid and typeid
                // if exists ==> update patientattachent
                // if not ==> insert into 

                cmd = new SqlCommand("insert into PationAttachment (PationId,src,PicType) values ('" + pid + "' ,'" + this.path + "','"+this.pictype+"') ", cn);
                
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("added to patient attachment");
            }

            catch
            {

                MessageBox.Show(" can't add  to patient attachment");

            }
            finally
            {

                cn.Close();

            }
        }


    



        private void dynamicDotNetTwain1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictype = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictype = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictype = 3;
        }




    }
}

/////////////////////////////////////////////////////////
            