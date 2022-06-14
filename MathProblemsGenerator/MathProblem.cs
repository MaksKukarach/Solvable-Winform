namespace MathProblemsGenerator
{
    class MathProblem
    {
        byte numberOfElements = 2;
        public byte NumberOfElements
        {
            get { return numberOfElements; }
            set { numberOfElements = value; }
        }

        string? problem;
        public string? Problem { get { return problem; } }

        int answer = 0;
        public int Answer { get { return answer; } }

        int upperElementBorder = 128;
        int lowerElementBorder = 1;
        int upperAnswerBorder = 128;
        int lowerAnswerBorder = 32;
        Random random = new Random(DateTime.Now.Millisecond);

        public MathProblem(byte numberOfElements)
        {
            this.numberOfElements = numberOfElements;
        }

        public void CreateAdditionProblem()
        {
            
            int result = random.Next(lowerAnswerBorder, upperAnswerBorder);
            answer = result;
            
            List<int> elements = new List<int>();

            for (int i = 1; i < numberOfElements; i++)
            {
                upperElementBorder = result / i;
                int maxValue = upperElementBorder > result ? result : upperElementBorder;
                if (lowerElementBorder > maxValue) break;
                int element = random.Next(lowerElementBorder, maxValue);
                elements.Add(element);
                result -= element;
            }

            elements.Add(result);
            problem = String.Join('+', elements);
        }

        public void PrintInfo()
        {
            Console.WriteLine(problem + " = " + answer);
        }
    }   
}