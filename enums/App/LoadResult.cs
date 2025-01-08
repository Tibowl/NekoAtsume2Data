
// Namespace: App
public enum LoadResult 
{
	// Fields
	public int value__; // 0x0
	public const LoadResult Succeed = 0;
	public const LoadResult AlreadyLoaded = 1;
	public const LoadResult NotAllowed = 2;
	public const LoadResult EmptyPath = 3;
	public const LoadResult DataVersionTooHigh = 4;
	public const LoadResult AssetVersionTooHigh = 5;
	public const LoadResult DeserializeFailed = 6;
	public const LoadResult ForceCreateFailed = 7;
	public const LoadResult SaveFileNotFound = 8;
	public const LoadResult EmptyFileContent = 9;
	public const LoadResult TestError = 10;
	public const LoadResult ReadError = 11;
	public const LoadResult InspectFailed = 12;
}