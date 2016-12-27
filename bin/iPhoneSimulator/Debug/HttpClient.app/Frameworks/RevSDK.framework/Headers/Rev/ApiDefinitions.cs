using Foundation;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double RevSDKVersionNumber;
	[Field ("RevSDKVersionNumber", "__Internal")]
	double RevSDKVersionNumber { get; }

	// extern const unsigned char [] RevSDKVersionString;
	[Field ("RevSDKVersionString", "__Internal")]
	byte[] RevSDKVersionString { get; }
}

// @interface RevSDK : NSObject
[BaseType (typeof(NSObject))]
interface RevSDK
{
	// +(void)startWithSDKKey:(NSString *)aSDKKey;
	[Static]
	[Export ("startWithSDKKey:")]
	void StartWithSDKKey (string aSDKKey);
}
