using System.Resources;

namespace MathProblemsGenerator
{
    public partial class MainPage : Form
    {

        Random random = new Random(DateTime.Now.Millisecond);
        MathProblem mathProblem;
        bool isEquation;
        ResourceManager ResourceManager;

        Dictionary<string, int> usersMap;
        string currentUser = "User";
        int currentScore;
        string pathToUsersData = @"..\Data\UsersMap.txt";

        public MainPage()
        {
            ResourceManager = new ResourceManager("MathProblemsGenerator.Properties.Resources", 
                                                  typeof(MainPage).Assembly);
            LoadUsersData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = answerButton;

            foreach (string user in usersMap.Keys)
                usersComboBox.Items.Add(user);

            currentScore = usersMap[currentUser];
            scoreTextBox.Text = $"IQ: {currentScore}";

            CreateExpression();
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            usersMap[currentUser] = currentScore;
            SaveUsersData();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (problemTextBox.Text != "Choose at least one problem type")
            {
                if (answerTextBox.Text == Convert.ToString(mathProblem.Answer))
                {
                    currentScore += mathProblem.Score;
                    picResult.Image = (Image?)ResourceManager.GetObject("happyFace");

                    CreateExpression();
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
                currentScore -= 10;
                picResult.Image = (Image?)ResourceManager.GetObject("angryFace");

                CreateExpression();

                scoreTextBox.Text = $"IQ: {currentScore}";
            }

            answerTextBox.Text = "";
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

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentUser != null)
                usersMap[currentUser] = currentScore;
            currentUser = usersComboBox.Text;
            currentScore = usersMap[currentUser];

            scoreTextBox.Text = $"IQ: {currentScore}";
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

        private void LoadUsersData()
        {
            usersMap = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(pathToUsersData))
            {
                while (true)
                {
                    string? line = reader.ReadLine();

                    if (line == null) break;

                    string[] parts = line.Split(' ');

                    string name = parts[0];
                    int score = Convert.ToInt32(parts[1]);

                    usersMap.Add(name, score);
                }

            }
        }

        private void SaveUsersData()
        {
            using (StreamWriter writer = new StreamWriter(pathToUsersData))
            {
                foreach (string name in usersMap.Keys)
                    writer.WriteLine($"{name} {usersMap[name]}");
            }
        }

        private void BtnOpenSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show(); 
        }
    }
}