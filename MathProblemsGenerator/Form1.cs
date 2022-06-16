namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;
        int score;

        public Form1()
        {
            mathProblem = new MathProblem(random.Next(10, 100), (byte) random.Next(2, 6));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            this.AcceptButton = answerButton;
            problemTextBox.Text = mathProblem.Problem;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

            if (answerTextBox.Text == Convert.ToString(mathProblem.Answer))
            {
                score += mathProblem.Score;
                mathProblem = new MathProblem(random.Next(10, 100), (byte)random.Next(2, 8));
                problemTextBox.Text = mathProblem.Problem;
            }
            else
            {
                score -= 1;
            }

            answerTextBox.Text = "";
            scoreTextBox.Text = $"IQ: {score}";
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            mathProblem = new MathProblem(random.Next(90, 100), (byte)random.Next(2, 8));
            problemTextBox.Text = mathProblem.Problem;
            answerTextBox.Text = "";

            score -= 5;
            scoreTextBox.Text = $"IQ: {score}";
        }
    }
}