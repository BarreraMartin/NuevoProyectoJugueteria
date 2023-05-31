namespace Articulo.View
{
    partial class frmAgregarCliente
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextTelefono = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTexboxNombre = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(414, 261);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(212, 47);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 37;
            this.metroButton2.Text = "Salir";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(92, 261);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(209, 47);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 36;
            this.metroButton1.Text = "Guardar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(349, 182);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 20);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Estado";
            // 
            // metroComboEstado
            // 
            this.metroComboEstado.FormattingEnabled = true;
            this.metroComboEstado.ItemHeight = 24;
            this.metroComboEstado.Location = new System.Drawing.Point(441, 174);
            this.metroComboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroComboEstado.Name = "metroComboEstado";
            this.metroComboEstado.Size = new System.Drawing.Size(181, 30);
            this.metroComboEstado.TabIndex = 30;
            this.metroComboEstado.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 174);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 20);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Apellido";
            // 
            // metroTextApellido
            // 
            // 
            // 
            // 
            this.metroTextApellido.CustomButton.Image = null;
            this.metroTextApellido.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.metroTextApellido.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextApellido.CustomButton.Name = "";
            this.metroTextApellido.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextApellido.CustomButton.TabIndex = 1;
            this.metroTextApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextApellido.CustomButton.UseSelectable = true;
            this.metroTextApellido.CustomButton.Visible = false;
            this.metroTextApellido.Lines = new string[0];
            this.metroTextApellido.Location = new System.Drawing.Point(120, 174);
            this.metroTextApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextApellido.MaxLength = 32767;
            this.metroTextApellido.Name = "metroTextApellido";
            this.metroTextApellido.PasswordChar = '\0';
            this.metroTextApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextApellido.SelectedText = "";
            this.metroTextApellido.SelectionLength = 0;
            this.metroTextApellido.SelectionStart = 0;
            this.metroTextApellido.ShortcutsEnabled = true;
            this.metroTextApellido.Size = new System.Drawing.Size(181, 28);
            this.metroTextApellido.TabIndex = 25;
            this.metroTextApellido.UseSelectable = true;
            this.metroTextApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(349, 112);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 20);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Telefono";
            // 
            // metroTextTelefono
            // 
            // 
            // 
            // 
            this.metroTextTelefono.CustomButton.Image = null;
            this.metroTextTelefono.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.metroTextTelefono.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextTelefono.CustomButton.Name = "";
            this.metroTextTelefono.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.metroTextTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextTelefono.CustomButton.TabIndex = 1;
            this.metroTextTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextTelefono.CustomButton.UseSelectable = true;
            this.metroTextTelefono.CustomButton.Visible = false;
            this.metroTextTelefono.Lines = new string[0];
            this.metroTextTelefono.Location = new System.Drawing.Point(441, 107);
            this.metroTextTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextTelefono.MaxLength = 32767;
            this.metroTextTelefono.Name = "metroTextTelefono";
            this.metroTextTelefono.PasswordChar = '\0';
            this.metroTextTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextTelefono.SelectedText = "";
            this.metroTextTelefono.SelectionLength = 0;
            this.metroTextTelefono.SelectionStart = 0;
            this.metroTextTelefono.ShortcutsEnabled = true;
            this.metroTextTelefono.Size = new System.Drawing.Size(181, 28);
            this.metroTextTelefono.TabIndex = 23;
            this.metroTextTelefono.UseSelectable = true;
            this.metroTextTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 112);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 20);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroTexboxNombre
            // 
            // 
            // 
            // 
            this.metroTexboxNombre.CustomButton.Image = null;
            this.metroTexboxNombre.CustomButton.Location = new System.Drawing.Point(155, 2);
            this.metroTexboxNombre.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTexboxNombre.CustomButton.Name = "";
            this.metroTexboxNombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTexboxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTexboxNombre.CustomButton.TabIndex = 1;
            this.metroTexboxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTexboxNombre.CustomButton.UseSelectable = true;
            this.metroTexboxNombre.CustomButton.Visible = false;
            this.metroTexboxNombre.Lines = new string[0];
            this.metroTexboxNombre.Location = new System.Drawing.Point(120, 112);
            this.metroTexboxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTexboxNombre.MaxLength = 32767;
            this.metroTexboxNombre.Name = "metroTexboxNombre";
            this.metroTexboxNombre.PasswordChar = '\0';
            this.metroTexboxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTexboxNombre.SelectedText = "";
            this.metroTexboxNombre.SelectionLength = 0;
            this.metroTexboxNombre.SelectionStart = 0;
            this.metroTexboxNombre.ShortcutsEnabled = true;
            this.metroTexboxNombre.Size = new System.Drawing.Size(181, 28);
            this.metroTexboxNombre.TabIndex = 19;
            this.metroTexboxNombre.UseSelectable = true;
            this.metroTexboxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTexboxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1, 2);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(675, 74);
            this.metroTile1.TabIndex = 35;
            this.metroTile1.Text = "Agregar Nuevo Cliente";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileImage = global::Articulo.View.Properties.Resources.iconfindercartsaleshop4177568_115973_1159421;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 367);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroComboEstado);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextApellido);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextTelefono);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTexboxNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarCliente";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboEstado;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextApellido;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextTelefono;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTexboxNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}