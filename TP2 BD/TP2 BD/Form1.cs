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
    public partial class Form1 : Form
    {
        private SqlConnection connexion;
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder cmdBuilder;
        private DataSet dataSet;
        private List<string> listIdFournisseur = new List<string>();
        public Form1(SqlConnection con)
        {
            InitializeComponent();
            connexion = con;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Remplir_CB_Fournisseur();
            Remplir_DGV("select * from Inventaire");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connexion.Close();
        }

        private void Remplir_CB_Fournisseur()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select IdFournisseur, NomFournisseur from Fournisseur", connexion);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    listIdFournisseur.Add(DR[0].ToString());
                    CB_Fournisseur.Items.Add(DR[1].ToString());
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Remplir_DGV(string SQL)
        {
            try
            {
                string sql = SQL;
                dataAdapter = new SqlDataAdapter(sql, connexion);
                cmdBuilder = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                DGV_Data.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            refreshGB();
        }

        private void NUD_QteStock_ValueChanged(object sender, EventArgs e)
        {
            refreshGB();
        }

        private void NUD_QteMin_ValueChanged(object sender, EventArgs e)
        {
            refreshGB();
        }

        private void NUD_QteMax_ValueChanged(object sender, EventArgs e)
        {
            refreshGB();
        }

        void refreshGB()
        {
            if (TB_Description.Text != "" && NUD_QteMax.Value > NUD_QteMin.Value)
            {
                BTN_Ajouter.Enabled = true;
                BTN_Modifier.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
                BTN_Modifier.Enabled = false;
            }
        }

        private void DGV_Data_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(DGV_Data.CurrentRow.Cells[0].Value.ToString());
            TB_Description.Text = DGV_Data.CurrentRow.Cells[1].Value.ToString();
            NUD_QteStock.Value = Convert.ToInt32(DGV_Data.CurrentRow.Cells[3].Value);
            NUD_QteMax.Value = Convert.ToInt32(DGV_Data.CurrentRow.Cells[5].Value);
            NUD_QteMin.Value = Convert.ToInt32(DGV_Data.CurrentRow.Cells[4].Value);
            CB_Fournisseur.SelectedIndex = Convert.ToInt32(DGV_Data.CurrentRow.Cells[2].Value) - 1;
        }

        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            if (TB_Recherche.Text == "")
            {
                Remplir_DGV("select * from Inventaire");
            }
            else
            {
                Remplir_DGV("select * from Inventaire where DescriptionInventaire like '%" + TB_Recherche.Text + "%'");
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Inventaire values ('" + TB_Description.Text + "',"
                    + (CB_Fournisseur.SelectedIndex + 1)
                    + "," + NUD_QteStock.Value.ToString() + "," + NUD_QteMin.Value + "," + NUD_QteMax.Value + ")", connexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Valeurs ajoutées !");
                Remplir_DGV("select * from Inventaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Inventaire SET DescriptionInventaire='" + TB_Description.Text + "',"
                    +"IdFournisseur="+ (CB_Fournisseur.SelectedIndex + 1)
                    + ",QteStock=" + NUD_QteStock.Value.ToString() + ",QteMinimum=" + NUD_QteMin.Value + ",QteMaximum=" + NUD_QteMax.Value 
                    + " where IdInventaire = "+DGV_Data.CurrentRow.Cells[0].Value, connexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Valeurs modifiées !");
                Remplir_DGV("select * from Inventaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Inventaire where IdInventaire = " + DGV_Data.CurrentRow.Cells[0].Value, connexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Valeurs Supprimées !");
                Remplir_DGV("select * from Inventaire");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_QteMinimum_Click(object sender, EventArgs e)
        {
            Remplir_DGV("select * from Inventaire where QteStock < QteMinimum");
        }

        private void BTN_CR_Click(object sender, EventArgs e)
        {
            new CRForm(CB_CR.SelectedIndex, connexion).ShowDialog();
        }

        private void CB_CR_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTN_CR.Enabled = true;
        }
    }
}
