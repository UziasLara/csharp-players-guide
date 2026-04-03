/// <summary>
/// Provides a base class for all inventory items that can be stored in a Pack.
/// Tracks their properties, such as weight and volume.
/// </summary>
class InventoryItem {
    public float Weight { get; protected set; }
    public float Volume { get; protected set; }

    public InventoryItem(float weight, float volumne)
    {
        Weight = weight;
        Volume = volumne;
    }
}