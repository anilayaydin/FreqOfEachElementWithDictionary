using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void getFreqofElement(int[] arr)
        {
            Dictionary<int, int> freqElementDict = new Dictionary<int, int>();
            for(int i=0; i < arr.Length; i++)
            {
                if(freqElementDict.ContainsKey(arr[i])) {
                   freqElementDict[arr[i]]++;
                }
                else {
                    freqElementDict[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in freqElementDict){
                System.Console.WriteLine(x.Key + "-->" + x.Value);
            }
        }

        static void Main(string[] args) {
            
            int[] arr = {0,1,2,3,1,4,5,2,3};
            getFreqofElement(arr);
        }
    }
}