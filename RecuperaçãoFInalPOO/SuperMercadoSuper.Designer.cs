
namespace RecuperaçãoFInalPOO
{
    partial class SuperMercadoSuper
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.mtxCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lvwProdutos = new System.Windows.Forms.ListView();
            this.chProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPreço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.mtxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.nudPagamento = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(111, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(279, 45);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Próximo Cliente";
            // 
            // mtxCpf
            // 
            this.mtxCpf.AllowPromptAsInput = false;
            this.mtxCpf.Location = new System.Drawing.Point(165, 87);
            this.mtxCpf.Mask = "000.000.000-00";
            this.mtxCpf.Name = "mtxCpf";
            this.mtxCpf.Size = new System.Drawing.Size(170, 35);
            this.mtxCpf.TabIndex = 1;
            this.mtxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxCpf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxCpf_MouseClick);
            this.mtxCpf.TextChanged += new System.EventHandler(this.mtxCpf_TextChanged);
            this.mtxCpf.Enter += new System.EventHandler(this.mtxCpf_Enter);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(40, 54);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(420, 30);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "digite o cpf para o clube de vantagens";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 644);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(484, 35);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lvwProdutos
            // 
            this.lvwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProduto,
            this.chPreço});
            this.lvwProdutos.FullRowSelect = true;
            this.lvwProdutos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwProdutos.HideSelection = false;
            this.lvwProdutos.Location = new System.Drawing.Point(12, 221);
            this.lvwProdutos.MultiSelect = false;
            this.lvwProdutos.Name = "lvwProdutos";
            this.lvwProdutos.Size = new System.Drawing.Size(460, 295);
            this.lvwProdutos.TabIndex = 4;
            this.lvwProdutos.UseCompatibleStateImageBehavior = false;
            this.lvwProdutos.View = System.Windows.Forms.View.Details;
            // 
            // chProduto
            // 
            this.chProduto.Text = "Produto";
            this.chProduto.Width = 333;
            // 
            // chPreço
            // 
            this.chPreço.Text = "Preço";
            this.chPreço.Width = 123;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(317, 43);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(137, 35);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // mtxCodigo
            // 
            this.mtxCodigo.AllowPromptAsInput = false;
            this.mtxCodigo.Location = new System.Drawing.Point(107, 43);
            this.mtxCodigo.Mask = "0.000000.000000";
            this.mtxCodigo.Name = "mtxCodigo";
            this.mtxCodigo.Size = new System.Drawing.Size(204, 35);
            this.mtxCodigo.TabIndex = 6;
            this.mtxCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxCodigo.Click += new System.EventHandler(this.mtxCodigo_Click);
            this.mtxCodigo.Enter += new System.EventHandler(this.mtxCodigo_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxCodigo);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(12, 522);
            this.txbTotal.Multiline = true;
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(460, 35);
            this.txbTotal.TabIndex = 10;
            // 
            // btnPagar
            // 
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPagar.Location = new System.Drawing.Point(0, 604);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(484, 40);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // nudPagamento
            // 
            this.nudPagamento.DecimalPlaces = 2;
            this.nudPagamento.Location = new System.Drawing.Point(12, 563);
            this.nudPagamento.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPagamento.Name = "nudPagamento";
            this.nudPagamento.Size = new System.Drawing.Size(460, 35);
            this.nudPagamento.TabIndex = 12;
            this.nudPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPagamento.ThousandsSeparator = true;
            // 
            // SuperMercadoSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 679);
            this.Controls.Add(this.nudPagamento);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwProdutos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtxCpf);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SuperMercadoSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Mercado Super";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox mtxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListView lvwProdutos;
        private System.Windows.Forms.ColumnHeader chProduto;
        private System.Windows.Forms.ColumnHeader chPreço;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox mtxCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.NumericUpDown nudPagamento;
    }
}

