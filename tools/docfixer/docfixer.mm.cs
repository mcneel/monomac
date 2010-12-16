//
// MonoTouch defines for docfixer
//
using System;

public partial class DocGenerator {
	Assembly assembly = typeof (MonoMac.Foundation.NSObject).Assembly;
	const string BaseNamespace = "MonoMac";
	
	static string GetMostRecentDocBase ()
	{
		return "/Developer/Documentation/DocSets/com.apple.adc.documentation.AppleSnowLeopard.CoreReference.docset/Contents/Resources/Documents/documentations";
	}

}