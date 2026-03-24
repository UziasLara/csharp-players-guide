// Create a program displaying all 14 variable types described in this level and display them.

sbyte minSByte = sbyte.MinValue;
sbyte maxSByte = sbyte.MaxValue;

byte minByte = byte.MinValue;
byte maxByte = byte.MaxValue;

short minShort = short.MinValue;
short maxShort = short.MaxValue;

ushort minUShort = ushort.MinValue;
ushort maxUShort = ushort.MaxValue;

int minInt = int.MinValue;
int maxInt = int.MaxValue;

uint minUInt = uint.MinValue;
uint maxUInt = uint.MaxValue;

long minLong = long.MinValue;
long maxLong = long.MaxValue;

ulong minULong = ulong.MinValue;
ulong maxULong = ulong.MaxValue;

float minFloat = float.MinValue;
float maxFloat = float.MaxValue;

double minDouble = double.MinValue;
double maxDouble = double.MaxValue;

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;

string firstName = "Uzias";
string lastName = "Lara";
char firtNameInitial = 'U';
char lastNameInitial = 'L';

bool isChallengeComplete = true;

// Console.WriteLine($"type ranges from {type.MinValue} to {type.MaxValue}");
// could also be used but would not satisfy the requirements.

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
Console.WriteLine($"My name is {firstName} {lastName} with initials as {firtNameInitial}. {lastNameInitial}.");
Console.WriteLine($"Is this challenge complete? {isChallengeComplete}");