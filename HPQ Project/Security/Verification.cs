using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Numerics;
using System.Text.RegularExpressions;

namespace HPQ_Project
{
    static class Verification
    {
        // A function to attempt to register an account, and add it to the database
        // Returns an integer code.
        internal static int regHandle(string username, string password, string email)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                return 1; // Error code 1 if either box is empty.
            }

            if (Databasing.GetAccount(username) != null)
            {
                return 3; // Error code 3 if account already exists.
            }
            
            // Check the email
            string emailPattern = @"^([a-zA-Z0-9]+)(@)([a-zA-Z0-9-]+)(\x2E\w+)+$";
            Regex emailRGX = new Regex(emailPattern);
            if (!emailRGX.IsMatch(email)) 
                return 2; // Error code 2 if email is invalid.

            // Variables
            byte[] Xarr = new byte[128],
                   Yarr = new byte[128];
            BigInteger X = new BigInteger(),
                       Y = new BigInteger();

            // Password encryption
            int len = password.Length;

            // Hashing the password via SHA512, to create a 64-byte array result.
            byte[] data = Encoding.Unicode.GetBytes(password);
            byte[] result = new byte[64];
            SHA512 shaM = SHA512.Create();
            result = shaM.ComputeHash(data);

            // Concaternate it to itself, and then convert to a hex string
            byte[] result1024 = result.Concat(result).ToArray();
            string result256h = Conversions.ByteArrayToHexViaLookup32(result1024);

            // Right shift the hex string by the length of the password, then convert back to a byte array
            string shifted256h = Conversions.rightShift(result256h, len);
            byte[] shifted1024 = Conversions.HexToByte(shifted256h);

            // Generate two 1024-bit primes.
            X = Primes.genPrime();
            Y = Primes.genPrime();
            Yarr = Y.ToByteArray();

            // Transform the prime Y by HK' (shifted hash) by a bitwise XOR
            byte[] transformedY = new byte[128];
            for (int i = 0; i < 128; i++)
            {
                int transformInt = Yarr[i] ^ shifted1024[i];
                transformedY[i] = Convert.ToByte(transformInt);
            }
            // Get the transformed Y integer, and the large prime Z.
            BigInteger trnsY = new BigInteger(transformedY);
            BigInteger Z = BigInteger.Multiply(X, Y);

            // Add this to the database and return a success code.
            Databasing.AddAccount(username, email, Z.ToString(), trnsY.ToString());
            return 0;
        }

        ///
        ///


        // A function to attempt to login as an account, checking it agianst the database.
        internal static int logHandle(string UName, string PWord)
        {
            // Make sure no inputs are empty...
            if (string.IsNullOrWhiteSpace(UName) ||
                string.IsNullOrWhiteSpace(PWord))
            {
                return 1;
            }

            // Get the referenced account (and make sure it exists!)
            Account acc = Databasing.GetAccount(UName);
            if (acc == null) return 2;

            // Get length of password used for verification
            int len = PWord.Length;

            // Hashing the password via SHA-512 for a 64-bit byte array
            byte[] data = Encoding.Unicode.GetBytes(PWord);
            byte[] result = new byte[64];
            SHA512 shaM = SHA512.Create();
            result = shaM.ComputeHash(data);

            // Get the concatenated hash and then convert to a hex string
            byte[] result1024 = result.Concat(result).ToArray();
            string result256h = Conversions.ByteArrayToHexViaLookup32(result1024);

            //Right shift the hex HK to get HK', and make it a byte[]
            string shifted256h = Conversions.rightShift(result256h, len);
            byte[] shifted1024 = Conversions.HexToByte(shifted256h);

            // Read Y' from the database, and XOR it by HK' to make Y
            BigInteger Ytransformed = BigInteger.Parse(acc.Ytrns);
            byte[] Y_orig = new byte[128];
            byte[] YtrnsArr = Ytransformed.ToByteArray();

            for (int i = 0; i < 128; i++)
            {
                int transformInt = YtrnsArr[i] ^ shifted1024[i];
                Y_orig[i] = Convert.ToByte(transformInt);
            }
            BigInteger Y = new BigInteger(Y_orig);
            BigInteger Z = BigInteger.Parse(acc.Zprim);

            BigInteger Check = BigInteger.Remainder(Z, Y);
            if (Check == 0)
                return 0;
            else
                return 3;
        }
    }
}

/*
 * Register result codes:
 * 0 = Success
 * 1 = One or more boxes empty
 * 2 = Email invalid
 * 3 = Account already exists
 * 
 * Login result codes:
 * 0 = Success
 * 1 = Username/pass empty
 * 2 = Account does not exist
 * 3 = Invalid username/password
*/