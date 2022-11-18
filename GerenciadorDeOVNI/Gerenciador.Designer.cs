namespace GerenciadorDeOVNI
{
    partial class Gerenciador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.grbTripulacao = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAddAbduzido = new System.Windows.Forms.Button();
            this.grbEstatisticas = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grbTripulacao.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbEstatisticas.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(505, 55);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerenciador de OVNI";
            // 
            // btnLigar
            // 
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(48, 95);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(134, 47);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.ForeColor = System.Drawing.Color.White;
            this.btnDesligar.Location = new System.Drawing.Point(213, 95);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(136, 47);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // grbTripulacao
            // 
            this.grbTripulacao.Controls.Add(this.btnRemoverTripulante);
            this.grbTripulacao.Controls.Add(this.btnAddTripulante);
            this.grbTripulacao.ForeColor = System.Drawing.Color.White;
            this.grbTripulacao.Location = new System.Drawing.Point(48, 161);
            this.grbTripulacao.Name = "grbTripulacao";
            this.grbTripulacao.Size = new System.Drawing.Size(301, 108);
            this.grbTripulacao.TabIndex = 5;
            this.grbTripulacao.TabStop = false;
            this.grbTripulacao.Text = "Tripulação:";
            this.grbTripulacao.Visible = false;
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverTripulante.ForeColor = System.Drawing.Color.White;
            this.btnRemoverTripulante.Location = new System.Drawing.Point(16, 63);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(272, 29);
            this.btnRemoverTripulante.TabIndex = 1;
            this.btnRemoverTripulante.Text = "Remover";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            this.btnRemoverTripulante.Click += new System.EventHandler(this.btnRemoverTripulante_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTripulante.ForeColor = System.Drawing.Color.White;
            this.btnAddTripulante.Location = new System.Drawing.Point(16, 28);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(272, 29);
            this.btnAddTripulante.TabIndex = 0;
            this.btnAddTripulante.Text = "Adicionar";
            this.btnAddTripulante.UseVisualStyleBackColor = true;
            this.btnAddTripulante.Click += new System.EventHandler(this.btnAddTripulante_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAddAbduzido);
            this.grbAbduzidos.ForeColor = System.Drawing.Color.White;
            this.grbAbduzidos.Location = new System.Drawing.Point(48, 275);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(301, 108);
            this.grbAbduzidos.TabIndex = 6;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos:";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverAbduzidos.ForeColor = System.Drawing.Color.White;
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(16, 63);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(272, 29);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAddAbduzido
            // 
            this.btnAddAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAbduzido.ForeColor = System.Drawing.Color.White;
            this.btnAddAbduzido.Location = new System.Drawing.Point(16, 28);
            this.btnAddAbduzido.Name = "btnAddAbduzido";
            this.btnAddAbduzido.Size = new System.Drawing.Size(272, 29);
            this.btnAddAbduzido.TabIndex = 0;
            this.btnAddAbduzido.Text = "Adicionar";
            this.btnAddAbduzido.UseVisualStyleBackColor = true;
            this.btnAddAbduzido.Click += new System.EventHandler(this.btnAddAbduzido_Click);
            // 
            // grbEstatisticas
            // 
            this.grbEstatisticas.Controls.Add(this.lblPlaneta);
            this.grbEstatisticas.Controls.Add(this.lblAbduzidos);
            this.grbEstatisticas.Controls.Add(this.lblTripulantes);
            this.grbEstatisticas.Controls.Add(this.lblStatus);
            this.grbEstatisticas.ForeColor = System.Drawing.Color.White;
            this.grbEstatisticas.Location = new System.Drawing.Point(377, 95);
            this.grbEstatisticas.Name = "grbEstatisticas";
            this.grbEstatisticas.Size = new System.Drawing.Size(170, 184);
            this.grbEstatisticas.TabIndex = 7;
            this.grbEstatisticas.TabStop = false;
            this.grbEstatisticas.Text = "Estatistícas:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneta.Location = new System.Drawing.Point(16, 135);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(112, 16);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta Atual: -----";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(16, 100);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(84, 16);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos: 0";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(16, 66);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(87, 16);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes: 1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(16, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: Ligado";
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.cmbPlaneta);
            this.grbPlaneta.ForeColor = System.Drawing.Color.White;
            this.grbPlaneta.Location = new System.Drawing.Point(377, 285);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(170, 59);
            this.grbPlaneta.TabIndex = 8;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta:";
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.BackColor = System.Drawing.Color.Black;
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlaneta.ForeColor = System.Drawing.Color.White;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(7, 25);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(157, 21);
            this.cmbPlaneta.TabIndex = 0;
            this.cmbPlaneta.SelectedIndexChanged += new System.EventHandler(this.cmbPlaneta_SelectedIndexChanged);
            this.cmbPlaneta.SelectionChangeCommitted += new System.EventHandler(this.cmbPlaneta_SelectionChangeCommitted);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(377, 354);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 29);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar para casa";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(613, 410);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbEstatisticas);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulacao);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbTripulacao.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbEstatisticas.ResumeLayout(false);
            this.grbEstatisticas.PerformLayout();
            this.grbPlaneta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.GroupBox grbTripulacao;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAddAbduzido;
        private System.Windows.Forms.GroupBox grbEstatisticas;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnVoltar;
    }
}