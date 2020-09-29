using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptDecrypt
{
    public class Util
    {
        public static string GetPlainText()
        {
            Console.Write("Enter a plain text:");
            string plainText = Console.ReadLine();
            return plainText;
        }
        public static string GetSingleKey()
        {
            Console.Write("Enter a single key as an alpha character:");
            string singleKey = Console.ReadLine();
            return singleKey;
        }
        public static string GetMultiKey()
        {
            Console.Write("Enter a multi key as an alpha character:");
            string multiKey = Console.ReadLine();
            return multiKey;
        }
        public static int[] Clean(string plainText)
        {
            string upperPlainText = plainText.ToUpper();
            string onlyAlpha = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                if(upperPlainText[i] < 91 && upperPlainText[i] > 64)
                {
                    onlyAlpha += upperPlainText[i];
                }
            }
            int[] asciiArray = new int[onlyAlpha.Length];
            for (int i = 0; i < onlyAlpha.Length; i++)
            {
                asciiArray[i] = onlyAlpha[i];
            }
            return asciiArray;
        }
        public static string SingleEnc(int[] cleanText, int[] sKey)
        {
            string encodedString = "";
            sKey[0] -= 64;
            for (int i = 0; i < cleanText.Length; i++)
            {
                if(cleanText[i] + sKey[0] < 91)
                {
                    cleanText[i] += sKey[0];
                    encodedString += (char)cleanText[i];
                }
                else
                {
                    cleanText[i] += sKey[0];
                    encodedString += (char)(cleanText[i]-26);
                }
            }
            return encodedString;
        }
        public static string MultiEnc(int[] cleanText, int[] mKey)
        {
            string encodedString = "";
            for (int i = 0; i < mKey.Length; i++)
            {
                mKey[i] -= 64;
            }
            int k = 0;
            int j = 0;
            while (k < cleanText.Length)
            {
                if (j == mKey.Length) j = 0;
                if ((cleanText[k] + mKey[j]) < 91)
                {
                    encodedString += (char)(cleanText[k] + mKey[j]);
                }
                else
                {
                    encodedString += (char)((cleanText[k] + mKey[j]) -26);
                }
                k++;
                j++;
            }
            return encodedString;
        }
        public static string ContiEnc(int[] cleanText, int[] mKey)
        {
            int[] longKey = new int[mKey.Length + cleanText.Length];
            for (int i = 0; i < longKey.Length; i++)
            {
                if (i < mKey.Length)
                {
                    longKey[i] = mKey[i];
                }
                if (i >= mKey.Length)
                {
                    longKey[i] = cleanText[i - (mKey.Length)] - 64;
                }
            }
            string encodedString = "";
            for (int i = 0; i < cleanText.Length; i++)
            {
                if ((cleanText[i] + longKey[i]) < 91)
                {
                    cleanText[i] += longKey[i];
                    encodedString += (char)cleanText[i];
                }
                else
                {
                    cleanText[i] += longKey[i];
                    encodedString += (char)(cleanText[i]-26);
                }
            }
            return encodedString;
        }
        public static string SingleDec(string encodedString, int[] sKey)
        {
            string decodedString = "";
            for (int i = 0; i < encodedString.Length; i++)
            {
                if(encodedString[i] - sKey[0] > 64)
                {
                    decodedString += (char)(encodedString[i] - sKey[0]);
                }
                else
                {
                    decodedString += (char)((encodedString[i] - sKey[0])+26);
                }
            }
            return decodedString;
        }
        public static string MultiDec(string encodedString, int[] mKey)
        {
            string decodedString = "";
            //for (int i = 0; i < mKey.Length; i++)
            //{
            //    mKey[i] += 64;
            //    Console.WriteLine(mKey[i]);
            //}
            int k = 0;
            int j = 0;
            while (k < encodedString.Length)
            {
                if (j == mKey.Length) j = 0;
                if(encodedString[k] - mKey[j] > 64)
                {
                    decodedString += (char)(encodedString[k] - mKey[j]);
                }
                else
                {
                    decodedString += (char)((encodedString[k] - mKey[j])+26);
                }
                k++;
                j++;
            }
            return decodedString;
        }
        public static string ContiDec(string encodedString, int[] mKey)
        {
            for (int i = 0; i < mKey.Length; i++)
            {
                //mKey[i] += 64;
            }
            string decodedString = "";
            for (int i = 0; i < encodedString.Length; i++)
            {
                if(i < mKey.Length)
                {
                    if (encodedString[i] - mKey[i] > 64)
                    {
                        decodedString += (char)(encodedString[i] - mKey[i]);

                    }
                    else
                    {
                        decodedString += (char)((encodedString[i] - mKey[i])+26);
                    }
                }
                else
                {
                    if ((encodedString[i] - ((decodedString[i - mKey.Length]) - 64)) > 64)
                    {
                        decodedString += (char)(encodedString[i] - ((decodedString[i - mKey.Length]) - 64));
                    }
                    else
                    {
                        decodedString += (char)(encodedString[i] - ((decodedString[i - mKey.Length]) - 64) + 26);
                    }
                }
            }
            return decodedString;
        }
    }
}
