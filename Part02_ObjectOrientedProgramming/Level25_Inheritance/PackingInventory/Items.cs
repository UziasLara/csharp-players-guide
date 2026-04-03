/// <summary>
/// Represents Arrow item
/// </summary>
class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f)
    {

    }
}

/// <summary>
/// Represents Bow item
/// </summary>
class Bow : InventoryItem
{
    public Bow() : base(1f, 4f)
    {

    }
}

/// <summary>
/// Represents Rope item
/// </summary>
class Rope : InventoryItem
{
    public Rope() : base(1, 1.5f)
    {

    }
}

/// <summary>
/// Represents Water item
/// </summary>
class Water : InventoryItem
{
    public Water() : base(2f, 3f)
    {
        
    }
}

/// <summary>
/// Represents Food item
/// </summary>
class Food : InventoryItem
{
    public Food() : base(1f, 0.5f)
    {
        
    }
}

/// <summary>
/// Represents Sword item
/// </summary>
class Sword : InventoryItem
{
    public Sword() : base(5f, 3f)
    {
        
    }
}