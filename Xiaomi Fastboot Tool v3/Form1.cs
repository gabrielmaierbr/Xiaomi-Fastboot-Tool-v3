using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Xiaomi_Fastboot_Tool_v3
{
    public partial class Form1 : Form
    {

        int i = 0;
        string texto = "Gabriel Maier";

        public Form1()
        {
            InitializeComponent();
        }

        private void TypewriteText()
        {
            while (i < texto.Length)
            {
                Thread.Sleep(150);
                label1.Invoke(new Action(() =>
                {
                    label1.Text += texto[i];
                }));
                i++;
            }
        }

        public void adbinstall_all()
        {

            if (Directory.Exists(@"C:/adb") == true)
            {
                byte[] arquivo = Properties.Resources.adbsetup143;
                System.IO.File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "adbsetup143.exe"), arquivo);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = (Path.Combine(Path.GetTempPath(), "adbsetup143.exe"));
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process process2 = new Process();
                process2.StartInfo.WorkingDirectory = "adb/miflash";
                process2.StartInfo.FileName = "XiaoMiFlash.exe";
                process2.Start();
                process2.WaitForExit();

                try
                {
                    File.WriteAllBytes(@"C:\adb\adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(@"C:\adb\AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(@"C:\adb\AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    File.WriteAllBytes(@"C:\adb\etc1tool.exe", Properties.Resources.etc1tool);
                    File.WriteAllBytes(@"C:\adb\fastboot.exe", Properties.Resources.fastboot);
                    File.WriteAllBytes(@"C:\adb\hprof_conv.exe", Properties.Resources.hprof_conv);
                    File.WriteAllBytes(@"C:\adb\libwinpthread_1.dll", Properties.Resources.libwinpthread_1);
                    File.WriteAllBytes(@"C:\adb\make_f2fs.exe", Properties.Resources.make_f2fs);
                    File.WriteAllBytes(@"C:\adb\make_f2fs_casefold.exe", Properties.Resources.make_f2fs_casefold);
                    File.WriteAllBytes(@"C:\adb\mke2fs.conf", Properties.Resources.mke2fs);
                    File.WriteAllBytes(@"C:\adb\mke2fs.exe", Properties.Resources.mke2fs1);
                    File.WriteAllBytes(@"C:\adb\sqlite3.exe", Properties.Resources.sqlite3);
                    MessageBox.Show("Platform Tools copiado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:/adb");

                byte[] arquivo = Properties.Resources.adbsetup143;
                System.IO.File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "adbsetup143.exe"), arquivo);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = (Path.Combine(Path.GetTempPath(), "adbsetup143.exe"));
                process.Start();
                process.WaitForExit();

                System.Diagnostics.Process process2 = new Process();
                process2.StartInfo.WorkingDirectory = "adb/miflash";
                process2.StartInfo.FileName = "XiaoMiFlash.exe";
                process2.Start();
                process2.WaitForExit();

                try
                {
                    File.WriteAllBytes(@"C:\adb\adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(@"C:\adb\AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(@"C:\adb\AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    File.WriteAllBytes(@"C:\adb\etc1tool.exe", Properties.Resources.etc1tool);
                    File.WriteAllBytes(@"C:\adb\fastboot.exe", Properties.Resources.fastboot);
                    File.WriteAllBytes(@"C:\adb\hprof_conv.exe", Properties.Resources.hprof_conv);
                    File.WriteAllBytes(@"C:\adb\libwinpthread_1.dll", Properties.Resources.libwinpthread_1);
                    File.WriteAllBytes(@"C:\adb\make_f2fs.exe", Properties.Resources.make_f2fs);
                    File.WriteAllBytes(@"C:\adb\make_f2fs_casefold.exe", Properties.Resources.make_f2fs_casefold);
                    File.WriteAllBytes(@"C:\adb\mke2fs.conf", Properties.Resources.mke2fs);
                    File.WriteAllBytes(@"C:\adb\mke2fs.exe", Properties.Resources.mke2fs1);
                    File.WriteAllBytes(@"C:\adb\sqlite3.exe", Properties.Resources.sqlite3);
                    MessageBox.Show("Platform Tools copiado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            label1.Text = string.Empty;
            Thread t = new Thread(new ThreadStart(this.TypewriteText));
            t.Start();

            if (File.Exists(@"C:/adb/adb.exe") == false && File.Exists(@"C:/adb/fastboot.exe") == false && File.Exists(@"C:/adb/AdbWinApi.dll") == false && File.Exists(@"C:/adb/AdbWinUsbApi.dll") == false)
            {
                if (MessageBox.Show("ADB não instalado.\n\nGostaria de instalar agora?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    adbinstall_all();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "reboot";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:/adb") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "cmd.exe";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new Process();
                    process.StartInfo.WorkingDirectory = @"C:/adb";
                    process.StartInfo.FileName = "fastboot.exe";
                    process.StartInfo.Arguments = "oem edl";
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/K fastboot oem device-info";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/K fastboot getvar current-slot";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "set_active a";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:/adb/fastboot.exe") == true)
            {
                System.Diagnostics.Process process = new Process();
                process.StartInfo.WorkingDirectory = @"C:/adb";
                process.StartInfo.FileName = "fastboot.exe";
                process.StartInfo.Arguments = "set_active b";
                process.Start();
            }
            else
            {
                MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aDBMinimalSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] arquivo = Properties.Resources.minimal_adb_fastboot_v1_4_3_setup;
            System.IO.File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "minimal_adb_fastboot_v1_4_3_setup.exe"), arquivo);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = (Path.Combine(Path.GetTempPath(), "minimal_adb_fastboot_v1_4_3_setup.exe"));
            process.Start();
            process.WaitForExit();
        }

        private void instalarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adbinstall_all();
        }

        private void platformToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:/adb") == true)
            {
                try
                {
                    File.WriteAllBytes(@"C:\adb\adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(@"C:\adb\AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(@"C:\adb\AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    File.WriteAllBytes(@"C:\adb\etc1tool.exe", Properties.Resources.etc1tool);
                    File.WriteAllBytes(@"C:\adb\fastboot.exe", Properties.Resources.fastboot);
                    File.WriteAllBytes(@"C:\adb\hprof_conv.exe", Properties.Resources.hprof_conv);
                    File.WriteAllBytes(@"C:\adb\libwinpthread_1.dll", Properties.Resources.libwinpthread_1);
                    File.WriteAllBytes(@"C:\adb\make_f2fs.exe", Properties.Resources.make_f2fs);
                    File.WriteAllBytes(@"C:\adb\make_f2fs_casefold.exe", Properties.Resources.make_f2fs_casefold);
                    File.WriteAllBytes(@"C:\adb\mke2fs.conf", Properties.Resources.mke2fs);
                    File.WriteAllBytes(@"C:\adb\mke2fs.exe", Properties.Resources.mke2fs1);
                    File.WriteAllBytes(@"C:\adb\sqlite3.exe", Properties.Resources.sqlite3);
                    MessageBox.Show("Platform Tools copiado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:/adb");

                try
                {
                    File.WriteAllBytes(@"C:\adb\adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(@"C:\adb\AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(@"C:\adb\AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    File.WriteAllBytes(@"C:\adb\etc1tool.exe", Properties.Resources.etc1tool);
                    File.WriteAllBytes(@"C:\adb\fastboot.exe", Properties.Resources.fastboot);
                    File.WriteAllBytes(@"C:\adb\hprof_conv.exe", Properties.Resources.hprof_conv);
                    File.WriteAllBytes(@"C:\adb\libwinpthread_1.dll", Properties.Resources.libwinpthread_1);
                    File.WriteAllBytes(@"C:\adb\make_f2fs.exe", Properties.Resources.make_f2fs);
                    File.WriteAllBytes(@"C:\adb\make_f2fs_casefold.exe", Properties.Resources.make_f2fs_casefold);
                    File.WriteAllBytes(@"C:\adb\mke2fs.conf", Properties.Resources.mke2fs);
                    File.WriteAllBytes(@"C:\adb\mke2fs.exe", Properties.Resources.mke2fs1);
                    File.WriteAllBytes(@"C:\adb\sqlite3.exe", Properties.Resources.sqlite3);
                    MessageBox.Show("Platform Tools copiado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void miFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"adb/miflash/XiaoMiFlash.exe") == true)
            {
                System.Diagnostics.Process process2 = new Process();
                process2.StartInfo.WorkingDirectory = "adb/miflash";
                process2.StartInfo.FileName = "XiaoMiFlash.exe";
                process2.Start();
                process2.WaitForExit();
            }
            else
            {
                MessageBox.Show("Arquivos do Mi Flash não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aDBSetup13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] arquivo = Properties.Resources.adbsetup13;
            System.IO.File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "adbsetup13.exe"), arquivo);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = (Path.Combine(Path.GetTempPath(), "adbsetup13.exe"));
            process.Start();
            process.WaitForExit();
        }

        private void aDBSetup143ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] arquivo = Properties.Resources.adbsetup143;
            System.IO.File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "adbsetup143.exe"), arquivo);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = (Path.Combine(Path.GetTempPath(), "adbsetup143.exe"));
            process.Start();
            process.WaitForExit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".NET Framework 3.5\n\nCriado por: Gabriel Maier\n\nPrograma utilizado: Visual Studio 2022, C#", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"adb/miunlock/miflash_unlock.exe") == true)
            {
                System.Diagnostics.Process process2 = new Process();
                process2.StartInfo.WorkingDirectory = "adb/miunlock";
                process2.StartInfo.FileName = "miflash_unlock.exe";
                process2.Start();
                process2.WaitForExit();
            }
            else
            {
                MessageBox.Show("Arquivos do Mi Unlock não encontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O bloqueio de Bootloader deve ser feito apenas na ROM Stock", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (MessageBox.Show("Você está na ROM Stock?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Tem certeza?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        if (File.Exists(@"C:/adb/fastboot.exe") == true)
                        {
                            System.Diagnostics.Process process = new Process();
                            process.StartInfo.WorkingDirectory = @"C:/adb";
                            process.StartInfo.FileName = "fastboot.exe";
                            process.StartInfo.Arguments = "oem lock";
                            process.Start();
                        }
                        else
                        {
                            MessageBox.Show("Arquivos ADB não encontrados.\n\nInstale os Drivers ADB.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void rOMFastbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastboot fastbootrom = new fastboot();
            fastbootrom.Show();
        }

        private void customRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recovery rec = new recovery();
            rec.Show();
        }
    }
}
