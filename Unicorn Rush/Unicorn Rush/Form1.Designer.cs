namespace Unicorn_Rush
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelZbychuZaklad = new System.Windows.Forms.Label();
            this.labelHelgaZaklad = new System.Windows.Forms.Label();
            this.labelEustachyZaklad = new System.Windows.Forms.Label();
            this.buttonPodpiszZaklad = new System.Windows.Forms.Button();
            this.groupBoxZawarteZaklady = new System.Windows.Forms.GroupBox();
            this.comboBoxGracz = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKwotaZakladu = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownJednorozecNumer = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAktualnyZaklad = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxJednorozec3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJednorozec1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJednorozec2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJednorozec311 = new System.Windows.Forms.PictureBox();
            this.pictureBoxJednorozec4 = new System.Windows.Forms.PictureBox();
            this.groupBoxZawarteZaklady.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwotaZakladu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJednorozecNumer)).BeginInit();
            this.groupBoxAktualnyZaklad.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec311)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(672, 423);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 142);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelZbychuZaklad
            // 
            this.labelZbychuZaklad.AutoSize = true;
            this.labelZbychuZaklad.Location = new System.Drawing.Point(20, 30);
            this.labelZbychuZaklad.Name = "labelZbychuZaklad";
            this.labelZbychuZaklad.Size = new System.Drawing.Size(144, 13);
            this.labelZbychuZaklad.TabIndex = 8;
            this.labelZbychuZaklad.Text = "Czekam na zakład Zbycha...";
            // 
            // labelHelgaZaklad
            // 
            this.labelHelgaZaklad.AutoSize = true;
            this.labelHelgaZaklad.Location = new System.Drawing.Point(20, 70);
            this.labelHelgaZaklad.Name = "labelHelgaZaklad";
            this.labelHelgaZaklad.Size = new System.Drawing.Size(132, 13);
            this.labelHelgaZaklad.TabIndex = 9;
            this.labelHelgaZaklad.Text = "Czekam na zakład Helgi...";
            // 
            // labelEustachyZaklad
            // 
            this.labelEustachyZaklad.AutoSize = true;
            this.labelEustachyZaklad.Location = new System.Drawing.Point(20, 110);
            this.labelEustachyZaklad.Name = "labelEustachyZaklad";
            this.labelEustachyZaklad.Size = new System.Drawing.Size(163, 13);
            this.labelEustachyZaklad.TabIndex = 10;
            this.labelEustachyZaklad.Text = "Czekam na zaklad Eustachego...";
            // 
            // buttonPodpiszZaklad
            // 
            this.buttonPodpiszZaklad.Location = new System.Drawing.Point(12, 542);
            this.buttonPodpiszZaklad.Name = "buttonPodpiszZaklad";
            this.buttonPodpiszZaklad.Size = new System.Drawing.Size(301, 23);
            this.buttonPodpiszZaklad.TabIndex = 11;
            this.buttonPodpiszZaklad.Text = "Podpisz zakład";
            this.buttonPodpiszZaklad.UseVisualStyleBackColor = true;
            this.buttonPodpiszZaklad.Click += new System.EventHandler(this.buttonPodpiszZaklad_Click);
            // 
            // groupBoxZawarteZaklady
            // 
            this.groupBoxZawarteZaklady.Controls.Add(this.labelZbychuZaklad);
            this.groupBoxZawarteZaklady.Controls.Add(this.labelHelgaZaklad);
            this.groupBoxZawarteZaklady.Controls.Add(this.labelEustachyZaklad);
            this.groupBoxZawarteZaklady.Location = new System.Drawing.Point(319, 418);
            this.groupBoxZawarteZaklady.Name = "groupBoxZawarteZaklady";
            this.groupBoxZawarteZaklady.Size = new System.Drawing.Size(347, 147);
            this.groupBoxZawarteZaklady.TabIndex = 12;
            this.groupBoxZawarteZaklady.TabStop = false;
            this.groupBoxZawarteZaklady.Text = "Zawarte zakłady:";
            // 
            // comboBoxGracz
            // 
            this.comboBoxGracz.FormattingEnabled = true;
            this.comboBoxGracz.Items.AddRange(new object[] {
            "Zbychu",
            "Helga",
            "Eustachy"});
            this.comboBoxGracz.Location = new System.Drawing.Point(20, 20);
            this.comboBoxGracz.Name = "comboBoxGracz";
            this.comboBoxGracz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGracz.TabIndex = 13;
            this.comboBoxGracz.SelectedIndexChanged += new System.EventHandler(this.comboBoxGracz_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ma aktualnie XXX PLN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chce postawić:";
            // 
            // numericUpDownKwotaZakladu
            // 
            this.numericUpDownKwotaZakladu.Location = new System.Drawing.Point(106, 48);
            this.numericUpDownKwotaZakladu.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownKwotaZakladu.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownKwotaZakladu.Name = "numericUpDownKwotaZakladu";
            this.numericUpDownKwotaZakladu.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownKwotaZakladu.TabIndex = 16;
            this.numericUpDownKwotaZakladu.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "PLN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "na jednorożca numer:";
            // 
            // numericUpDownJednorozecNumer
            // 
            this.numericUpDownJednorozecNumer.Location = new System.Drawing.Point(137, 78);
            this.numericUpDownJednorozecNumer.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownJednorozecNumer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJednorozecNumer.Name = "numericUpDownJednorozecNumer";
            this.numericUpDownJednorozecNumer.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownJednorozecNumer.TabIndex = 19;
            this.numericUpDownJednorozecNumer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxAktualnyZaklad
            // 
            this.groupBoxAktualnyZaklad.Controls.Add(this.comboBoxGracz);
            this.groupBoxAktualnyZaklad.Controls.Add(this.numericUpDownJednorozecNumer);
            this.groupBoxAktualnyZaklad.Controls.Add(this.label1);
            this.groupBoxAktualnyZaklad.Controls.Add(this.label7);
            this.groupBoxAktualnyZaklad.Controls.Add(this.label5);
            this.groupBoxAktualnyZaklad.Controls.Add(this.label6);
            this.groupBoxAktualnyZaklad.Controls.Add(this.numericUpDownKwotaZakladu);
            this.groupBoxAktualnyZaklad.Location = new System.Drawing.Point(12, 418);
            this.groupBoxAktualnyZaklad.Name = "groupBoxAktualnyZaklad";
            this.groupBoxAktualnyZaklad.Size = new System.Drawing.Size(301, 118);
            this.groupBoxAktualnyZaklad.TabIndex = 20;
            this.groupBoxAktualnyZaklad.TabStop = false;
            this.groupBoxAktualnyZaklad.Text = "Aktualny zakład";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Unicorn_Rush.Properties.Resources.TorTecza;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBoxJednorozec3);
            this.panel1.Controls.Add(this.pictureBoxJednorozec1);
            this.panel1.Controls.Add(this.pictureBoxJednorozec2);
            this.panel1.Controls.Add(this.pictureBoxJednorozec311);
            this.panel1.Controls.Add(this.pictureBoxJednorozec4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 400);
            this.panel1.TabIndex = 21;
            // 
            // pictureBoxJednorozec3
            // 
            this.pictureBoxJednorozec3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxJednorozec3.BackgroundImage = global::Unicorn_Rush.Properties.Resources.Jednorozec3;
            this.pictureBoxJednorozec3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxJednorozec3.Location = new System.Drawing.Point(5, 205);
            this.pictureBoxJednorozec3.Name = "pictureBoxJednorozec3";
            this.pictureBoxJednorozec3.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxJednorozec3.TabIndex = 7;
            this.pictureBoxJednorozec3.TabStop = false;
            // 
            // pictureBoxJednorozec1
            // 
            this.pictureBoxJednorozec1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxJednorozec1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxJednorozec1.Image = global::Unicorn_Rush.Properties.Resources.Jednorozec1;
            this.pictureBoxJednorozec1.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxJednorozec1.Name = "pictureBoxJednorozec1";
            this.pictureBoxJednorozec1.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxJednorozec1.TabIndex = 3;
            this.pictureBoxJednorozec1.TabStop = false;
            // 
            // pictureBoxJednorozec2
            // 
            this.pictureBoxJednorozec2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxJednorozec2.BackgroundImage = global::Unicorn_Rush.Properties.Resources.Jednorozec2;
            this.pictureBoxJednorozec2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxJednorozec2.Location = new System.Drawing.Point(5, 105);
            this.pictureBoxJednorozec2.Name = "pictureBoxJednorozec2";
            this.pictureBoxJednorozec2.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxJednorozec2.TabIndex = 4;
            this.pictureBoxJednorozec2.TabStop = false;
            // 
            // pictureBoxJednorozec311
            // 
            this.pictureBoxJednorozec311.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxJednorozec311.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxJednorozec311.Location = new System.Drawing.Point(5, 205);
            this.pictureBoxJednorozec311.Name = "pictureBoxJednorozec311";
            this.pictureBoxJednorozec311.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxJednorozec311.TabIndex = 5;
            this.pictureBoxJednorozec311.TabStop = false;
            // 
            // pictureBoxJednorozec4
            // 
            this.pictureBoxJednorozec4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxJednorozec4.BackgroundImage = global::Unicorn_Rush.Properties.Resources.Jednorozec4;
            this.pictureBoxJednorozec4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxJednorozec4.Location = new System.Drawing.Point(5, 305);
            this.pictureBoxJednorozec4.Name = "pictureBoxJednorozec4";
            this.pictureBoxJednorozec4.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxJednorozec4.TabIndex = 6;
            this.pictureBoxJednorozec4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 573);
            this.Controls.Add(this.groupBoxAktualnyZaklad);
            this.Controls.Add(this.groupBoxZawarteZaklady);
            this.Controls.Add(this.buttonPodpiszZaklad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Unicorn Rush";
            this.groupBoxZawarteZaklady.ResumeLayout(false);
            this.groupBoxZawarteZaklady.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKwotaZakladu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJednorozecNumer)).EndInit();
            this.groupBoxAktualnyZaklad.ResumeLayout(false);
            this.groupBoxAktualnyZaklad.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec311)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJednorozec4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxJednorozec1;
        private System.Windows.Forms.PictureBox pictureBoxJednorozec2;
        private System.Windows.Forms.PictureBox pictureBoxJednorozec311;
        private System.Windows.Forms.PictureBox pictureBoxJednorozec4;
        private System.Windows.Forms.Label labelZbychuZaklad;
        private System.Windows.Forms.Label labelHelgaZaklad;
        private System.Windows.Forms.Label labelEustachyZaklad;
        private System.Windows.Forms.Button buttonPodpiszZaklad;
        private System.Windows.Forms.GroupBox groupBoxZawarteZaklady;
        private System.Windows.Forms.ComboBox comboBoxGracz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKwotaZakladu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownJednorozecNumer;
        private System.Windows.Forms.GroupBox groupBoxAktualnyZaklad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxJednorozec3;
    }
}

