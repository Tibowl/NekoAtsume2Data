
// Namespace: App
[Flags]
public enum CatFilterType 
{
	// Fields
	public int value__; // 0x0
	public const CatFilterType None = 0;
	public const CatFilterType Normal = 1;
	public const CatFilterType Rare = 2;
	public const CatFilterType Myneko = 4;
	public const CatFilterType Other = 8;
	public const CatFilterType Unknown = 16;
	public const CatFilterType NormalAndRare = 3;
	public const CatFilterType All = -1;
}