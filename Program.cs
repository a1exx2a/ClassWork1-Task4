namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {1,2,3,4,5,6,7,8,9,10,11,12};

        foreach (int i in x) {
            if (i%2 == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
