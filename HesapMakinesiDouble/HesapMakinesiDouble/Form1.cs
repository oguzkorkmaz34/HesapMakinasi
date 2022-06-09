namespace HesapMakinesiDouble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1;
            double sayi2;
            double toplam, çarpým, fark, bölme;


            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            çarpým = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            bölme = sayi1 / sayi2;

            label10.Text = toplam.ToString();
            label8.Text = çarpým.ToString();
            label9.Text = fark.ToString();
            label7.Text = bölme.ToString();
            






        }
    }
}