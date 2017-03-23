﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchString
{
    public class MatchString
    {
        public static bool Match(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                int result = 0;

                for (int x = 0; x < s1.Length; x++)
                {
                    for (int y = 0; y < s2.Length; y++)
                    {
                        if (s1[x] == s2[y])
                            result++;
                    }
                }

                if (s1.Length == result)
                    return true;
            }
            return false;
        }
    }
}
