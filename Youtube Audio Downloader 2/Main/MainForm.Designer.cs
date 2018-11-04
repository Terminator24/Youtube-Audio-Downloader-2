﻿namespace YoutubeAudioDownloader2.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanelMenu.Controls.Add(this.buttonSearch);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonList);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDownload);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonSettings);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(97, 620);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(3, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 90);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Cerca";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.Honeydew;
            this.buttonList.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonList.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.Location = new System.Drawing.Point(3, 99);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(90, 90);
            this.buttonList.TabIndex = 1;
            this.buttonList.Text = "Lista";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonDownload.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Location = new System.Drawing.Point(3, 195);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(90, 90);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(3, 291);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(90, 90);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Opzioni";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(97, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(734, 620);
            this.panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(831, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(847, 659);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelContent;
    }
}

