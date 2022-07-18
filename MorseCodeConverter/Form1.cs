namespace MorseCodeConverter
{
    using System.Text;
    public partial class Form1 : Form
    {
        private Driver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            StringBuilder sb = new StringBuilder();


            for (int i=0; i<lines.Length; i++)
            {
                sb.AppendLine(Driver.Convert(lines[i]));
            }
            label3.Text = sb.ToString();
            
        }
    }
}