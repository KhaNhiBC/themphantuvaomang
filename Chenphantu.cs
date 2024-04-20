public class Chenphantu()
{
    public static void chenphantu(int x,int indext, int[] myarry)
    {
        
        if (indext <= 1 & indext >= myarry.Length-1)
        {
            Console.WriteLine("Khong chen duoc gia tri {0} vao mang !",x);
        }
        else
        {
            int n = myarry.Length+1;
            int[] arry2 = new int[n];
            for (int i = 0; i < indext;i++)
            {
                arry2[i] = myarry[i];
            }
            arry2[indext] = x;
            for (int i = indext+1; i < arry2.Length;i++)
            {
                arry2[i] = myarry[i-1];
            }
            for (int i = 0;i < arry2.Length;i++)
            {
                Console.Write(arry2[i]+",");
            }
        }
    } 
} 