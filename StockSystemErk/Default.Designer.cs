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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.Font = new System.Drawing.Font("Californian FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaVenda.ForeColor = System.Drawing.Color.Black;
            this.btnTelaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnTelaVenda.Image")));
            this.btnTelaVenda.Location = new System.Drawing.Point(342, 116);
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.Size = new System.Drawing.Size(111, 60);
            this.btnTelaVenda.TabIndex = 0;
            this.btnTelaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelaVenda.UseVisualStyleBackColor = true;
            this.btnTelaVenda.Click += new System.EventHandler(this.btnTelaVenda_Click);
            // 
            // btnCaderneta
            // 
            this.btnCaderneta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaderneta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCaderneta.Font = new System.Drawing.Font("Californian FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaderneta.ForeColor = System.Drawing.Color.Black;
            this.btnCaderneta.Location = new System.Drawing.Point(342, 214);
            this.btnCaderneta.Name = "btnCaderneta";
            this.btnCaderneta.Size = new System.Drawing.Size(111, 60);
            this.btnCaderneta.TabIndex = 1;
            this.btnCaderneta.Text = "Caderneta ";
            this.btnCaderneta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaderneta.UseVisualStyleBackColor = false;
            this.btnCaderneta.Click += new System.EventHandler(this.btnCaderneta_Click);
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnControleEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnControleEstoque.Image")));
            this.btnControleEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleEstoque.Location = new System.Drawing.Point(137, 116);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(162, 60);
            this.btnControleEstoque.TabIndex = 2;
            this.btnControleEstoque.Text = "Estoque";
            this.btnControleEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnControleEstoque.UseVisualStyleBackColor = false;
            this.btnControleEstoque.Click += new System.EventHandler(this.btnControleEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle de Venda";
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.Font = new System.Drawing.Font("Californian FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturamento.ForeColor = System.Drawing.Color.Black;
            this.btnFaturamento.Location = new System.Drawing.Point(137, 214);
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(111, 60);
            this.btnFaturamento.TabIndex = 4;
            this.btnFaturamento.Text = "Faturamento ";
            this.btnFaturamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturamento.UseVisualStyleBackColor = true;
            this.btnFaturamento.Click += new System.EventHandler(this.btnFaturamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Controle de Venda";
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
    }
}

