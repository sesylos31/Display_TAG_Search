﻿using System;
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
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }


        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool CPFValido = false;
            CPFValido = Biblioteca.Cls_Uteis.Valida(Msk_CPF.Text);
            if (CPFValido == true)
            {
                Lbl_Resultado.Text = "CPF VÁLIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else 
            {
                Lbl_Resultado.Text = "CPF INVÁLIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }

        }

        private void Lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Msk_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}
