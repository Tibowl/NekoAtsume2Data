
// Namespace: App
public enum PhotoGenMethod 
{
	// Fields
	public int value__; // 0x0
	[InspectorName("庭先ランダム撮影")]
	public const PhotoGenMethod YardRandom = 0;
	[InspectorName("どアップ顔")]
	public const PhotoGenMethod FaceUp = 1;
	[InspectorName("おしりアップ1")]
	public const PhotoGenMethod HipUp = 2;
	[InspectorName("おしりアップ2")]
	public const PhotoGenMethod HipUp2 = 3;
	[InspectorName("ゴハンを食べる")]
	public const PhotoGenMethod Eat = 4;
	[InspectorName("カメラ近づき")]
	public const PhotoGenMethod SuwariUp = 5;
	[InspectorName("びっくり")]
	public const PhotoGenMethod Shock = 6;
	[InspectorName("のび")]
	public const PhotoGenMethod Stretch = 7;
	[InspectorName("走る")]
	public const PhotoGenMethod Run = 8;
	[InspectorName("歩く")]
	public const PhotoGenMethod Walk = 9;
}