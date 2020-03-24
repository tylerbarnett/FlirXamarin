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

namespace FlirThermalBinding {
	[Protocol (Name = "FLIRDataReceivedDelegate", WrapperType = typeof (FLIRDataReceivedDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnConnectionStatusChanged", Selector = "onConnectionStatusChanged:Status:withError:", ParameterType = new Type [] { typeof (FlirThermalBinding.FLIRCamera), typeof (FlirThermalBinding.FLIRConnectionStatus), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ImageReceived", Selector = "imageReceived")]
	public interface IFLIRDataReceivedDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onConnectionStatusChanged:Status:withError:")]
		[Preserve (Conditional = true)]
		void OnConnectionStatusChanged (FLIRCamera camera, FLIRConnectionStatus status, NSError error);
		
	}
	
	public static partial class FLIRDataReceivedDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ImageReceived (this IFLIRDataReceivedDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("imageReceived"));
		}
		
	}
	
	internal sealed class FLIRDataReceivedDelegateWrapper : BaseWrapper, IFLIRDataReceivedDelegate {
		[Preserve (Conditional = true)]
		public FLIRDataReceivedDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("onConnectionStatusChanged:Status:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnConnectionStatusChanged (FLIRCamera camera, FLIRConnectionStatus status, NSError error)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr (this.Handle, Selector.GetHandle ("onConnectionStatusChanged:Status:withError:"), camera.Handle, (UInt64)status, error == null ? IntPtr.Zero : error.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr (this.Handle, Selector.GetHandle ("onConnectionStatusChanged:Status:withError:"), camera.Handle, (UInt32)status, error == null ? IntPtr.Zero : error.Handle);
			}
		}
		
	}
}
namespace FlirThermalBinding {
	[Protocol()]
	[Register("ApiDefinition__FlirThermalBinding_FLIRDataReceivedDelegate", false)]
	[Model]
	public unsafe abstract partial class FLIRDataReceivedDelegate : NSObject, IFLIRDataReceivedDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected FLIRDataReceivedDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRDataReceivedDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRDataReceivedDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("imageReceived")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ImageReceived ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onConnectionStatusChanged:Status:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void OnConnectionStatusChanged (FLIRCamera camera, FLIRConnectionStatus status, NSError error);
	} /* class FLIRDataReceivedDelegate */
}
