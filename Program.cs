namespace Homework 
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int sum = 0;
            double avg = 0.0;
            int numZeros = 0;
            int numPositives = 0;
            int numNegatives = 0;
            int count = 0;
            int numEntries;

            Console.WriteLine("Welcome to number stats! How many entries do you wish to enter?");

            while(true)
            {
                try
                {
                    numEntries = Convert.ToInt32(Console.ReadLine());
                    if(numEntries < 0)
                        {
                            Console.WriteLine("Please enter a positive integer");
                            continue;
                        }
                    break;
                    
                } 
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a positive integer"); 
                }
            }

            
            Console.WriteLine($"Expecting {numEntries} numbers");

            int[] numbers = new int[numEntries];

            
            for(int i = 0; i < numbers.Length;)
            {
                try
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                    continue;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter an integer"); 
                }
            }


            for(int i = 0; i < numbers.Length; i++)
            {
                count++;
                sum += numbers[i];
                if(numbers[i] == 0)
                    numZeros++; 
                if(numbers[i] > 0)
                    numPositives++;
                if(numbers[i] < 0)
                    numNegatives++;
            }

            if(count > 0)
            {
                avg = (double)sum / count; 
                Console.WriteLine($"The sum of all numbers entered:{sum}");
                Console.WriteLine($"The average of all numbers entered:{avg}");
                Console.WriteLine($"The number of zeros entered:{numZeros}");
                Console.WriteLine($"The number of positive numbers entered:{numPositives}");
                Console.WriteLine($"The number of negative numbers entered:{numNegatives}");
            }
            
            Console.WriteLine("Done!");
        } 
    }
}
