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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTelaVenda
            // 
            resources.ApplyResources(this.btnTelaVenda, "btnTelaVenda");
            this.btnTelaVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTelaVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTelaVenda.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTelaVenda.ForeColor = System.Drawing.Color.Black;
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.UseVisualStyleBackColor = false;
            this.btnTelaVenda.Click += new System.EventHandler(this.btnTelaVenda_Click);
            // 
            // btnCaderneta
            // 
            resources.ApplyResources(this.btnCaderneta, "btnCaderneta");
            this.btnCaderneta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaderneta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCaderneta.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCaderneta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCaderneta.ForeColor = System.Drawing.Color.Black;
            this.btnCaderneta.Name = "btnCaderneta";
            this.btnCaderneta.UseVisualStyleBackColor = false;
            this.btnCaderneta.Click += new System.EventHandler(this.btnCaderneta_Click);
            // 
            // btnControleEstoque
            // 
            resources.ApplyResources(this.btnControleEstoque, "btnControleEstoque");
            this.btnControleEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnControleEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnControleEstoque.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnControleEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.UseVisualStyleBackColor = false;
            this.btnControleEstoque.Click += new System.EventHandler(this.btnControleEstoque_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFaturamento
            // 
            resources.ApplyResources(this.btnFaturamento, "btnFaturamento");
            this.btnFaturamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFaturamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFaturamento.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFaturamento.ForeColor = System.Drawing.Color.Black;
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.UseVisualStyleBackColor = false;
            this.btnFaturamento.Click += new System.EventHandler(this.btnFaturamento_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Default
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFaturamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControleEstoque);
            this.Controls.Add(this.btnCaderneta);
            this.Controls.Add(this.btnTelaVenda);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Default";
            this.TransparencyKey = System.Drawing.Color.Transparent;
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
        private System.Windows.Forms.Label label2;
    }
}

