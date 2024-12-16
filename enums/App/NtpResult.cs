
// Namespace: App
public enum NtpResult 
{
	// Fields
	public int value__; // 0x0
	public const NtpResult Ok = 0;
	public const NtpResult InvalidResponse = 1;
	public const NtpResult SocketError = 2;
	public const NtpResult Timeout = 3;
	public const NtpResult ServerNotReachable = 4;
	public const NtpResult UnexpectedError = 5;
}