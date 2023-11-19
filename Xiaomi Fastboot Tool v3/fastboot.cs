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
    public partial class fastboot : Form
    {
        public fastboot()
        {
            InitializeComponent();
        }

        private void fastboot_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            if (File.Exists(@"C:/adb/aospa.zip") == true)
            {
                File.Delete(@"C:/adb/aospa.zip");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Text = "Selecionar pasta da ROM";
                button1.Visible = true;
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.Text = "Selecionar pasta da ROM";
                button1.Visible = true;
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button1.Text = "Selecionar pasta da ROM";
                button1.Visible = true;
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button1.Text = "Selecionar zip da ROM";
                button1.Visible = true;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = diag.SelectedPath;
                    button2.Visible = true;
                    button2.Enabled = true;
                    button3.Visible = false;
                    button3.Enabled = false;
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = diag.SelectedPath;
                    button2.Visible = true;
                    button2.Enabled = true;
                    button3.Visible = true;
                    button3.Enabled = true;
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = diag.SelectedPath;
                    button2.Visible = true;
                    button2.Enabled = true;
                    button3.Visible = false;
                    button3.Enabled = false;
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Selecione a ROM Paranoid Android";
                open.Filter = "Zip (*.zip)|*.zip";
                open.FilterIndex = 1;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = open.FileName;
                    File.Delete(@"C:/adb/aospa.zip");
                    File.Copy(@" " + textBox1.Text, @"C:/adb/aospa.zip");
                    button2.Enabled = true;
                    button2.Visible = true;
                    button3.Enabled = false;
                    button3.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (File.Exists(textBox1.Text + "/flash_all.bat") == true)
                {
                    stock stockrom = new stock(textBox1.Text);
                    stockrom.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (File.Exists(textBox1.Text + "/windows_fastboot_first_install_with_data_format.bat") == true)
                {
                    System.Diagnostics.Process process = new Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "windows_fastboot_first_install_with_data_format.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Arquivo windows_fastboot_first_install_with_data_format.bat não existe, caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 2)
            {
                if (File.Exists(textBox1.Text + "/windows_fastboot_installer.bat") == true)
                {
                    System.Diagnostics.Process process = new Process();
                    process.StartInfo.WorkingDirectory = textBox1.Text;
                    process.StartInfo.FileName = "windows_fastboot_installer.bat";
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Arquivo windows_fastboot_installer.bat não existe, caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 3)
            {
                paranoid aospa = new paranoid();
                aospa.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text + "/windows_fastboot_update_rom.bat") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = textBox1.Text;
                process.StartInfo.FileName = "windows_fastboot_update_rom.bat";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivo windows_fastboot_update_rom.bat não existe, caminho incorreto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
