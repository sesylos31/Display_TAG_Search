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
    public partial class Frm_Tela_Inicial_UC : Form
    {
        int ControleValidaCFP = 0;
        int ControleValidaSenha = 0;
        int ControleValidaCPF2 = 0;
        int ControleArquivoImagem = 0;

        

        public Frm_Tela_Inicial_UC()
        {
            InitializeComponent();

            desconectarToolStripMenuItem.Enabled = false;
            abrirToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            cursoAbreJanelasToolStripMenuItem.Enabled = false;
            fecharAbaToolStripMenuItem.Enabled = false;
            
        }
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_ValidaCPF2_UC f = new Frm_ValidaCPF2_UC();
            //f.MdiParent = this;
            //f.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.MdiParent = this;
            f.Show();

        }

        private void arquivosdsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            //f.MdiParent = this;
            //f.Show();
            ControleValidaCFP += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCFP;
            TB.Text = "Valida CPF " + ControleValidaCFP;
            TB.Controls.Add(U);
            TB.ImageIndex=3;
            Tbc_Aplicacoes.TabPages.Add(TB);


        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2  += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF2;
            TB.Text = "Valida CPF " + ControleValidaCPF2;
            TB.Controls.Add(U);
            TB.ImageIndex = 4;
            Tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ValidaSenha f = new Frm_ValidaSenha();
            //f.MdiParent = this;
            //f.Show();
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valida Senha " + ControleValidaSenha;
            TB.Controls.Add(U);
            TB.ImageIndex = 5;
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);

        }

        private void Txt_NomeDoArquivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Aplicacoes.SelectedTab != null)
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivosdsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = @"D:\Sergio Data\Projetos\TAG Search\Display_TAG_Search\Imagens";
            Db.Filter = "PNG|*.png";
            Db.Title = "Escolha a Imagem";

            if(Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                
                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Arquivo Imgem" + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem" + ControleArquivoImagem;
                TB.Controls.Add(U);
                TB.ImageIndex = 6;
                Tbc_Aplicacoes.TabPages.Add(TB);
            }

            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult== DialogResult.OK)
            {

                string senha = F.senha;
                string login= F.login;

                if (Biblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    abrirToolStripMenuItem.Enabled = true ;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    cursoAbreJanelasToolStripMenuItem.Enabled = true;
                    fecharAbaToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Benvindo ao Localizador de TAGs do Adant station ABB","mensagem",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                }
                else
                {
                    MessageBox.Show("Senha Invalida", "mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }


            }
           


        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Mensagem Db = new Frm_Mensagem("icons8_ponto_de_interrogação_64", "Voce Tem certeza que deseja desconectar ?");
            Db.ShowDialog();

            for (int i=Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i+=-1)
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            }
            
            conectarToolStripMenuItem.Enabled = true ;
            desconectarToolStripMenuItem.Enabled = false;
            abrirToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            cursoAbreJanelasToolStripMenuItem.Enabled = false;
            fecharAbaToolStripMenuItem.Enabled = false;
        }
    }
}
