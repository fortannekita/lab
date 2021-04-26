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
    public partial class ModifyEntry : Form
    {
        public ModifyEntry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\maxim\Clothes.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {

                SqlCommand command = new SqlCommand("UPDATE [CLOTH] SET [NameCloth]=@NameCloth, [TypeCloth]=@TypeCloth, [PriceCloth]=@PriceCloth, [ProductCloth]=@ProductCloth WHERE [IdCloth]=@IdCloth", con);

                con.Open();
                command.Parameters.AddWithValue("@IdCloth", textBox1.Text);
                command.Parameters.AddWithValue("@NameCloth", textBox2.Text);
                command.Parameters.AddWithValue("@TypeCloth", textBox3.Text);
                command.Parameters.AddWithValue("@PriceCloth", textBox4.Text);
                command.Parameters.AddWithValue("@ProductCloth", textBox5.Text);
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
