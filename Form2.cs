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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlDataAdapter adapt;
        int ID = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            SqlDataAdapter da = new SqlDataAdapter("select * from student",conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"].DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // insert into db
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            conn.Open();
            string query = "insert into student values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Inserted Succesfully !");
            DisplayData();
            ClearData();
        }

        // update into db
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            conn.Open();
            string query = "update student set Name='" + textBox2.Text + "', Department='" + textBox3.Text + "' where ID='" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Succesfully !");
            DisplayData();
            ClearData();
        }

        // delete entry
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            conn.Open();
            string query = "delete from student where ID='" + textBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
            ClearData();
            
        }


        // update grid view
        private void DisplayData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from student",conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        // clear the text holder
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
        }

    }
}
