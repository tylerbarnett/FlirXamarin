//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace FlirThermalLib {
	[Protocol (Name = "FLIRRemoteDelegate", WrapperType = typeof (FLIRRemoteDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChargingStateChanged", Selector = "ChargingStateChanged:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRChargingState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PercentageChanged", Selector = "PercentageChanged:", ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CalibrationStateChanged", Selector = "CalibrationStateChanged:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LastStoredImageChanged", Selector = "LastStoredImageChanged:", ParameterType = new Type [] { typeof (FlirThermalLib.LastStoredImage_t) }, ParameterByRef = new bool [] { false })]
	public interface IFLIRRemoteDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class FLIRRemoteDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChargingStateChanged (this IFLIRRemoteDelegate This, FLIRChargingState state)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("ChargingStateChanged:"), (UInt64)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("ChargingStateChanged:"), (UInt32)state);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PercentageChanged (this IFLIRRemoteDelegate This, int percent)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("PercentageChanged:"), percent);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CalibrationStateChanged (this IFLIRRemoteDelegate This, bool state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("CalibrationStateChanged:"), state);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LastStoredImageChanged (this IFLIRRemoteDelegate This, LastStoredImage_t laststore)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_LastStoredImage_t (This.Handle, Selector.GetHandle ("LastStoredImageChanged:"), laststore);
		}
		
	}
	
	internal sealed class FLIRRemoteDelegateWrapper : BaseWrapper, IFLIRRemoteDelegate {
		[Preserve (Conditional = true)]
		public FLIRRemoteDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FlirThermalLib {
	[Protocol()]
	[Register("ApiDefinition__FlirThermalLib_FLIRRemoteDelegate", false)]
	[Model]
	public unsafe partial class FLIRRemoteDelegate : NSObject, IFLIRRemoteDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRRemoteDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRRemoteDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRRemoteDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("CalibrationStateChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CalibrationStateChanged (bool state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("ChargingStateChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChargingStateChanged (FLIRChargingState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("LastStoredImageChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LastStoredImageChanged (LastStoredImage_t laststore)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("PercentageChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PercentageChanged (int percent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class FLIRRemoteDelegate */
}
