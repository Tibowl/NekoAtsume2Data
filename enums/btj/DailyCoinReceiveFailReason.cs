
// Namespace: 
internal enum btj.DailyCoinReceiveFailReason 
{
	// Fields
	public int value__; // 0x0
	public const btj.DailyCoinReceiveFailReason None = 0;
	[Label("所持数MAX", 0)]
	public const btj.DailyCoinReceiveFailReason WalletCountMax = 1;
	[Label("日次制限", 0)]
	public const btj.DailyCoinReceiveFailReason DailyCountMax = 2;
	[Label("週次制限", 0)]
	public const btj.DailyCoinReceiveFailReason WeeklyAmountMax = 3;
}