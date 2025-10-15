
// Namespace: R3
public enum AwaitOperation 
{
	// Fields
	public int value__; // 0x0
	public const AwaitOperation Sequential = 0;
	public const AwaitOperation Drop = 1;
	public const AwaitOperation Switch = 2;
	public const AwaitOperation Parallel = 3;
	public const AwaitOperation SequentialParallel = 4;
	public const AwaitOperation ThrottleFirstLast = 5;
}