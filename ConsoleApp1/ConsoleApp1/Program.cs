internal class Program
{
    #region Pass By Value and ref and out
    //value Type ,pass by value and ref
    public static void swap(ref int x,ref int y)
    {
        int temp=x;
        x=y;
        y=temp;
        Console.WriteLine($"{x}{y}");
    }
    //ref type ,pass by value
    public static int SumArray(ref int[] arr)
    {
        int sum = 0;
      //  if (arr is not null)
       // {
            for (int i = 0; i < arr?.Length; i++)
                sum += arr[i];
         arr =new int[] {11,5,8,1};
            Console.WriteLine(arr.GetHashCode());
            return sum;
        //   }
        //pass by value read only 
        //pass by ref read and write but is nessary is be intilize
    }
    //pass by out write first and then write
    public static void SumN(int x, int y,out int s,out int m)
    {
        s = x + y; m=x+y;
        Console.WriteLine(s);
    }
    #endregion

    private static void Main(string[] args)
    {
        int a = 7;int b = 8;
      //  swap(ref a,ref b);
      //  Console.WriteLine($"{ a}{ b}");
        int[] arr = { 1, 2, 3, 5 };
        Console.WriteLine(SumArray( ref arr));
        Console.WriteLine(arr[1]); //show what diff betwen pass ref by ref and pass ref by value
       Console.WriteLine(arr.GetHashCode());
        int result;int mresult;

        SumN(a,b,out result,out mresult);
        SumN(a,b,out result,out _); //i donot care about mresult /C#7

        #region Nullable

        double x = 50;
        double? y = 50;
        y = null;
        //if (y is not null)
        //    x = (int)y;
        //else
        //    x = 0;
        //if (y.HasValue)
        //    x =(int) y.Value;
        //else
        //    x = 0;
        x = y.HasValue ? (int)y.Value : 0;
        x = y ?? 0; //if y not null return y and if null return 0
        int[] arr4 = { 2, 3, 6 };
        int[] arr2 = null;
        int? num3 = arr2?.Length??4; //Unsafe

        for (int i = 0; i < arr2?.Length; i++)
            Console.WriteLine(arr2[i]);
        Employee employee = null;
        Console.WriteLine(employee?.student?.name??"mohamed");
        #region Tryparsing
        int result2;
        do
        {
            Console.WriteLine("Enter first num");
        }
        while(!int.TryParse(Console.ReadLine(), out result2)); //no ex is fire
        Console.WriteLine(result2);
        #endregion
        #endregion

        #region Try and Catch
        #endregion



    }
}
class Student
{
    public string name;
}class Employee
{
    public Student student;
}


