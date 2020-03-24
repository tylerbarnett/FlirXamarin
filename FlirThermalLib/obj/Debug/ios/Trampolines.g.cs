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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::FlirThermalLib.FLIRThermalImageBlock))]
		internal delegate void DFLIRThermalImageBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFLIRThermalImageBlock {
			static internal readonly DFLIRThermalImageBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFLIRThermalImageBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::FlirThermalLib.FLIRThermalImageBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<FlirThermalLib.FLIRThermalImage> (arg0));
			}
		} /* class SDFLIRThermalImageBlock */
		
		internal sealed class NIDFLIRThermalImageBlock : TrampolineBlockBase {
			DFLIRThermalImageBlock invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFLIRThermalImageBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFLIRThermalImageBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::FlirThermalLib.FLIRThermalImageBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::FlirThermalLib.FLIRThermalImageBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDFLIRThermalImageBlock ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::FlirThermalLib.FLIRThermalImage arg0)
			{
				invoker (BlockPointer, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDFLIRThermalImageBlock */
	}
}
