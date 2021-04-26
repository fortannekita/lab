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
    public partial class MainFilms : Form
    {
        public MainFilms()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\maxim\Clothes.mdf;Integrated Security=True;Connect Timeout=30");

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from CLOTH", con);
            SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from CLOTH ORDER BY NameCloth", con);
            SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from CLOTH ORDER BY PriceCloth", con);
            SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddEntry addEntry = new AddEntry();
            addEntry.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DeleteEntry deleteEntry = new DeleteEntry();
            deleteEntry.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ModifyEntry modifyEntry = new ModifyEntry();
            modifyEntry.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlString = "";
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrWhiteSpace(textBox2.Text))


                sqlString = "select * from CLOTH where NameCloth = '" + textBox1.Text + "'";


            else if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrWhiteSpace(textBox1.Text) &&
               !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))

                sqlString = "select * from CLOTH where PriceCloth = '" + textBox2.Text + "'";
            
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
              !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))

                sqlString = "select * from CLOTH where  NameCloth = '" + textBox1.Text + "' AND  PriceCloth ='" + textBox2.Text + "'";
            
            con.Open();
            SqlCommand seltari = new SqlCommand(sqlString, con);
            SqlDataAdapter ad = new SqlDataAdapter(seltari);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void MainFilms_Load(object sender, EventArgs e)
        {

        }
    }
}
