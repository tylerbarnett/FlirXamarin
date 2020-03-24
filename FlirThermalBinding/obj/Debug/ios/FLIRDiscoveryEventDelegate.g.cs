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
	[Protocol (Name = "FLIRDiscoveryEventDelegate", WrapperType = typeof (FLIRDiscoveryEventDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CameraFound", Selector = "cameraFound:", ParameterType = new Type [] { typeof (FlirThermalBinding.FLIRIdentity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DiscoveryError", Selector = "discoveryError:netServiceError:on:", ParameterType = new Type [] { typeof (string), typeof (int), typeof (FlirThermalBinding.FLIRCommunicationInterface) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraLost", Selector = "cameraLost:", ParameterType = new Type [] { typeof (FlirThermalBinding.FLIRIdentity) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DiscoveryFinished", Selector = "discoveryFinished:", ParameterType = new Type [] { typeof (FlirThermalBinding.FLIRCommunicationInterface) }, ParameterByRef = new bool [] { false })]
	public interface IFLIRDiscoveryEventDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("cameraFound:")]
		[Preserve (Conditional = true)]
		void CameraFound (FLIRIdentity cameraIdentity);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("discoveryError:netServiceError:on:")]
		[Preserve (Conditional = true)]
		void DiscoveryError (string error, int nsnetserviceserror, FLIRCommunicationInterface iface);
		
	}
	
	public static partial class FLIRDiscoveryEventDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraLost (this IFLIRDiscoveryEventDelegate This, FLIRIdentity cameraIdentity)
		{
			if (cameraIdentity == null)
				throw new ArgumentNullException ("cameraIdentity");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("cameraLost:"), cameraIdentity.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscoveryFinished (this IFLIRDiscoveryEventDelegate This, FLIRCommunicationInterface iface)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("discoveryFinished:"), (UInt64)iface);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("discoveryFinished:"), (UInt32)iface);
			}
		}
		
	}
	
	internal sealed class FLIRDiscoveryEventDelegateWrapper : BaseWrapper, IFLIRDiscoveryEventDelegate {
		[Preserve (Conditional = true)]
		public FLIRDiscoveryEventDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("cameraFound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CameraFound (FLIRIdentity cameraIdentity)
		{
			if (cameraIdentity == null)
				throw new ArgumentNullException ("cameraIdentity");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraFound:"), cameraIdentity.Handle);
		}
		
		[Export ("discoveryError:netServiceError:on:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DiscoveryError (string error, int nsnetserviceserror, FLIRCommunicationInterface iface)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			var nserror = NSString.CreateNative (error);
			
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_UInt64 (this.Handle, Selector.GetHandle ("discoveryError:netServiceError:on:"), nserror, nsnetserviceserror, (UInt64)iface);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_UInt32 (this.Handle, Selector.GetHandle ("discoveryError:netServiceError:on:"), nserror, nsnetserviceserror, (UInt32)iface);
			}
			NSString.ReleaseNative (nserror);
			
		}
		
	}
}
namespace FlirThermalBinding {
	[Protocol()]
	[Register("ApiDefinition__FlirThermalBinding_FLIRDiscoveryEventDelegate", false)]
	[Model]
	public unsafe abstract partial class FLIRDiscoveryEventDelegate : NSObject, IFLIRDiscoveryEventDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected FLIRDiscoveryEventDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRDiscoveryEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRDiscoveryEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("cameraFound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void CameraFound (FLIRIdentity cameraIdentity);
		[Export ("cameraLost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraLost (FLIRIdentity cameraIdentity)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("discoveryError:netServiceError:on:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DiscoveryError (string error, int nsnetserviceserror, FLIRCommunicationInterface iface);
		[Export ("discoveryFinished:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscoveryFinished (FLIRCommunicationInterface iface)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class FLIRDiscoveryEventDelegate */
}
