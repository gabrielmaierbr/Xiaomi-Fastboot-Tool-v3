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
    public partial class paranoid : Form
    {
        public paranoid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/aospa.zip") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "update aospa.zip";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo 'aospa.zip' não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/aospa.zip") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "update --skip-reboot aospa.zip";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo 'aospa.zip' não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/aospa.zip") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "update --skip-secondary aospa.zip";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo 'aospa.zip' não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/aospa.zip") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "update --skip-reboot --skip-secondary aospa.zip";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo 'aospa.zip' não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
