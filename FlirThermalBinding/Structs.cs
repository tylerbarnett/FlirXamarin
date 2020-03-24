//using System;

//namespace NativeLibrary
//{
//}
using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace FlirThermalBinding
{
	[Flags]
	[Native]
	public enum FLIRCommunicationInterface : ulong
	{
		None = 0x0,
		Usb = 0x1,
		Network = 0x2,
		Firewire = 0x4,
		Emulator = 0x8,
		Bluetooth = 0x10,
		Ebus = 0x20,
		UsbHsi = 0x40,
		Lightning = 0x80
	}

	[Native]
	public enum FLIRCameraType : long
	{
		Generic,
		FlirOne
	}

	[Native]
	public enum FLIRChargingState : ulong
	{
		Developer,
		Nocharging,
		Managedcharging,
		Chargingsmartphone,
		Fault,
		Faultheat,
		Faultbadcharger,
		Chargingsmartphonefaultheat,
		Managedchargingonly,
		Chargingsmartphoneonly,
		Bad
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct LastStoredImage_t
	{
		public NSUrl thermalImageUrl;

		public NSUrl visualImageUrl;
	}

	[Native]
	public enum FLIRCameraState : ulong
	{
		NotReady,
		Cooling,
		Ready
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct CompassInformation_t
	{
		public int degrees;

		public int roll;

		public int pitch;

		public int tilt;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GpsInformation_t
	{
		public bool isValid;

		public double dop;

		public double altitude;

		public nint altitudeRef;

		public double latitude;

		public string latitudeRef;

		public double longitude;

		public string longitudeRef;

		public string mapDatum;

		public string satellites;

		public nuint timeStamp;
	}

	[Native]
	public enum RotationAngle : ulong
	{
		RotationAngle180Degrees,
		RotationAngle270Degrees,
		RotationAngle90Degrees
	}

	[Native]
	public enum TemperatureUnit : ulong
	{
		Celsius,
		Fahrenheit,
		Kelvin,
		Signal
	}

	[Native]
	public enum ThermalValueState : ulong
	{
		Invalid,
		Ok,
		Overflow,
		Underflow,
		Outside,
		Warning,
		Unstable,
		Delta
	}

	public enum FusionMode : uint
	{
		IrMode,
		VisualMode,
		FusionPipMode,
		FusionThermalMode,
		FusionMsxMode,
		FusionBlendingMode
	}

	public enum VisualColorMode : uint
	{
		Color = 0,
		BlackAndWhite = 1
	}

	public enum ColorDistribution : uint
	{
		TemperatureLinear,
		HistogramEqualization
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct CameraInformation_t
	{
		public string filter;

		public string lens;

		public string modelName;

		public string serialNumber;

		FLIRThermalValue rangeMin;

		FLIRThermalValue rangeMax;
	}

	[Native]
	public enum DistanceUnit : ulong
	{
		Meter,
		Feet
	}

	[Native]
	public enum FLIRConnectionStatus : ulong
	{
		Disconnected,
		Disconnecting,
		Connecting,
		Connected
	}

	[Native]
	public enum CameraEvent : long
	{
		ImageSavedInCamera = 0,
		CameraConnectionLost = 1
	}

	[Native]
	public enum MLMeterType : ulong
	{
		other = 0,
		dmm,
		clamp,
		temperatureMeter,
		rhMeter,
		anemometer,
		manometer,
		moisture,
		gasSensor,
		waterQuality,
		vibrationMeter,
		soundMeter,
		weightScale,
		speed,
		tachometer,
		pressureMeter,
		last,
		invalid = 255
	}

	[Native]
	public enum MLSensorQuantity : ulong
	{
		invalid = 0,
		current,
		voltage,
		resistance,
		reactance,
		impedance,
		conductance,
		capacitance,
		inductance,
		el_field,
		mag_field,
		mag_flux,
		charge,
		temperature,
		free_slot,
		time,
		frequency,
		mass,
		force,
		pressure,
		momentum,
		torque,
		speed,
		acceleration,
		energy,
		power,
		enthalpy,
		relhumidity,
		abshumidity,
		relmoisture,
		distance,
		angle,
		radioactivity,
		rad_exposure,
		rad_abs_dose,
		rad_eq_dose,
		mass_mass_frac,
		mass_vol_frac,
		vol_vol_frac,
		rad_flux,
		lum_flux,
		lum_intensity,
		illuminance,
		power_factor,
		none,
		no_impl,
		admittance,
		rpm,
		dutycycle,
		test_volt,
		polar_index,
		dar,
		ebond_test_volt,
		ebond_test,
		SensorQuantity_20ma,
		phase,
		harmonic_lev,
		harmonic_thd,
		crest,
		quality_fact,
		dissipation,
		esr,
		ac_tester_load,
		ac_tester_unload_volt,
		ac_tester_load_volt,
		ac_tester_drop,
		receptacle_test,
		afci,
		gfci,
		gfci_trip_curr,
		gfci_trip_time,
		edp_trip_curr,
		neutral_ground,
		hot_imp,
		neutral_imp,
		ground_imp,
		short_circ_current,
		emissivity,
		resmoisture,
		group,
		capmoisture,
		soilmoisture,
		area,
		volume,
		emf_freq,
		emf_strength,
		weight,
		irradiance,
		compbearing,
		pitch,
		latitude,
		longitude,
		altitude,
		last
	}

	[Native]
	public enum MLSensorAuxInfo : ulong
	{
		invalid = 0,
		dc,
		ac,
		@internal,
		external,
		min_depr,
		max_depr,
		dew,
		air,
		ir,
		k,
		cond,
		db,
		wb,
		wme,
		ac_dc,
		vfd,
		thd,
		pf,
		last
	}

	[Native]
	public enum MLSensorMeasureInfo : ulong
	{
		invalid = 0,
		min,
		max,
		peakmin,
		peakmax,
		peaktopeak,
		mean,
		rms,
		median,
		alarm,
		hold,
		error,
		last
	}

	[Native]
	public enum FLIRMeterLinkState : long
	{
		Unknown = 0,
		Resetting,
		Unsupported,
		Unauthorized,
		PoweredOff,
		PoweredOn
	}

	[Native]
	public enum FLIRMeterLinkFileType : long
	{
		Log,
		Jpeg
	}

	[Native]
	public enum FLIRMeterLinkParseError : long
	{
		invalidType,
		uninitializedDevice,
		badParameter,
		badJpeg
	}
}

