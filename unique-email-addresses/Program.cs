using System;

namespace unique_email_addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new String[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            var sonuc = NumUniqueEmails(arr);
            Console.WriteLine("Sonuc: " + sonuc);

        }

        public static int NumUniqueEmails(string[] emails)
        {


            return emails.Length;
        }

    }
}
