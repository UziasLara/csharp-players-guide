/// <summary>
/// Represents a class used to filter delegate methods.
/// </summary>
class Sieve
{
    Func<int, bool> _checkNumber;
    public Sieve(Func<int, bool> function)
    {
        _checkNumber = function;
    }
    public bool IsGood(int number) => _checkNumber(number);

}

