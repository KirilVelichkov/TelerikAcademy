using System;
/*
Problem 12.	Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, 3 credit card numbers associated with the account. 
Declare the variables needed to keep the information for a single bank account using the appropriate data 
types and descriptive names.
*/
class BankData
{
    static void Main()
    {
        string FirstName = "Ivan";
        string MiddleName = "Georgiev";
        string LastName = "Ivanov";
        decimal Balance = 123456789.9876M;
        string BankName = "BNB";
        string IBAN = "IBG123456789";
        ulong Card1 = 12345678910111213;
        ulong Card2 = 12345678910111214;
        ulong Card3 = 12345678910111215;
    }
}
