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
	[Register("FLIRMeasurementMarker", true)]
	public unsafe partial class FLIRMeasurementMarker : FLIRMeasurementShape {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRMeasurementMarker");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRMeasurementMarker () : base (NSObjectFlag.Empty)
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
		protected FLIRMeasurementMarker (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRMeasurementMarker (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Average {
			[Export ("average")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("average")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("average")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ColdSpot {
			[Export ("coldSpot")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("coldSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("coldSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("coldSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("coldSpot"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coldSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("coldSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coldSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coldSpot"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint HotSpot {
			[Export ("hotSpot")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("hotSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("hotSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("hotSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("hotSpot"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hotSpot"));
						} else {
							global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("hotSpot"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hotSpot"));
					} else {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hotSpot"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAverageEnabled {
			[Export ("isAverageEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAverageEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAverageEnabled"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsColdSpotEnabled {
			[Export ("isColdSpotEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isColdSpotEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isColdSpotEnabled"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsColdSpotVisible {
			[Export ("isColdSpotVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isColdSpotVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isColdSpotVisible"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsHotSpotEnabled {
			[Export ("isHotSpotEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHotSpotEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHotSpotEnabled"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsHotSpotVisible {
			[Export ("isHotSpotVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHotSpotVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHotSpotVisible"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Max {
			[Export ("max")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("max")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("max")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRThermalValue Min {
			[Export ("min")]
			get {
				FLIRThermalValue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("min")));
				} else {
					ret =  Runtime.GetNSObject<FLIRThermalValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("min")));
				}
				return ret;
			}
			
		}
		
	} /* class FLIRMeasurementMarker */
}
