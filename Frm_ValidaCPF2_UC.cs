using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_TAG_Search
{
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace("-", " ").Replace(".", " ");
            vConteudo = vConteudo.Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("CPF não foi digitado", "mensagem de alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                vConteudo = vConteudo.Trim();
                int cpfCount = vConteudo.Length;
                if (cpfCount < 11)
                {
                    MessageBox.Show("CPF Deve ter 11 digitos!", "mensagem de alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Msk_CPF.Text = "";

                }
                else
                {
                    //if (MessageBox.Show("Voce tem certeza que quer validar o CPF?", "mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Frm_Mensagem Db = new Frm_Mensagem("Frm_ValidaCPF2" , " Teste de mensagem");
                    Db.ShowDialog();

                    
                    if (Db.DialogResult  == DialogResult.Yes )
                    {
                        bool CPFValido = false;
                        CPFValido = Biblioteca.Cls_Uteis.Valida(Msk_CPF.Text);
                        if (CPFValido == true)
                        {
                            MessageBox.Show("CPF VALIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVALIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
