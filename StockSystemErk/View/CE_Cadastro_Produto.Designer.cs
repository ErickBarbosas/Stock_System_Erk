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
            resources.ApplyResources(this.textProduto, "textProduto");
            this.textProduto.Name = "textProduto";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // textVlrCompra
            // 
            resources.ApplyResources(this.textVlrCompra, "textVlrCompra");
            this.textVlrCompra.Name = "textVlrCompra";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // texVlrVenda
            // 
            resources.ApplyResources(this.texVlrVenda, "texVlrVenda");
            this.texVlrVenda.Name = "texVlrVenda";
            this.texVlrVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texVlrVenda_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // dateCompra
            // 
            resources.ApplyResources(this.dateCompra, "dateCompra");
            this.dateCompra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCompra.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateCompra.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateCompra.Name = "dateCompra";
            // 
            // dllCategoria
            // 
            resources.ApplyResources(this.dllCategoria, "dllCategoria");
            this.dllCategoria.FormattingEnabled = true;
            this.dllCategoria.Items.AddRange(new object[] {
            resources.GetString("dllCategoria.Items"),
            resources.GetString("dllCategoria.Items1"),
            resources.GetString("dllCategoria.Items2")});
            this.dllCategoria.Name = "dllCategoria";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // btncadastrar
            // 
            resources.ApplyResources(this.btncadastrar, "btncadastrar");
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            // 
            // txtQuantidade
            // 
            resources.ApplyResources(this.txtQuantidade, "txtQuantidade");
            this.txtQuantidade.Name = "txtQuantidade";
            // 
            // textDescricao
            // 
            resources.ApplyResources(this.textDescricao, "textDescricao");
            this.textDescricao.Name = "textDescricao";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // CE_Cadastro_Produto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CE_Cadastro_Produto";
            this.ShowIcon = false;
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