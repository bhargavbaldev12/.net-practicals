using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        string imgPath;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnsave_Click(object sender, EventArgs e)
        {
            string gen = null;
            string subject = null;
            if (genMale.Checked == true) {
                gen = "m";
            }
            if (genFemale.Checked == true) {
                gen = "f";
            }
            if (ck1.Checked == true) {
                subject = subject + " s1";
            }
            if (ck2.Checked == true) {
                subject = subject + " s2";
            }
            string source = @"Data Source=Mishil-Patel\SQLExpress;Initial Catalog=DemoDb;Integrated Security=True;Pooling=False";
            string insert = "insert into tblstudent (fname,lname,gender,subject,imgStudent) values ('" + txtfname.Text + "','" + txtlname.Text + "','" + gen + "','" + subject + "','" + (imgPath == null ? "" : imgPath) + "')";
            //MessageBox.Show(insert);
            //string insert = "insert into tblstudent(fname) values ('jhgjh')";
            SqlConnection conn = new SqlConnection(source);
            
            SqlCommand cmd = new SqlCommand(insert,conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Success....");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgPath =  openFileDialog1.SafeFileName;
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                //MessageBox.Show(imgPath);
            }
        }


    }
}
