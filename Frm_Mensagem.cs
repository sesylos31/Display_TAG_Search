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
    public partial class Frm_Mensagem : Form
    {
        public Frm_Mensagem(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image myImage = (Image)global::Display_TAG_Search.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image  = myImage;

            Lbl_Mensagem.Text = mensagem;


        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel ;
            this.Close();
           
        }

        private void Pic_Imagem_Click(object sender, EventArgs e)
        {

        }
    }
}
