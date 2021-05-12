using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace fucker
{
    
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mem1()
        {
            string path = "dp\\b.py";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("def mem1():");
                streamWriter.Write("    return'");
                streamWriter.Write(this.textBox2.Text);
                streamWriter.Write("'");
            }
        }
        private void token1()
        {
         string path = "dp\\a.py";
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("def token():");
                streamWriter.Write("    return'");
                streamWriter.Write(this.textBox1.Text);
                streamWriter.Write("'");
            }
        }
        private void op1()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            bool flag1 = this.ft.Checked;
            if (flag1)
            {
                Process.Start("dp\\ft1.py");
            }
            bool flag2 = this.dc.Checked;
            if (flag2)
            {
                Thread.Sleep(3000);
                Process.Start("dp\\ft2.py");
            }
        }
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
            Console.Title = "Meta Fucker | By Morlin";
            Console.WriteLine("Criando o arquivo.");
            Thread.Sleep(500);
            Console.WriteLine("Criando o arquivo..");
            Thread.Sleep(500);
            Console.WriteLine("Criando o arquivo...");
            Thread.Sleep(500);
            Console.WriteLine("Criando o arquivo....");
            Thread.Sleep(500);
            Console.WriteLine("Arquivo criado.");
            Thread.Sleep(500);
            Console.WriteLine("Aguarde.");
            op1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "")
            {
                MessageBox.Show("Sem token");
            }
            else
            {
                MessageBox.Show("Token selecionado " + textBox1.Text);
                token1();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("                    ███╗   ███╗███████╗████████╗ █████╗  ██╗ ██████╗ ███████╗");
            Console.WriteLine("                    ████╗ ████║██╔════╝╚══██╔══╝██╔══██╗███║██╔═████╗╚════██║");
            Console.WriteLine("                    ██╔████╔██║█████╗     ██║   ███████║╚██║██║██╔██║    ██╔╝");
            Console.WriteLine("                    ██║╚██╔╝██║██╔══╝     ██║   ██╔══██║ ██║████╔╝██║   ██╔╝ ");
            Console.WriteLine("                    ██║ ╚═╝ ██║███████╗   ██║   ██║  ██║ ██║╚██████╔╝   ██║  ");
            Console.WriteLine("                    ╚═╝     ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═╝ ╚═════╝    ╚═╝  ");
            Console.WriteLine("                                     by Morlin107#6499");
            Thread.Sleep(5000);
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Sem nenhuma mensagem");
            }
            else
            {
                MessageBox.Show("Mensagem " + textBox2.Text);
                mem1();
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
