using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace CircunferenciaOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, double
        //programa Area de circunferencia
        //Jonas Valereo - Técnico em Informática 

        //declarando o attributos, variaveis, campos da classe dados

        private double _raio;
        private double _pi;

        //declarando o construtor da classe dados
        public Dados(double raio, double pi)
        {
            _raio = raio;
            _pi = pi;
        }

        //declarando o metodo Area da classe dados
        public double Area()
        {
            return + Math.Pow(_raio, 2.0) * _pi;
        }

        //declarando modificador da class dados, tipo string
        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
     
        }

        //fim da classe dados
    }
}
