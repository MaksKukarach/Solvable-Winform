using System.Resources;

namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;
        bool isEquation;
        ResourceManager ResourceManager;

        Dictionary<string, int> usersMap;
        string currentUser;
        int currentScore;

        public Form1()
        {
            ResourceManager = new ResourceManager("MathProblemsGenerator.Properties.Resources", 
                                                  typeof(Form1).Assembly);
            LoadUsersData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentScore = 0;
            this.AcceptButton = answerButton;
            foreach (string user in usersMap.Keys)
                usersComboBox.Items.Add(user);

            CreateExpression();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (problemTextBox.Text != "Choose at least one problem type")
            {
                if (answerTextBox.Text == Convert.ToString(mathProblem.Answer))
                {
                    currentScore += mathProblem.Score;
                    CreateExpression();
                    picResult.Image = (Image?)ResourceManager.GetObject("happyFace");
                }
                else
                {
                    currentScore -= 3;
                    picResult.Image = (Image?)ResourceManager.GetObject("angryFace");
                }
                scoreTextBox.Text = $"IQ: {currentScore}";
            }

            answerTextBox.Text = "";
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (problemTextBox.Text != "Choose at least one problem type")
            {
                CreateExpression();
                currentScore -= 10;
                scoreTextBox.Text = $"IQ: {currentScore}";
                picResult.Image = (Image?)ResourceManager.GetObject("angryFace");
            }

            answerTextBox.Text = "";
        }

        private void CreateExpression()
        {
            isEquation = equationsCheckBox.Checked;

            if (calculationCheckBox.Checked || isEquation)
            {
                if (calculationCheckBox.Checked && isEquation)
                {
                    isEquation = random.Next(2) == 1;
                }

                mathProblem = new MathProblem(random.Next(100, 150), (byte)random.Next(7, 8), isEquation);
                problemTextBox.Text = mathProblem.Problem;
            }

            else problemTextBox.Text = "Choose at least one problem type";

            isEquation = equationsCheckBox.Checked;
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            usersMap[currentUser] = currentScore;
            SaveUsersData();
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentUser != null)
                usersMap[currentUser] = currentScore;
            currentUser = usersComboBox.Text;
            currentScore = usersMap[currentUser];

            scoreTextBox.Text = $"IQ: {currentScore}";
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string user = addUserTxt.Text;
            addUserTxt.Text = "";
            if (!usersMap.Keys.Contains(user))
            {
                usersMap.Add(user, 0);
                usersComboBox.Items.Add(user);
            }

            usersComboBox.SelectedIndex = usersComboBox.FindString(user);
        }
    }
}