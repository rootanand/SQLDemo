using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//for microsoft sql server
using System.Data.SqlClient;

namespace ado_sql_Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //select using scalar
            SqlConnection sqlconn = new SqlConnection();

            // sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            //sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; trusted_connection=true";
            //  sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
             sqlconn.ConnectionString = "SERVER=.\\SQLDEV; Database=Student; Integrated Security=true";
            //sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; Integrated security=SSPI";
            //Security Support Provider Interface- an API (.dll file) that is used to provide Windows Authentication
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");

            }
            if (sqlconn.State == ConnectionState.Open)
            {
                this.Text = "welcome to ADO.Net";


                //select using scalar
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;
                //sqlcomm.CommandText = "select name from student where Studentid='1'";
               
               sqlcomm.CommandText = "select name from student where Studentid='" + textBox3.Text + "'";

                MessageBox.Show(sqlcomm.CommandText);
                MessageBox.Show(Convert.ToString(sqlcomm.ExecuteScalar()));

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();

            // sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            //  sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            sqlconn.ConnectionString = "SERVER=.\\SQLDEV; Database=Student; Integrated Security=true";
           // sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; Trusted_connection=true";
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");

            }
            if (sqlconn.State == ConnectionState.Open)
            {
                this.Text = "welcome to ADO.Net";
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;
                //insert using nonquery
                //sqlcomm.CommandText = "insert into student values('1','anand')";

                sqlcomm.CommandText = "insert into Student values('" + textBox1.Text + "','" + textBox2.Text + "')";
                MessageBox.Show(sqlcomm.CommandText);
                sqlcomm.ExecuteNonQuery();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();

            // sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            //  sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            // sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; Integrated Security=true";
            //sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; Trusted_connection=true";
            sqlconn.ConnectionString = "SERVER=.\\SQLDEV; Database=Student; Integrated Security=SSPI";
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");

            }
            if (sqlconn.State == ConnectionState.Open)
            {
                this.Text = "welcome to ADO.Net";
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;

                //delete using non query
                sqlcomm.CommandText = "delete from Student where Studentid='" + textBox4.Text + "'";

                MessageBox.Show(sqlcomm.CommandText);
                sqlcomm.ExecuteNonQuery();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();

            // sqlconn.ConnectionString = "SERVER=DESKTOP-AVF20I7\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            //  sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; uid=root;pwd=data";
            // sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; Integrated Security=true";
            //sqlconn.ConnectionString = "SERVER=.\\SQLEXPRESS; Database=Student; Trusted_connection=true";
            sqlconn.ConnectionString = "SERVER=.\\SQLDEV; Database=Student; Integrated Security=SSPI";
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed");

            }
            if (sqlconn.State == ConnectionState.Open)
            {
                this.Text = "welcome to ADO.Net";
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.Connection = sqlconn;

                //update name using non query
                sqlcomm.CommandText = "update Student set name='" + textBox6.Text + "' where Studentid='" + textBox5.Text + "'";

                MessageBox.Show(sqlcomm.CommandText);
                sqlcomm.ExecuteNonQuery();
            }
        }
    }
}
 

