using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemsGenerator
{
    public partial class Form1 : Form
    {
        string path = @"..\Data\UsersMap.txt";

        private void LoadUsersData()
        {
            usersMap = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (true)
                {
                    string? line = reader.ReadLine();

                    if (line == null) break;

                    string[] parts = line.Split(' ');

                    string name = parts[0];
                    int score = Convert.ToInt32(parts[2]);

                    usersMap.Add(parts[0], Convert.ToInt32(parts[2]));
                }

            }
        }

        private void SaveUsersData()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string name in usersMap.Keys)
                    writer.WriteLine($"{name}  {usersMap[name]}");
            }
        }
    }
}
    

