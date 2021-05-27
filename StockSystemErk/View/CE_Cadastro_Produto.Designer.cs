namespace StockSystemErk.View
{
    partial class CE_Cadastro_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CE_Cadastro_Produto));
            this.textProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textVlrCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texVlrVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateCompra = new System.Windows.Forms.DateTimePicker();
            this.dllCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(123, 47);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(125, 20);
            this.textProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(304, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de Compra ";
            // 
            // textVlrCompra
            // 
            this.textVlrCompra.Location = new System.Drawing.Point(414, 88);
            this.textVlrCompra.Name = "textVlrCompra";
            this.textVlrCompra.Size = new System.Drawing.Size(125, 20);
            this.textVlrCompra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor de Venda";
            // 
            // texVlrVenda
            // 
            this.texVlrVenda.Location = new System.Drawing.Point(123, 88);
            this.texVlrVenda.Name = "texVlrVenda";
            this.texVlrVenda.Size = new System.Drawing.Size(125, 20);
            this.texVlrVenda.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(310, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data da Compra";
            // 
            // dateCompra
            // 
            this.dateCompra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCompra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateCompra.CustomFormat = "yyyy-MM-dd";
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCompra.Location = new System.Drawing.Point(414, 43);
            this.dateCompra.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateCompra.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateCompra.Name = "dateCompra";
            this.dateCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateCompra.Size = new System.Drawing.Size(125, 20);
            this.dateCompra.TabIndex = 8;
            // 
            // dllCategoria
            // 
            this.dllCategoria.FormattingEnabled = true;
            this.dllCategoria.Items.AddRange(new object[] {
            "Bebida alcoolica",
            "Doce",
            "Salgado"});
            this.dllCategoria.Location = new System.Drawing.Point(414, 129);
            this.dllCategoria.Name = "dllCategoria";
            this.dllCategoria.Size = new System.Drawing.Size(125, 21);
            this.dllCategoria.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(282, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria do produto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(223, 258);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(142, 43);
            this.btncadastrar.TabIndex = 11;
            this.btncadastrar.Text = "Cadastrar Produtor";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(123, 130);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(125, 20);
            this.txtQuantidade.TabIndex = 13;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(79, 186);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(416, 66);
            this.textDescricao.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(76, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descrição:";
            // 
            // CE_Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(578, 316);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dllCategoria);
            this.Controls.Add(this.dateCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texVlrVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVlrCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textProduto);
            this.Name = "CE_Cadastro_Produto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.Cadastro_Produto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textVlrCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texVlrVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateCompra;
        private System.Windows.Forms.ComboBox dllCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label7;
    }
}