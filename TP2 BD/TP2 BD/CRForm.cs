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
                    RapportStandard("lister tous les fournisseurs");
                    break;
                case 1:
                    RapportPublipostage("lister tous les fournisseurs pour des étiquettes de publipostage");
                    break;
                case 2:
                    RapportStandard("liste les fournisseurs avec leurs produits que nous avons en inventaire");
                    break;
                case 3:
                    RapportStandard("liste les fournisseurs avec leurs produits mais uniquement ceux dont la quantité minimale est atteinte ");
                    break;
            }
        }
        private void RapportStandard(string sql)
        {

        }
        private void RapportPublipostage(string sql)
        {

        }
    }
}
