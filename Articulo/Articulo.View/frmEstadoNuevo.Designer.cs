﻿
namespace Articulo.View
{
    partial class frmEstadoNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(605, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(31, 124);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(480, 28);
            this.metroTextBox1.TabIndex = 20;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 97);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 20);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Nombre de estado";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 4);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(576, 71);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Agregar nuevo estado";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(332, 182);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(129, 28);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(90, 182);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(141, 28);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Guardar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEstadoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 225);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEstadoNuevo";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "frmEstadoNuevo";
            this.Load += new System.EventHandler(this.frmEstadoNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}