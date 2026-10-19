
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Card
{
    public partial class Form1 : Form
    {
        private bool cvcGorunur = false;

        public Form1()
        {
            InitializeComponent();

            textBox1.MaxLength = 19;
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 4;

            textBox3.UseSystemPasswordChar = true;

            button1.Text = "yoxla";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nomre = new string(
                textBox1.Text.Where(char.IsDigit).Take(16).ToArray());

            label1.Text = string.Join(" ",
                Enumerable.Range(0, (nomre.Length + 3) / 4)
                .Select(i => nomre.Substring(
                    i * 4, Math.Min(4, nomre.Length - i * 4))));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text.ToUpperInvariant();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string cvc = new string(
                textBox3.Text.Where(char.IsDigit).Take(4).ToArray());

            label3.Text = cvcGorunur
                ? cvc
                : new string('*', cvc.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomre = new string(
                textBox1.Text.Where(char.IsDigit).ToArray());
            string adSoyad = textBox2.Text.Trim();

            string cvc = new string(
                textBox3.Text.Where(char.IsDigit).ToArray());

            if (nomre.Length != 16)
            {
                MessageBox.Show("Kart nömrəsi 16 rəqəm olmalıdır!");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(adSoyad) ||
                !adSoyad.Contains(" "))
            {
                MessageBox.Show("Ad və soyadı daxil edin!");
                textBox2.Focus();
                return;
            }

            if (cvc.Length != 3 && cvc.Length != 4)
            {
                MessageBox.Show("CVC 3 və ya 4 rəqəm olmalıdır!");
                textBox3.Focus();
                return;
            }

            MessageBox.Show("Məlumatların formatı düzgündür!");
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            cvcGorunur = !cvcGorunur;
            textBox3.UseSystemPasswordChar = !cvcGorunur;

            string cvc = new string(
                textBox3.Text.Where(char.IsDigit).Take(4).ToArray());

            label3.Text = cvcGorunur
                ? cvc
                : new string('*', cvc.Length);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
{
    cvcGorunur = !cvcGorunur;

    textBox3.UseSystemPasswordChar = !cvcGorunur;

    string cvc = new string(
        textBox3.Text.Where(char.IsDigit).Take(4).ToArray()
    );

    label3.Text = cvcGorunur
        ? cvc
        : new string('*', cvc.Length);

    label4.Text = cvcGorunur ? "🙈" : "👁";
}
    }
}