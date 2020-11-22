
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_TAG_Search
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }
    
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
            
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Valida_Click_1(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace("-", " ").Replace(".", " ");
            vConteudo = vConteudo.Trim();
            



            if (vConteudo  == "")
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
                    if (MessageBox.Show("Voce tem certeza que quer validar o CPF?", "mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool CPFValido = false;
                        CPFValido =  Biblioteca.Cls_Uteis.Valida(Msk_CPF.Text);
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

        private void Btn_Reset_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
