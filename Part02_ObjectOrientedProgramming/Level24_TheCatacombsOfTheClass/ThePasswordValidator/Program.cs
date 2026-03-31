// Wrie a program to validate a password with the following requirements.
// Password must contain a capital letter, a lowercase letter, a digit, and be between 6 and 13 characters long (inclusive).
// Password must not contain a capital letter 'T' or the ampersand symbol '&'.
// See book for more details.

Validate();

void Validate()
{
    Console.Clear();

    Console.Write("Let's validate your password: ");
    while(true)
    {
        string? password = Console.ReadLine();

        if (password != null) 
        {
            if(PasswordValidator.Validate(password)) break;
        }
        Console.WriteLine("Invalid password. Try again. ");
    }
    Console.WriteLine("Your password is valid.");
}

class PasswordValidator
{
    private readonly static int _minLength = 6;
    private readonly static int _maxLength = 13;
    private static bool IsPasswordInRange(string password) => (password.Length >= _minLength && password.Length <= _maxLength);
    public static bool Validate(string password)
    {
        if (IsPasswordInRange(password))
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            
            bool hasLetterT = false;
            bool hasSymbolAmpersand = false;

            foreach (char letter in password)
            {
                if (letter == 'T' ) { hasLetterT = true; hasUpper = true; continue; }
                if (letter == '&' ) { hasSymbolAmpersand = true; continue; }
                if (char.IsUpper(letter)) { hasUpper = true; continue; }
                if (char.IsLower(letter)) { hasLower = true; continue; }
                if (char.IsDigit(letter)) { hasDigit = true; continue; }
            }            
            if (hasUpper && hasLower && hasDigit && !hasLetterT && !hasSymbolAmpersand ) return true;
        }
        return false;
    }
}