using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string plain_text = Util.GetPlainText();
            string single_key = Util.GetSingleKey();
            string multi_key = Util.GetMultiKey();
            Console.WriteLine();
            Console.WriteLine($"You entered [{plain_text}] as plain text");
            Console.WriteLine($"You entered [{single_key}] as your single key");
            Console.WriteLine($"You entered [{multi_key}] as your multi key");
            Console.WriteLine();
            int[] clean_text = Util.Clean(plain_text);
            int[] clean_skey = Util.Clean(single_key);
            int[] clean_mkey = Util.Clean(multi_key);
            Console.WriteLine();
            string enc_single = Util.SingleEnc(clean_text, clean_skey);
            Console.WriteLine($"Encrypted message with single key is[{enc_single}]");
            string dec_single = Util.SingleDec(enc_single, clean_skey);
            Console.WriteLine($"Decrypted message with single key is [{dec_single}]");
            Console.WriteLine();
            plain_text = dec_single;
            clean_text = Util.Clean(plain_text);
            string enc_multi = Util.MultiEnc(clean_text, clean_mkey);
            Console.WriteLine($"Encrypted message with multi key is[{enc_multi}]");
            string dec_multi = Util.MultiDec(enc_multi, clean_mkey);
            Console.WriteLine($"Decrypted message with multi key is [{dec_multi}]");
            Console.WriteLine();
            plain_text = dec_multi;
            clean_text = Util.Clean(plain_text);
            string enc_conti = Util.ContiEnc(clean_text, clean_mkey);
            Console.WriteLine($"Encrypted message with continuous key is[{enc_conti}]");
            string dec_conti = Util.ContiDec(enc_conti, clean_mkey);
            Console.WriteLine($"Decrypted message with continuous key is [{dec_conti}]");
        }
    }
}
