
// Namespace: App.Save
public enum FavoriteAddResult 
{
	// Fields
	public int value__; // 0x0
	public const FavoriteAddResult Ok = 0;
	public const FavoriteAddResult FullCapacity = 1;
	public const FavoriteAddResult IsOwned = 2;
	public const FavoriteAddResult DataVersionTooHigh = 3;
	public const FavoriteAddResult InvalidData = 4;
}