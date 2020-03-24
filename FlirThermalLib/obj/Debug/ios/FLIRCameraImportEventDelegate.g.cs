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
	[Protocol (Name = "FLIRCameraImportEventDelegate", WrapperType = typeof (FLIRCameraImportEventDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileAdded", Selector = "fileAdded:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileError", Selector = "fileError:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ImportError", Selector = "importError:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FileProgress", Selector = "fileProgress:forFileNumber:", ParameterType = new Type [] { typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	public interface IFLIRCameraImportEventDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("fileAdded:")]
		[Preserve (Conditional = true)]
		void FileAdded (NSObject @event);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("fileError:")]
		[Preserve (Conditional = true)]
		void FileError (NSObject @event);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("importError:")]
		[Preserve (Conditional = true)]
		void ImportError (NSDictionary e);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("fileProgress:forFileNumber:")]
		[Preserve (Conditional = true)]
		void FileProgress (int progress, int number);
		
	}
	
	internal sealed class FLIRCameraImportEventDelegateWrapper : BaseWrapper, IFLIRCameraImportEventDelegate {
		[Preserve (Conditional = true)]
		public FLIRCameraImportEventDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("fileAdded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FileAdded (NSObject @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileAdded:"), @event.Handle);
		}
		
		[Export ("fileError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FileError (NSObject @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("fileError:"), @event.Handle);
		}
		
		[Export ("importError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ImportError (NSDictionary e)
		{
			if (e == null)
				throw new ArgumentNullException ("e");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("importError:"), e.Handle);
		}
		
		[Export ("fileProgress:forFileNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FileProgress (int progress, int number)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("fileProgress:forFileNumber:"), progress, number);
		}
		
	}
}
namespace FlirThermalLib {
	[Protocol()]
	[Register("ApiDefinition__FlirThermalLib_FLIRCameraImportEventDelegate", false)]
	[Model]
	public unsafe abstract partial class FLIRCameraImportEventDelegate : NSObject, IFLIRCameraImportEventDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected FLIRCameraImportEventDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRCameraImportEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRCameraImportEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("fileAdded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void FileAdded (NSObject @event);
		[Export ("fileError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void FileError (NSObject @event);
		[Export ("fileProgress:forFileNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void FileProgress (int progress, int number);
		[Export ("importError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ImportError (NSDictionary e);
	} /* class FLIRCameraImportEventDelegate */
}
