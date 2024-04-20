internal class Program
{
    private static void Main(string[] args)
    {
        int[] myarry = {5,6,8,9,4,7,5,3,4,5};
        Console.WriteLine("Nhap vao gia tri can chen: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao vi tri can chen: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Chenphantu.chenphantu(x,n,myarry);
    }
}