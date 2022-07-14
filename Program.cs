namespace Homework 
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            string? x = null;
            
            Console.WriteLine(IsNull(x));
        } 
        public static string IsNull(string? x){
            string? result = x;
            return result == null ? result?.GetValue() ?? -1 : 0;
        }
    }
}
