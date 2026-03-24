// Create a program displaying all 14 variable types described in this level and display them.
// Update the program with new values for each variable.

sbyte minSByte = -128;
sbyte maxSByte = 127;

byte minByte = -0;
byte maxByte = 255;

short minShort = -32768;
short maxShort = 32767;

ushort minUShort = 0;
ushort maxUShort = 65535;

int minInt = -2147483648;
int maxInt = 2147483647;

uint minUInt = 0;
uint maxUInt = 4294967295;

long minLong = -9223372036854775808;
long maxLong = 9223372036854775807;

ulong minULong = 0;
ulong maxULong = 18446744073709551615;

float minFloat = -3.4028235E+38f;
float maxFloat = 3.4028235E+38f;

double minDouble = -1.7976931348623157E+308;
double maxDouble = 1.7976931348623157E+308;

decimal minDecimal = -79228162514264337593543950335m;
decimal maxDecimal = 79228162514264337593543950335m;

string firstName = "John";
string lastName = "Doe";
char firtNameInitial = 'J';
char lastNameInitial = 'D';

bool isMyName = false;

// Console.WriteLine($"type ranges from {type.MinValue} to {type.MaxValue}");
// could also be used to avoid writing out variable names but it would not satisfy the requirements.

Console.WriteLine($"sbyte ranges from: {minSByte} to {maxSByte}");
Console.WriteLine($"byte ranges from: {minByte} to {maxByte}");
Console.WriteLine($"short ranges from: {minShort} to {maxShort}");
Console.WriteLine($"ushort ranges from: {minUShort} to {maxUShort}");
Console.WriteLine($"int ranges from: {minInt} to {maxInt}");
Console.WriteLine($"uint ranges from: {minUInt} to {maxUInt}");
Console.WriteLine($"long ranges from: {minLong} to {maxLong}");
Console.WriteLine($"ulong ranges from: {minULong} to {maxULong}");
Console.WriteLine($"float ranges from: {minFloat} to {maxFloat}");
Console.WriteLine($"double ranges from: {minDouble} to {maxDouble}");
Console.WriteLine($"decimal ranges from: {minDecimal} to {maxDecimal}");
Console.WriteLine();
Console.WriteLine($"Default name is {firstName} {lastName} with initials as {firtNameInitial}. {lastNameInitial}.");
Console.WriteLine($"Is that my name? {isMyName}");