using System;


namespace Ejercisios
{
	public class CountTheDigit
    {
        public int NbDig(int n, int d)
        {
            // your code
            List<int> intList = new();
            int finalCount = 0;
            for (int i = 0; i <= n; i++)
            {
                intList.Add(i * i);
            }
            Console.WriteLine(intList.Aggregate((accu, e) => accu + e));

  
            intList.ForEach((e)=> {
                var count = e.ToString().Count( (e) => e == d);
              

                Console.WriteLine(finalCount);
            });

            return 0;
        }
    }
}

