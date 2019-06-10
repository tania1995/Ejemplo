using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, recantdigitos, recontpares,recontimpares,recontneutros,reinvertir;
            string repalindromo, reprimo;
            num = int.Parse(textBox1.Text);

            repalindromo= palindromo(num);
            recantdigitos = cantdigitos(num);
            recontpares = contpares(num);
            recontimpares = contimpares(num);
            recontneutros = contneutros(num);
            reprimo = primo(num);
            reinvertir = invertir(num);

            textBox2.Text = repalindromo;
            textBox3.Text = recantdigitos.ToString();
            textBox4.Text = recontpares.ToString();
            textBox5.Text = recontimpares.ToString();
            textBox6.Text = recontneutros.ToString();
            textBox7.Text = reprimo;
            textBox8.Text = reinvertir.ToString();
        }
        public string palindromo(int x)
        {
            int digito, invertido, numorginal;
            invertido = 0;
            numorginal = x;
            while (x > 0)
            {
                digito = x % 10;
                invertido = (invertido * 10) + digito;
                x = x / 10;
            }
            if(numorginal==invertido)
            {
                return "SI ES PALINDROMO";
            }
            else
            {
                return "NO ES PALINDROMO";
            }
        }
        public int cantdigitos(int x)
        {
            int digito;
            digito = 0;
            while(x>0)
            {
                digito = digito + 1;
                x = x / 10;
            }
            return digito;
        }
        public int contpares(int x)
        {
            int aux,cpares,cimpares,cneutros;
            cpares = 0;
            cimpares = 0;
            cneutros = 0;

            while (x>0)
            {
                aux = x % 10;
                if (aux == 0)
                {
                    cneutros = cneutros + 1;
                }
                else
                {
                    if (aux % 2 == 0)
                    {
                        cpares = cpares + 1;
                    }
                    else
                    {
                        cimpares = cimpares + 1;
                    }
                }
                x = x / 10;
            }
            return cpares;
        }
        public int contimpares(int x)
        {
            int aux, cpares, cimpares, cneutros;
            cpares = 0;
            cimpares = 0;
            cneutros = 0;

            while (x > 0)
            {
                aux = x % 10;
                if (aux == 0)
                {
                    cneutros = cneutros + 1;
                }
                else
                {
                    if (aux % 2 == 0)
                    {
                        cpares = cpares + 1;
                    }
                    else
                    {
                        cimpares = cimpares + 1;
                    }
                }
                x = x / 10;
            }
            return cimpares;
        }
        public int contneutros(int x)
        {
            int aux, cpares, cimpares, cneutros;
            cpares = 0;
            cimpares = 0;
            cneutros = 0;

            while (x > 0)
            {
                aux = x % 10;
                if (aux == 0)
                {
                    cneutros = cneutros + 1;
                }
                else
                {
                    if (aux % 2 == 0)
                    {
                        cpares = cpares + 1;
                    }
                    else
                    {
                        cimpares = cimpares + 1;
                    }
                }
                x = x / 10;
            }
            return cneutros;
        }
        public string primo(int x)
        {
            int i, cont;
            cont = 0;
            for(i=1;i<=x;i++)
            {
                if(x%i==0)
                {
                    cont = cont + 1;
                }
            }
            if(cont<=2)
            {
                return "ES PRIMO";
            }
            else
            {
                return "NO ES PRIMO";
            }
        }
        public int invertir(int x)
        {
            int digito, invertido;
            invertido = 0;
            while (x > 0)
            {
                digito = x % 10;
                invertido = (invertido * 10) + digito;
                x = x / 10;
            }
            return invertido;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
