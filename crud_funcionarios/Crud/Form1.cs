﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //instanciar o objeto
            empregado gado = new empregado();
            //criar as variaveis
            string nome, sobre, cpf;
            nome = txtNome.Text;
            sobre = txtSobrenome.Text;
            cpf = mskCpf.Text;

            //tratamento de erros
            try
            {
                gado.setNome(nome);
                gado.setSobrenome(sobre);
                gado.setCpf(cpf);
                //chamando o metodo inserir
                gado.inserir();
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao inserir os dados."); 
            }








        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultar opa = new frmConsultar();
            
                opa.Show();
            




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluir excluir = new frmExcluir();
            excluir.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterar alt = new frmAlterar();
            alt.Show();
        }
    }
}
