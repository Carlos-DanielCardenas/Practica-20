namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);
            if (edad < 12) MessageBox.Show(" ES UN NIÑO");

            if (edad >= 12 && edad < 18) MessageBox.Show(" ES UN ADOLENTE");

            if (edad >= 18 && edad < 60) MessageBox.Show(" ES UN ADULTO");

            if (edad >= 60) MessageBox.Show(" ES DE LA TERCERA EDAD");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}