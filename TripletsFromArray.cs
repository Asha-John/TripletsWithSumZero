
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace TripletsWithSumOfZero
{
   public class TripletsFromArray
    {
      public static void findTriplets(int []arr, int n) 
       { 
            bool found = false; 
            for (int i = 0; i < n-2; i++) 
            { 
              for (int j = i+1; j < n-1; j++) 
              { 
                 for (int k = j+1; k < n; k++) 
                 { 
                    if (arr[i] + arr[j] + arr[k] == 0) 
                    { 
                        Console.Write(arr[i]); 
                        Console.Write(" "); 
                        Console.Write(arr[j]); 
                        Console.Write(" "); 
                        Console.Write(arr[k]); 
                        Console.Write("\n"); 
                        found = true; 
                    } 
                } 
            } 
        } 
      
        // If no triplet with 0 sum found in  array 
        if (found == false) 
            Console.Write(" not exist "); 
    } 
    }
}