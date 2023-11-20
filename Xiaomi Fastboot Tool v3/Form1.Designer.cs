namespace Xiaomi_Fastboot_Tool_v3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBMinimalSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBSetup13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBSetup143ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMFastbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bootloader";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bloquear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Desbloquear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(163, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slot";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 45);
            this.button5.TabIndex = 3;
            this.button5.Text = "Trocar para Slot B";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 45);
            this.button6.TabIndex = 3;
            this.button6.Text = "Trocar para Slot A";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 45);
            this.button7.TabIndex = 1;
            this.button7.Text = "Status";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(42, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 45);
            this.button8.TabIndex = 5;
            this.button8.Text = "CMD ADB";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 45);
            this.button9.TabIndex = 6;
            this.button9.Text = "Modo EDL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.rOMFastbootToolStripMenuItem,
            this.customRecoveryToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDBDriversToolStripMenuItem,
            this.miFlashToolStripMenuItem,
            this.platformToolsToolStripMenuItem,
            this.instalarTodosToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // aDBDriversToolStripMenuItem
            // 
            this.aDBDriversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDBMinimalSetupToolStripMenuItem,
            this.aDBSetup13ToolStripMenuItem,
            this.aDBSetup143ToolStripMenuItem});
            this.aDBDriversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDBDriversToolStripMenuItem.Image")));
            this.aDBDriversToolStripMenuItem.Name = "aDBDriversToolStripMenuItem";
            this.aDBDriversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDBDriversToolStripMenuItem.Text = "ADB Drivers";
            // 
            // aDBMinimalSetupToolStripMenuItem
            // 
            this.aDBMinimalSetupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDBMinimalSetupToolStripMenuItem.Image")));
            this.aDBMinimalSetupToolStripMenuItem.Name = "aDBMinimalSetupToolStripMenuItem";
            this.aDBMinimalSetupToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aDBMinimalSetupToolStripMenuItem.Text = "ADB Minimal Setup";
            this.aDBMinimalSetupToolStripMenuItem.Click += new System.EventHandler(this.aDBMinimalSetupToolStripMenuItem_Click);
            // 
            // aDBSetup13ToolStripMenuItem
            // 
            this.aDBSetup13ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDBSetup13ToolStripMenuItem.Image")));
            this.aDBSetup13ToolStripMenuItem.Name = "aDBSetup13ToolStripMenuItem";
            this.aDBSetup13ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aDBSetup13ToolStripMenuItem.Text = "ADB Setup 1.3";
            this.aDBSetup13ToolStripMenuItem.Click += new System.EventHandler(this.aDBSetup13ToolStripMenuItem_Click);
            // 
            // aDBSetup143ToolStripMenuItem
            // 
            this.aDBSetup143ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDBSetup143ToolStripMenuItem.Image")));
            this.aDBSetup143ToolStripMenuItem.Name = "aDBSetup143ToolStripMenuItem";
            this.aDBSetup143ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aDBSetup143ToolStripMenuItem.Text = "ADB Setup 1.4.3";
            this.aDBSetup143ToolStripMenuItem.Click += new System.EventHandler(this.aDBSetup143ToolStripMenuItem_Click);
            // 
            // miFlashToolStripMenuItem
            // 
            this.miFlashToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("miFlashToolStripMenuItem.Image")));
            this.miFlashToolStripMenuItem.Name = "miFlashToolStripMenuItem";
            this.miFlashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miFlashToolStripMenuItem.Text = "Mi Flash";
            this.miFlashToolStripMenuItem.Click += new System.EventHandler(this.miFlashToolStripMenuItem_Click);
            // 
            // platformToolsToolStripMenuItem
            // 
            this.platformToolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("platformToolsToolStripMenuItem.Image")));
            this.platformToolsToolStripMenuItem.Name = "platformToolsToolStripMenuItem";
            this.platformToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.platformToolsToolStripMenuItem.Text = "Platform Tools";
            this.platformToolsToolStripMenuItem.Click += new System.EventHandler(this.platformToolsToolStripMenuItem_Click);
            // 
            // instalarTodosToolStripMenuItem
            // 
            this.instalarTodosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instalarTodosToolStripMenuItem.Image")));
            this.instalarTodosToolStripMenuItem.Name = "instalarTodosToolStripMenuItem";
            this.instalarTodosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instalarTodosToolStripMenuItem.Text = "Instalar Todos";
            this.instalarTodosToolStripMenuItem.Click += new System.EventHandler(this.instalarTodosToolStripMenuItem_Click);
            // 
            // rOMFastbootToolStripMenuItem
            // 
            this.rOMFastbootToolStripMenuItem.Name = "rOMFastbootToolStripMenuItem";
            this.rOMFastbootToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.rOMFastbootToolStripMenuItem.Text = "ROM Fastboot";
            this.rOMFastbootToolStripMenuItem.Click += new System.EventHandler(this.rOMFastbootToolStripMenuItem_Click);
            // 
            // customRecoveryToolStripMenuItem
            // 
            this.customRecoveryToolStripMenuItem.Name = "customRecoveryToolStripMenuItem";
            this.customRecoveryToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.customRecoveryToolStripMenuItem.Text = "Custom Recovery";
            this.customRecoveryToolStripMenuItem.Click += new System.EventHandler(this.customRecoveryToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.infoToolStripMenuItem.Text = "Sobre";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gabriel Maier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xiaomi Fastboot Tool v3 - by Gabriel Maier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBMinimalSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBSetup13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBSetup143ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMFastbootToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem customRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

