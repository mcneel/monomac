//
// Copyright 2010, 2011 Novell, Inc.
// Copyright 2011, Xamarin, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using MonoMac.ObjCRuntime;

#if !MAC64
#error this file is specifically for a 64 bit build
#endif

namespace MonoMac.AppKit {
	/*
	public enum  : ulong { // NSUInteger
		NSTextReadInapplicableDocumentTypeError = 65806,
		NSTextWriteInapplicableDocumentTypeError = 66062,
		NSTextReadWriteErrorMinimum = 65792,
		NSTextReadWriteErrorMaximum = 66303,
		NSServiceApplicationNotFoundError = 66560,
		NSServiceApplicationLaunchFailedError = 66561,
		NSServiceRequestTimedOutError = 66562,
		NSServiceInvalidPasteboardDataError = 66563,
		NSServiceMalformedServiceDictionaryError = 66564,
		NSServiceMiscellaneousError = 66800,
		NSServiceErrorMinimum = 66560,
		NSServiceErrorMaximum = 66817
	}*/
	
	public enum NSCompositingOperation : ulong { // NSUInteger
		Clear = 0,
		Copy = 1,
		SourceOver = 2,
		SourceIn = 3,
		SourceOut = 4,
		SourceAtop = 5,
		DestinationOver = 6,
		DestinationIn = 7,
		DestinationOut = 8,
		DestinationAtop = 9,
		XOR = 10,
		PlusDarker = 11,
		Highlight = 12,
		PlusLighter = 13
	}

	
	public enum NSBackingStoreType : ulong { // NSUInteger
		Retained = 0,
		Nonretained = 1,
		Buffered = 2
	}
	
	public enum NSWindowOrderingMode : long { // NSInteger
		Above = 1,
		Below = -1,
		Out = 0
	}
	
	public enum NSFocusRingPlacement : ulong { // NSUInteger
		RingOnly = 0,
		RingBelow = 1,
		RingAbove = 2
	}

	public enum NSFocusRingType : ulong { //NSUInteger
		Default = 0,
		None = 1,
		Exterior = 2
	}

	public enum NSColorRenderingIntent : long { // NSInteger
		Default = 0,
		AbsoluteColorimetric = 1,
		RelativeColorimetric = 2,
		Perceptual = 3,
		Saturation = 4
	}
	
	public enum NSWindowDepth : long { // NSInteger
		TwentyfourBitRGB = 520,
		SixtyfourBitRGB = 528,
		OnehundredtwentyeightBitRGB = 544
	}

	public enum NSAnimationEffect : ulong { // NSUInteger
		DisappearingItemDefault = 0,
		Poof = 10
	}
	
	public enum NSImageInterpolation : ulong { // NSUInteger
		Default = 0,
		None = 1,
		Low = 2,
		Medium = 4,
		High = 3
	}

	public enum NSTouchPhase : ulong { // NSUInteger
		NSTouchPhaseBegan = 1,
		NSTouchPhaseMoved = 2,
		NSTouchPhaseStationary = 4,
		NSTouchPhaseEnded = 8,
		NSTouchPhaseCancelled = 16,
		NSTouchPhaseTouching = 7,
		NSTouchPhaseAny = ulong.MaxValue
	}

	public enum NSEventType : ulong { // NSUInteger
		LeftMouseDown = 1,
		LeftMouseUp = 2,
		RightMouseDown = 3,
		RightMouseUp = 4,
		MouseMoved = 5,
		LeftMouseDragged = 6,
		RightMouseDragged = 7,
		MouseEntered = 8,
		MouseExited = 9,
		KeyDown = 10,
		KeyUp = 11,
		FlagsChanged = 12,
		AppKitDefined = 13,
		SystemDefined = 14,
		ApplicationDefined = 15,
		Periodic = 16,
		CursorUpdate = 17,
		ScrollWheel = 22,
		TabletPoint = 23,
		TabletProximity = 24,
		OtherMouseDown = 25,
		OtherMouseUp = 26,
		OtherMouseDragged = 27,
		EventTypeGesture = 29,
		EventTypeMagnify = 30,
		EventTypeSwipe = 31,
		EventTypeRotate = 18,
		EventTypeBeginGesture = 19,
		EventTypeEndGesture = 20,
		EventTypeSmartMagnify = 32,
		EventTypeQuickLook = 33
	}
	
	public enum NSEventMask : ulong {
		LeftMouseDownMask = 2,
		LeftMouseUpMask = 4,
		RightMouseDownMask = 8,
		RightMouseUpMask = 16,
		MouseMovedMask = 32,
		LeftMouseDraggedMask = 64,
		RightMouseDraggedMask = 128,
		MouseEnteredMask = 256,
		MouseExitedMask = 512,
		KeyDownMask = 1024,
		KeyUpMask = 2048,
		FlagsChangedMask = 4096,
		AppKitDefinedMask = 8192,
		SystemDefinedMask = 16384,
		ApplicationDefinedMask = 32768,
		PeriodicMask = 65536,
		CursorUpdateMask = 131072,
		ScrollWheelMask = 4194304,
		TabletPointMask = 8388608,
		TabletProximityMask = 16777216,
		OtherMouseDownMask = 33554432,
		OtherMouseUpMask = 67108864,
		OtherMouseDraggedMask = 134217728,
		EventMaskGesture = 536870912,
		EventMaskMagnify = 1073741824,
		EventMaskSwipe = 2147483648,
		EventMaskRotate = 262144,
		EventMaskBeginGesture = 524288,
		EventMaskEndGesture = 1048576,
		EventMaskSmartMagnify = 4294967296,
		AnyEvent = ulong.MaxValue
	}
	
	public enum NSEventModifierMask : ulong { // NSUInteger
		AlphaShift = 65536,
		Shift = 131072,
		Control = 262144,
		Alternate = 524288,
		Command = 1048576,
		NumericPad = 2097152,
		Help = 4194304,
		Function = 8388608,
		DeviceIndependentModifierFlags = 0xffff0000
	}
	
	public enum NSPointingDeviceType : ulong { // NSUInteger
		NSUnknownPointingDevice = 0,
		NSPenPointingDevice = 1,
		NSCursorPointingDevice = 2,
		NSEraserPointingDevice = 3
	}
	
	public enum NSButtonMask : ulong { // NSUInteger
		NSPenTipMask = 1,
		NSPenLowerSideMask = 2,
		NSPenUpperSideMask = 4
	}
	
	public enum NSEventPhase : ulong { // NSUInteger
		NSEventPhaseNone = 0,
		NSEventPhaseBegan = 1,
		NSEventPhaseStationary = 2,
		NSEventPhaseChanged = 4,
		NSEventPhaseEnded = 8,
		NSEventPhaseCancelled = 16,
		NSEventPhaseMayBegin = 32
	}
	
	public enum NSEventGestureAxis : long { // NSInteger
		NSEventGestureAxisNone = 0,
		NSEventGestureAxisHorizontal = 1,
		NSEventGestureAxisVertical = 2
	}
	
	public enum NSEventSwipeTrackingOptions : ulong { // NSUInteger
		NSEventSwipeTrackingLockDirection = 1,
		NSEventSwipeTrackingClampGestureAmount = 2
	}

	public enum NSKey : ulong { // NSUInteger
		A              = 0x00,
		S              = 0x01,
		D              = 0x02,
		F              = 0x03,
		H              = 0x04,
		G              = 0x05,
		Z              = 0x06,
		X              = 0x07,
		C              = 0x08,
		V              = 0x09,
		B              = 0x0B,
		Q              = 0x0C,
		W              = 0x0D,
		E              = 0x0E,
		R              = 0x0F,
		Y              = 0x10,
		T              = 0x11,
		D1             = 0x12,
		D2             = 0x13,
		D3             = 0x14,
		D4             = 0x15,
		D6             = 0x16,
		D5             = 0x17,
		Equal          = 0x18,
		D9             = 0x19,
		D7             = 0x1A,
		Minus          = 0x1B,
		D8             = 0x1C,
		D0             = 0x1D,
		RightBracket   = 0x1E,
		O              = 0x1F,
		U              = 0x20,
		LeftBracket    = 0x21,
		I              = 0x22,
		P              = 0x23,
		L              = 0x25,
		J              = 0x26,
		Quote          = 0x27,
		K              = 0x28,
		Semicolon      = 0x29,
		Backslash      = 0x2A,
		Comma          = 0x2B,
		Slash          = 0x2C,
		N              = 0x2D,
		M              = 0x2E,
		Period         = 0x2F,
		Grave          = 0x32,
		KeypadDecimal  = 0x41,
		KeypadMultiply = 0x43,
		KeypadPlus     = 0x45,
		KeypadClear    = 0x47,
		KeypadDivide   = 0x4B,
		KeypadEnter    = 0x4C,
		KeypadMinus    = 0x4E,
		KeypadEquals   = 0x51,
		Keypad0        = 0x52,
		Keypad1        = 0x53,
		Keypad2        = 0x54,
		Keypad3        = 0x55,
		Keypad4        = 0x56,
		Keypad5        = 0x57,
		Keypad6        = 0x58,
		Keypad7        = 0x59,
		Keypad8        = 0x5B,
		Keypad9        = 0x5C,
		Return         = 0x24,
		Tab            = 0x30,
		Space          = 0x31,
		Escape         = 0x35,
		Command        = 0x37,
		Shift          = 0x38,
		CapsLock       = 0x39,
		Option         = 0x3A,
		Control        = 0x3B,
		RightShift     = 0x3C,
		RightOption    = 0x3D,
		RightControl   = 0x3E,
		Function       = 0x3F,
		VolumeUp       = 0x48,
		VolumeDown     = 0x49,
		Mute           = 0x4A,
		ForwardDelete  = 0x75,
		UpArrow        = 0xF700,
		DownArrow      = 0xF701,
		LeftArrow      = 0xF702,
		RightArrow     = 0xF703,
		F1             = 0xF704,
		F2             = 0xF705,
		F3             = 0xF706,
		F4             = 0xF707,
		F5             = 0xF708,
		F6             = 0xF709,
		F7             = 0xF70A,
		F8             = 0xF70B,
		F9             = 0xF70C,
		F10            = 0xF70D,
		F11            = 0xF70E,
		F12            = 0xF70F,
		F13            = 0xF710,
		F14            = 0xF711,
		F15            = 0xF712,
		F16            = 0xF713,
		F17            = 0xF714,
		F18            = 0xF715,
		F19            = 0xF716,
		F20            = 0xF717,
		F21            = 0xF718,
		F22            = 0xF719,
		F23            = 0xF71A,
		F24            = 0xF71B,
		F25            = 0xF71C,
		F26            = 0xF71D,
		F27            = 0xF71E,
		F28            = 0xF71F,
		F29            = 0xF720,
		F30            = 0xF721,
		F31            = 0xF722,
		F32            = 0xF723,
		F33            = 0xF724,
		F34            = 0xF725,
		F35            = 0xF726,
		Insert         = 0xF727,
		Delete         = 51,
		Home           = 0xF729,
		Begin          = 0xF72A,
		End            = 0xF72B,
		PageUp         = 0xF72C,
		PageDown       = 0xF72D,
		PrintScreen    = 0xF72E,
		ScrollLock     = 0xF72F,
		Pause          = 0xF730,
		SysReq         = 0xF731,
		Break          = 0xF732,
		Reset          = 0xF733,
		Stop           = 0xF734,
		Menu           = 0xF735,
		User           = 0xF736,
		System         = 0xF737,
		Print          = 0xF738,
		ClearLine      = 0xF739,
		ClearDisplay   = 0xF73A,
		InsertLine     = 0xF73B,
		DeleteLine     = 0xF73C,
		InsertChar     = 0xF73D,
		DeleteChar     = 0xF73E,
		Prev           = 0xF73F,
		Next           = 0xF740,
		Select         = 0xF741,
		Execute        = 0xF742,
		Undo           = 0xF743,
		Redo           = 0xF744,
		Find           = 0xF745,
		Help           = 0xF746,
		ModeSwitch     = 0xF747
	}

	public enum NSEventSubtype : ulong { // NSUInteger
		WindowExposed = 0,
		ApplicationActivated = 1,
		ApplicationDeactivated = 2,
		WindowMoved = 4,
		ScreenChanged = 8,
		AWT = 16
	}

	public enum NSSystemDefinedEvents : ulong { // NSUInteger
		NSPowerOffEventType = 1
	}
/*
public enum  : ulong { // NSUInteger
	NSMouseEventSubtype = 0,
	NSTabletPointEventSubtype = 1,
	NSTabletProximityEventSubtype = 2,
	NSTouchEventSubtype = 3
}
				 */
	public enum NSAnimationCurve : ulong { // NSUInteger
		NSAnimationEaseInOut = 0,
		NSAnimationEaseIn = 1,
		NSAnimationEaseOut = 2,
		NSAnimationLinear = 3
	}
	
	public enum NSAnimationBlockingMode : ulong { // NSUInteger
		Blocking = 0,
		Nonblocking = 1,
		NonblockingThreaded = 2
	}

	public enum NSDragOperation : ulong { // NSUInteger
		None = 0,
		Copy = 1,
		Link = 2,
		Generic = 4,
		Private = 8,
		AllObsolete = 15,
		Move = 16,
		Delete = 32,
		Every = ulong.MaxValue
	}
	
	public enum NSDraggingFormation : long { // NSInteger
		NSDraggingFormationDefault = 0,
		NSDraggingFormationNone = 1,
		NSDraggingFormationPile = 2,
		NSDraggingFormationList = 3,
		NSDraggingFormationStack = 4
	}
	
	public enum NSDraggingContext : long { // NSInteger
		NSDraggingContextOutsideApplication = 0,
		NSDraggingContextWithinApplication = 1
	}
	
	public enum NSDraggingItemEnumerationOptions : ulong { // NSUInteger
		NSDraggingItemEnumerationConcurrent = 1,
		NSDraggingItemEnumerationClearNonenumeratedImages = 65536
	}

	[Flags]
	public enum NSViewResizingMask : ulong { // NSUInteger
		NotSizable = 0,
		MinXMargin = 1,
		WidthSizable = 2,
		MaxXMargin = 4,
		MinYMargin = 8,
		HeightSizable = 16,
		MaxYMargin = 32
	}

	public enum NSBorderType : ulong { // NSUInteger
		NoBorder = 0,
		LineBorder = 1,
		BezelBorder = 2,
		GrooveBorder = 3
	}
	
	public enum NSViewLayerContentsRedrawPolicy : long { // NSInteger
		NSViewLayerContentsRedrawNever = 0,
		NSViewLayerContentsRedrawOnSetNeedsDisplay = 1,
		NSViewLayerContentsRedrawDuringViewResize = 2,
		NSViewLayerContentsRedrawBeforeViewResize = 3
	}
	
	public enum NSViewLayerContentsPlacement : long { // NSInteger
		NSViewLayerContentsPlacementScaleAxesIndependently = 0,
		NSViewLayerContentsPlacementScaleProportionallyToFit = 1,
		NSViewLayerContentsPlacementScaleProportionallyToFill = 2,
		NSViewLayerContentsPlacementCenter = 3,
		NSViewLayerContentsPlacementTop = 4,
		NSViewLayerContentsPlacementTopRight = 5,
		NSViewLayerContentsPlacementRight = 6,
		NSViewLayerContentsPlacementBottomRight = 7,
		NSViewLayerContentsPlacementBottom = 8,
		NSViewLayerContentsPlacementBottomLeft = 9,
		NSViewLayerContentsPlacementLeft = 10,
		NSViewLayerContentsPlacementTopLeft = 11
	}

/*
	public enum  : ulong { // NSUInteger
		NSEnterCharacter = 3,
		NSBackspaceCharacter = 8,
		NSTabCharacter = 9,
		NSNewlineCharacter = 10,
		NSFormFeedCharacter = 12,
		NSCarriageReturnCharacter = 13,
		NSBackTabCharacter = 25,
		NSDeleteCharacter = 127,
		NSLineSeparatorCharacter = 8232,
		NSParagraphSeparatorCharacter = 8233
	}
	*/
	public enum NSTextAlignment : ulong { // NSUInteger
		Left = 0,
		Right = 1,
		Center = 2,
		Justified = 3,
		Natural = 4
	}
	
	public enum NSWritingDirection : long { // NSInteger
		Natural = -1,
		LeftToRight = 0,
		RightToLeft = 1,

		Embedding = 0,
		Override = 2
	}
	/*
	public enum NSWritingDirection : ulong { // NSUInteger
		NSTextWritingDirectionEmbedding = 0,
		NSTextWritingDirectionOverride = 2
	}*/
	
	public enum NSTextMovement : ulong { // NSUInteger
		NSIllegalTextMovement = 0,
		NSReturnTextMovement = 16,
		NSTabTextMovement = 17,
		NSBacktabTextMovement = 18,
		NSLeftTextMovement = 19,
		NSRightTextMovement = 20,
		NSUpTextMovement = 21,
		NSDownTextMovement = 22,
		NSCancelTextMovement = 23,
		NSOtherTextMovement = 0
	}

	public enum NSTextTabType : ulong { // NSUInteger
		NSLeftTabStopType = 0,
		NSRightTabStopType = 1,
		NSCenterTabStopType = 2,
		NSDecimalTabStopType = 3
	}

	public enum NSLineBreakMode : ulong { // NSUInteger
		ByWordWrapping = 0,
		CharWrapping = 1,
		Clipping = 2,
		TruncatingHead = 3,
		TruncatingTail = 4,
		TruncatingMiddle = 5
	}

	public enum NSWorkspaceIconCreationOptions : ulong { // NSUInteger
		NSWorkspaceLaunchAndPrint = 2,
		NSWorkspaceLaunchInhibitingBackgroundOnly = 128,
		NSWorkspaceLaunchWithoutAddingToRecents = 256,
		NSWorkspaceLaunchWithoutActivation = 512,
		NSWorkspaceLaunchAsync = 65536,
		NSWorkspaceLaunchAllowingClassicStartup = 131072,
		NSWorkspaceLaunchPreferringClassic = 262144,
		NSWorkspaceLaunchNewInstance = 524288,
		NSWorkspaceLaunchAndHide = 1048576,
		NSWorkspaceLaunchAndHideOthers = 2097152,
		NSWorkspaceLaunchDefault = 196608
	}
	/*
	public enum NSWorkspaceIconCreationOptions : ulong { // NSUInteger
		NSExcludeQuickDrawElementsIconCreationOption = 2,
		NSExclude10_4ElementsIconCreationOption = 4
	}*/

	public enum NSApplicationActivationOptions : ulong { // NSUInteger
		NSApplicationActivateAllWindows = 1,
		NSApplicationActivateIgnoringOtherApps = 2
	}
	
	public enum NSApplicationActivationPolicy : long { // NSInteger
		NSApplicationActivationPolicyRegular = 0,
		NSApplicationActivationPolicyAccessory = 1,
		NSApplicationActivationPolicyProhibited = 2
	}

	public enum NSRunResponse : long { // NSInteger
		NSRunStoppedResponse = -1000,
		NSRunAbortedResponse = -1001,
		NSRunContinuesResponse = -1002
	}
	
				/*
	public enum  : ulong { // NSUInteger
		NSUpdateWindowsRunLoopOrdering = 500000
	}*/
	
	public enum NSApplicationPresentationOptions : ulong { // NSUInteger
		NSApplicationPresentationDefault = 0,
		NSApplicationPresentationAutoHideDock = 1,
		NSApplicationPresentationHideDock = 2,
		NSApplicationPresentationAutoHideMenuBar = 4,
		NSApplicationPresentationHideMenuBar = 8,
		NSApplicationPresentationDisableAppleMenu = 16,
		NSApplicationPresentationDisableProcessSwitching = 32,
		NSApplicationPresentationDisableForceQuit = 64,
		NSApplicationPresentationDisableSessionTermination = 128,
		NSApplicationPresentationDisableHideApplication = 256,
		NSApplicationPresentationDisableMenuBarTransparency = 512,
	/*}
	
	public enum NSApplicationPresentationOptions : ulong { // NSUInteger*/
		NSApplicationPresentationFullScreen = 1024,
		NSApplicationPresentationAutoHideToolbar = 2048
	}
	
	public enum NSRequestUserAttentionType : ulong { // NSUInteger
		NSCriticalRequest = 0,
		NSInformationalRequest = 10
	}
	
	public enum NSApplicationDelegateReply : ulong { // NSUInteger
		Success = 0,
		Cancel = 1,
		Failure = 2
	}

	public enum NSApplicationTerminateReply : ulong { // NSUInteger
		Cancel = 0,
		Now = 1,
		Later = 2
	}
	
	public enum NSApplicationPrintReply : ulong { // NSUInteger
		Cancelled = 0,
		Success = 1,
		Failure = 3,
		ReplyLater = 2
	}

	public enum NSUserInterfaceLayoutDirection : long { // NSInteger
		LeftToRight = 0,
		RightToLeft = 1
	}

	public enum NSRemoteNotificationType : ulong { // NSUInteger
		None = 0,
		Badge = 1,
		Sound = 2,
		Alert = 4
	}

	public enum NSType : ulong { // NSUInteger
		Any = 0,
		Int = 1,
		PositiveInt = 2,
		Float = 3,
		PositiveFloat = 4,
		Double = 6,
		PositiveDouble = 7
	}
	
	public enum NSCellType : ulong { // NSUInteger
		Null = 0,
		Text = 1,
		Image = 2
	}
	
	public enum NSCellAttribute : ulong { // NSUInteger
		NSCellDisabled = 0,
		NSCellState = 1,
		NSPushInCell = 2,
		NSCellEditable = 3,
		NSChangeGrayCell = 4,
		NSCellHighlighted = 5,
		NSCellLightsByContents = 6,
		NSCellLightsByGray = 7,
		NSChangeBackgroundCell = 8,
		NSCellLightsByBackground = 9,
		NSCellIsBordered = 10,
		NSCellHasOverlappingImage = 11,
		NSCellHasImageHorizontal = 12,
		NSCellHasImageOnLeftOrBottom = 13,
		NSCellChangesContents = 14,
		NSCellIsInsetButton = 15,
		NSCellAllowsMixedState = 16
	}
	
	public enum NSCellImagePosition : ulong { // NSUInteger
		NoImage = 0,
		ImageOnly = 1,
		ImageLeft = 2,
		ImageRight = 3,
		ImageBelow = 4,
		ImageAbove = 5,
		ImageOverlaps = 6
	}
	
	public enum NSImageScaling : ulong { // NSUInteger
		ProportionallyDown = 0,
		AxesIndependently = 1,
		None = 2,
		ProportionallyUpOrDown = 3
	}
	
	public enum NSCellStateValue : long { // NSInteger
		Mixed = -1,
		Off = 0,
		On = 1
	}
	
	[Flags]
	public enum NSCellMask : ulong { // NSUInteger
		None = 0,
		Contents = 1,
		PushIn = 2,
		ChangeGray = 4,
		ChangeBackground = 8
	}

	public enum NSControlTint : ulong { // NSUInteger
		Default = 0,
		Blue = 1,
		Graphite = 6,
		Clear = 7
	}
	
	public enum NSControlSize : ulong { // NSUInteger
		Regular = 0,
		Small = 1,
		Mini = 2
	}

	public enum NSCellHit : ulong { // NSUInteger
		None = 0,
		ContentArea = 1,
		EditableTextArea = 2,
		TrackableArea = 4
	}

	public enum NSBackgroundStyle : long { // NSInteger
		Light = 0,
		Dark = 1,
		Raised = 2,
		Lowered = 3
	}
				/*
	public enum  : ulong { // NSUInteger
		NSScaleProportionally = 0,
		NSScaleToFit = 1,
		NSScaleNone = 2
	}
*/

	public enum NSAlertStyle : ulong { // NSUInteger
		Warning = 0,
		Informational = 1,
		Critical = 2
	}
	/*
	public enum  : ulong { // NSUInteger
		NSAlertFirstButtonReturn = 1000,
		NSAlertSecondButtonReturn = 1001,
		NSAlertThirdButtonReturn = 1002
	}
*/







	public enum NSApplicationLayoutDirection {
		LeftToRight = 0,
		RightToLeft = 1
	}

	public enum NSComposite {
		Clear,
		Copy,
		SourceOver,
		SourceIn,
		SourceOut,
		SourceAtop,
		DestinationOver,
		DestinationIn,
		DestinationOut,
		DestinationAtop,
		XOR,
		PlusDarker,
		Highlight,
		PlusLighter,
	}

#if MAC64
	public enum NSBackingStore : ulong {
#else
	public enum NSBackingStore {
#endif
		Retained, Nonretained, Buffered
	}


	

	//TODO: review size for 64 bit
	public enum NSRectEdge {
		MinXEdge, MinYEdge, MaxXEdge, MaxYEdge
	}


#region NSColorSpace
	public enum NSColorSpaceModel {
		Unknown = -1,
		Gray,
		RGB,
		CMYK,
		LAB,
		DeviceN,
		Indexed,
		Pattern
    }
#endregion

#region NSFileWrapper
	[Flags]
	public enum NSFileWrapperReadingOptions {
		Immediate = 1, WithoutMapping = 2
	}
#endregion
	
	
#region NSCell Defines 

	public enum NSImageScale {
		ProportionallyDown = 0,
		AxesIndependently,     
		None,                 
		ProportionallyUpOrDown
	}
#endregion

#region NSImage
	
	public enum NSImageLoadStatus {
	    		Completed,
	    		Cancelled,
	    		InvalidData,
	    		UnexpectedEOF,
	    		ReadError
	}
	
	public enum NSImageCacheMode {
		Default, 
		Always,  
		BySize,  
		Never    
	}
		
#endregion
	

#region NSEvent

	[Flags]
	public enum NSPointingDeviceMask {
		Pen = 1, PenLower = 2, PenUpper = 4
	}




	public enum NSEventMouseSubtype {
		Mouse, TablePoint, TabletProximity, Touch
	}
	
#endregion

#region NSView
	

	public enum NSTextFieldBezelStyle {
		Square, Rounded
	}
	


#endregion
	
#region NSWindow
	[Flags]
#if MAC64
	public enum NSWindowStyle : ulong {
#else
	public enum NSWindowStyle {
#endif
		Borderless	       = 0,
		Titled		       = 1 << 0,
		Closable	       = 1 << 1,
		Miniaturizable	       = 1 << 2,
		Resizable	       = 1 << 3,
		Utility		       = 1 << 4,
		DocModal	       = 1 << 6,
		NonactivatingPanel     = 1 << 7,
		TexturedBackground     = 1 << 8,
		Unscaled	       = 1 << 11,
		UnifiedTitleAndToolbar = 1 << 12,
		Hud		       = 1 << 13,
		FullScreenWindow       = 1 << 14
	}

#if MAC64
	public enum NSWindowSharingType : ulong {
#else
	public enum NSWindowSharingType {
#endif
		None, ReadOnly, ReadWrite
	}

#if MAC64
	public enum NSWindowBackingLocation : ulong {
#else
	public enum NSWindowBackingLocation {
#endif
		Default, VideoMemory, MainMemory,
	}

	[Flags]
#if MAC64
	public enum NSWindowCollectionBehavior : ulong {
#else
	public enum NSWindowCollectionBehavior {
#endif
		Default = 0,
		CanJoinAllSpaces = 1 << 0,
		MoveToActiveSpace = 1 << 1,
		Managed = 1 << 2,
		Transient = 1 << 3,
		Stationary = 1 << 4,
		ParticipatesInCycle = 1 << 5,
		IgnoresCycle = 1 << 6,
		FullScreenPrimary = 1 << 7,
		FullScreenAuxiliary = 1 << 8
	}

#if MAC64
	public enum NSWindowNumberListOptions : ulong {
#else
	public enum NSWindowNumberListOptions {
#endif
		AllApplication = 1 << 0,
		AllSpaces = 1 << 4
	}

#if MAC64
	public enum NSSelectionDirection : ulong {
#else
	public enum NSSelectionDirection {
#endif
		Direct = 0,
		Next,
		Previous
	}

#if MAC64
	public enum NSWindowButton : ulong {
#else
	public enum NSWindowButton {
#endif
		CloseButton, MiniaturizeButton, ZoomButton, ToolbarButton, DocumentIconButton, DocumentVersionsButton = 6, FullScreenButton
	}

#endregion

#region NSBox
	
	public enum NSTitlePosition {
		NoTitle,
		AboveTop,
		AtTop,
		BelowTop,
		AboveBottom,
		AtBottom,
		BelowBottom
	};

	public enum NSBoxType {
		NSBoxPrimary,
		NSBoxSecondary,
		NSBoxSeparator,
		NSBoxOldStyle,
		NSBoxCustom
	};
#endregion

#region NSButtonCell
#if MAC64
	public enum NSButtonType : ulong {
#else
	public enum NSButtonType {
#endif
		MomentaryLightButton,
		PushOnPushOff,
		Toggle,
		Switch,
		Radio,
		MomentaryChange,
		OnOff,
		MomentaryPushIn
	}
	
#if MAC64
	public enum NSBezelStyle : ulong {
#else
	public enum NSBezelStyle {
#endif
		Rounded = 1,
		RegularSquare,
		ThickSquare,
		ThickerSquare,
		Disclosure,
		ShadowlessSquare,
		Circular,
		TexturedSquare,
		HelpButton,
		SmallSquare,
		TexturedRounded,
		RoundRect,
		Recessed,
		RoundedDisclosure,
		Inline
	}

	public enum NSGradientType {
		None,
		ConcaveWeak,
		ConcaveStrong,
		ConvexWeak,
		ConvexStrong
	}
	
#endregion

#region NSMatrix
	public enum NSMatrixMode {
		Radio, Highlight, List, Track
	}
#endregion

#region NSBrowser
	public enum NSBrowserColumnResizingType {
		None, Auto, User
	}

	public enum NSBrowserDropOperation {
		On, Above
	}
#endregion

#region NSColorPanel
	public enum NSColorPanelMode {
		None = -1,
		Gray = 0,
		RGB,
		CMYK,
		HSB,
		CustomPalette,
		ColorList,
		Wheel,
		Crayon
	};

	[Flags]
	public enum NSColorPanelFlags {
	    Gray	= 0x00000001,
	    RGB		= 0x00000002,
	    CMYK	= 0x00000004,
	    HSB		= 0x00000008,
	    CustomPalette= 0x00000010,
	    ColorList	= 0x00000020,
	    Wheel	= 0x00000040,
	    Crayon	= 0x00000080,
	    All		= 0x0000ffff
	}
#endregion
#region NSDocument

	public enum NSDocumentChangeType  {
		Done, Undone, Cleared, Redone, ReadOtherContents, Autosaved
	}

	public enum NSSaveOperationType  {
		Save, SaveAs, SaveTo,
		Autosave = 3,	/* Deprecated name in Lion */
		Elsewhere = 3,	/* New Lion name */
		InPlace = 4,	/* New in Lion */
		AutoSaveAs = 5	/* New in Mountain Lion */
	}

#endregion

#region NSBezelPath
	
	public enum NSLineCapStyle {
		Butt, Round, Square
	}
	
	public enum NSLineJoinStyle {
		Miter, Round, Bevel
	}
	
	public enum NSWindingRule {
		NonZero, EvenOdd
	}
	
	public enum NSBezierPathElement {
		MoveTo, LineTo, CurveTo, ClosePath
	}
#endregion

#region NSRulerView
	public enum NSRulerOrientation {
		Horizontal, Vertical
	}
#endregion
	


	
	[Flags]
	public enum NSMenuProperty {
		Title = 1 << 0,
		AttributedTitle = 1 << 1,
		KeyEquivalent = 1 << 2,
		Image = 1 << 3,
		Enabled = 1 << 4,
		AccessibilityDescription = 1 << 5
	}

	public enum NSFontRenderingMode {
		Default, Antialiased, IntegerAdvancements, AntialiasedIntegerAdvancements
	}

	[Flags]
	public enum NSPasteboardReadingOptions {
		AsData = 0,
		AsString = 1,
		AsPropertyList = 2,
		AsKeyedArchive = 4
	}

	public enum NSUnderlineStyle {
		None                = 0x00,
		Single              = 0x01,
		Thick               = 0x02,
		Double              = 0x09
	}

	public enum NSUnderlinePattern {
		Solid             = 0x0000,
		Dot               = 0x0100,
		Dash              = 0x0200,
		DashDot           = 0x0300,
		DashDotDot        = 0x0400
	}

	public enum NSSelectionAffinity {
		Upstream, Downstream
	}

	public enum NSSelectionGranularity {
		Character, Word, Paragraph
	}

#region NSTrackingArea
	[Flags]
#if MAC64
	public enum NSTrackingAreaOptions : ulong {
#else
	public enum NSTrackingAreaOptions {
#endif
		MouseEnteredAndExited     = 0x01,
		MouseMoved                = 0x02,
		CursorUpdate 		  = 0x04,
		ActiveWhenFirstResponder  = 0x10,
		ActiveInKeyWindow         = 0x20,
		ActiveInActiveApp 	  = 0x40,
		ActiveAlways 		  = 0x80,
		AssumeInside              = 0x100,
		InVisibleRect             = 0x200,
		EnabledDuringMouseDrag    = 0x400 	
	}
#endregion

	public enum NSLineSweepDirection {
		NSLineSweepLeft,
		NSLineSweepRight,
		NSLineSweepDown,
		NSLineSweepUp
	}

	public enum NSLineMovementDirection {
		None, Left, Right, Down, Up
	}

	public enum  NSTiffCompression {
		None = 1,
		CcittFax3 = 3,
		CcittFax4 = 4,
		Lzw = 5,

		[Obsolete ("no longer supported")]
		Jpeg		= 6,
		Next		= 32766,
		PackBits	= 32773,

		[Obsolete ("no longer supported")]
		OldJpeg		= 32865
	}

	public enum NSBitmapImageFileType {
		Tiff,
		Bmp,
		Gif,
		Jpeg,
		Png,
		Jpeg2000
	}

	public enum NSImageRepLoadStatus {
		UnknownType     = -1,
		ReadingHeader   = -2,
		WillNeedAllData = -3,
		InvalidData     = -4,
		UnexpectedEOF   = -5,
		Completed       = -6 
	}

	[Flags]
	public enum NSBitmapFormat {
		AlphaFirst = 1,
		AlphaNonpremultiplied = 2,
		FloatingPointSamples = 4
	}

	public enum NSPrintingOrientation {
		Portrait, Landscape
	}
	
	public enum NSPrintingPaginationMode {
		Auto, Fit, Clip
	}

	[Flags]
	public enum NSGlyphStorageOptions {
		ShowControlGlyphs = 1,
		ShowInvisibleGlyphs = 2,
		WantsBidiLevels = 4
	}

	[Flags]
	public enum NSTextStorageEditedFlags {
		EditedAttributed = 1,
		EditedCharacters = 2
	}

	public enum NSPrinterTableStatus {
		Ok, NotFound, Error
	}

	public enum NSScrollArrowPosition {
		MaxEnd, MinEnd, DefaultSetting, None
	}

	public enum NSUsableScrollerParts {
		NoScroller, OnlyArrows, All
	}

	public enum NSScrollerPart {
		None, DecrementPage, Knob, IncrementPage, DecrementLine, IncrementLine, KnobSlot
	}

	public enum NSScrollerArrow {
		IncrementArrow, DecrementArrow
	}

	public enum NSPrintingPageOrder {
		Descending = -1,
		Special,
		Ascending,
		Unknown
	}

	[Flags]
	public enum NSPrintPanelOptions {
		ShowsCopies = 1,
		ShowsPageRange = 2,
		ShowsPaperSize = 4,
		ShowsOrientation = 8,
		ShowsScaling = 16,
		ShowsPrintSelection = 32,
		ShowsPageSetupAccessory = 256,
		ShowsPreview = 131072
	}

	public enum NSTextBlockValueType {
		Absolute, Percentage
	}

	public enum NSTextBlockDimension {
		Width, MinimumWidth, MaximumWidth, Height, MinimumHeight, MaximumHeight
	}
	
	public enum NSTextBlockLayer {
		Padding = -1, Border, Margin
	}

	public enum NSTextBlockVerticalAlignment {
		Top, Middle, Bottom, Baseline
	}

	public enum NSTextTableLayoutAlgorithm {
		Automatic, Fixed
	}

	[Flags]
	public enum NSTextListOptions {
		PrependEnclosingMarker = 1
	}

	[Flags]
	public enum NSFontSymbolicTraits : int {
		ItalicTrait = (1 << 0),
		BoldTrait = (1 << 1),
		ExpandedTrait = (1 << 5),
		CondensedTrait = (1 << 6),
		MonoSpaceTrait = (1 << 10),
		VerticalTrait = (1 << 11), 
		UIOptimizedTrait = (1 << 12),
		
		UnknownClass = 0 << 28,
		OldStyleSerifsClass = 1 << 28,
		TransitionalSerifsClass = 2 << 28,
		ModernSerifsClass = 3 << 28,
		ClarendonSerifsClass = 4 << 28,
		SlabSerifsClass = 5 << 28,
		FreeformSerifsClass = 7 << 28,
		SansSerifClass = 8 << 28,
		OrnamentalsClass = 9 << 28,
		ScriptsClass = 10 << 28,
		SymbolicClass = 12 << 28,

		FamilyClassMask = (int) -268435456,
	}

	[Flags]
	public enum NSFontTraitMask {
		Italic = 1,
		Bold = 2,
		Unbold = 4,
		NonStandardCharacterSet = 8,
		Narrow = 0x10,
		Expanded = 0x20,
		Condensed = 0x40,
		SmallCaps = 0x80,
		Poster = 0x100,
		Compressed = 0x200,
		FixedPitch = 0x400,
		Unitalic = 0x1000000
	}
	
	[Flags]
	public enum NSPasteboardWritingOptions	 {
		WritingPromised = 1 << 9
	}


#if MAC64
	public enum NSToolbarDisplayMode : ulong {
#else
	public enum NSToolbarDisplayMode {
#endif
		Default, IconAndLabel, Icon, Label
	}

#if MAC64
	public enum NSToolbarSizeMode : ulong {
#else
	public enum NSToolbarSizeMode {
#endif
		Default, Regular, Small
	}

	public enum NSAlertType {
		ErrorReturn = -2,
		OtherReturn,
		AlternateReturn,
		DefaultReturn
	}

	public enum NSPanelButtonType {
		Cancel, Ok
	}

	public enum NSTableViewColumnAutoresizingStyle {
		None = 0,
		Uniform,
		Sequential,
		ReverseSequential,
		LastColumnOnly,
		FirstColumnOnly
	}

	public enum NSTableViewSelectionHighlightStyle {
		None = -1,
		Regular = 0,
		SourceList = 1
	}

	public enum NSTableViewDraggingDestinationFeedbackStyle {
		None = -1,
		Regular = 0,
		SourceList = 1
	}

	public enum NSTableViewDropOperation {
		On,
		Above
	}

	[Flags]
	public enum NSTableColumnResizing {
		None = -1,
		Autoresizing = ( 1 << 0 ),
		UserResizingMask = ( 1 << 1 )
	} 

	[Flags]
	public enum NSTableViewGridStyle {
		None = 0,
		SolidVerticalLine   = 1 << 0,
		SolidHorizontalLine = 1 << 1,
		DashedHorizontalGridLine = 1 << 3
	}

	[Flags]
	public enum NSGradientDrawingOptions {
		None = 0,
		BeforeStartingLocation =   (1 << 0),
		AfterEndingLocation =    (1 << 1)
	}
	
	public enum NSImageAlignment {
		Center = 0,
		Top,
		TopLeft,
		TopRight,
		Left,
		Bottom,
		BottomLeft,
		BottomRight,
		Right
	}
	
	public enum NSImageFrameStyle {
		None = 0,
		Photo,
		GrayBezel,
		Groove,
		Button
	}
	
	public enum NSSpeechBoundary {
		Immediate =  0,
		hWord,
		Sentence
	}

	public enum NSSplitViewDividerStyle {
		Thick = 1,
		Thin = 2,
		PaneSplitter = 3
	}
	
	
	public enum NSSegmentStyle {
		Automatic = 0,
		Rounded = 1,
		TexturedRounded = 2,
		RoundRect = 3,
		TexturedSquare = 4,
		Capsule = 5,
		SmallSquare = 6
	}
	
	public enum NSSegmentSwitchTracking {
		SelectOne = 0,
		SelectAny = 1,
		Momentary = 2
	}
	
	public enum NSTickMarkPosition {
		Below,
		Above,
		Left,
		Right
	}
	
	public enum NSSliderType {
		Linear   = 0,
		Circular = 1
	}
	
#if MAC64
	public enum NSTokenStyle : ulong {
#else
	public enum NSTokenStyle {
#endif
		Default,
		PlainText,
		Rounded
	}

	[Flags]
#if MAC64
	public enum NSWorkspaceLaunchOptions : ulong {
#else
	public enum NSWorkspaceLaunchOptions {
#endif
		Print = 2,
		InhibitingBackgroundOnly = 0x80,
		WithoutAddingToRecents = 0x100,
		WithoutActivation = 0x200,
		Async = 0x10000,
		AllowingClassicStartup = 0x20000,
		PreferringClassic = 0x40000,
		NewInstance = 0x80000,
		Hide = 0x100000,
		HideOthers = 0x200000,
		Default = Async | AllowingClassicStartup
	}


	public enum NSPathStyle {
		NSPathStyleStandard,
		NSPathStyleNavigationBar,
		NSPathStylePopUp
	}

	public enum NSTabViewType {
		NSTopTabsBezelBorder,
		NSLeftTabsBezelBorder,
		NSBottomTabsBezelBorder,
		NSRightTabsBezelBorder,
		NSNoTabsBezelBorder,
		NSNoTabsLineBorder,
		NSNoTabsNoBorder,
	}

	public enum NSTabState {
		Selected, Background, Pressed
	}

	public enum NSLevelIndicatorStyle {
		Relevancy, ContinuousCapacity, DiscreteCapacity, RatingLevel
	}

	[Flags]
	public enum NSFontCollectionOptions {
		ApplicationOnlyMask = 1
	}

	public enum NSCollectionViewDropOperation {
		On = 0, Before = 1
	}

	public enum NSDatePickerStyle {
		TextFieldAndStepper,
		ClockAndCalendar,
		TextField
	}

	public enum NSDatePickerMode {
		Single, Range
	}

	[Flags]
	public enum NSDatePickerElementFlags {
		HourMinute = 0xc,
		HourMinuteSecond = 0xe,
		TimeZone = 0x10,

		YearMonthDate = 0xc0,
		YearMonthDateDay = 0xe0,
		Era = 0x100
	}

	public enum NSOpenGLContextParameter {
		[Obsolete] SwapRectangle = 200,
		[Obsolete] SwapRectangleEnable = 201,
		[Obsolete] RasterizationEnable = 221,
		[Obsolete] StateValidation = 301,
		[Obsolete] SurfaceSurfaceVolatile = 306,

		SwapInterval = 222,
		SurfaceOrder = 235,
		SurfaceOpacity = 236,

		[Lion] SurfaceBackingSize = 304,
		[Lion] ReclaimResources = 308,
		[Lion] CurrentRendererID = 309,
		[Lion] GpuVertexProcessing = 310,
		[Lion] GpuFragmentProcessing = 311,
		[Lion] HasDrawable = 314,
		[Lion] MpsSwapsInFlight = 315
	}
	
	public enum NSSurfaceOrder {
		AboveWindow = 1,
		BelowWindow = -1
	}

	public enum NSOpenGLPixelFormatAttribute {
		AllRenderers       =   1,
		DoubleBuffer       =   5,
		[Lion] TrippleBuffer = 3,
		Stereo             =   6,
		AuxBuffers         =   7,
		ColorSize          =   8,
		AlphaSize          =  11,
		DepthSize          =  12,
		StencilSize        =  13,
		AccumSize          =  14,
		MinimumPolicy      =  51,
		MaximumPolicy      =  52,
		OffScreen          =  53,
		FullScreen         =  54,
		SampleBuffers      =  55,
		Samples            =  56,
		AuxDepthStencil    =  57,
		ColorFloat         =  58,
		Multisample        =  59,
		Supersample        =  60,
		SampleAlpha        =  61,
		RendererID         =  70,
		SingleRenderer     =  71,
		NoRecovery         =  72,
		Accelerated        =  73,
		ClosestPolicy      =  74,
		BackingStore       =  76,
		Window             =  80,
		Compliant          =  83,
		ScreenMask         =  84,
		PixelBuffer        =  90,
		RemotePixelBuffer  =  91,
		AllowOfflineRenderers = 96,
		AcceleratedCompute =  97,

		// Specify the profile
		[Lion] OpenGLProfile = 99,
		VirtualScreenCount = 128,

		[Obsolete] Robust  =  75,
		[Obsolete] MPSafe  =  78,
		[Obsolete] MultiScreen =  81
	}

	public enum NSOpenGLProfile {
		VersionLegacy   = 0x1000, // Legacy
		Version3_2Core  = 0x3200  // 3.2 or better
	}
	
	public enum NSAlertButtonReturn {
		First = 1000,
		Second = 1001,
		Third = 1002,
	}

	public enum NSOpenGLGlobalOption {
		FormatCacheSize = 501,
		ClearFormatCache = 502,
		RetainRenderers = 503,
		[Lion] UseBuildCache = 506,
		[Obsolete] ResetLibrary = 504
	}

	public enum NSGLTextureTarget {
		T2D = 0x0de1,
		CubeMap = 0x8513,
		RectangleExt = 0x84F5,
	}

	public enum NSGLFormat {
		RGB = 0x1907,
		RGBA = 0x1908,
		DepthComponent = 0x1902,
	}
	
	public enum NSGLTextureCubeMap {
		None = 0,
		PositiveX = 0x8515,
		PositiveY = 0x8517,
		PositiveZ = 0x8519,
		NegativeX = 0x8516,
		NegativeY = 0x8517,
		NegativeZ = 0x851A
	}

	public enum NSGLColorBuffer {
		Front = 0x0404,
		Back = 0x0405,
		Aux0 = 0x0409
	}

	public enum NSProgressIndicatorThickness {
		Small = 10,
		Regular = 14,
		Aqua = 12,
		Large = 18
	}

	public enum NSProgressIndicatorStyle {
		Bar, Spinning
	}

	public enum NSPopUpArrowPosition {
		None,
		Center,
		Bottom
	}

	public static class NSFileTypeForHFSTypeCode {
		public static readonly string ComputerIcon = "root";
		public static readonly string DesktopIcon = "desk";
		public static readonly string FinderIcon = "FNDR";
	}
	
	// These constants specify the possible states of a drawer.
	public enum NSDrawerState {
		Closed = 0,
		Opening = 1,
		Open = 2,
		Closing = 3
	}

#if MAC64
	public enum NSWindowLevel : long {
#else
	public enum NSWindowLevel {
#endif
		Normal = 0,
		Dock = 20,
		Floating = 3,
		MainMenu = 24, 
		ModalPanel = 8,
		PopUpMenu = 101,
		ScreenSaver = 1000,
		Status = 25,
		Submenu = 3,
		TornOffMenu = 3
	}

#if MAC64
	public enum NSRuleEditorRowType : ulong {
#else
	public enum NSRuleEditorRowType{
#endif
		Simple = 0,
		Compound
	}
   
	//TODO: figure out size for 64 bit
	public enum NSRuleEditorNestingMode {
		Single,
		List,
		Compound,
		Simple
	}

	public enum NSGlyphInscription {
		Base, Below, Above, Overstrike, OverBelow
	}

	public enum NSTypesetterBehavior {
		Latest = -1,
		Original = 0,
		Specific_10_2_WithCompatibility = 1,
		Specific_10_2 = 2,
		Specific_10_3 = 3,
		Specific_10_4 = 4,
			
	}
																			
	public enum NSScrollViewFindBarPosition {
		AboveHorizontalRuler = 0,
		AboveContent,
		BelowContent
	}
	
	public enum NSScrollerStyle {
   		Legacy = 0,
		Overlay
	}
	
	public enum  NSScrollElasticity {
		Automatic = 0,
   		None,
		Allowed
	}
	
	public enum  NSScrollerKnobStyle {
		Default  = 0,
		Dark     = 1,
		Light    = 2
	}


	public enum NSLayoutRelation {
		LessThanOrEqual = -1,
		Equal = 0,
		GreaterThanOrEqual = 1
	}

#if MAC64
	public enum NSLayoutAttribute : long {
#else
	public enum NSLayoutAttribute {
#endif
		NoAttribute = 0,
		Left = 1,
		Right,
		Top,
		Bottom,
		Leading,
		Trailing,
		Width,
		Height,
		CenterX,
		CenterY,
		Baseline
	}

	public enum NSLayoutFormatOptions {
		None = 0,

		AlignAllLeft = (1 << (int)NSLayoutAttribute.Left),
		AlignAllRight = (1 << (int)NSLayoutAttribute.Right),
		AlignAllTop = (1 << (int)NSLayoutAttribute.Top),
		AlignAllBottom = (1 << (int)NSLayoutAttribute.Bottom),
		AlignAllLeading = (1 << (int)NSLayoutAttribute.Leading),
		AlignAllTrailing = (1 << (int)NSLayoutAttribute.Trailing),
		AlignAllCenterX = (1 << (int)NSLayoutAttribute.CenterX),
		AlignAllCenterY = (1 << (int)NSLayoutAttribute.CenterY),
		AlignAllBaseline = (1 << (int)NSLayoutAttribute.Baseline),
		
		AlignmentMask = 0xFFFF,
		
		/* choose only one of these three
		 */
		DirectionLeadingToTrailing = 0 << 16, // default
		DirectionLeftToRight = 1 << 16,
		DirectionRightToLeft = 2 << 16,
		
		DirectionMask = 0x3 << 16,
	}

#if MAC64
	public enum NSLayoutConstraintOrientation : long {
#else
	public enum NSLayoutConstraintOrientation {
#endif
		Horizontal, Vertical
	}

	public enum NSLayoutPriority {
		Required = 1000,
		DefaultHigh = 750,
		DragThatCanResizeWindow = 510,
		WindowSizeStayPut = 500,
		DragThatCannotResizeWindow = 490,
		DefaultLow = 250,
		FittingSizeCompression = 50,
	}

	public enum NSPopoverAppearance {
		Minimal, HUD
	}

	public enum NSPopoverBehavior {
		ApplicationDefined, Transient, Semitransient
	}

	public enum NSTableViewRowSizeStyle {
		Default = -1,
		Custom = 0,
		Small, Medium, Large
	}

	[Flags]
	public enum NSTableViewAnimation {
		None, Fade = 1, Gap = 2,
		SlideUp = 0x10, SlideDown = 0x20, SlideLeft = 0x30, SlideRight = 0x40
	}

#if MAC64
	public enum NSWindowAnimationBehavior : long {
#else
	public enum NSWindowAnimationBehavior {
#endif
		Default = 0, None = 2, DocumentWindow, UtilityWindow, AlertPanel
	}

	[Lion]
	public enum NSTextFinderAction {
		ShowFindInterface = 1,
		NextMatch = 2,
		PreviousMatch = 3,
		ReplaceAll = 4,
		Replace = 5,
		ReplaceAndFind = 6,
		SetSearchString = 7,
		ReplaceAllInSelection = 8,
		SelectAll = 9,
		SelectAllInSelection = 10,
		HideFindInterface = 11,
		ShowReplaceInterface = 12,
		HideReplaceInterface = 13
	}

	[Flags]
	public enum NSFontPanelMode {
		FaceMask = 1 << 0,
		SizeMask = 1 << 1,
		CollectionMask = 1 << 2,
		UnderlineEffectMask = 1<<8,
		StrikethroughEffectMask = 1<<9,
		TextColorEffectMask = 1<< 10,
		DocumentColorEffectMask = 1<<11,
		ShadowEffectMask = 1<<12,
		AllEffectsMask = 0XFFF00,
		StandardMask = 0xFFFF,
		AllModesMask = unchecked( (int)0xFFFFFFFF )
	}

	[Flags]
	public enum NSFontCollectionVisibility {
		Process = 1 << 0,
		User = 1 << 1,
		Computer = 1 << 2,
	}

#if MAC64
	public enum NSSharingContentScope : long {
#else
	public enum NSSharingContentScope {
#endif
		Item,
		Partial,
		Full
	}

	public enum NSSharingServiceName {
		PostOnFacebook,
		PostOnTwitter,
		PostOnSinaWeibo,
		ComposeEmail,
		ComposeMessage,
		SendViaAirDrop,
		AddToSafariReadingList,
		AddToIPhoto,
		AddToAperture,
		UseAsTwitterProfileImage,
		UseAsDesktopPicture,
		PostImageOnFlickr,
		PostVideoOnVimeo,
		PostVideoOnYouku,
		PostVideoOnTudou
	}

	[Flags]
	public enum NSTypesetterControlCharacterAction {
		ZeroAdvancement = 1 << 0,
		Whitespace = 1 << 1,
		HorizontalTab = 1 << 2,
		LineBreak = 1 << 3,
		ParagraphBreak = 1 << 4,
		ContainerBreak = 1 << 5,
	}
}
