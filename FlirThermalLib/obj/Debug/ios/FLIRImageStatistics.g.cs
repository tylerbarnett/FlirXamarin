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
	[Register("FLIRImageStatistics", true)]
	public unsafe partial class FLIRImageStatistics : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRImageStatistics");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRImageStatistics () : base (NSObjectFlag.Empty)
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
		protected FLIRImageStatistics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRImageStatistics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Average {
			[Export ("getAverage")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAverage")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAverage")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ColdSpot {
			[Export ("getColdSpot")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getColdSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getColdSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getColdSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getColdSpot"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getColdSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getColdSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getColdSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getColdSpot"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint HotSpot {
			[Export ("getHotSpot")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getHotSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getHotSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getHotSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("getHotSpot"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHotSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getHotSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHotSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHotSpot"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Max {
			[Export ("getMax")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMax")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMax")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Min {
			[Export ("getMin")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMin")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMin")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue StandardDeviation {
			[Export ("getStandardDeviation")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStandardDeviation")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStandardDeviation")));
				}
				return ret;
			}
			
		}
		
	} /* class FLIRImageStatistics */
}
