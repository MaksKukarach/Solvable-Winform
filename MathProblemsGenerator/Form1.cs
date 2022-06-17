namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;
        int score;
        bool isEquation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            this.AcceptButton = answerButton;

            CreateExpression();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

            if (answerTextBox.Text == Convert.ToString(mathProblem.Answer))
            {
                score += mathProblem.Score;
                CreateExpression();
            }
            else
            {
                score -= 3;
            }

            answerTextBox.Text = "";
            scoreTextBox.Text = $"IQ: {score}";
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            CreateExpression();
            answerTextBox.Text = "";

            score -= 10;
            scoreTextBox.Text = $"IQ: {score}";
        }

        private void CreateExpression()
        {
            mathProblem = new MathProblem(random.Next(90, 100), (byte)random.Next(2, 8));

            if (calculationCheckBox.Checked || equationsCheckBox.Checked)
            {
                if (calculationCheckBox.Checked && equationsCheckBox.Checked)
                {
                    isEquation = random.Next(2) == 1;
                }

                mathProblem = new MathProblem(random.Next(90, 100), (byte)random.Next(2, 8), isEquation);
                problemTextBox.Text = mathProblem.Problem;
            }

            else problemTextBox.Text = "Choose at least one problem type";

            isEquation = equationsCheckBox.Checked;
        }

        private void equationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isEquation = equationsCheckBox.Checked;
        }
    }
}