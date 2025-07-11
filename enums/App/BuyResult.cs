
// Namespace: App
public enum BuyResult 
{
	// Fields
	public int value__; // 0x0
	public const BuyResult Success = 0;
	public const BuyResult NoMoney = 1;
	public const BuyResult FullCapacity = 2;
	public const BuyResult CalcError = 3;
	public const BuyResult InvalidCurrency = 4;
	public const BuyResult CurrencyMismatch = 5;
	public const BuyResult InvalidPrice = 6;
	public const BuyResult RenewError = 7;
	public const BuyResult OtherError = 8;
}