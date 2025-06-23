namespace LocalizadorDeCEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Piclogo = new System.Windows.Forms.PictureBox();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GrbResultado = new System.Windows.Forms.GroupBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.LblUnidade = new System.Windows.Forms.Label();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.Lbllogradouro = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblLocalidade = new System.Windows.Forms.Label();
            this.LblUF = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblRegiao = new System.Windows.Forms.Label();
            this.LblDdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).BeginInit();
            this.GrbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Piclogo
            // 
            this.Piclogo.Image = global::LocalizadorDeCEP.Properties.Resources.map;
            this.Piclogo.Location = new System.Drawing.Point(113, 31);
            this.Piclogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Piclogo.Name = "Piclogo";
            this.Piclogo.Size = new System.Drawing.Size(80, 55);
            this.Piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Piclogo.TabIndex = 0;
            this.Piclogo.TabStop = false;
            // 
            // TxtCep
            // 
            this.TxtCep.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCep.Location = new System.Drawing.Point(56, 131);
            this.TxtCep.Mask = "00000-000";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(207, 30);
            this.TxtCep.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(56, 182);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(207, 48);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GrbResultado
            // 
            this.GrbResultado.Controls.Add(this.LblDdd);
            this.GrbResultado.Controls.Add(this.LblRegiao);
            this.GrbResultado.Controls.Add(this.LblEstado);
            this.GrbResultado.Controls.Add(this.LblUF);
            this.GrbResultado.Controls.Add(this.LblLocalidade);
            this.GrbResultado.Controls.Add(this.LblBairro);
            this.GrbResultado.Controls.Add(this.Lbllogradouro);
            this.GrbResultado.Controls.Add(this.LblComplemento);
            this.GrbResultado.Controls.Add(this.LblUnidade);
            this.GrbResultado.Controls.Add(this.LblCEP);
            this.GrbResultado.Location = new System.Drawing.Point(315, 21);
            this.GrbResultado.Name = "GrbResultado";
            this.GrbResultado.Size = new System.Drawing.Size(374, 231);
            this.GrbResultado.TabIndex = 3;
            this.GrbResultado.TabStop = false;
            this.GrbResultado.Text = "Resultado";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(15, 24);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(39, 19);
            this.LblCEP.TabIndex = 0;
            this.LblCEP.Text = "Cep:";
            // 
            // LblUnidade
            // 
            this.LblUnidade.AutoSize = true;
            this.LblUnidade.Location = new System.Drawing.Point(15, 81);
            this.LblUnidade.Name = "LblUnidade";
            this.LblUnidade.Size = new System.Drawing.Size(72, 19);
            this.LblUnidade.TabIndex = 1;
            this.LblUnidade.Text = "Unidade:";
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Location = new System.Drawing.Point(15, 62);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(109, 19);
            this.LblComplemento.TabIndex = 2;
            this.LblComplemento.Text = "Complemento:";
            // 
            // Lbllogradouro
            // 
            this.Lbllogradouro.AutoSize = true;
            this.Lbllogradouro.Location = new System.Drawing.Point(15, 43);
            this.Lbllogradouro.Name = "Lbllogradouro";
            this.Lbllogradouro.Size = new System.Drawing.Size(92, 19);
            this.Lbllogradouro.TabIndex = 3;
            this.Lbllogradouro.Text = "Logradouro:";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(15, 100);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(56, 19);
            this.LblBairro.TabIndex = 4;
            this.LblBairro.Text = "Bairro:";
            // 
            // LblLocalidade
            // 
            this.LblLocalidade.AutoSize = true;
            this.LblLocalidade.Location = new System.Drawing.Point(15, 119);
            this.LblLocalidade.Name = "LblLocalidade";
            this.LblLocalidade.Size = new System.Drawing.Size(89, 19);
            this.LblLocalidade.TabIndex = 5;
            this.LblLocalidade.Text = "Localidade:";
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Location = new System.Drawing.Point(15, 138);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(32, 19);
            this.LblUF.TabIndex = 6;
            this.LblUF.Text = "UF:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(15, 157);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(59, 19);
            this.LblEstado.TabIndex = 7;
            this.LblEstado.Text = "Estado:";
            // 
            // LblRegiao
            // 
            this.LblRegiao.AutoSize = true;
            this.LblRegiao.Location = new System.Drawing.Point(15, 176);
            this.LblRegiao.Name = "LblRegiao";
            this.LblRegiao.Size = new System.Drawing.Size(60, 19);
            this.LblRegiao.TabIndex = 8;
            this.LblRegiao.Text = "Região:";
            // 
            // LblDdd
            // 
            this.LblDdd.AutoSize = true;
            this.LblDdd.Location = new System.Drawing.Point(15, 195);
            this.LblDdd.Name = "LblDdd";
            this.LblDdd.Size = new System.Drawing.Size(46, 19);
            this.LblDdd.TabIndex = 9;
            this.LblDdd.Text = "DDD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 272);
            this.Controls.Add(this.GrbResultado);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.Piclogo);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizador de CEP";
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).EndInit();
            this.GrbResultado.ResumeLayout(false);
            this.GrbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Piclogo;
        private System.Windows.Forms.MaskedTextBox TxtCep;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GrbResultado;
        private System.Windows.Forms.Label LblDdd;
        private System.Windows.Forms.Label LblRegiao;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.Label LblLocalidade;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label Lbllogradouro;
        private System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.Label LblUnidade;
        private System.Windows.Forms.Label LblCEP;
    }
}

