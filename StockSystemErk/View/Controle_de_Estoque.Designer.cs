namespace StockSystemErk.View
{
    partial class Controle_de_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_de_Estoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gridEstoque = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlr_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlr_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelEstoque = new System.Windows.Forms.Panel();
            this.painelAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdatacompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtvalorProduto = new System.Windows.Forms.TextBox();
            this.txtvalorVenda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAlterarPRD = new System.Windows.Forms.Button();
            this.txtQtdTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenor5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.subPainelAlterar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).BeginInit();
            this.painelEstoque.SuspendLayout();
            this.painelAlterar.SuspendLayout();
            this.subPainelAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de Produtos:";
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalProduto.Location = new System.Drawing.Point(151, 426);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalProduto.TabIndex = 2;
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastraProduto.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCadastraProduto.FlatAppearance.BorderSize = 50;
            this.btnCadastraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnCadastraProduto.Location = new System.Drawing.Point(994, 101);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(132, 32);
            this.btnCadastraProduto.TabIndex = 4;
            this.btnCadastraProduto.Text = "Cadastrar Novo Produto";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPesquisar.Location = new System.Drawing.Point(838, 108);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(142, 20);
            this.txtPesquisar.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(3, 101);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(59, 32);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(967, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(21, 21);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gridEstoque
            // 
            this.gridEstoque.AllowUserToAddRows = false;
            this.gridEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridEstoque.BackgroundColor = System.Drawing.Color.White;
            this.gridEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAlterar,
            this.btnExcluir,
            this.CODIGO,
            this.Produto,
            this.Vlr_Compra,
            this.vlr_venda,
            this.quantidade,
            this.descricao,
            this.dataCompra});
            this.gridEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridEstoque.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridEstoque.Location = new System.Drawing.Point(3, 146);
            this.gridEstoque.Name = "gridEstoque";
            this.gridEstoque.ReadOnly = true;
            this.gridEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridEstoque.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gridEstoque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridEstoque.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gridEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridEstoque.Size = new System.Drawing.Size(1126, 259);
            this.gridEstoque.TabIndex = 0;
            this.gridEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEstoque_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.HeaderText = "Alterar";
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ReadOnly = true;
            this.btnAlterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Apagar";
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "PRD_CODIGO";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "PRD_PRODUTO";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Vlr_Compra
            // 
            this.Vlr_Compra.DataPropertyName = "PRD_VLRCOMPRA";
            this.Vlr_Compra.HeaderText = "Valor de Compra";
            this.Vlr_Compra.Name = "Vlr_Compra";
            this.Vlr_Compra.ReadOnly = true;
            // 
            // vlr_venda
            // 
            this.vlr_venda.DataPropertyName = "PRD_VLRVENDA";
            this.vlr_venda.HeaderText = "Valor de Venda";
            this.vlr_venda.Name = "vlr_venda";
            this.vlr_venda.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "PRD_QUANTIDADE";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "PRD_DESCRICAO";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // dataCompra
            // 
            this.dataCompra.DataPropertyName = "PRD_DATACOMPRA";
            this.dataCompra.HeaderText = "Data da Compra";
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.ReadOnly = true;
            // 
            // painelEstoque
            // 
            this.painelEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelEstoque.BackColor = System.Drawing.Color.Transparent;
            this.painelEstoque.Controls.Add(this.painelAlterar);
            this.painelEstoque.Controls.Add(this.gridEstoque);
            this.painelEstoque.Controls.Add(this.btnAtualizar);
            this.painelEstoque.Controls.Add(this.btnPesquisar);
            this.painelEstoque.Controls.Add(this.btnCadastraProduto);
            this.painelEstoque.Controls.Add(this.txtPesquisar);
            this.painelEstoque.Location = new System.Drawing.Point(12, 12);
            this.painelEstoque.Name = "painelEstoque";
            this.painelEstoque.Size = new System.Drawing.Size(1129, 408);
            this.painelEstoque.TabIndex = 8;
            // 
            // painelAlterar
            // 
            this.painelAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.painelAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.painelAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.painelAlterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAlterar.Controls.Add(this.btnCancelar);
            this.painelAlterar.Controls.Add(this.btnAlterarPRD);
            this.painelAlterar.Controls.Add(this.subPainelAlterar);
            this.painelAlterar.Location = new System.Drawing.Point(254, 47);
            this.painelAlterar.Name = "painelAlterar";
            this.painelAlterar.Size = new System.Drawing.Size(639, 327);
            this.painelAlterar.TabIndex = 9999;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(410, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 32);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(265, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(50, 179);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 79);
            this.txtDescricao.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(337, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(452, 102);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(337, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data da Compra";
            // 
            // txtdatacompra
            // 
            this.txtdatacompra.Location = new System.Drawing.Point(452, 66);
            this.txtdatacompra.Name = "txtdatacompra";
            this.txtdatacompra.Size = new System.Drawing.Size(100, 20);
            this.txtdatacompra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(4, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor de Compra ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor de Venda";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo:";
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(107, 66);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(100, 20);
            this.txtproduto.TabIndex = 4;
            // 
            // txtvalorProduto
            // 
            this.txtvalorProduto.Location = new System.Drawing.Point(107, 99);
            this.txtvalorProduto.Name = "txtvalorProduto";
            this.txtvalorProduto.Size = new System.Drawing.Size(100, 20);
            this.txtvalorProduto.TabIndex = 3;
            // 
            // txtvalorVenda
            // 
            this.txtvalorVenda.Location = new System.Drawing.Point(107, 137);
            this.txtvalorVenda.Name = "txtvalorVenda";
            this.txtvalorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtvalorVenda.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(65, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnAlterarPRD
            // 
            this.btnAlterarPRD.Location = new System.Drawing.Point(92, 290);
            this.btnAlterarPRD.Name = "btnAlterarPRD";
            this.btnAlterarPRD.Size = new System.Drawing.Size(138, 32);
            this.btnAlterarPRD.TabIndex = 0;
            this.btnAlterarPRD.Text = "Alterar";
            this.btnAlterarPRD.UseVisualStyleBackColor = true;
            this.btnAlterarPRD.Click += new System.EventHandler(this.btnAlterarPRD_Click);
            // 
            // txtQtdTotal
            // 
            this.txtQtdTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtQtdTotal.Location = new System.Drawing.Point(591, 425);
            this.txtQtdTotal.Name = "txtQtdTotal";
            this.txtQtdTotal.Size = new System.Drawing.Size(100, 20);
            this.txtQtdTotal.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(515, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "QTD Total:";
            // 
            // txtMenor5
            // 
            this.txtMenor5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenor5.Location = new System.Drawing.Point(994, 425);
            this.txtMenor5.Name = "txtMenor5";
            this.txtMenor5.Size = new System.Drawing.Size(100, 20);
            this.txtMenor5.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(794, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Produtos Com QTD  Menor que 5:";
            // 
            // subPainelAlterar
            // 
            this.subPainelAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.subPainelAlterar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPainelAlterar.Controls.Add(this.txtCodigo);
            this.subPainelAlterar.Controls.Add(this.label3);
            this.subPainelAlterar.Controls.Add(this.label8);
            this.subPainelAlterar.Controls.Add(this.label10);
            this.subPainelAlterar.Controls.Add(this.txtQuantidade);
            this.subPainelAlterar.Controls.Add(this.txtproduto);
            this.subPainelAlterar.Controls.Add(this.label7);
            this.subPainelAlterar.Controls.Add(this.txtDescricao);
            this.subPainelAlterar.Controls.Add(this.txtdatacompra);
            this.subPainelAlterar.Controls.Add(this.label4);
            this.subPainelAlterar.Controls.Add(this.txtvalorProduto);
            this.subPainelAlterar.Controls.Add(this.label6);
            this.subPainelAlterar.Controls.Add(this.txtvalorVenda);
            this.subPainelAlterar.Controls.Add(this.label5);
            this.subPainelAlterar.Location = new System.Drawing.Point(22, 14);
            this.subPainelAlterar.Name = "subPainelAlterar";
            this.subPainelAlterar.Size = new System.Drawing.Size(586, 270);
            this.subPainelAlterar.TabIndex = 25;
            // 
            // Controle_de_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.painelEstoque);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMenor5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtdTotal);
            this.Controls.Add(this.txtTotalProduto);
            this.Controls.Add(this.label1);
            this.Name = "Controle_de_Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).EndInit();
            this.painelEstoque.ResumeLayout(false);
            this.painelEstoque.PerformLayout();
            this.painelAlterar.ResumeLayout(false);
            this.subPainelAlterar.ResumeLayout(false);
            this.subPainelAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel painelEstoque;
        private System.Windows.Forms.DataGridView gridEstoque;
        private System.Windows.Forms.TextBox txtQtdTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel painelAlterar;
        private System.Windows.Forms.Button btnAlterarPRD;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtvalorProduto;
        private System.Windows.Forms.TextBox txtvalorVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdatacompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn btnAlterar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlr_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlr_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompra;
        private System.Windows.Forms.TextBox txtMenor5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel subPainelAlterar;
    }
}