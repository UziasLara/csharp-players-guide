/// <summary>
/// Represents a Sword of different qualities
/// </summary>
/// <param name="Material">enum representing the Sword's material</param>
/// <param name="Gemstone">enum representing the Sword's gemstone</param>
/// <param name="Length">Represents the sword's length</param>
/// <param name="CrossguardWidth">Represents the Sword's crossguard width</param>
public record Sword(Material Material, Gemstone Gemstone, int Length, int CrossguardWidth);

public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { Emerald, Amber, Sapphire, Diamond, Bitstone, None }