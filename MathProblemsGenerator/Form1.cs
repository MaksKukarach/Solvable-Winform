namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;


        public Form1()
        {
            mathProblem = new MathProblem((byte)random.Next(2, 6));
            mathProblem.CreateAdditionProblem();
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
                mathProblem.NumberOfElements = (byte) random.Next(2, 6);
                mathProblem.CreateAdditionProblem();
                problemTextBox.Text = mathProblem.Problem;
            }

            answerTextBox.Text = "";
        }
    }
}