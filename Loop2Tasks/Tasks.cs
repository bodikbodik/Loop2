using System.Linq;

namespace Loop2Tasks
{
    public static class Tasks
    {
        public static int Task1(int n)
        {
            int sum = 0;
            int a = 0;  

            for(; n>0; n /= 10)
            {
               a = n % 10;
               sum += ((a % 2 == 0) ? a : 0); 
            }
            return sum;
        }

        public static int Task2(int n)
        {
            int max = 0;
            int sum1 = 0;
            int sum2 = 0;
            int a = 0;
            int b = n;
            int c = 0;

            for (; n > 0; n /= 10)
            {
                a = n % 10;
                sum1 += ((a % 2 == 0) ? a : 0);
            }


            for (; b > 0; b /= 10)
            {
                c = b % 10;
                sum2 += ((c % 2 == 0) ? 0 : c);
            }
            max = Math.Max(sum1, sum2);

            return max;
        }

        public static int Task3(int n)
        {
            int result = 0, digits = 0, temp_n = n;
            while (temp_n > 0)
            {
                temp_n /= 10;
                digits++;
            }

            int[] myNum = new int [digits];
            for ( int i = 0; n >0 ; n /= 10, i++)
            {
                result = n % 10;
                myNum[i] = result;
            }
            Array.Sort(myNum);
            string result_str = string.Join ("",myNum);
            result = Int32.Parse(result_str);
            return result;
        }
    }
}