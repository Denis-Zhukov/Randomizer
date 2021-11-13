using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeCodeEvergyMonster;
internal static class Extands {
    public static string Shuffle(this string str) {
        char[] arr = str.ToArray<char>();
        int max = arr.Length;
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++) {
            int j = random.Next(0, max);
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
        return String.Join("", arr);
    }
}

