using RecuperaçãoFInalPOO.Classes;
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Drawing;

namespace RecuperaçãoFInalPOO
{
    public partial class SuperMercadoSuper : Form
    {
        BuscarDB db = new BuscarDB();
        DataTable dt;
        bool membro = false;
        double sub = 0, total = 0, desconto = 0;
        List<ListViewItem> prodList = new List<ListViewItem>();
        public SuperMercadoSuper()
        {
            InitializeComponent();
            btnFinalizar.Enabled = btnPagar.Enabled = nudPagamento.Enabled = false;
            txbTotal.ReadOnly = true;
        }

        private void mtxCpf_TextChanged(object sender, EventArgs e)
        {
            if (mtxCpf.Text.Length == 11)
            {
                db.ProcurarCliente(mtxCpf.Text);
                if (db.ms.Length <= 0)
                {
                    ResetarTitulos();
                }
                else
                {
                    lblCliente.Text = db.ms;
                    lblCpf.Text = "Membro do clube de vantagens";
                    membro = true;

                    lblCliente.Left = (this.Width - lblCliente.Width) / 2;
                    lblCpf.Left = (this.Width - lblCpf.Width) / 2;
                }
            }
        }

        private void mtxCpf_Enter(object sender, EventArgs e)
        {
            selectAll(mtxCpf);
        }
        private void mtxCpf_MouseClick(object sender, MouseEventArgs e)
        {
            selectAll(mtxCpf);
        }

        private void mtxCodigo_Enter(object sender, EventArgs e)
        {
            selectAll(mtxCodigo);
        }
        private void mtxCodigo_Click(object sender, EventArgs e)
        {
            selectAll(mtxCodigo);
        }

        void selectAll(MaskedTextBox mtx)
        {
            mtx.Focus();
            mtx.SelectAll();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = db.ProcurarProduto(mtxCodigo.Text);
            if (dt.Rows.Count > 0)
            {
                ListViewItem item = new ListViewItem(dt.Rows[0]["nome"].ToString());
                item.SubItems.Add(dt.Rows[0]["preço"].ToString());
                item.SubItems.Add(dt.Rows[0]["desconto"].ToString());
                prodList.Add(item);
                sub += Double.Parse(dt.Rows[0]["preço"].ToString());
                desconto += Double.Parse(dt.Rows[0]["desconto"].ToString());
                txbTotal.Text = $"Subtotal sem descontos: {sub}";
                btnFinalizar.Enabled = true;
            }
            AtualizarlvwProdutos();
        }

        void AtualizarlvwProdutos()
        {
            lvwProdutos.Items.Clear();
            lvwProdutos.Items.AddRange(prodList.ToArray());
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Double.Parse(nudPagamento.Value.ToString()) >= total)
            {
                nudPagamento.ForeColor = Color.Black;
                btnPagar.Enabled = nudPagamento.Enabled = false;
                double troco = Double.Parse(nudPagamento.Value.ToString()) - total;
                txbTotal.Text = $"Retornar troco de: {troco}R$";

                sub = desconto = 0;
                prodList.Clear();
                AtualizarlvwProdutos();
                mtxCpf.Text = mtxCodigo.Text = "";
                ResetarTitulos();

            }
            else
            {
                nudPagamento.ForeColor = Color.Red;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (membro)
            {
                total = sub - sub * (desconto / 100);
            }
            else
            {
                total = sub;
            }
            txbTotal.Text = $"Total da compra: {total}R$";
            btnFinalizar.Enabled = false;
            btnPagar.Enabled = nudPagamento.Enabled = true;
        }
        private void ResetarTitulos()
        {
            nudPagamento.Value = 0; lblCliente.Text = "Próximo Cliente";
            lblCpf.Text = "digite o cpf para o clube de vantagens";
            membro = false;

            lblCliente.Left = (this.Width - lblCliente.Width) / 2;
            lblCpf.Left = (this.Width - lblCpf.Width) / 2;
        }
    }
}
