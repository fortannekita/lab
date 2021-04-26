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

namespace PA
{
    public partial class DeleteEntry : Form
    {
        public DeleteEntry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\maxim\Clothes.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM CLOTH WHERE IdCLOTH='" + textBox1.Text + "'", con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill all");
            }
        }
    }
}
