
/// <summary>
/// Represents a series of method extensions for the Random class.
/// </summary>
public static class RandomExtensions
{
    /// <summary>
    /// Returns a double from 0 to the specified max range.
    /// </summary>
    /// <param name="max">Max number that can be returned.</param>
    /// <returns>A double within 0 to the specified max.</returns>
    public static double NextDouble(this Random random, double max) => random.NextDouble() * max;

    /// <summary>
    /// Selects a string at random based on the number of strings passed with an equal chance of returning fsor each string.
    /// </summary>
    /// <param name="items">A series of strings.</param>
    /// <returns>Returns a string at random.</returns>
    public static string NextString(this Random random, params string[] items)
    {
        double frequency = 1 / items.Length;
        double chance = random.NextDouble();
        string chosenString = string.Empty;

        for (int i = 0; i < items.Length; i++)
        {
            if (chance <= frequency * i)
            {
                chosenString = items[i];
            }
        }
        return chosenString;
    }

    /// <summary>
    /// Determines whether a coin toss results in heads or tails.
    /// </summary>
    /// <param name="chanceOfHeads">Probability that heads will be chosen.</param>
    /// <returns>Returns true for heads and false for tails.</returns>
    public static bool CoinFlip(this Random random, double chanceOfHeads = 0.5) => random.NextDouble() <= chanceOfHeads;
    
}