/// <summary>
/// Manages a collection of InventoryItems, bound by constraints such as weight, volume, and capacity.
/// </summary>
class Pack
{
    public int MaxItems { get; }
    public float MaxWeight { get; }
    public float MaxVolume { get; }
    public int ItemsInPack { get; private set; } = 0;
    public float Weight { get; private set; } = 0;
    public float Volume { get; private set; } = 0;
    public InventoryItem[] BackPack;
    public Pack(int maxItems, float maxWeight, float maxVoume)
    {
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVoume;

        BackPack = new InventoryItem[maxItems];
    }

    public bool Add(InventoryItem item)
    {
        if ((Weight + item.Weight < MaxWeight) && (Volume + item.Volume < MaxVolume) && (ItemsInPack < MaxItems))
        {
            BackPack[ItemsInPack] = item;

            Weight += item.Weight;
            Volume += item.Volume;
            ItemsInPack++;

            return true;
        }
        return false;
    }
}