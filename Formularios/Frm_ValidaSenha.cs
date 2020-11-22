using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.Cls_Uteis;

namespace Display_TAG_Search
{
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Txt_Senha.Text = "";

        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha Verifica = new ChecaForcaSenha() ;
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = Verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel" )
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Senha.PasswordChar == '\0' )
            {
               Txt_Senha.PasswordChar = '*';
                Btn_Mostra.Text = "Mostra Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_Mostra.Text = "Esconde Senha";
            }
        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }
    }

}
