namespace class2
{  
    public class Program 
    {
        private static string DisplayOutcome(int finalMark)
        {
            string outCome; 
            if(finalMark >= 75)
            {
                outCome = "You passed with a distinction";
            }
            else if(finalMark >= 50 && finalMark <= 74)
            {
                outCome = "Passed";
            }
            else if(finalMark >= 40 && finalMark <= 49)
            {
                outCome = "Admission to supplementary exam";
            }
            else
            {
                outCome = "Fail";
            }
            return outCome;
        }
        static void Main (string [] args)    
        {
            int userFinalMark;
            Console.WriteLine("What is your final mark? ");
            userFinalMark  = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Outcome: {0}", DisplayOutcome(userFinalMark));

        }
    }
}
