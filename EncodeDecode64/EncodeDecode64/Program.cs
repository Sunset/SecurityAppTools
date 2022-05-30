using System;

namespace EncodeDecode64
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string passText = "This is a password";

            Console.WriteLine("Begin Encode Process");
            Console.WriteLine("This is your password: {0}", passText);
            var convertToBytes = System.Text.Encoding.UTF8.GetBytes(passText);
            var encoded = System.Convert.ToBase64String(convertToBytes);
            Console.WriteLine("This is your encoded password: {0}", encoded);
            Console.WriteLine("End Encode Process");

            Console.WriteLine("Begin Decode Process");
            var convertFromBytes = System.Convert.FromBase64String(encoded);
            Console.WriteLine("This is your Converted from base64 bytes, {0}", string.Join(", ", convertFromBytes));
            var decoded = System.Text.Encoding.UTF8.GetString(convertFromBytes);
            Console.WriteLine("This is your password: {0}", decoded);
            Console.WriteLine("End decode process");
        }
    }
}
