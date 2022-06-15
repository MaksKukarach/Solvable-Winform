namespace MathProblemsGenerator
{
    class MathProblem
    {
        int answer = 0;
        public int Answer { get { return answer; } }

        byte numberOfElements = 2;
        public byte NumberOfElements { get { return numberOfElements; } }

        int upperElementBorder = 128;
        int lowerElementBorder = 1;

        List<string> problemList = new List<string> { " " };

        string problem = "";
        public string Problem { get { return problem; } }

        Random random = new Random(DateTime.Now.Millisecond);

        public MathProblem(int answer, byte numberOfElements)
        {
            this.answer = answer;
            this.numberOfElements = numberOfElements;
            CreateProblem();
        }

        private void CreateProblem()
        {
            problemList.Add($"{answer}");

            for (int i = 2; i <= numberOfElements; i++)
            {
                while (true)
                {
                    int index = random.Next(0, problemList.Count);
                    string pickedElement = problemList[index];
                    if (int.TryParse(pickedElement, out int n))
                    {
                        int number = Convert.ToInt32(pickedElement);
                        if (number > 1)
                        {
                            List<string> result = DecomposeRandomly(number, problemList[index - 1]);
                            problemList.RemoveAt(index);

                            List<string> firstHalf = problemList.GetRange(0, index);
                            List<string> secondHalf = problemList.GetRange(index, problemList.Count - index);

                            firstHalf.AddRange(result);
                            firstHalf.AddRange(secondHalf);
                            problemList = firstHalf;

                            break;
                        }             
                    }
                }
                    
            }

            problem = String.Join("", problemList);
        }

        /*private string DecomposeIntoSum(int number)
        {
            int firstElement = random.Next(lowerElementBorder, number);

            return $"{firstElement} + {number - firstElement}";
        }*/

        private List<string> DecomposeIntoSum(int number, string symbolBehind)
        {
            int first = random.Next(lowerElementBorder, number);
            int second = number - first;
            if (symbolBehind == "-")
                return new List<string> { "(", $"{first}", "+", $"{second}", ")" };
            return new List<string> { $"{first}", "+", $"{second}"};
        }

        private List<string> DecomposeIntoDiff(int number, string symbolBehind)
        {
            int subtrahend = random.Next(lowerElementBorder, number);
            int minuend = number + subtrahend;
            if (symbolBehind == "-")
                return new List<string> { "(", $"{minuend}", "-", $"{subtrahend}", ")" };
            return new List<string> { $"{minuend}", "-", $"{subtrahend}" };
        }

        private List<string> DecomposeRandomly(int number, string symbolBehind)
        {
            int n = random.Next(1, 3);
            switch (n)
            {
                case 1:
                    return DecomposeIntoSum(number, symbolBehind);
                case 2:
                    return DecomposeIntoDiff(number, symbolBehind);
            }

            return new List<string>();
        }

        public void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }   
}