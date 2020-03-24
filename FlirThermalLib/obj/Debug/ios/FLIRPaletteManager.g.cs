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
	[Register("FLIRPaletteManager", true)]
	public unsafe partial class FLIRPaletteManager : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("FLIRPaletteManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FLIRPaletteManager () : base (NSObjectFlag.Empty)
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
		protected FLIRPaletteManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRPaletteManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("open:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Open (NSUrl paletteFile)
		{
			if (paletteFile == null)
				throw new ArgumentNullException ("paletteFile");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("open:"), paletteFile.Handle));
			} else {
				return  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("open:"), paletteFile.Handle));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Arctic {
			[Export ("arctic")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("arctic")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("arctic")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Blackhot {
			[Export ("blackhot")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("blackhot")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("blackhot")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Coldest {
			[Export ("coldest")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("coldest")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("coldest")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette ColorWheel6 {
			[Export ("colorWheel6")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("colorWheel6")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("colorWheel6")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette[] DefaultPalettes {
			[Export ("getDefaultPalettes")]
			get {
				FLIRPalette[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<FLIRPalette>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDefaultPalettes")));
				} else {
					ret = NSArray.ArrayFromHandle<FLIRPalette>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDefaultPalettes")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette DoubleRainbow {
			[Export ("doubleRainbow")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("doubleRainbow")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("doubleRainbow")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette FromImage {
			[Export ("fromImage")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fromImage")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fromImage")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Gray {
			[Export ("gray")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("gray")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gray")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Hottest {
			[Export ("hottest")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hottest")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hottest")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Iron {
			[Export ("iron")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("iron")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("iron")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Lava {
			[Export ("lava")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lava")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lava")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette RainHC {
			[Export ("rainHC")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rainHC")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rainHC")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Rainbow {
			[Export ("rainbow")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rainbow")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rainbow")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FLIRPalette Whitehot {
			[Export ("whitehot")]
			get {
				FLIRPalette ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("whitehot")));
				} else {
					ret =  Runtime.GetNSObject<FLIRPalette> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("whitehot")));
				}
				return ret;
			}
			
		}
		
	} /* class FLIRPaletteManager */
}
