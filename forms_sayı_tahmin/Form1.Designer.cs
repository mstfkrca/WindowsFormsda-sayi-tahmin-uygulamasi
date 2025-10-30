namespace forms_sayı_tahmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxtahmin = new TextBox();
            btntahminet = new Button();
            lblkalanhak = new Label();
            listboxgeçmiş = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbltahminedinmesajı = new Label();
            SuspendLayout();
            // 
            // txtboxtahmin
            // 
            txtboxtahmin.Location = new Point(394, 77);
            txtboxtahmin.Name = "txtboxtahmin";
            txtboxtahmin.Size = new Size(100, 23);
            txtboxtahmin.TabIndex = 0;
            txtboxtahmin.TextChanged += txtboxtahmin_TextChanged;
            // 
            // btntahminet
            // 
            btntahminet.Location = new Point(546, 74);
            btntahminet.Name = "btntahminet";
            btntahminet.Size = new Size(75, 26);
            btntahminet.TabIndex = 2;
            btntahminet.Text = "tahmin et";
            btntahminet.UseVisualStyleBackColor = true;
            btntahminet.Click += btntahminet_Click;
            // 
            // lblkalanhak
            // 
            lblkalanhak.AutoSize = true;
            lblkalanhak.Location = new Point(546, 125);
            lblkalanhak.Name = "lblkalanhak";
            lblkalanhak.Size = new Size(81, 15);
            lblkalanhak.TabIndex = 4;
            lblkalanhak.Text = "kalan hakkınız";
            lblkalanhak.Click += lblkalanhak_Click;
            // 
            // listboxgeçmiş
            // 
            listboxgeçmiş.FormattingEnabled = true;
            listboxgeçmiş.ItemHeight = 15;
            listboxgeçmiş.Location = new Point(374, 134);
            listboxgeçmiş.Name = "listboxgeçmiş";
            listboxgeçmiş.Size = new Size(120, 94);
            listboxgeçmiş.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(258, 134);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 6;
            label1.Text = "Yüzler bas.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(258, 171);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 7;
            label2.Text = "Onlar bas.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(258, 211);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 8;
            label3.Text = "Birler bas.";
            // 
            // lbltahminedinmesajı
            // 
            lbltahminedinmesajı.AutoSize = true;
            lbltahminedinmesajı.Location = new Point(258, 80);
            lbltahminedinmesajı.Name = "lbltahminedinmesajı";
            lbltahminedinmesajı.Size = new Size(114, 15);
            lbltahminedinmesajı.TabIndex = 9;
            lbltahminedinmesajı.Text = "Sayı Tahmin Ediniz : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 559);
            Controls.Add(lbltahminedinmesajı);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listboxgeçmiş);
            Controls.Add(lblkalanhak);
            Controls.Add(btntahminet);
            Controls.Add(txtboxtahmin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxtahmin;
        private Button btntahminet;
        private HScrollBar hScrollBar1;
        private Label lblkalanhak;
        private ListBox listboxgeçmiş;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbltahminedinmesajı;
    }
}
