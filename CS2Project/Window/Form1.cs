using Newtonsoft.Json.Linq;

namespace Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked, it will show a random Pokemon card on screen and tell you the name of the card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Request.CardImage);
            textBox1.Text = "Nice! You got a " + Request.CardName + ".";
        }
    }
}
