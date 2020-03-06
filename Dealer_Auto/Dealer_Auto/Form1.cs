using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Dealer_Auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conexiune;

        private void Form1_Shown(object sender, EventArgs e)
        {
            string adresa_Bazei_De_Date = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BazaDeDate.accdb;Persist Security Info=True";
            conexiune = new OleDbConnection(adresa_Bazei_De_Date);
            try
            {
                conexiune.Open();
            }
            catch( Exception exceptie )
            {
                MessageBox.Show(exceptie.Message);
            }

        }

        private void button_Logare_Click(object sender, EventArgs e)
        {
            string utilizator = textBox_Utilizator.Text;
            string parola = textBox_Parola.Text;
            if( utilizator != "" && parola != "" )
            {
                string text_Comanda = "SELECT * FROM [Tabel_Useri] WHERE Username='" + utilizator + "' AND Parola ='" + parola + "'";
                OleDbCommand comanda = new OleDbCommand(text_Comanda, conexiune);
                OleDbDataReader cititor_Date = comanda.ExecuteReader();
                if (cititor_Date.HasRows)
                {
                    cititor_Date.Read();
                    MessageBox.Show(cititor_Date[4].ToString() + " " + cititor_Date[6].ToString());

                }
                else
                    MessageBox.Show("Nu ati introdus datele !");
           
            }
            else
                MessageBox.Show("Nu ati introdus datele !");
        }
    }
}
