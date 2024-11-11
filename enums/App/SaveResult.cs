
// Namespace: App
public enum SaveResult 
{
	// Fields
	public int value__; // 0x0
	public const SaveResult Succeed = 0;
	public const SaveResult NotAllowed = 1;
	public const SaveResult EmptyData = 2;
	public const SaveResult NotModified = 3;
	public const SaveResult EmptyPath = 4;
	public const SaveResult SerializeError = 5;
	public const SaveResult TestError = 6;
	public const SaveResult WriteError = 7;
}