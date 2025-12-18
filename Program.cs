public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in Array:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements of Array:");
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter Threshold:");
        int threshold = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Filtered Array (elements greater than Threshold):");
        for(int i = 0; i < n; i++)
        {
            if(arr[i] > threshold)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
