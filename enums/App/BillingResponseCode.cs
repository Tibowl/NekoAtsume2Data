
// Namespace: App
public enum BillingResponseCode 
{
	// Fields
	public int value__; // 0x0
	public const BillingResponseCode Ok = 0;
	public const BillingResponseCode UserCancelled = 1;
	public const BillingResponseCode ServiceUnavailable = 2;
	public const BillingResponseCode BillingUnavailable = 3;
	public const BillingResponseCode ItemUnavailable = 4;
	public const BillingResponseCode DeveloperError = 5;
	public const BillingResponseCode Error = 6;
	public const BillingResponseCode ItemAlreadyOwned = 7;
	public const BillingResponseCode ItemNotOwned = 8;
	public const BillingResponseCode NetworkError = 12;
	public const BillingResponseCode ServiceDisconnected = -1;
	public const BillingResponseCode FeatureNotSupported = -2;
	public const BillingResponseCode ServiceTimeout = -3;
}