using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoTicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)



        {
            if (textBox1.Text == "")

            {
                MessageBox.Show("necesitas registrarte");
                textBox1.Focus();

            }
            else
            {


                String conexiónString = null;
                conexiónString = "Server=LAPTOP-R5SL9MVM;Database=pokemon;Trusted_Connection=True;";
                SqlConnection conexión;
                conexión = new SqlConnection(conexiónString);

                SqlCommand comando;

                string query;
                query = "INSERT INTO Jugador VALUES('" + textBox1.Text + "')";
                conexión.Open();
                comando = new SqlCommand(query, conexión);
                comando.ExecuteNonQuery();

                Form1 ventana1 = new Form1();
                ventana1.Show(this);
                this.Hide();

                comando.Dispose();
                conexión.Close();
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
