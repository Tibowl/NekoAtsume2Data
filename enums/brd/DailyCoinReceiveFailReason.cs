
// Namespace: 
internal enum brd.DailyCoinReceiveFailReason 
{
	// Fields
	public int value__; // 0x0
	public const brd.DailyCoinReceiveFailReason None = 0;
	[Label("所持数MAX", 0)]
	public const brd.DailyCoinReceiveFailReason WalletCountMax = 1;
	[Label("日次制限", 0)]
	public const brd.DailyCoinReceiveFailReason DailyCountMax = 2;
	[Label("週次制限", 0)]
	public const brd.DailyCoinReceiveFailReason WeeklyAmountMax = 3;
}