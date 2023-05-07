using System.Drawing.Drawing2D;

namespace AMJJSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(pictureBox1.ClientRectangle);
            pictureBox1.Region = new Region(path);
        }
    }
}