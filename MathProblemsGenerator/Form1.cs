namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;


        public Form1()
        {
            mathProblem = new MathProblem(random.Next(10, 100), (byte) random.Next(2, 6));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = answerButton;
            problemTextBox.Text = mathProblem.Problem;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

            if (answerTextBox.Text == Convert.ToString(mathProblem.Answer))
            {
                mathProblem = new MathProblem(random.Next(10, 100), (byte)random.Next(2, 6));
                problemTextBox.Text = mathProblem.Problem;
            }

            answerTextBox.Text = "";
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            mathProblem = new MathProblem(random.Next(90, 100), (byte)random.Next(7, 8));
            problemTextBox.Text = mathProblem.Problem;
            answerTextBox.Text = "";
        }
    }
}