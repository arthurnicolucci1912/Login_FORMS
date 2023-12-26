using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String nome, ntag, CPF;
            nome = textBox1.Text;
            ntag = textBox2.Text;
            CPF = textBox3.Text;
            // Concatenar os valores das duas caixas de texto antes de escrever no arquivo
            
            const string caption = "Dados salvos com sucesso";
            string dados = ("Nome:   ", nome) + Environment.NewLine + ("Email:  ", ntag) + Environment.NewLine + ("CPF:  ", CPF);

            // Criando arquivo para salvar os dados de nome e ntag do Cliente

            System.IO.File.WriteAllText(@"dados.txt", dados);
            // Mostrando o arquivo criado
            dados = System.IO.File.ReadAllText(@"dados.txt");
            MessageBox.Show(dados, caption);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", @"dados.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string message = "Deseja sair?";
            const string caption = "Sair do Sistema";
               var result = MessageBox.Show( message, caption , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
                                                    