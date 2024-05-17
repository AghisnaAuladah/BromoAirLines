namespace BromoAirLines
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(52, 32);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 14);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 37;
            label2.Text = "Tiket Saya";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(261, 15);
            label1.TabIndex = 38;
            label1.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(12, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 301);
            dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode Penerbangan";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Maskapai";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Bandara Keberangkatan";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Bandara Tujuan";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Tanggal Keberangkatan";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Waktu Penerbangan";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Status Terakhir";
            Column7.Name = "Column7";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 416);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}