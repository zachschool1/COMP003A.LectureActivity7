using System.Threading.Tasks.Sources;
using System.Collections.Generic;

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] scores = { 85, 90, 78, 92, 88 };

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            List<string> names = new List<string>();

            names.Add("Alex");
            names.Add("Jordan");
            names.Add("Taylor");

            foreach(string name in names)
            {
                Console.WriteLine(name);    
            }
            for (int i = 0; i < scores.Length; i++) 
            {
                Console.WriteLine(scores[i]);            
            }
            for (int i = 0;i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Enter a number 1-3");
            string inputNum = Console.ReadLine();
            int inputInt = 0;
            try
            {
                inputInt = int.Parse(inputNum);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number entered");
            }


            //for this reason, i would think that I would rather just do good input validation rather than try catch because I still need to validate that it is within my range regardless, so adding a try catch and puttin an if statement about something nto being a number do basically the same thing. try catch would be much more useful in things where I am not sure the format or expected format.
            if (inputInt < 1 || inputInt > 3)
            {
                Console.WriteLine("Enter a number between 1 and 3.");
            } else
            {
                Console.WriteLine("Success!");
            }
            
        }
    }
}
