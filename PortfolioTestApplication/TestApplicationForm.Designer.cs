namespace PortfolioTestApplication
{
    partial class TestApplicationForm
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
            this.components = new System.ComponentModel.Container();
            this.portfolioDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.checkResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isMarketValueCheckInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isWeightCheckInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.portfolioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // portfolioDataGridView
            // 
            this.portfolioDataGridView.AllowUserToAddRows = false;
            this.portfolioDataGridView.AllowUserToDeleteRows = false;
            this.portfolioDataGridView.AllowUserToOrderColumns = true;
            this.portfolioDataGridView.AutoGenerateColumns = false;
            this.portfolioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portfolioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isMarketValueCheckInDataGridViewCheckBoxColumn,
            this.isWeightCheckInDataGridViewCheckBoxColumn,
            this.portfolioDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.portfolioDataGridView.DataSource = this.checkResultBindingSource;
            this.portfolioDataGridView.Location = new System.Drawing.Point(12, 12);
            this.portfolioDataGridView.Name = "portfolioDataGridView";
            this.portfolioDataGridView.ReadOnly = true;
            this.portfolioDataGridView.Size = new System.Drawing.Size(600, 376);
            this.portfolioDataGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(537, 404);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // checkResultBindingSource
            // 
            this.checkResultBindingSource.DataSource = typeof(PortfolioTestApplication.PortfolioServiceReference.CheckResult);
            // 
            // isMarketValueCheckInDataGridViewCheckBoxColumn
            // 
            this.isMarketValueCheckInDataGridViewCheckBoxColumn.DataPropertyName = "IsMarketValueCheckIn";
            this.isMarketValueCheckInDataGridViewCheckBoxColumn.HeaderText = "IsMarketValueCheckIn";
            this.isMarketValueCheckInDataGridViewCheckBoxColumn.Name = "isMarketValueCheckInDataGridViewCheckBoxColumn";
            this.isMarketValueCheckInDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isWeightCheckInDataGridViewCheckBoxColumn
            // 
            this.isWeightCheckInDataGridViewCheckBoxColumn.DataPropertyName = "IsWeightCheckIn";
            this.isWeightCheckInDataGridViewCheckBoxColumn.HeaderText = "IsWeightCheckIn";
            this.isWeightCheckInDataGridViewCheckBoxColumn.Name = "isWeightCheckInDataGridViewCheckBoxColumn";
            this.isWeightCheckInDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // portfolioDataGridViewTextBoxColumn
            // 
            this.portfolioDataGridViewTextBoxColumn.DataPropertyName = "Portfolio";
            this.portfolioDataGridViewTextBoxColumn.HeaderText = "Portfolio";
            this.portfolioDataGridViewTextBoxColumn.Name = "portfolioDataGridViewTextBoxColumn";
            this.portfolioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TestApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.portfolioDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestApplicationForm";
            this.Text = "Gambit Recruitment Test Application - Quentin Lecler";
            ((System.ComponentModel.ISupportInitialize)(this.portfolioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView portfolioDataGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMarketValueCheckInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isWeightCheckInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portfolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checkResultBindingSource;
    }
}

