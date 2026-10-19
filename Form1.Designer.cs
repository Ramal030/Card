
namespace Card
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(520, 40);
            textBox1.MaxLength = 19;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Kart nömrəsi";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(520, 90);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ad Soyad";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(520, 140);
            textBox3.MaxLength = 4;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "CVC";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 3;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(520, 195);
            button1.Name = "button1";
            button1.Size = new Size(155, 35);
            button1.TabIndex = 4;
            button1.Text = "Yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card;
            pictureBox1.Location = new Point(10, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DeepPink;
            pictureBox2.Image = Properties.Resources.chip;
            pictureBox2.Location = new Point(347, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepPink;
            label1.Location = new Point(30, 225);
            label1.Name = "label1";
            label1.Size = new Size(224, 35);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.DeepPink;
            label2.Location = new Point(30, 282);
            label2.Name = "label2";
            label2.Size = new Size(224, 35);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.DeepPink;
            label3.Location = new Point(260, 294);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = Color.White;
            label4.Location = new Point(366, 302);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 10;
            label4.Text = "👁";
            label4.Click += label4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 350);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}