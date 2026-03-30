// Write Door class that can change states (open, close, locked)
// Allow the door to unlock given a numeric passcode. 
// See book for complete details.
// For simplicity, this code has minimal input validation.

DoorPlay();

// Get integer from user
int GetInt(string text)
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

// Prompt user for door actions
void DoorPlay()
{
    Console.Clear();

    Door door = new Door(GetInt("Please enter a numeric passcode for your door: "));

    while (true)
    {
        Console.WriteLine($"Your door is {door.State}. What would you like to do next? (lock, unlock, open, close, change passcode)");
        string? userAction = Console.ReadLine() ?? "";

        switch (userAction)
        {
            case "unlock":
                door.Unlock(GetInt("What is your current passcode? "));
                break;

            case "lock":
                door.Lock();
                break;

            case "open":
                door.Open();
                break;

            case "close":
                door.Close();
                break;

            case "change passcode":
                door.ChangePasscode(GetInt("What's the current passcode? "), GetInt("What's the new passcode? "));
                break;
        }
    }
}

class Door
{
    public int Passcode { get; private set; }
    public DoorState State { get; private set; } = DoorState.Lock;
    public Door(int passcode)
    {
        Passcode = passcode;
    }

    public void ChangePasscode(int current, int next) => Passcode = (current == Passcode) ? next : Passcode;
    public void Lock() => State = (State == DoorState.Close) ? DoorState.Lock : State;
    public void Unlock(int passcode) => State = (State == DoorState.Lock && passcode == Passcode) ? DoorState.Close : State;
    public void Open() => State = (State == DoorState.Close) ? DoorState.Open : State;
    public void Close() => State = (State == DoorState.Open) ? DoorState.Close : State;
}

// Use enums to define Door states
enum DoorState { Open, Close, Lock }