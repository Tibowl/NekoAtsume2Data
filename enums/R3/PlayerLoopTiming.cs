
// Namespace: R3
internal enum PlayerLoopTiming 
{
	// Fields
	public int value__; // 0x0
	public const PlayerLoopTiming Initialization = 0;
	public const PlayerLoopTiming EarlyUpdate = 1;
	public const PlayerLoopTiming FixedUpdate = 2;
	public const PlayerLoopTiming PreUpdate = 3;
	public const PlayerLoopTiming Update = 4;
	public const PlayerLoopTiming PreLateUpdate = 5;
	public const PlayerLoopTiming PostLateUpdate = 6;
	public const PlayerLoopTiming TimeUpdate = 7;
	public const PlayerLoopTiming PostFixedUpdate = 8;
}