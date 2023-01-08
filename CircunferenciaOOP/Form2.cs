using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CircunferenciaOOP.Classe.Dados; 

namespace CircunferenciaOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClique_Click_1(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //programa Area de circunferencia
            //Jonas Valereo - Técnico em Informática 

            //declarando, validar os campos textBox, raio, pi

            //declarando validar textboxRaio
            if (textBoxRaio.Text == "")
            {
                MessageBox.Show("Digite, valor do raio...", "Preenche o campo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxRaio.BackColor = Color.Aqua;
                textBoxRaio.Focus();

                return;
            }

            //declarando validar textboPi
            if (textBoxPi.Text == "")
            {
                MessageBox.Show("Digite o valor do pi...", "Preencha o campo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxPi.BackColor = Color.Aqua;
                textBoxPi.Focus();

                return; ;
            }

            /*declarando, entrada de dados na textbox, aplicando
              variaveis auxiliares*/
            double raio = double.Parse(textBoxRaio.Text,
                CultureInfo.InvariantCulture);
            double pi = double.Parse(textBoxPi.Text,
                CultureInfo.InvariantCulture);

            //declarando o objeto, a, da classe dados, instanciando
            Dados a = new Dados(raio, pi);

            /*declarando, imprimir saida de dados messageBox, chamando o objeto a,
            chamando o método toString da classe dados*/
            MessageBox.Show("Valor da circunferência " + a.ToString(), "Messagem",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //declarando, limpar as textBox, apos validar dados
            textBoxRaio.Clear();
            textBoxPi.Clear();
            textBoxRaio.Focus();
            textBoxRaio.BackColor = Color.White;
            textBoxPi.BackColor = Color.White;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //declarando limpar a textbox, após apertar buttom cancelar
            textBoxRaio.Clear();
            textBoxPi.Clear();
            textBoxRaio.Focus();
            textBoxRaio.BackColor = Color.White;
            textBoxPi.BackColor = Color.White;
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            //declarando buttom fechar
            Close();
        }
    }
}