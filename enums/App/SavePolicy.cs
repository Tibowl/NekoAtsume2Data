
// Namespace: App
[Flags]
public enum SavePolicy 
{
	// Fields
	public int value__; // 0x0
	public const SavePolicy None = 0;
	public const SavePolicy WriteIfNotChanged = 2;
	public const SavePolicy WriteIfDenied = 4;
	public const SavePolicy All = 6;
}