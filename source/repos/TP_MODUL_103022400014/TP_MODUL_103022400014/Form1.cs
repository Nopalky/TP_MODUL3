namespace TP_MODUL_103022400014
{
    public partial class Form1 : Form
    {

        string masukan = "";
        int firstNumber = 0;
        bool checkedClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Buttonclk(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            masukan += btn.Text;
            label1.Text = masukan;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (masukan != "")
            {
                firstNumber = int.Parse(masukan);
                masukan = "";
                checkedClicked = true;
                label1.Text = "+";
                }   
            }
        

        private void button12_Click(object sender, EventArgs e)
        {
            int secondNumber = int.Parse(masukan);
            int result = firstNumber + secondNumber;

            label1.Text = result.ToString();

            masukan = result.ToString();
            checkedClicked = false;
            }
        }

        
    }
