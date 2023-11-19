namespace LeetCodeTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            int sumNum = 5; 

            consumeArray(myArray, sumNum);
        }

        private void consumeArray(int[] myArray, int sum)
        {
            Console.WriteLine("Testing");

            textArray.Text = "wat";

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
        }
    }
}
