using System.Data;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Kata;
public class RomanNumerals
    {
        private static string[] romanLetters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        private static int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        
        public static string ToRoman(int n)
        {
            var romanNumber = string.Empty;
            int i = 0;
            while (n!=0)
            {
                if (n >= numbers[i])
                {
                    romanNumber += romanLetters[i];
                    n -= numbers[i];
                }
                else
                {
                    i++;
                }
            }
            return romanNumber;
        }
        
        //private static string[] romanLetters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static int FromRoman(string romanNumeral)
        {
            var arabicNumber = 0;
            var romanCharArr = (romanNumeral+ " ").ToArray() ;
            int i = 0;
            int currentValueOfRoman = 0;
            
            //MMCDCCVI
            
            while (romanCharArr[currentValueOfRoman] != ' ')
            {
                if (romanCharArr[currentValueOfRoman].ToString() == romanLetters[i])
                {
                    arabicNumber += numbers[i];
                    currentValueOfRoman++;
                }
                else if (romanCharArr[currentValueOfRoman] + romanCharArr[currentValueOfRoman+1].ToString() == romanLetters[i])
                {
                    arabicNumber += numbers[i];
                    currentValueOfRoman +=2;
                }
                else
                {
                    i++;
                }
            }
            return arabicNumber;
        }
    }