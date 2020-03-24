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
	[Register("FLIRImageBase", true)]
	public unsafe partial class FLIRImageBase : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRImageBase");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRImageBase () : base (NSObjectFlag.Empty)
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
		protected FLIRImageBase (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRImageBase (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDescription (string description)
		{
			if (description == null)
				throw new ArgumentNullException ("description");
			var nsdescription = NSString.CreateNative (description);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDescription:"), nsdescription);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDescription:"), nsdescription);
			}
			NSString.ReleaseNative (nsdescription);
			
		}
		
		[Export ("setRotate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRotate (RotationAngle angle)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setRotate:"), (UInt64)angle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setRotate:"), (UInt32)angle);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setRotate:"), (UInt64)angle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setRotate:"), (UInt32)angle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CompassInformation_t CompassInformation {
			[Export ("getCompassInformation")]
			get {
				CompassInformation_t ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSend (this.Handle, Selector.GetHandle ("getCompassInformation"));
						} else {
							global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getCompassInformation"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSend (this.Handle, Selector.GetHandle ("getCompassInformation"));
					} else {
						global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getCompassInformation"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCompassInformation"));
						} else {
							global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getCompassInformation"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCompassInformation"));
					} else {
						global::ApiDefinition.Messaging.CompassInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getCompassInformation"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Description {
			[Export ("getDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDescription")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDescription")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GpsInformation_t GpsInformation {
			[Export ("getGpsInformation")]
			get {
				GpsInformation_t ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSend (this.Handle, Selector.GetHandle ("getGpsInformation"));
						} else {
							global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getGpsInformation"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getGpsInformation"));
					} else {
						global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getGpsInformation"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getGpsInformation"));
						} else {
							global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getGpsInformation"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getGpsInformation"));
					} else {
						global::ApiDefinition.Messaging.GpsInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getGpsInformation"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Height {
			[Export ("getHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getHeight"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHeight"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Width {
			[Export ("getWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getWidth"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWidth"));
				}
			}
			
		}
		
	} /* class FLIRImageBase */
}
