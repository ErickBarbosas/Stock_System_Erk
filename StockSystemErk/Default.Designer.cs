﻿namespace StockSystemErk
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
            this.btnTelaVenda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnControleEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.Location = new System.Drawing.Point(369, 116);
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.Size = new System.Drawing.Size(119, 60);
            this.btnTelaVenda.TabIndex = 0;
            this.btnTelaVenda.Text = "Fazer Venda";
            this.btnTelaVenda.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.Location = new System.Drawing.Point(112, 116);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(106, 60);
            this.btnControleEstoque.TabIndex = 2;
            this.btnControleEstoque.Text = "Controle de Estoque ";
            this.btnControleEstoque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControleEstoque);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTelaVenda);
            this.Name = "Default";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaVenda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnControleEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}

