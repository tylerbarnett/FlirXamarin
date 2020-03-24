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
	[Register("FLIRMeasurementCollection", true)]
	public unsafe partial class FLIRMeasurementCollection : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRMeasurementCollection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRMeasurementCollection () : base (NSObjectFlag.Empty)
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
		protected FLIRMeasurementCollection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRMeasurementCollection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addCircle:Radius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementCircle AddCircle (CGPoint posistion, int radius)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRMeasurementCircle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint_int (this.Handle, Selector.GetHandle ("addCircle:Radius:"), posistion, radius));
			} else {
				return  Runtime.GetNSObject<FLIRMeasurementCircle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint_int (this.SuperHandle, Selector.GetHandle ("addCircle:Radius:"), posistion, radius));
			}
		}
		
		[Export ("addHorizontalLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementLine AddHorizontalLine (int y)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRMeasurementLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("addHorizontalLine:"), y));
			} else {
				return  Runtime.GetNSObject<FLIRMeasurementLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addHorizontalLine:"), y));
			}
		}
		
		[Export ("addRectangle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementRectangle AddRectangle (CGRect rect)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRMeasurementRectangle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("addRectangle:"), rect));
			} else {
				return  Runtime.GetNSObject<FLIRMeasurementRectangle> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("addRectangle:"), rect));
			}
		}
		
		[Export ("addSpot:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementSpot AddSpot (CGPoint point)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRMeasurementSpot> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("addSpot:"), point));
			} else {
				return  Runtime.GetNSObject<FLIRMeasurementSpot> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("addSpot:"), point));
			}
		}
		
		[Export ("addVerticalLine:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRMeasurementLine AddVerticalLine (int x)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRMeasurementLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("addVerticalLine:"), x));
			} else {
				return  Runtime.GetNSObject<FLIRMeasurementLine> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addVerticalLine:"), x));
			}
		}
		
		[Export ("remove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (NSObject measurement)
		{
			if (measurement == null)
				throw new ArgumentNullException ("measurement");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("remove:"), measurement.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("remove:"), measurement.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementCircles {
			[Export ("measurementCircles")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementCircles")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementCircles")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementDeltas {
			[Export ("measurementDeltas")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementDeltas")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementDeltas")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementLines {
			[Export ("measurementLines")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementLines")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementLines")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementPolygons {
			[Export ("measurementPolygons")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementPolygons")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementPolygons")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementRectangles {
			[Export ("measurementRectangles")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementRectangles")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementRectangles")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MeasurementSpots {
			[Export ("measurementSpots")]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("measurementSpots")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("measurementSpots")));
				}
				return ret;
			}
			
		}
		
	} /* class FLIRMeasurementCollection */
}
