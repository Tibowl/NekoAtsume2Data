
// Namespace: App
[Flags]
public enum GoodsStatusFilter 
{
	// Fields
	public int value__; // 0x0
	public const GoodsStatusFilter None = 0;
	public const GoodsStatusFilter Owned = 1;
	public const GoodsStatusFilter NotOwned = 2;
	public const GoodsStatusFilter SizeS = 4;
	public const GoodsStatusFilter SizeL = 8;
	public const GoodsStatusFilter New = 16;
	public const GoodsStatusFilter Break = 32;
	public const GoodsStatusFilter Repair = 64;
	public const GoodsStatusFilter NewArrival = 128;
	public const GoodsStatusFilter LimitedMonth = 256;
}