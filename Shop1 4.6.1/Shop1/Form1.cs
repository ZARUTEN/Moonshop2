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

namespace Shop1
{
    public partial class Form1 : Form
    {
        bool vis = true;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != textBox2.Text )
        { 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Initial Catalog=Database1 ;Integrated Security=false;Connect Timeout=30");
            SqlDataAdapter Tablet = new SqlDataAdapter("Select Count (*) Login From [Table] Where Login ='" + textBox1.Text + "'and Password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            Tablet.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(textBox1.Text == "admin" )
                    {
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                        f.button19.Visible = true;
                        f.BackColor = Color.DarkGray;

                    }
                else
                    {
                        Form2 f = new Form2();
                        f.Show();
                        this.Hide();
                       
                    }
               
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (vis)
            {

                textBox2.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {

                textBox2.UseSystemPasswordChar = true;
                vis = true;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
            f.button19.Visible = true;
            f.BackColor = Color.DarkGray;
        }
    }
}
