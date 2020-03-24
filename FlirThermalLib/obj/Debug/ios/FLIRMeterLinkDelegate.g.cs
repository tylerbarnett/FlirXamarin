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
	[Protocol (Name = "FLIRMeterLinkDelegate", WrapperType = typeof (FLIRMeterLinkDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeviceDiscovered", Selector = "deviceDiscovered:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeviceDisappeared", Selector = "deviceDisappeared:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeviceConnected", Selector = "deviceConnected:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeviceDisconnected", Selector = "deviceDisconnected:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeviceUpdated", Selector = "deviceUpdated:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MlState", Selector = "mlState:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DataRecordingReceived", Selector = "dataRecordingReceived:data:CSVString:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice), typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ImageReceived", Selector = "imageReceived:image:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TransferProgress", Selector = "transferProgress:filetype:progressCurrent:progressTotal:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice), typeof (FlirThermalLib.FLIRMeterLinkFileType), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ParserError", Selector = "parserError:parseError:", ParameterType = new Type [] { typeof (FlirThermalLib.FLIRMeterLinkDevice), typeof (FlirThermalLib.FLIRMeterLinkParseError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedPacket", Selector = "receivedPacket:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	public interface IFLIRMeterLinkDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("deviceDiscovered:")]
		[Preserve (Conditional = true)]
		void DeviceDiscovered (FLIRMeterLinkDevice device);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("deviceDisappeared:")]
		[Preserve (Conditional = true)]
		void DeviceDisappeared (FLIRMeterLinkDevice device);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("deviceConnected:")]
		[Preserve (Conditional = true)]
		void DeviceConnected (FLIRMeterLinkDevice device);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("deviceDisconnected:")]
		[Preserve (Conditional = true)]
		void DeviceDisconnected (FLIRMeterLinkDevice device);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("deviceUpdated:")]
		[Preserve (Conditional = true)]
		void DeviceUpdated (FLIRMeterLinkDevice device);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("mlState:")]
		[Preserve (Conditional = true)]
		void MlState (FLIRMeterLinkState state);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("dataRecordingReceived:data:CSVString:")]
		[Preserve (Conditional = true)]
		void DataRecordingReceived (FLIRMeterLinkDevice device, NSObject data, string csvString);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("imageReceived:image:")]
		[Preserve (Conditional = true)]
		void ImageReceived (FLIRMeterLinkDevice device, NSData image);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("transferProgress:filetype:progressCurrent:progressTotal:")]
		[Preserve (Conditional = true)]
		void TransferProgress (FLIRMeterLinkDevice device, FLIRMeterLinkFileType type, int current, int total);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("parserError:parseError:")]
		[Preserve (Conditional = true)]
		void ParserError (FLIRMeterLinkDevice device, FLIRMeterLinkParseError error);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("receivedPacket:")]
		[Preserve (Conditional = true)]
		void ReceivedPacket (NSData data);
		
	}
	
	internal sealed class FLIRMeterLinkDelegateWrapper : BaseWrapper, IFLIRMeterLinkDelegate {
		[Preserve (Conditional = true)]
		public FLIRMeterLinkDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("deviceDiscovered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeviceDiscovered (FLIRMeterLinkDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deviceDiscovered:"), device.Handle);
		}
		
		[Export ("deviceDisappeared:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeviceDisappeared (FLIRMeterLinkDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deviceDisappeared:"), device.Handle);
		}
		
		[Export ("deviceConnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeviceConnected (FLIRMeterLinkDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deviceConnected:"), device.Handle);
		}
		
		[Export ("deviceDisconnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeviceDisconnected (FLIRMeterLinkDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deviceDisconnected:"), device.Handle);
		}
		
		[Export ("deviceUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeviceUpdated (FLIRMeterLinkDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deviceUpdated:"), device.Handle);
		}
		
		[Export ("mlState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MlState (FLIRMeterLinkState state)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("mlState:"), (Int64)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("mlState:"), (int)state);
			}
		}
		
		[Export ("dataRecordingReceived:data:CSVString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DataRecordingReceived (FLIRMeterLinkDevice device, NSObject data, string csvString)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (csvString == null)
				throw new ArgumentNullException ("csvString");
			var nscsvString = NSString.CreateNative (csvString);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("dataRecordingReceived:data:CSVString:"), device.Handle, data.Handle, nscsvString);
			NSString.ReleaseNative (nscsvString);
			
		}
		
		[Export ("imageReceived:image:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ImageReceived (FLIRMeterLinkDevice device, NSData image)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (image == null)
				throw new ArgumentNullException ("image");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("imageReceived:image:"), device.Handle, image.Handle);
		}
		
		[Export ("transferProgress:filetype:progressCurrent:progressTotal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void TransferProgress (FLIRMeterLinkDevice device, FLIRMeterLinkFileType type, int current, int total)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64_int_int (this.Handle, Selector.GetHandle ("transferProgress:filetype:progressCurrent:progressTotal:"), device.Handle, (Int64)type, current, total);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_int_int (this.Handle, Selector.GetHandle ("transferProgress:filetype:progressCurrent:progressTotal:"), device.Handle, (int)type, current, total);
			}
		}
		
		[Export ("parserError:parseError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ParserError (FLIRMeterLinkDevice device, FLIRMeterLinkParseError error)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("parserError:parseError:"), device.Handle, (Int64)error);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("parserError:parseError:"), device.Handle, (int)error);
			}
		}
		
		[Export ("receivedPacket:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedPacket (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("receivedPacket:"), data.Handle);
		}
		
	}
}
namespace FlirThermalLib {
	[Protocol()]
	[Register("ApiDefinition__FlirThermalLib_FLIRMeterLinkDelegate", false)]
	[Model]
	public unsafe abstract partial class FLIRMeterLinkDelegate : NSObject, IFLIRMeterLinkDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected FLIRMeterLinkDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected FLIRMeterLinkDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FLIRMeterLinkDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("dataRecordingReceived:data:CSVString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DataRecordingReceived (FLIRMeterLinkDevice device, NSObject data, string csvString);
		[Export ("deviceConnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DeviceConnected (FLIRMeterLinkDevice device);
		[Export ("deviceDisappeared:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DeviceDisappeared (FLIRMeterLinkDevice device);
		[Export ("deviceDisconnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DeviceDisconnected (FLIRMeterLinkDevice device);
		[Export ("deviceDiscovered:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DeviceDiscovered (FLIRMeterLinkDevice device);
		[Export ("deviceUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void DeviceUpdated (FLIRMeterLinkDevice device);
		[Export ("imageReceived:image:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ImageReceived (FLIRMeterLinkDevice device, NSData image);
		[Export ("mlState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void MlState (FLIRMeterLinkState state);
		[Export ("parserError:parseError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ParserError (FLIRMeterLinkDevice device, FLIRMeterLinkParseError error);
		[Export ("receivedPacket:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ReceivedPacket (NSData data);
		[Export ("transferProgress:filetype:progressCurrent:progressTotal:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void TransferProgress (FLIRMeterLinkDevice device, FLIRMeterLinkFileType type, int current, int total);
	} /* class FLIRMeterLinkDelegate */
}
