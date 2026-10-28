namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoten = new Button();
            button4 = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 94);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 132);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(93, 86);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(262, 23);
            txtHo.TabIndex = 2;
            txtHo.TextChanged += textHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(93, 128);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(262, 23);
            txtTen.TabIndex = 3;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(28, 222);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(75, 23);
            btnHo.TabIndex = 4;
            btnHo.Text = "họ ";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(156, 222);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(75, 23);
            btnTen.TabIndex = 5;
            btnTen.Text = "tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += button2_Click;
            // 
            // btnHoten
            // 
            btnHoten.Location = new Point(280, 222);
            btnHoten.Name = "btnHoten";
            btnHoten.Size = new Size(75, 23);
            btnHoten.TabIndex = 6;
            btnHoten.Text = "họ và tên";
            btnHoten.UseVisualStyleBackColor = true;
            btnHoten.Click += btnHoten_Click;
            // 
            // button4
            // 
            button4.Location = new Point(156, 275);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Thoát chương trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(91, 42);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(55, 15);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "lblHoTen";
            lblHoTen.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 341);
            Controls.Add(lblHoTen);
            Controls.Add(button4);
            Controls.Add(btnHoten);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài tập họ tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoten;
        private Button button4;
        private Label lblHoTen;
    }
}
