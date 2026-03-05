
// Namespace: App
public enum PhotoGenMethod 
{
	// Fields
	public int value__; // 0x0
	[InspectorName("通常写真")]
	public const PhotoGenMethod Default = 0;
	[InspectorName("どアップ")]
	public const PhotoGenMethod CloseUp = 1;
	[InspectorName("どアップ ピンぼけver")]
	public const PhotoGenMethod CloseUpBlur = 2;
}