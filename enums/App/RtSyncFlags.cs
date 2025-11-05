
// Namespace: App
[Flags]
internal enum RtSyncFlags 
{
	// Fields
	public int value__; // 0x0
	public const RtSyncFlags None = 0;
	public const RtSyncFlags Pos = 1;
	public const RtSyncFlags Size = 2;
	public const RtSyncFlags Rot = 4;
	public const RtSyncFlags PosSize = 3;
	public const RtSyncFlags All = 7;
}