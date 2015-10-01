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

namespace TP2_BD
{
    public partial class Form2 : Form
    {
        private SqlConnection connexion;
        public Form2()
        {
            InitializeComponent();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                String connexionChaine;
                connexionChaine = "Data Source=" + TB_pcName.Text + ";Initial Catalog=bdOperation;User ID=conOperation;Password=conOperation";
                connexion = new SqlConnection(connexionChaine);

                connexion.Open();
                new Form1(connexion).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le nom du PC ou la chaine de connexion n'est pas bonne ");
            }
            
        }
    }
}
