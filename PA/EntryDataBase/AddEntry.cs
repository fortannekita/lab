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
    public partial class AddEntry : Form
    {
        public AddEntry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\maxim\Clothes.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            comboBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("select IdCloth from Cloth", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read()) comboBox1.Items.Add(DR[0].ToString());

            int i = Int32.Parse(comboBox1.Items[comboBox1.Items.Count - 1].ToString());

            con.Close();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {

                SqlCommand command = new SqlCommand("INSERT INTO Cloth(IdCloth,NameCloth,TypeCloth,PriceCloth,ProductCloth) values(@IdCloth,@NameCloth,@TypeCloth,@PriceCloth,@ProductCloth)", con);

                con.Open();

                command.Parameters.AddWithValue("@IdCloth", i + 1);
                command.Parameters.AddWithValue("@NameCloth", textBox1.Text);
                command.Parameters.AddWithValue("@TypeCloth", textBox2.Text);
                command.Parameters.AddWithValue("@PriceCloth", textBox3.Text);
                command.Parameters.AddWithValue("@ProductCloth", textBox4.Text);
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
