﻿namespace PortfolioMarketSimulator
{
    partial class MarketSimulatorForm
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
            this.marketSimulatorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // marketSimulatorTimer
            // 
            this.marketSimulatorTimer.Enabled = true;
            this.marketSimulatorTimer.Interval = 20000;
            this.marketSimulatorTimer.Tick += new System.EventHandler(this.marketSimulatorTimer_Tick);
            // 
            // MarketSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MarketSimulatorForm";
            this.Text = "PortfolioMarketSimulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer marketSimulatorTimer;
    }
}

