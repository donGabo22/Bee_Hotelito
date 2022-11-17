
namespace EstandaresdeCalidad_Hotel.negocio
{
    partial class Form_BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarCliente));
            this.dgvabeja = new System.Windows.Forms.DataGridView();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvabeja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvabeja
            // 
            this.dgvabeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvabeja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvabeja.Enabled = false;
            this.dgvabeja.Location = new System.Drawing.Point(0, 529);
            this.dgvabeja.Name = "dgvabeja";
            this.dgvabeja.RowHeadersWidth = 62;
            this.dgvabeja.RowTemplate.Height = 33;
            this.dgvabeja.Size = new System.Drawing.Size(1121, 233);
            this.dgvabeja.TabIndex = 6;
            this.dgvabeja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvabeja_CellContentClick);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(161, 183);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.PlaceholderText = "Busca por nombre";
            this.txbBuscar.Size = new System.Drawing.Size(782, 31);
            this.txbBuscar.TabIndex = 8;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EstandaresdeCalidad_Hotel.Properties.Resources.inkpx_word_art__9_;
            this.pictureBox2.Location = new System.Drawing.Point(161, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(782, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnLlamar
            // 
            this.btnLlamar.BackgroundImage = global::EstandaresdeCalidad_Hotel.Properties.Resources.telefono1;
            this.btnLlamar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLlamar.Location = new System.Drawing.Point(962, 158);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(76, 56);
            this.btnLlamar.TabIndex = 10;
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = global::EstandaresdeCalidad_Hotel.Properties.Resources.flecha_hacia_atras;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 95);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::EstandaresdeCalidad_Hotel.Properties.Resources.preguntas_mas_frecuentes;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1033, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 56);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1049, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "ayuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(978, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "llamar";
            // 
            // Form_BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::EstandaresdeCalidad_Hotel.Properties.Resources.WhatsApp_Image_2022_10_17_at_10_13_13_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1121, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.dgvabeja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BuscarCliente";
            this.Load += new System.EventHandler(this.Form_BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvabeja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvabeja;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}