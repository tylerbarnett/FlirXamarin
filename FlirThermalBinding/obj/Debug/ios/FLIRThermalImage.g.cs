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
	[Register("FLIRThermalImage", true)]
	public unsafe partial class FLIRThermalImage : FLIRImageBase {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRThermalImage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRThermalImage () : base (NSObjectFlag.Empty)
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
		protected FLIRThermalImage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRThermalImage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getValueAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetValueAt (CGPoint point)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("getValueAt:"), point);
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("getValueAt:"), point);
			}
		}
		
		[Export ("getValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] GetValues (NSValue[] points)
		{
			if (points == null)
				throw new ArgumentNullException ("points");
			var nsa_points = NSArray.FromNSObjects (points);
			
			NSNumber[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getValues:"), nsa_points.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getValues:"), nsa_points.Handle));
			}
			nsa_points.Dispose ();
			
			return ret;
		}
		
		[Export ("saveAs:imageViewWithOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveAs (string fileName, global::UIKit.UIImageView overlay)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (overlay == null)
				throw new ArgumentNullException ("overlay");
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("saveAs:imageViewWithOverlay:"), nsfileName, overlay.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAs:imageViewWithOverlay:"), nsfileName, overlay.Handle);
			}
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("saveAs:imageWithOverlay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveAs (string fileName, global::UIKit.UIImage imageWithOverlay)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (imageWithOverlay == null)
				throw new ArgumentNullException ("imageWithOverlay");
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("saveAs:imageWithOverlay:"), nsfileName, imageWithOverlay.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAs:imageWithOverlay:"), nsfileName, imageWithOverlay.Handle);
			}
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("saveAs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SaveAs (string fileName)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("saveAs:"), nsfileName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("saveAs:"), nsfileName);
			}
			NSString.ReleaseNative (nsfileName);
			
		}
		
		[Export ("setColorDistribution:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetColorDistribution (ColorDistribution value)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setColorDistribution:"), (UInt32)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setColorDistribution:"), (UInt32)value);
			}
		}
		
		[Export ("setDistanceUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDistanceUnit (DistanceUnit value)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setDistanceUnit:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setDistanceUnit:"), (UInt32)value);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setDistanceUnit:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setDistanceUnit:"), (UInt32)value);
				}
			}
		}
		
		[Export ("setTemperatureUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTemperatureUnit (TemperatureUnit value)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTemperatureUnit:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTemperatureUnit:"), (UInt32)value);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTemperatureUnit:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTemperatureUnit:"), (UInt32)value);
				}
			}
		}
		
		[Export ("setTextAnnotations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextAnnotations (NSDictionary<NSString, NSString> annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextAnnotations:"), annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextAnnotations:"), annotations.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CameraInformation_t CameraInformation {
			[Export ("getCameraInformation")]
			get {
				CameraInformation_t ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSend (this.Handle, Selector.GetHandle ("getCameraInformation"));
						} else {
							global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getCameraInformation"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getCameraInformation"));
					} else {
						global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("getCameraInformation"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCameraInformation"));
						} else {
							global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getCameraInformation"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getCameraInformation"));
					} else {
						global::ApiDefinition.Messaging.CameraInformation_t_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("getCameraInformation"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ColorDistribution ColorDistribution {
			[Export ("getColorDistribution")]
			get {
				if (IsDirectBinding) {
					return (ColorDistribution) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getColorDistribution"));
				} else {
					return (ColorDistribution) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getColorDistribution"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DistanceUnit DistanceUnit {
			[Export ("getDistanceUnit")]
			get {
				DistanceUnit ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (DistanceUnit) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("getDistanceUnit"));
					} else {
						ret = (DistanceUnit) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getDistanceUnit"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (DistanceUnit) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDistanceUnit"));
					} else {
						ret = (DistanceUnit) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDistanceUnit"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] ExternalSensors {
			[Export ("getExternalSensors")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getExternalSensors")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getExternalSensors")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRFusion Fusion {
			[Export ("getFusion")]
			get {
				FLIRFusion ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRFusion> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getFusion")));
				} else {
					ret =  Runtime.GetNSObject<FLIRFusion> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getFusion")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage Image {
			[Export ("getImage")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getImage")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRImageParameters ImageParameters {
			[Export ("getImageParameters")]
			get {
				FLIRImageParameters ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRImageParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getImageParameters")));
				} else {
					ret =  Runtime.GetNSObject<FLIRImageParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getImageParameters")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRImageStatistics ImageStatistics {
			[Export ("getImageStatistics")]
			get {
				FLIRImageStatistics ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRImageStatistics> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getImageStatistics")));
				} else {
					ret =  Runtime.GetNSObject<FLIRImageStatistics> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getImageStatistics")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementCollection Measurements {
			[Export ("Measurements")]
			get {
				FLIRMeasurementCollection ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRMeasurementCollection> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("Measurements")));
				} else {
					ret =  Runtime.GetNSObject<FLIRMeasurementCollection> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("Measurements")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_Palette_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Palette {
			[Export ("Palette", ArgumentSemantic.UnsafeUnretained)]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("Palette")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("Palette")));
				}
				MarkDirty ();
				__mt_Palette_var = ret;
				return ret;
			}
			
			[Export ("setPalette:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPalette:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPalette:"), value.Handle);
				}
				MarkDirty ();
				__mt_Palette_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPaletteManager PaletteManager {
			[Export ("PaletteManager")]
			get {
				FLIRPaletteManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPaletteManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("PaletteManager")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPaletteManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PaletteManager")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage Photo {
			[Export ("getPhoto")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getPhoto")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPhoto")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRScale Scale {
			[Export ("getScale")]
			get {
				FLIRScale ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRScale> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getScale")));
				} else {
					ret =  Runtime.GetNSObject<FLIRScale> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getScale")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TemperatureUnit TemperatureUnit {
			[Export ("getTemperatureUnit")]
			get {
				TemperatureUnit ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (TemperatureUnit) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("getTemperatureUnit"));
					} else {
						ret = (TemperatureUnit) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getTemperatureUnit"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (TemperatureUnit) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTemperatureUnit"));
					} else {
						ret = (TemperatureUnit) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTemperatureUnit"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, NSString> TextAnnotations {
			[Export ("getTextAnnotations")]
			get {
				NSDictionary<NSString, NSString> ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTextAnnotations")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTextAnnotations")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Palette_var = null;
			}
		}
	} /* class FLIRThermalImage */
}
