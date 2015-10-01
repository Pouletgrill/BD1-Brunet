namespace TP2_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.TB_Recherche = new System.Windows.Forms.TextBox();
            this.BTN_QteMinimum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.CB_Fournisseur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_QteStock = new System.Windows.Forms.NumericUpDown();
            this.NUD_QteMin = new System.Windows.Forms.NumericUpDown();
            this.NUD_QteMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GB_ModSupAdd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteMax)).BeginInit();
            this.GB_ModSupAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Enabled = false;
            this.BTN_Ajouter.Location = new System.Drawing.Point(93, 321);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(174, 321);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 1;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(255, 321);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 2;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Location = new System.Drawing.Point(174, 12);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(93, 23);
            this.BTN_Rechercher.TabIndex = 3;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // DGV_Data
            // 
            this.DGV_Data.AllowUserToAddRows = false;
            this.DGV_Data.AllowUserToDeleteRows = false;
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Location = new System.Drawing.Point(12, 41);
            this.DGV_Data.MultiSelect = false;
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.ReadOnly = true;
            this.DGV_Data.RowHeadersVisible = false;
            this.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Data.Size = new System.Drawing.Size(420, 155);
            this.DGV_Data.TabIndex = 4;
            this.DGV_Data.SelectionChanged += new System.EventHandler(this.DGV_Data_SelectionChanged);
            // 
            // TB_Recherche
            // 
            this.TB_Recherche.Location = new System.Drawing.Point(273, 15);
            this.TB_Recherche.Name = "TB_Recherche";
            this.TB_Recherche.Size = new System.Drawing.Size(159, 20);
            this.TB_Recherche.TabIndex = 5;
            // 
            // BTN_QteMinimum
            // 
            this.BTN_QteMinimum.Location = new System.Drawing.Point(12, 12);
            this.BTN_QteMinimum.Name = "BTN_QteMinimum";
            this.BTN_QteMinimum.Size = new System.Drawing.Size(156, 23);
            this.BTN_QteMinimum.TabIndex = 6;
            this.BTN_QteMinimum.Text = "Afficher produits en manque";
            this.BTN_QteMinimum.UseVisualStyleBackColor = true;
            this.BTN_QteMinimum.Click += new System.EventHandler(this.BTN_QteMinimum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description :";
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(81, 26);
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(100, 20);
            this.TB_Description.TabIndex = 10;
            this.TB_Description.TextChanged += new System.EventHandler(this.TB_Description_TextChanged);
            // 
            // CB_Fournisseur
            // 
            this.CB_Fournisseur.FormattingEnabled = true;
            this.CB_Fournisseur.Location = new System.Drawing.Point(81, 52);
            this.CB_Fournisseur.Name = "CB_Fournisseur";
            this.CB_Fournisseur.Size = new System.Drawing.Size(100, 21);
            this.CB_Fournisseur.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fournisseur :";
            // 
            // NUD_QteStock
            // 
            this.NUD_QteStock.Location = new System.Drawing.Point(309, 26);
            this.NUD_QteStock.Name = "NUD_QteStock";
            this.NUD_QteStock.Size = new System.Drawing.Size(98, 20);
            this.NUD_QteStock.TabIndex = 13;
            this.NUD_QteStock.ValueChanged += new System.EventHandler(this.NUD_QteStock_ValueChanged);
            // 
            // NUD_QteMin
            // 
            this.NUD_QteMin.Location = new System.Drawing.Point(309, 52);
            this.NUD_QteMin.Name = "NUD_QteMin";
            this.NUD_QteMin.Size = new System.Drawing.Size(98, 20);
            this.NUD_QteMin.TabIndex = 14;
            this.NUD_QteMin.ValueChanged += new System.EventHandler(this.NUD_QteMin_ValueChanged);
            // 
            // NUD_QteMax
            // 
            this.NUD_QteMax.Location = new System.Drawing.Point(309, 78);
            this.NUD_QteMax.Name = "NUD_QteMax";
            this.NUD_QteMax.Size = new System.Drawing.Size(98, 20);
            this.NUD_QteMax.TabIndex = 15;
            this.NUD_QteMax.ValueChanged += new System.EventHandler(this.NUD_QteMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "QteStock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "QteMinimum :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "QteMaximum :";
            // 
            // GB_ModSupAdd
            // 
            this.GB_ModSupAdd.Controls.Add(this.label6);
            this.GB_ModSupAdd.Controls.Add(this.label5);
            this.GB_ModSupAdd.Controls.Add(this.label2);
            this.GB_ModSupAdd.Controls.Add(this.label4);
            this.GB_ModSupAdd.Controls.Add(this.TB_Description);
            this.GB_ModSupAdd.Controls.Add(this.NUD_QteMax);
            this.GB_ModSupAdd.Controls.Add(this.CB_Fournisseur);
            this.GB_ModSupAdd.Controls.Add(this.NUD_QteMin);
            this.GB_ModSupAdd.Controls.Add(this.label3);
            this.GB_ModSupAdd.Controls.Add(this.NUD_QteStock);
            this.GB_ModSupAdd.Location = new System.Drawing.Point(12, 202);
            this.GB_ModSupAdd.Name = "GB_ModSupAdd";
            this.GB_ModSupAdd.Size = new System.Drawing.Size(420, 113);
            this.GB_ModSupAdd.TabIndex = 19;
            this.GB_ModSupAdd.TabStop = false;
            this.GB_ModSupAdd.Text = "Inventaire";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 356);
            this.Controls.Add(this.GB_ModSupAdd);
            this.Controls.Add(this.BTN_QteMinimum);
            this.Controls.Add(this.TB_Recherche);
            this.Controls.Add(this.DGV_Data);
            this.Controls.Add(this.BTN_Rechercher);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gestion Inventaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_QteMax)).EndInit();
            this.GB_ModSupAdd.ResumeLayout(false);
            this.GB_ModSupAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.TextBox TB_Recherche;
        private System.Windows.Forms.Button BTN_QteMinimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.ComboBox CB_Fournisseur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_QteStock;
        private System.Windows.Forms.NumericUpDown NUD_QteMin;
        private System.Windows.Forms.NumericUpDown NUD_QteMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GB_ModSupAdd;
    }
}

