using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1LD2A2\\SQLEXPRESS;Initial Catalog=\"Crud System\";Integrated Security=True") ;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into ut values(@id,@name,@age)",con);

            cmd.Parameters.AddWithValue("@id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", (textBox2.Text));
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Inserted");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1LD2A2\\SQLEXPRESS;Initial Catalog=\"Crud System\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("update ut set name = @name  , age = @age where id = @id",con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", (textBox2.Text));
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully updated");



        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1LD2A2\\SQLEXPRESS;Initial Catalog=\"Crud System\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete ut where id = @id",con);

            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Successfully Deleted");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G1LD2A2\\SQLEXPRESS;Initial Catalog=\"Crud System\";Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from ut where id = @id" ,con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            
            dataGridView1.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
