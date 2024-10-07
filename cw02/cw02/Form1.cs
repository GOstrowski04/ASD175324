namespace cw02
{
    public partial class Form1 : Form
    {
        public int[] tab1 = [5, 2, 7, 1, 7, 9, 1];
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("[5, 2, 7, 1, 7, 9, 1]");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tab1.Length > 1)
            {
                for (int i = 1; i < tab1.Length; i++)
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (tab1[j] < tab1[j - 1])
                        {
                            int x = tab1[j];
                            tab1[j] = tab1[j - 1];
                            tab1[j - 1] = x;
                        }
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", tab1));
            textBox1.Text = '[' + string.Join(", ", tab1) + ']';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tab1.Length > 1)
            {
                for (int i = tab1.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                        if (tab1[j] > tab1[j + 1])
                        {
                            int x = tab1[j];
                            tab1[j] = tab1[j + 1];
                            tab1[j + 1] = x;
                        }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", tab1));
            textBox1.Text = '[' + string.Join(", ", tab1) + ']';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int p = 0;
            int q = tab1.Length - 1;
            if (p < q)
            {

            }

        }
    }
}
