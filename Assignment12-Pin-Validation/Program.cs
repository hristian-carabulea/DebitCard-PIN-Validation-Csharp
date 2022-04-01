class AssignmentPINValidation
{
    static void Main()
    {
        DebitCard debitCard = new DebitCard();

        System.Console.Write("Enter a 4-digit or 6-digit PIN: ");
        debitCard.PIN = System.Console.ReadLine();

        //debitCard.PIN = "12345"; //Output: PIN contains one or more non-digit characters.
        System.Console.WriteLine(debitCard.PIN); //Output: null (shown as blank)

        System.Console.WriteLine("Enter any key to end ");
        System.Console.ReadKey();

    }
}
