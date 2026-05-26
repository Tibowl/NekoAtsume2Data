
// Namespace: 
internal enum brk.DailyCoinReceiveFailReason 
{
	// Fields
	public int value__; // 0x0
	public const brk.DailyCoinReceiveFailReason None = 0;
	[Label("所持数MAX", 0)]
	public const brk.DailyCoinReceiveFailReason WalletCountMax = 1;
	[Label("日次制限", 0)]
	public const brk.DailyCoinReceiveFailReason DailyCountMax = 2;
	[Label("週次制限", 0)]
	public const brk.DailyCoinReceiveFailReason WeeklyAmountMax = 3;
}