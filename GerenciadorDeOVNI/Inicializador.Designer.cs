namespace GerenciadorDeOVNI
{
    partial class Inicializador
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
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.NumericUpDown();
            this.txbAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::GerenciadorDeOVNI.Properties.Resources._3306658;
            this.pibIcone.Location = new System.Drawing.Point(31, 64);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(182, 160);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 0;
            this.pibIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(94, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciador de OVNI";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(228, 79);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(137, 13);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Capacidade de Tripulantes:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(231, 108);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(134, 13);
            this.lblAbduzidos.TabIndex = 3;
            this.lblAbduzidos.Text = "Capacidade de Abduzidos:";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(371, 77);
            this.txbTripulantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(148, 20);
            this.txbTripulantes.TabIndex = 4;
            this.txbTripulantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbTripulantes.ValueChanged += new System.EventHandler(this.txbTripulantes_ValueChanged);
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(371, 106);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(148, 20);
            this.txbAbduzidos.TabIndex = 5;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(268, 137);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(97, 13);
            this.lblPlaneta.TabIndex = 6;
            this.lblPlaneta.Text = "Planeta de Origem:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(371, 132);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(148, 21);
            this.cmbPlanetas.TabIndex = 7;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(231, 171);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(287, 32);
            this.btnCriar.TabIndex = 8;
            this.btnCriar.Text = "CRIAR NAVE";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 251);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibIcone);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.NumericUpDown txbTripulantes;
        private System.Windows.Forms.NumericUpDown txbAbduzidos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnCriar;
    }
}