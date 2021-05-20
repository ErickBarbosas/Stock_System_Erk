namespace StockSystemErk
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.btnTelaVenda = new System.Windows.Forms.Button();
            this.btnCaderneta = new System.Windows.Forms.Button();
            this.btnControleEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFaturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaVenda.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaVenda.ForeColor = System.Drawing.Color.Black;
            this.btnTelaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnTelaVenda.Image")));
            this.btnTelaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaVenda.Location = new System.Drawing.Point(342, 116);
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.Size = new System.Drawing.Size(162, 60);
            this.btnTelaVenda.TabIndex = 0;
            this.btnTelaVenda.Text = "Vender";
            this.btnTelaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTelaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelaVenda.UseVisualStyleBackColor = true;
            this.btnTelaVenda.Click += new System.EventHandler(this.btnTelaVenda_Click);
            // 
            // btnCaderneta
            // 
            this.btnCaderneta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaderneta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCaderneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaderneta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaderneta.ForeColor = System.Drawing.Color.Black;
            this.btnCaderneta.Image = ((System.Drawing.Image)(resources.GetObject("btnCaderneta.Image")));
            this.btnCaderneta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaderneta.Location = new System.Drawing.Point(342, 214);
            this.btnCaderneta.Name = "btnCaderneta";
            this.btnCaderneta.Size = new System.Drawing.Size(162, 60);
            this.btnCaderneta.TabIndex = 1;
            this.btnCaderneta.Text = "Caderneta ";
            this.btnCaderneta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaderneta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaderneta.UseVisualStyleBackColor = false;
            this.btnCaderneta.Click += new System.EventHandler(this.btnCaderneta_Click);
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleEstoque.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnControleEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnControleEstoque.Image")));
            this.btnControleEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleEstoque.Location = new System.Drawing.Point(72, 116);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(162, 60);
            this.btnControleEstoque.TabIndex = 2;
            this.btnControleEstoque.Text = "Estoque";
            this.btnControleEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControleEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControleEstoque.UseVisualStyleBackColor = false;
            this.btnControleEstoque.Click += new System.EventHandler(this.btnControleEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle de Venda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturamento.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamento.ForeColor = System.Drawing.Color.Black;
            this.btnFaturamento.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturamento.Image")));
            this.btnFaturamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturamento.Location = new System.Drawing.Point(72, 214);
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(162, 60);
            this.btnFaturamento.TabIndex = 4;
            this.btnFaturamento.Text = "Faturamento ";
            this.btnFaturamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturamento.UseVisualStyleBackColor = true;
            this.btnFaturamento.Click += new System.EventHandler(this.btnFaturamento_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnFaturamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControleEstoque);
            this.Controls.Add(this.btnCaderneta);
            this.Controls.Add(this.btnTelaVenda);
            this.Name = "Default";
            this.Text = "Stock System Erk";
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaVenda;
        private System.Windows.Forms.Button btnCaderneta;
        private System.Windows.Forms.Button btnControleEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaturamento;
    }
}

