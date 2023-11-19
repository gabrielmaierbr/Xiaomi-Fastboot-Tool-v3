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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Xiaomi_Fastboot_Tool_v3
{
    public partial class stock : Form
    {
        public string TextFastboot;

        public stock()
        {
            InitializeComponent();
        }
        public stock(string textbox)
        {
            InitializeComponent();
            TextFastboot = textbox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextFastboot + "/flash_all.bat") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = TextFastboot;
                process.StartInfo.FileName = "flash_all.bat";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo flash_all.bat não existe, caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextFastboot + "/flash_all_lock.bat") == true)
            {
                if (MessageBox.Show("Tem certeza?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new Process();
                    process.StartInfo.WorkingDirectory = TextFastboot;
                    process.StartInfo.FileName = "flash_all_lock.bat";
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("Arquivo flash_all_lock.bat não existe, caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stock_Load(object sender, EventArgs e)
        {
            
        }
    }
}
