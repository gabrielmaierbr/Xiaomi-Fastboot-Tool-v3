using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xiaomi_Fastboot_Tool_v3
{
    public partial class recovery : Form
    {
        public recovery()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:/adb") == true)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Selecione um Custom Recovery";
                open.Filter = "Imagem (*.img)|*.img";
                open.FilterIndex = 1;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = open.FileName;
                    if (File.Exists(@"C:/adb/recovery.img") == true)
                    {
                        File.Delete(@"C:/adb/recovery.img");
                        File.Copy(@" " + textBox1.Text, @"C:/adb/recovery.img");
                    }
                    else
                    {
                        File.Copy(@" " + textBox1.Text, @"C:/adb/recovery.img");
                    }
                }
            }
            else
            {
                MessageBox.Show("ADB não instalado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void recovery_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/recovery.img") == true)
            {
                File.Delete(@"C:/adb/recovery.img");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/recovery.img") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "boot recovery.img";
                process.Start();
            }
            else
            {
                MessageBox.Show("Recovery não selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/recovery.img") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "flash recovery recovery.img";
                process.Start();
            }
            else
            {
                MessageBox.Show("Recovery não selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/recovery.img") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "flash recovery_ab recovery.img";
                process.Start();
            }
            else
            {
                MessageBox.Show("Recovery não selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "reboot recovery";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
