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
	[Register("FLIRCameraEvent", true)]
	public unsafe partial class FLIRCameraEvent : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRCameraEvent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRCameraEvent () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRCameraEvent (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRCameraEvent (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithCameraDeviceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FLIRCameraEvent (FLIRCameraDeviceInfo cameraDeviceInfo)
			: base (NSObjectFlag.Empty)
		{
			if (cameraDeviceInfo == null)
				throw new ArgumentNullException ("cameraDeviceInfo");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCameraDeviceInfo:"), cameraDeviceInfo.Handle), "initWithCameraDeviceInfo:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCameraDeviceInfo:"), cameraDeviceInfo.Handle), "initWithCameraDeviceInfo:");
			}
		}
		
		[Export ("initWithCameraIpAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FLIRCameraEvent (string ipAddress)
			: base (NSObjectFlag.Empty)
		{
			if (ipAddress == null)
				throw new ArgumentNullException ("ipAddress");
			var nsipAddress = NSString.CreateNative (ipAddress);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCameraIpAddress:"), nsipAddress), "initWithCameraIpAddress:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCameraIpAddress:"), nsipAddress), "initWithCameraIpAddress:");
			}
			NSString.ReleaseNative (nsipAddress);
			
		}
		
		[Export ("initWithIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FLIRCameraEvent (FLIRIdentity identity)
			: base (NSObjectFlag.Empty)
		{
			if (identity == null)
				throw new ArgumentNullException ("identity");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentity:"), identity.Handle), "initWithIdentity:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithIdentity:"), identity.Handle), "initWithIdentity:");
			}
		}
		
		[Export ("listenForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ListenForEvent (CameraEvent eventID)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("listenForEvent:"), (Int64)eventID);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("listenForEvent:"), (int)eventID);
				}
			} else {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("listenForEvent:"), (Int64)eventID);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("listenForEvent:"), (int)eventID);
				}
			}
		}
		
		[Export ("stopListening")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopListening ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopListening"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopListening"));
			}
		}
		
	} /* class FLIRCameraEvent */
}
