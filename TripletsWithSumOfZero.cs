using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace TripletsWithSumOfZero
{
    public class UniqueTripletWithSumZero
    {
        public static void Main(String[] args)
        {
            Console.Write("Please Enter your numbers for array : ");
            string mainstring = Console.ReadLine();
            string[] _array1=mainstring.Split(',');
            string[] _numbers1=mainstring.Split(',');
            List<int> _numbers=new List<int>();
            foreach(string str in _array1)
            {
                int _num=int.Parse(str);
                _numbers.Add(_num);
            }
            int[] _numberArray=_numbers.ToArray();
            int _length=_numberArray.Length;
        // string _itemsArrays=string.Empty;
        // foreach(int _item in _numberArray)
        // {
        //     if(string.IsNullOrEmpty(_itemsArrays))
        //     {
        //         _itemsArrays=_item.ToString();
        //     }
        //     else{
        //         _itemsArrays=_itemsArrays+", "+_item.ToString();
        //     }
        // }
            //Substring _substring =new Substring();
            
         // Console.WriteLine("Your array is : " +"{ "+ _numberArray +" }");
          TripletsFromArray.findTriplets(_numberArray,_length);
        }
    }
}