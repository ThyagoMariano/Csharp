using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCarroForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblProcurar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (tbPlaca.Text == "")
            {
                MessageBox.Show("espaço em branco");
                return;
            }
            if (tbModelo.Text == "")
            {
                MessageBox.Show("espaço em branco");
                return;
            }

            if (mtbMarca.Text == "")
            {
                MessageBox.Show("espaço em branco");
                return;
            }

            if (mtbDono.Text == "")
            {
                MessageBox.Show("espaço em branco");
                return;
            }

            if (mtbAno.Text == "")
            {
                MessageBox.Show("espaço em branco");
                return;
            }

            Cadastrar cadas = new Cadastrar();

            cadas.Placa = tbPlaca.Text;
            cadas.Modelo = tbModelo.Text;
            cadas.Marca = mtbMarca.Text;
            cadas.Dono = mtbDono.Text;
            cadas.Ano = int.Parse(mtbAno.Text);
            cadas.DataCompra = dtpCompra.Value;

            cadas.Registrar();

            MessageBox.Show("Cadastro feito");
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            if (tbPlaca.Text == "")
            {
                MessageBox.Show("Nada Digitado");
                return;
            }

            bool ok = false;

            string placa = tbPlaca.Text;
            Cadastrar cadas = new Cadastrar();
            ok = cadas.Procurar(placa.Trim());

            if (ok)
            {
                tbModelo.Text = cadas.Modelo;
                mtbMarca.Text = cadas.Marca;
                mtbDono.Text = cadas.Dono;
                mtbAno.Text = cadas.Ano.ToString();
                dtpCompra.Value = cadas.DataCompra;

            }
            else
            {
                MessageBox.Show("Nao Encontrado");
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            Cadastrar cadas = new Cadastrar();
            txtListar.Text = cadas.Listar();
            
        }
    }
}
