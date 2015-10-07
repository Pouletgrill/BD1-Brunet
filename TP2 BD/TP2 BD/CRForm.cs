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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace TP2_BD
{
    public partial class CRForm : Form
    {
        int typeSql;
        SqlConnection connexion;
        public CRForm(int Type, SqlConnection con)
        {
            InitializeComponent();
            typeSql = Type;
            connexion = con;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            switch (typeSql)
            {
                case 0:
                    Rechercher("select * from Fournisseur ", "Fournisseur", "..\\..\\CrystalReport1.rpt");
                    break;
                case 1:
                    Rechercher("select * from Fournisseur ", "Fournisseur", "..\\..\\CrystalReport2.rpt");
                    break;
                case 2:
                    Rechercher("select * from Fournisseur INNER JOIN inventaire on inventaire.idfournisseur=fournisseur.idfournisseur ", "Fournisseur", "..\\..\\CrystalReport3.rpt");
                    break;
                case 3:
                    Rechercher("select * from Fournisseur INNER JOIN inventaire on inventaire.idfournisseur=fournisseur.idfournisseur "+
                "where QteStock < QteMinimum ", "Fournisseur", "..\\..\\CrystalReport3.rpt");
                    break;
            }
        }

        private void Rechercher(string sql, string table, string PathCR)
        {
            try
            {
                DataSet LeDataTableClients;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                ReportDocument monRapport = new ReportDocument();
                //Vous trouverez la méthode IsNumeric plus bas
                
                    LeDataTableClients = new DataSet(table);
                    //Spécifier les propriétés SelectCommand
                    //ici la connexion a été faite dans une autre procédure
                    dataAdapter.SelectCommand = new SqlCommand(sql, connexion);
                    dataAdapter.Fill(LeDataTableClients, table);
                    //On lui fourni la chaîne de caractères de la requête
                    if (this.BindingContext[LeDataTableClients, table].Count > 0)
                    {
                        String chemin;
                        //La conmmande qui suit permet de savoir quel est le dossier de démarrage de l'application
                        //MessageBox.Show(Application.StartupPath);
                        chemin = PathCR;
                        monRapport.Load(chemin);
                        monRapport.SetDataSource(LeDataTableClients.Tables[table]);
                        //On associe le contrôle à la source de données et rafraîchir le contrôle
                        crystalReportViewer1.ReportSource = monRapport;
                        crystalReportViewer1.Refresh();

                        //On relâche
                        LeDataTableClients.Clear();
                        dataAdapter.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a aucun employé entre ces numéros");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Méthode qui retourne vrai quand la chaine de caractères est numérique
        public bool IsNumeric(string Nombre)
        {
            int i = 0;
            int nb = 0;
            bool ok = false;
            char[] tabNombre;
            char[] unNb;
            tabNombre = Nombre.ToCharArray(0, Nombre.Length);
            for (i = 0; i < Nombre.Length; i++)
            {
                ok = false;
                while ((nb < 10) && (ok == false))
                {
                    unNb = Convert.ToString(nb).ToCharArray(0, 1);
                    if (tabNombre[i] == unNb[0])
                    {
                        ok = true;
                        nb = 0;
                    }
                    else
                    {
                        if ((i == 0) && (tabNombre[i] == '-'))
                        {
                            ok = true;
                            nb = 0;
                        }
                        else
                        {
                            ok = false;
                            nb++;
                        }
                    }
                }
            }
            return ok;
        }
    }
}
