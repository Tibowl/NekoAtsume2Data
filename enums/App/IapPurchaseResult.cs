
// Namespace: App
public enum IapPurchaseResult 
{
	// Fields
	public int value__; // 0x0
	public const IapPurchaseResult PurchaseStarted = 0;
	public const IapPurchaseResult NotInitalized = 1;
	public const IapPurchaseResult InvalidSku = 2;
	public const IapPurchaseResult TierDowngrade = 3;
	public const IapPurchaseResult TierSame = 4;
	public const IapPurchaseResult TierUnknown = 5;
}