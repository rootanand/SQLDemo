using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adosqldatareader1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = "SERVER=.\\; DATABASE= pubs; Integrated Security=true";
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (sqlconn.State == ConnectionState.Open)
            {
                //MessageBox.Show("Welcome!!!");
            }
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection=sqlconn;
           //sqlcomm.CommandText = "select au_id from authors";
          //sqlcomm.CommandText = "select au_id, au_fname, au_lname from authors";
         sqlcomm.CommandText = "select * from authors";
            SqlDataReader dr;
            dr = sqlcomm.ExecuteReader();
            listBox1.Items.Clear();

            while (dr.Read())
            {

                //listBox1.Items.Add(dr.GetString(2));


                //listBox1.Items.Add(dr.GetString(0) + "  " + dr.GetString(1) + "  " + dr.GetString(2));

                //listBox1.Items.Add(dr.GetString(0));
                //listBox1.Items.Add(dr.GetString(2) + " " + dr.GetString(1));

                listBox1.Items.Add("author id : " + dr.GetString(0));
                listBox1.Items.Add("First name : " + dr.GetString(2));
                listBox1.Items.Add("Last name : " + dr.GetString(1));
                listBox1.Items.Add("");

            }
            dr.Close();
        }
    }
}
