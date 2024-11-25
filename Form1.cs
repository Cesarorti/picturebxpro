namespace picturebxpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void feliz_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i3;
        }

        private void triste_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i2;
        }

        private void desagrado_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i5;
        }

        private void furia_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i1;
        }

        private void temor_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i4;
        }

        private void ansiedad_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i6;
        }

        private void enui_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i8;
        }

        private void envidia_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = picturebxpro.Properties.Resources.i7;
        }
    }
}
