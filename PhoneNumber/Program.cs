// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


PhoneNumber ph = new PhoneNumber();

Console.WriteLine(ph.Clean("(223) 456-7890"));
Console.WriteLine(ph.Clean("12234567890"));
Console.WriteLine(ph.Clean("(223) 456 - 7890)"));
Console.WriteLine(ph.Clean("223.456.7890"));
Console.WriteLine(ph.Clean("223 456   7890   "));
Console.WriteLine(ph.Clean("123456789"));
Console.WriteLine(ph.Clean("12234567890"));
Console.WriteLine(ph.Clean("+1 (223) 456-7890"));

Console.ReadLine();


public class PhoneNumber
{
    public string Clean(string phoneNumber)
    {
        string cleanNumber = "";
        string trimmedPhone = phoneNumber.Trim();

        //remove special chars
        for (int i = 0; i < trimmedPhone.Length; i++)
        {
            if (Char.IsDigit(trimmedPhone[i]))
            {
                cleanNumber += trimmedPhone[i];
            }
        }

        //check if first digit is 0
        if (cleanNumber.StartsWith("0"))
        {
            //throw new ArgumentException(cleanNumber + " must be 9 digits");
            Console.WriteLine($"{cleanNumber} cannot start with 0");

        }

        //check if first digit is 1
        if (cleanNumber.StartsWith("1"))
        {
            //remove first digit if it is 1
            cleanNumber = cleanNumber.Remove(0, 1);

        }

        // check if exchange starts with 1 or 0
        if (cleanNumber.Substring(3, 1) == "0" || cleanNumber.Substring(3, 1) == "1") 
        {
            //throw new ArgumentException(cleanNumber + " must be 9 digits");
            Console.WriteLine($"{cleanNumber} exchange cannot start with 0 or 1");
        }

        // check if exchange starts with 1 or 0
        if (cleanNumber.Substring(0, 1) == "0" || cleanNumber.Substring(0, 1) == "1")
        {
            //throw new ArgumentException(cleanNumber + " must be 9 digits");
            Console.WriteLine($"{cleanNumber} area code cannot start with 0 or 1");
        }

        if (cleanNumber.Length != 10)
        {
            //throw new ArgumentException(cleanNumber + " must be 9 digits");
            Console.WriteLine($"{cleanNumber} is not 10 digits.");
        }

        return cleanNumber;
    }
}