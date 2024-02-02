using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleting_a_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deleting D1 = new Deleting();
            int[] arr= new int[] {1,6,4,5};
            D1.pop(arr, 0);
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadKey();
        }
    }
    public class Deleting 
    {
        
        public void pop(int[]arr ,int index)
        {
            for (int i = index; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }

        }
    }
}
