using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnispis_Click(object sender, EventArgs e)
        {
            List<string> dataItems = new List<string>();
            var connString = "Host=localhost; Port = 5432; Username='postgres'; Password=87654321; Database=test";

            using (var conn = new NpgsqlConnection(connString))
            {
                
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT datetime FROM reporting3", conn))
                using (var reader = cmd.ExecuteReader())
                /*  for (int i = 0; reader.Read(); i++)
                  {
                      rtb.Text = dataItems.Add(reader + "\r\n");
                  }*/
                 while (reader.Read())
                     rtb.Text = (reader.GetString(0) + "\r\n");


            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

           var connString = "Host=localhost; Port = 5432; Username='postgres'; Password=87654321; Database=test";

            var conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into reporting3(id, cause , datetime, longitude , latitude , ratingP, ratingM ,direction , ban,  userid) VALUES (@id, @cause ,  @datetime, @longitude , @latitude , @ratingP, @ratingM ,@direction , @ban,  @userid);", conn);

            command.Parameters.AddWithValue("@id", 2);
            command.Parameters.AddWithValue("@cause", 1);
            command.Parameters.AddWithValue("@datetime", DateTime.Now);
            command.Parameters.AddWithValue("@longitude", 1);
            command.Parameters.AddWithValue("@latitude", 1);
            command.Parameters.AddWithValue("@ratingP", 1);
            command.Parameters.AddWithValue("@ratingM", 1);
            command.Parameters.AddWithValue("@direction", 1);
            command.Parameters.AddWithValue("@ban", 1);
            command.Parameters.AddWithValue("@UserId", 1);
            command.ExecuteNonQuery();

            conn.Close();


            /* NpgsqlCommand command = new NpgsqlCommand("insert into reporting2(id, name , age , adress, salery) VALUES (@id, @name, @age, @adress, @salery);" , conn);

             var id = 180;
             command.Parameters.AddWithValue("@id", id);
             command.Parameters.AddWithValue("@name", "ludnica666");
             command.Parameters.AddWithValue("@age", 35);
             command.Parameters.AddWithValue("@adress", "osijek");
             command.Parameters.AddWithValue("@salery", 100000);
             command.ExecuteNonQuery();

             id++;
             conn.Close();
             /*
             using (var cmd = new NpgsqlCommand())
             {

             cmd.CommandText = "insert into company(id, name , age , adress, salery) VALUES (@id, @name, @age, @adress, @salery);";
             cmd.Parameters.AddWithValue("@id", 161);
             cmd.Parameters.AddWithValue("@name", "ludnica666");
             cmd.Parameters.AddWithValue("@age", 35);
             cmd.Parameters.AddWithValue("@adress", "osijek");
             cmd.Parameters.AddWithValue("@salery", 100000);
             rtb.Text = connString;
             cmd.ExecuteNonQuery();
             }
             conn.Close();
             /* bool blnfound = false();

              NpgsqlConnection conn = new NpgsqlConnection("Host=localhost; Port = 5432; Username='postgres'; Password=87654321; Database=test");
              conn.Open(); // opens the connection

              NpgsqlCommand cmd = new NpgsqlCommand("select * from login where name = '" + tb1.Text + "' and password = '" + tb2.Text + "'" , conn);
              NpgsqlDataReader dr = cmd.ExecuteReader();

              if (dr.Read())
              {
                  blnfound = true;
                  Form2 f5 = new Form2();
                  f5.Show();
                  this.Hide();

              }
              if (blnfound == false)
              {
                  MessageBox.Show("Name of password is not correct !! " , MessageBoxButtons.OK,MessageBoxDefaultButton.Button1);
              }

              dr.Close();
              conn.Close();
              */
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connString = "Host=localhost; Port = 5432; Username='postgres'; Password=87654321; Database=reporttable; Database=test";

            var conn = new NpgsqlConnection(connString);
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("insert into reporting3(id, cause , datetime, longitude , latitude , ratingP, ratingM ,direction , ban,  userid) VALUES (@id, @cause ,  @datetime, @longitude , @latitude , @ratingP, @ratingM ,@direction , @ban,  @userid);", conn);


            var text1 = Convert.ToInt32(tb1.Text);
            var text2 = Convert.ToInt32(tb2.Text);
            var text4 = Convert.ToInt32(tb4.Text);
            var text5 = Convert.ToInt32(tb5.Text);
            var text6 = Convert.ToInt32(tb6.Text);
            var text7 = Convert.ToInt32(tb7.Text);
            var text8 = Convert.ToInt32(tb8.Text);
            var text9 = Convert.ToInt32(tb9.Text);
            var text10 = Convert.ToInt32(tb10.Text);

            command.Parameters.AddWithValue("@id", text1);
            command.Parameters.AddWithValue("@cause", text2);
            command.Parameters.AddWithValue("@datetime", DateTime.Now);
            command.Parameters.AddWithValue("@longitude", text4);
            command.Parameters.AddWithValue("@latitude", text5);
            command.Parameters.AddWithValue("@ratingP", text6);
            command.Parameters.AddWithValue("@ratingM", text7);
            command.Parameters.AddWithValue("@direction", text8);
            command.Parameters.AddWithValue("@ban", text9);
            command.Parameters.AddWithValue("@UserId", text10);
            command.ExecuteNonQuery();

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
