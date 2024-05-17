namespace BromoAirLines
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            lihatStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 39);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 7);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 7;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(55, 39);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 515);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(1, 481);
            button4.Name = "button4";
            button4.Size = new Size(37, 33);
            button4.TabIndex = 28;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, lihatStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(185, 515);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            masterBandaraToolStripMenuItem.Image = (Image)resources.GetObject("masterBandaraToolStripMenuItem.Image");
            masterBandaraToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            masterBandaraToolStripMenuItem.Size = new Size(178, 20);
            masterBandaraToolStripMenuItem.Text = "Master Bandara";
            masterBandaraToolStripMenuItem.Click += masterBandaraToolStripMenuItem_Click;
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            masterMaskapaiToolStripMenuItem.Image = (Image)resources.GetObject("masterMaskapaiToolStripMenuItem.Image");
            masterMaskapaiToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            masterMaskapaiToolStripMenuItem.Size = new Size(178, 20);
            masterMaskapaiToolStripMenuItem.Text = "Master Maskapai";
            masterMaskapaiToolStripMenuItem.Click += masterMaskapaiToolStripMenuItem_Click;
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            masterJadwalPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("masterJadwalPenerbanganToolStripMenuItem.Image");
            masterJadwalPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(178, 20);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            masterJadwalPenerbanganToolStripMenuItem.Click += masterJadwalPenerbanganToolStripMenuItem_Click;
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.Image = (Image)resources.GetObject("masterKodePromoToolStripMenuItem.Image");
            masterKodePromoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(178, 20);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            // 
            // lihatStatusPenerbanganToolStripMenuItem
            // 
            lihatStatusPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("lihatStatusPenerbanganToolStripMenuItem.Image");
            lihatStatusPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            lihatStatusPenerbanganToolStripMenuItem.Name = "lihatStatusPenerbanganToolStripMenuItem";
            lihatStatusPenerbanganToolStripMenuItem.Size = new Size(178, 20);
            lihatStatusPenerbanganToolStripMenuItem.Text = "Lihat Status Penerbangan";
            lihatStatusPenerbanganToolStripMenuItem.Click += lihatStatusPenerbanganToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(221, 53);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 5;
            label2.Text = "Master Kode Promo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 82);
            label3.Name = "label3";
            label3.Size = new Size(294, 15);
            label3.TabIndex = 6;
            label3.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(221, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(668, 214);
            dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Persentase Diskon";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Maksimum Diskon";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Berlaku Sampai";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Deskripsi";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 350);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 8;
            label4.Text = "Kode Promo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(221, 387);
            label5.Name = "label5";
            label5.Size = new Size(97, 17);
            label5.TabIndex = 9;
            label5.Text = "Berlaku Sampai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(221, 421);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 10;
            label6.Text = "Persentase Diskon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(221, 458);
            label7.Name = "label7";
            label7.Size = new Size(114, 17);
            label7.TabIndex = 11;
            label7.Text = "Maksimum Diskon";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(579, 350);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 12;
            label8.Text = "Deskripsi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 383);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(356, 421);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(356, 458);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(200, 23);
            numericUpDown2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(662, 350);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 56);
            textBox1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(662, 451);
            button2.Name = "button2";
            button2.Size = new Size(89, 32);
            button2.TabIndex = 26;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(800, 451);
            button3.Name = "button3";
            button3.Size = new Size(89, 32);
            button3.TabIndex = 27;
            button3.Text = "Simpan";
            button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(36, 530);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 28;
            label12.Text = "Logout";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 554);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form7";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem lihatStatusPenerbanganToolStripMenuItem;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label12;
    }
}