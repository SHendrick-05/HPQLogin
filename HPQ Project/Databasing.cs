using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace HPQ_Project
{
    public class Account  // An account class that will be used for interfacing with the database
    {


        // A simple constructor method
        public Account(string UN, string EM, string ZP, string YT)
        {
            Uname = UN;
            Email = EM;
            Zprim = ZP;
            Ytrns = YT;
        }
        // Simple properties, only what is stored in DB
        public string Uname { get; set; }
        public string Email { get; set; }
        public string Zprim { get; set; }
        public string Ytrns { get; set; }
    }

    internal static class Databasing
    {
        public static string dbPath = "database.xlsx";//Properties.Resources.databasePath;

        // Constructor method, to verify existence of the database
        static Databasing()
        {
            if (!System.IO.File.Exists(dbPath))
            {
                // Database file not found, create one.
                var exApp = new Excel.Application();
                var wb = exApp.Workbooks.Add();

                // Format columns A-D as text
                exApp.get_Range("A:A").NumberFormat = "@";
                exApp.get_Range("B:B").NumberFormat = "@";
                exApp.get_Range("C:C").NumberFormat = "@";
                exApp.get_Range("D:D").NumberFormat = "@";

                // Small labels for manual requirements
                exApp.get_Range("A1").Value = "Username";
                exApp.get_Range("B1").Value = "Email";
                exApp.get_Range("C1").Value = "Z";
                exApp.get_Range("D1").Value = "Y'";
                
                // Save the result
                string x = Path.GetFullPath(dbPath);
                wb.SaveAs(Path.GetFullPath(dbPath));
                exApp.Quit();
            }
        }

        // A global list of accounts used to save to and load from the database
        private static List<Account> Accounts = new List<Account>();

        // DERIVED METHODS //

        // Add an account to the list, save to DB. Wrapper.
        internal static void AddAccount(string UN, string EM, string ZP, string YT)
        {
            Accounts.Add(new Account(UN, EM, ZP, YT));
            _Save();
        }

        // Get username, return Account object.
        internal static Account GetAccount(string UName)
        {
            foreach (Account acc in Accounts)
            {
                if (acc.Uname == UName)
                    return acc;
            }
            return null;
        }

        // SECOND ORDER MANAGEMENT //

        // Wrappers
        internal static void _Save()
        {
            SaveAccs(Accounts);
        }

        internal static void _Load()
        {
            Accounts = LoadAccs();
        }

        // DATABASE INTERACTION //

        // VERY IMPORTANT: USE Path.GetFullPath(dbPath) instead of dbPath, otherwise it will save to Documents instead of the source file.

        // Save all accounts from the list into the database
        private static void SaveAccs(List<Account> toSave)
        {
            // Load the database
            var exApp = new Excel.Application();
            var wb = exApp.Workbooks.Open(Path.GetFullPath(dbPath));

            // Loop over all items in the accounts list
            for (int i = 0; i < toSave.Count; i++)
            {
                Account acc = toSave[i];
                string iStr = (i+2).ToString();


                // Save each value to the database
                exApp.get_Range("A" + iStr).Value = acc.Uname;
                exApp.get_Range("B" + iStr).Value = acc.Email;
                exApp.get_Range("C" + iStr).Value = acc.Zprim;
                exApp.get_Range("D" + iStr).Value = acc.Ytrns;
            }
            // Close the database
            wb.Save();
            exApp.Quit();
        }



        // Load all accounts from the database into the list, overwriting any data from the list.
        private static List<Account> LoadAccs()
        {
            // Result variable
            List<Account> result = new List<Account>();

            // Load up the database
            var exApp = new Excel.Application();
            var wb = exApp.Workbooks.Open(Path.GetFullPath(dbPath));

            // Loop over all values in database
            // Halt when the next value is null
            int i = 2;
            while (exApp.get_Range("A" + (i).ToString()).Value2 != null)
            {
                // Load each value from the database
                string iStr = i.ToString();
                string Uname = exApp.get_Range("A" + iStr).Value;
                string Email = exApp.get_Range("B" + iStr).Value;
                string Zprim = exApp.get_Range("C" + iStr).Value;
                string Ytrns = exApp.get_Range("D" + iStr).Value;
                
                //Add it to the account.
                result.Add(new Account(Uname, Email, Zprim, Ytrns));
                i++;
            } 

            // Close the database
            exApp.Quit();

            return result;
        }

    }
}
