using UIKit;
using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace FlirThermalLib
{

	//namespace libFlirBinder
	//{
		// @interface FLIRAdapterInfo : NSObject
		[BaseType(typeof(NSObject))]
		public interface FLIRAdapterInfo
		{
			// -(NSString * _Nonnull)name;
			[Export("name")]
			//[Verify (MethodToProperty)]
			string Name { get; }

			// -(BOOL)isWireless;
			[Export("isWireless")]
			//[Verify (MethodToProperty)]
			bool IsWireless { get; }

			// -(NSString * _Nonnull)macAddress;
			[Export("macAddress")]
			//[Verify (MethodToProperty)]
			string MacAddress { get; }

			// -(NSString * _Nonnull)ipAddress;
			[Export("ipAddress")]
			//[Verify (MethodToProperty)]
			string IpAddress { get; }

			// -(NSString * _Nonnull)mask;
			[Export("mask")]
			//[Verify (MethodToProperty)]
			string Mask { get; }
		}

		// @interface FLIRIpSettings : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRIpSettings
		{
			// -(NSString * _Nullable)hosttarget;
			[NullAllowed, Export("hosttarget")]
			//[Verify (MethodToProperty)]
			string Hosttarget { get; }

			// -(NSString * _Nonnull)ipAddress;
			[Export("ipAddress")]
			//[Verify (MethodToProperty)]
			string IpAddress { get; }

			// -(NSString * _Nonnull)macAddress;
			[Export("macAddress")]
			//[Verify (MethodToProperty)]
			string MacAddress { get; }

			// -(NSString * _Nonnull)defaultGateway;
			[Export("defaultGateway")]
			//[Verify (MethodToProperty)]
			string DefaultGateway { get; }

			// -(NSString * _Nonnull)subnetMask;
			[Export("subnetMask")]
			//[Verify (MethodToProperty)]
			string SubnetMask { get; }

			// -(BOOL)isDhcpEnabled;
			[Export("isDhcpEnabled")]
			//[Verify (MethodToProperty)]
			bool IsDhcpEnabled { get; }

			// -(BOOL)isValid;
			[Export("isValid")]
			//[Verify (MethodToProperty)]
			bool IsValid { get; }

			// -(FLIRAdapterInfo * _Nonnull)adapterInfo;
			[Export("adapterInfo")]
			//[Verify (MethodToProperty)]
			FLIRAdapterInfo AdapterInfo { get; }
		}

		// @interface FLIRCameraInformation : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCameraInformation
		{
			// -(NSString * _Nonnull)modelName;
			[Export("modelName")]
			//[Verify (MethodToProperty)]
			string ModelName { get; }

			// -(NSString * _Nonnull)name;
			[Export("name")]
			//[Verify (MethodToProperty)]
			string Name { get; }

			// -(NSString * _Nonnull)displayName;
			[Export("displayName")]
			//[Verify (MethodToProperty)]
			string DisplayName { get; }

			// -(NSString * _Nonnull)description;
			[Export("description")]
			//[Verify (MethodToProperty)]
			string Description { get; }

			// -(NSString * _Nonnull)serialNumber;
			[Export("serialNumber")]
			//[Verify (MethodToProperty)]
			string SerialNumber { get; }

			// -(NSString * _Nonnull)osImagekitName __attribute__((deprecated("Use osImageKitName instead.")));
			[Export("osImagekitName")]
			//[Verify (MethodToProperty)]
			string OsImagekitName { get; }

			// -(NSString * _Nonnull)osImageKitName;
			[Export("osImageKitName")]
			//[Verify (MethodToProperty)]
			string OsImageKitName { get; }

			// -(NSString * _Nonnull)swCombinationVersion;
			[Export("swCombinationVersion")]
			//[Verify (MethodToProperty)]
			string SwCombinationVersion { get; }

			// -(NSString * _Nonnull)confKitName;
			[Export("confKitName")]
			//[Verify (MethodToProperty)]
			string ConfKitName { get; }

			// -(NSString * _Nonnull)article;
			[Export("article")]
			//[Verify (MethodToProperty)]
			string Article { get; }

			// -(NSString * _Nullable)date;
			[NullAllowed, Export("date")]
			//[Verify (MethodToProperty)]
			string Date { get; }

			// -(NSInteger)width;
			[Export("width")]
			//[Verify (MethodToProperty)]
			nint Width { get; }

			// -(NSInteger)height;
			[Export("height")]
			//[Verify (MethodToProperty)]
			nint Height { get; }

			// -(NSString * _Nonnull)firmwareRevision;
			[Export("firmwareRevision")]
			//[Verify (MethodToProperty)]
			string FirmwareRevision { get; }
		}

		// @interface FLIRIdentity : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRIdentity
		{
			// -(FLIRCommunicationInterface)communicationInterface;
			[Export("communicationInterface")]
			//[Verify (MethodToProperty)]
			FLIRCommunicationInterface CommunicationInterface { get; }

			// -(FLIRCameraType)cameraType;
			[Export("cameraType")]
			//[Verify (MethodToProperty)]
			FLIRCameraType CameraType { get; }

			// -(NSString * _Nonnull)deviceId;
			[Export("deviceId")]
			//[Verify (MethodToProperty)]
			string DeviceId { get; }

			// -(FLIRIpSettings * _Nullable)ipSettings;
			[NullAllowed, Export("ipSettings")]
			//[Verify (MethodToProperty)]
			FLIRIpSettings IpSettings { get; }

			// -(instancetype _Nullable)initWithIpAddr:(NSString * _Nullable)ipAddr;
			//[Export ("initWithIpAddr:")]
			//IntPtr Constructor ([NullAllowed] string ipAddr);

			// -(instancetype _Nullable)initWithFlirOneSerialNo:(NSString * _Nullable)serial;
			[Export("initWithFlirOneSerialNo:")]
			IntPtr Constructor([NullAllowed] string serial);
		}

		// @protocol FLIRRemoteDelegate <NSObject>
		[Protocol, Model(AutoGeneratedName = true)]
		[BaseType(typeof(NSObject))]
		interface FLIRRemoteDelegate
		{
			// @optional -(void)ChargingStateChanged:(FLIRChargingState)state;
			[Export("ChargingStateChanged:")]
			void ChargingStateChanged(FLIRChargingState state);

			// @optional -(void)PercentageChanged:(int)percent;
			[Export("PercentageChanged:")]
			void PercentageChanged(int percent);

			// @optional -(void)CalibrationStateChanged:(BOOL)state;
			[Export("CalibrationStateChanged:")]
			void CalibrationStateChanged(bool state);

			// @optional -(void)LastStoredImageChanged:(LastStoredImage_t)laststore;
			[Export("LastStoredImageChanged:")]
			void LastStoredImageChanged(LastStoredImage_t laststore);
		}

		// @interface FLIRBattery : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRBattery
		{
			// -(FLIRChargingState)getChargingState;
			[Export("getChargingState")]
			//[Verify (MethodToProperty)]
			FLIRChargingState ChargingState { get; }

			// -(int)getPercentage;
			[Export("getPercentage")]
			//[Verify (MethodToProperty)]
			int Percentage { get; }

			// -(void)subscribeChargingState;
			[Export("subscribeChargingState")]
			void SubscribeChargingState();

			// -(void)subscribePercentage;
			[Export("subscribePercentage")]
			void SubscribePercentage();

			// -(void)unsubscribeChargingState;
			[Export("unsubscribeChargingState")]
			void UnsubscribeChargingState();

			// -(void)unsubscribePercentage;
			[Export("unsubscribePercentage")]
			void UnsubscribePercentage();
		}

		// @interface FLIRCalibration : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCalibration
		{
			// -(BOOL)isActive;
			[Export("isActive")]
			//[Verify (MethodToProperty)]
			bool IsActive { get; }

			// -(void)performNUC;
			[Export("performNUC")]
			void PerformNUC();

			// -(void)subscribeCalibrationState;
			[Export("subscribeCalibrationState")]
			void SubscribeCalibrationState();

			// -(void)unsubscribeCalibrationState;
			[Export("unsubscribeCalibrationState")]
			void UnsubscribeCalibrationState();
		}

		// @interface FLIRStorage : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRStorage
		{
			// -(NSURL * _Nullable)getImagesStorage;
			[NullAllowed, Export("getImagesStorage")]
			//[Verify (MethodToProperty)]
			NSUrl ImagesStorage { get; }

			// -(LastStoredImage_t)getLastStoredImage;
			[Export("getLastStoredImage")]
			//[Verify (MethodToProperty)]
			LastStoredImage_t LastStoredImage { get; }

			// -(void)subscribeLastStoredImage;
			[Export("subscribeLastStoredImage")]
			void SubscribeLastStoredImage();

			// -(void)unsubscribeLastStoredImag;
			[Export("unsubscribeLastStoredImag")]
			void UnsubscribeLastStoredImag();
		}

		// @interface FLIRRemoteControl : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRRemoteControl
		{
			[Wrap("WeakDelegate")]
			[NullAllowed]
			NSObject Delegate { get; set; }

			// @property (assign, nonatomic) id _Nullable delegate;
			[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
			NSObject WeakDelegate { get; set; }

			// -(FLIRCameraInformation * _Nullable)getCameraInformation:(NSError * _Nullable * _Nullable)error;
			[Export("getCameraInformation:")]
			[return: NullAllowed]
			FLIRCameraInformation GetCameraInformation([NullAllowed] out NSError error);

			// -(FLIRBattery * _Nullable)getBattery;
			[NullAllowed, Export("getBattery")]
			//[Verify (MethodToProperty)]
			FLIRBattery Battery { get; }

			// -(FLIRCalibration * _Nullable)getCalibration;
			[NullAllowed, Export("getCalibration")]
			//[Verify (MethodToProperty)]
			FLIRCalibration Calibration { get; }

			// -(FLIRStorage * _Nullable)getStorage;
			[NullAllowed, Export("getStorage")]
			//[Verify (MethodToProperty)]
			FLIRStorage Storage { get; }

			// -(FLIRCameraState)isCameraReady;
			[Export("isCameraReady")]
			//[Verify (MethodToProperty)]
			FLIRCameraState IsCameraReady { get; }
		}

		// @interface FLIRImageBase : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRImageBase
		{
			// -(int)getWidth;
			[Export("getWidth")]
			//[Verify (MethodToProperty)]
			int Width { get; }

			// -(int)getHeight;
			[Export("getHeight")]
			//[Verify (MethodToProperty)]
			int Height { get; }

			// -(CompassInformation_t)getCompassInformation;
			[Export("getCompassInformation")]
			//[Verify (MethodToProperty)]
			CompassInformation_t CompassInformation { get; }

			// -(GpsInformation_t)getGpsInformation;
			[Export("getGpsInformation")]
			//[Verify (MethodToProperty)]
			GpsInformation_t GpsInformation { get; }

			// -(void)setRotate:(RotationAngle)angle;
			[Export("setRotate:")]
			void SetRotate(RotationAngle angle);

			// -(NSString *)getDescription;
			[Export("getDescription")]
			//[Verify (MethodToProperty)]
			string Description { get; }

			// -(void)setDescription:(NSString *)description;
			[Export("setDescription:")]
			void SetDescription(string description);
		}

		// @interface FLIRMeasurementParameters : NSObject
		[BaseType(typeof(NSObject))]
		[DisableDefaultCtor]
		interface FLIRMeasurementParameters
		{
			// @property (readwrite) double distance;
			[Export("distance")]
			double Distance { get; set; }

			// @property (readwrite) double emissivity;
			[Export("emissivity")]
			double Emissivity { get; set; }

			// @property (readwrite) double reflectedTemperature;
			[Export("reflectedTemperature")]
			double ReflectedTemperature { get; set; }

			// @property (readwrite) _Bool useCustomObjectParameters;
			[Export("useCustomObjectParameters")]
			bool UseCustomObjectParameters { get; set; }
		}

		// @interface FLIRMeasurementShape : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeasurementShape
		{
			// @property (readonly) uint32_t identity;
			[Export("identity")]
			uint Identity { get; }

			// @property (readwrite, nonatomic) NSString * name;
			[Export("name")]
			string Name { get; set; }

			// @property (readonly, nonatomic) FLIRMeasurementParameters * thermalParameters;
			[Export("thermalParameters")]
			FLIRMeasurementParameters ThermalParameters { get; }

			// -(void)offset:(CGPoint)offset;
			[Export("offset:")]
			void Offset(CGPoint offset);

			// -(void)moveTo:(CGPoint)point;
			[Export("moveTo:")]
			void MoveTo(CGPoint point);
		}

		// @interface FLIRThermalValue : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRThermalValue
		{
			// -(instancetype)initWithValue:(double)value andUnit:(TemperatureUnit)unit;
			[Export("initWithValue:andUnit:")]
			IntPtr Constructor(double value, TemperatureUnit unit);

			// @property (readonly) double value;
			[Export("value")]
			double Value { get; }

			// @property (readonly) TemperatureUnit unit;
			[Export("unit")]
			TemperatureUnit Unit { get; }

			// @property (readonly) ThermalValueState state;
			[Export("state")]
			ThermalValueState State { get; }
		}

		// @interface FLIRMeasurementSpot : FLIRMeasurementShape
		[BaseType(typeof(FLIRMeasurementShape))]
		interface FLIRMeasurementSpot
		{
			// @property (readonly, nonatomic) FLIRThermalValue * value;
			[Export("value")]
			FLIRThermalValue Value { get; }

			// @property (readwrite) uint32_t x;
			[Export("x")]
			uint X { get; set; }

			// @property (readwrite) uint32_t y;
			[Export("y")]
			uint Y { get; set; }
		}

		// @interface FLIRMeasurementMarker : FLIRMeasurementShape
		[BaseType(typeof(FLIRMeasurementShape))]
		interface FLIRMeasurementMarker
		{
			// @property (readonly, nonatomic) FLIRThermalValue * average;
			[Export("average")]
			FLIRThermalValue Average { get; }

			// @property (readonly, nonatomic) FLIRThermalValue * max;
			[Export("max")]
			FLIRThermalValue Max { get; }

			// @property (readonly, nonatomic) FLIRThermalValue * min;
			[Export("min")]
			FLIRThermalValue Min { get; }

			// @property (readonly, nonatomic) CGPoint hotSpot;
			[Export("hotSpot")]
			CGPoint HotSpot { get; }

			// @property (readonly, nonatomic) CGPoint coldSpot;
			[Export("coldSpot")]
			CGPoint ColdSpot { get; }

			// @property (readonly, nonatomic) BOOL isAverageEnabled;
			[Export("isAverageEnabled")]
			bool IsAverageEnabled { get; }

			// @property (readonly, nonatomic) BOOL isHotSpotEnabled;
			[Export("isHotSpotEnabled")]
			bool IsHotSpotEnabled { get; }

			// @property (readonly, nonatomic) BOOL isHotSpotVisible;
			[Export("isHotSpotVisible")]
			bool IsHotSpotVisible { get; }

			// @property (readonly, nonatomic) BOOL isColdSpotEnabled;
			[Export("isColdSpotEnabled")]
			bool IsColdSpotEnabled { get; }

			// @property (readonly, nonatomic) BOOL isColdSpotVisible;
			[Export("isColdSpotVisible")]
			bool IsColdSpotVisible { get; }
		}

		// @interface FLIRMeasurementArea : FLIRMeasurementMarker
		[BaseType(typeof(FLIRMeasurementMarker))]
		interface FLIRMeasurementArea
		{
			// @property (readonly) uint32_t width;
			[Export("width")]
			uint Width { get; }

			// @property (readonly) uint32_t height;
			[Export("height")]
			uint Height { get; }
		}

		// @interface FLIRMeasurementRectangle : FLIRMeasurementArea
		[BaseType(typeof(FLIRMeasurementArea))]
		interface FLIRMeasurementRectangle
		{
			// @property (readwrite) CGPoint position;
			[Export("position", ArgumentSemantic.Assign)]
			CGPoint Position { get; set; }

			// @property (readwrite) CGRect rectangle;
			[Export("rectangle", ArgumentSemantic.Assign)]
			CGRect Rectangle { get; set; }
		}

		// @interface FLIRMeasurementCircle : FLIRMeasurementArea
		[BaseType(typeof(FLIRMeasurementArea))]
		interface FLIRMeasurementCircle
		{
			// @property (readwrite) CGPoint position;
			[Export("position", ArgumentSemantic.Assign)]
			CGPoint Position { get; set; }

			// @property (readwrite) int radius;
			[Export("radius")]
			int Radius { get; set; }
		}

		// @interface FLIRMeasurementLine : FLIRMeasurementMarker
		[BaseType(typeof(FLIRMeasurementMarker))]
		interface FLIRMeasurementLine
		{
			// -(void)setVerticalLine:(int)x MarkerMin:(_Bool)markerMin MarkerMax:(_Bool)markerMax;
			[Export("setVerticalLine:MarkerMin:MarkerMax:")]
			void SetVerticalLine(int x, bool markerMin, bool markerMax);

			// -(void)setHorizontalLine:(int)y MarkerMin:(_Bool)markerMin MarkerMax:(_Bool)markerMax;
			[Export("setHorizontalLine:MarkerMin:MarkerMax:")]
			void SetHorizontalLine(int y, bool markerMin, bool markerMax);

			// @property (readonly) CGPoint startPosition;
			[Export("startPosition")]
			CGPoint StartPosition { get; }

			// @property (readonly) CGPoint endPosition;
			[Export("endPosition")]
			CGPoint EndPosition { get; }

			// -(BOOL)isHorizontal;
			[Export("isHorizontal")]
			//[Verify (MethodToProperty)]
			bool IsHorizontal { get; }
		}

		// @interface FLIRMeasurementCollection : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeasurementCollection
		{
			// @property (readonly, nonatomic) NSMutableArray * measurementDeltas;
			[Export("measurementDeltas")]
			NSMutableArray MeasurementDeltas { get; }

			// @property (readonly, nonatomic) NSMutableArray * measurementCircles;
			[Export("measurementCircles")]
			NSMutableArray MeasurementCircles { get; }

			// @property (readonly, nonatomic) NSMutableArray * measurementLines;
			[Export("measurementLines")]
			NSMutableArray MeasurementLines { get; }

			// @property (readonly, nonatomic) NSMutableArray * measurementPolygons;
			[Export("measurementPolygons")]
			NSMutableArray MeasurementPolygons { get; }

			// @property (readonly, nonatomic) NSMutableArray * measurementRectangles;
			[Export("measurementRectangles")]
			NSMutableArray MeasurementRectangles { get; }

			// @property (readonly, nonatomic) NSMutableArray * measurementSpots;
			[Export("measurementSpots")]
			NSMutableArray MeasurementSpots { get; }

			// -(FLIRMeasurementSpot *)addSpot:(CGPoint)point;
			[Export("addSpot:")]
			FLIRMeasurementSpot AddSpot(CGPoint point);

			// -(FLIRMeasurementRectangle *)addRectangle:(CGRect)rect;
			[Export("addRectangle:")]
			FLIRMeasurementRectangle AddRectangle(CGRect rect);

			// -(FLIRMeasurementCircle *)addCircle:(CGPoint)posistion Radius:(int)radius;
			[Export("addCircle:Radius:")]
			FLIRMeasurementCircle AddCircle(CGPoint posistion, int radius);

			// -(FLIRMeasurementLine *)addHorizontalLine:(int)y;
			[Export("addHorizontalLine:")]
			FLIRMeasurementLine AddHorizontalLine(int y);

			// -(FLIRMeasurementLine *)addVerticalLine:(int)x;
			[Export("addVerticalLine:")]
			FLIRMeasurementLine AddVerticalLine(int x);

			// -(void)remove:(id)measurement;
			[Export("remove:")]
			void Remove(NSObject measurement);
		}

		// @interface FLIRPalette : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRPalette
		{
			// @property (readwrite) UIColor * aboveSpanColor;
			[Export("aboveSpanColor", ArgumentSemantic.Assign)]
			UIColor AboveSpanColor { get; set; }

			// @property (readwrite) UIColor * belowSpanColor;
			[Export("belowSpanColor", ArgumentSemantic.Assign)]
			UIColor BelowSpanColor { get; set; }

			// @property (readwrite) UIColor * overflowColor;
			[Export("overflowColor", ArgumentSemantic.Assign)]
			UIColor OverflowColor { get; set; }

			// @property (readwrite) UIColor * underflowColor;
			[Export("underflowColor", ArgumentSemantic.Assign)]
			UIColor UnderflowColor { get; set; }

			// @property (readwrite) NSArray * paletteColors;
			[Export("paletteColors", ArgumentSemantic.Assign)]
			//[Verify (StronglyTypedNSArray)]
			NSObject[] PaletteColors { get; set; }

			// @property (readwrite) BOOL isInverted;
			[Export("isInverted")]
			bool IsInverted { get; set; }

			// @property (readwrite) NSString * name;
			[Export("name")]
			string Name { get; set; }
		}

		// @interface FLIRPaletteManager : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRPaletteManager
		{
			// @property (readonly) FLIRPalette * arctic;
			[Export("arctic")]
			FLIRPalette Arctic { get; }

			// @property (readonly) FLIRPalette * blackhot;
			[Export("blackhot")]
			FLIRPalette Blackhot { get; }

			// @property (readonly) FLIRPalette * gray;
			[Export("gray")]
			FLIRPalette Gray { get; }

			// @property (readonly) FLIRPalette * iron;
			[Export("iron")]
			FLIRPalette Iron { get; }

			// @property (readonly) FLIRPalette * lava;
			[Export("lava")]
			FLIRPalette Lava { get; }

			// @property (readonly) FLIRPalette * rainbow;
			[Export("rainbow")]
			FLIRPalette Rainbow { get; }

			// @property (readonly) FLIRPalette * rainHC;
			[Export("rainHC")]
			FLIRPalette RainHC { get; }

			// @property (readonly) FLIRPalette * coldest;
			[Export("coldest")]
			FLIRPalette Coldest { get; }

			// @property (readonly) FLIRPalette * hottest;
			[Export("hottest")]
			FLIRPalette Hottest { get; }

			// @property (readonly) FLIRPalette * colorWheel6;
			[Export("colorWheel6")]
			FLIRPalette ColorWheel6 { get; }

			// @property (readonly) FLIRPalette * doubleRainbow;
			[Export("doubleRainbow")]
			FLIRPalette DoubleRainbow { get; }

			// @property (readonly) FLIRPalette * whitehot;
			[Export("whitehot")]
			FLIRPalette Whitehot { get; }

			// @property (readonly) FLIRPalette * fromImage;
			[Export("fromImage")]
			FLIRPalette FromImage { get; }

			// -(FLIRPalette *)open:(NSURL *)paletteFile;
			[Export("open:")]
			FLIRPalette Open(NSUrl paletteFile);

			// -(NSArray<FLIRPalette *> *)getDefaultPalettes;
			[Export("getDefaultPalettes")]
			//[Verify (MethodToProperty)]
			FLIRPalette[] DefaultPalettes { get; }
		}

		// @interface FLIRImageParameters : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRImageParameters
		{
			// @property (readwrite) float emissivity;
			[Export("emissivity")]
			float Emissivity { get; set; }

			// @property (readwrite) float objectDistance;
			[Export("objectDistance")]
			float ObjectDistance { get; set; }

			// @property (readwrite) float reflectedTemperature;
			[Export("reflectedTemperature")]
			float ReflectedTemperature { get; set; }

			// @property (readwrite) float atmosphericTemperature;
			[Export("atmosphericTemperature")]
			float AtmosphericTemperature { get; set; }

			// @property (readwrite) float externalOpticsTemperature;
			[Export("externalOpticsTemperature")]
			float ExternalOpticsTemperature { get; set; }

			// @property (readwrite) float externalOpticsTransmission;
			[Export("externalOpticsTransmission")]
			float ExternalOpticsTransmission { get; set; }

			// @property (readwrite) float transmission;
			[Export("transmission")]
			float Transmission { get; set; }

			// @property (readwrite) float relativeHumidity;
			[Export("relativeHumidity")]
			float RelativeHumidity { get; set; }
		}

		// @interface FLIRImageStatistics : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRImageStatistics
		{
			// -(FLIRThermalValue *)getMin;
			[Export("getMin")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue Min { get; }

			// -(FLIRThermalValue *)getMax;
			[Export("getMax")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue Max { get; }

			// -(FLIRThermalValue *)getAverage;
			[Export("getAverage")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue Average { get; }

			// -(FLIRThermalValue *)getStandardDeviation;
			[Export("getStandardDeviation")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue StandardDeviation { get; }

			// -(CGPoint)getHotSpot;
			[Export("getHotSpot")]
			//[Verify (MethodToProperty)]
			CGPoint HotSpot { get; }

			// -(CGPoint)getColdSpot;
			[Export("getColdSpot")]
			//[Verify (MethodToProperty)]
			CGPoint ColdSpot { get; }
		}

		// @interface FLIRFusion : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRFusion
		{
			// -(void)setFusionMode:(FusionMode)mode;
			[Export("setFusionMode:")]
			void SetFusionMode(FusionMode mode);

			// -(FusionMode)getFusionMode;
			[Export("getFusionMode")]
			//[Verify (MethodToProperty)]
			FusionMode FusionMode { get; }

			// -(void)setMSX:(double)alpha;
			[Export("setMSX:")]
			void SetMSX(double alpha);

			// -(double)getMSX;
			[Export("getMSX")]
			//[Verify (MethodToProperty)]
			double MSX { get; }

			// -(void)setPictureInPicture:(CGRect)rect;
			[Export("setPictureInPicture:")]
			void SetPictureInPicture(CGRect rect);

			// -(CGRect)getPictureInPictureRect;
			[Export("getPictureInPictureRect")]
			//[Verify (MethodToProperty)]
			CGRect PictureInPictureRect { get; }

			// -(void)setVisualOnly:(VisualColorMode)mode;
			[Export("setVisualOnly:")]
			void SetVisualOnly(VisualColorMode mode);

			// -(VisualColorMode)getVisualOnly;
			[Export("getVisualOnly")]
			//[Verify (MethodToProperty)]
			VisualColorMode VisualOnly { get; }

			// -(void)setThermalFusionWithMin:(FLIRThermalValue *)min andMax:(FLIRThermalValue *)max;
			[Export("setThermalFusionWithMin:andMax:")]
			void SetThermalFusionWithMin(FLIRThermalValue min, FLIRThermalValue max);

			// -(void)setThermalFusionWithMin:(FLIRThermalValue *)min;
			[Export("setThermalFusionWithMin:")]
			void SetThermalFusionWithMin(FLIRThermalValue min);

			// -(void)setThermalFusionWithMax:(FLIRThermalValue *)max;
			[Export("setThermalFusionWithMax:")]
			void SetThermalFusionWithMax(FLIRThermalValue max);

			// -(FLIRThermalValue *)getThermalFusionMin;
			[Export("getThermalFusionMin")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue ThermalFusionMin { get; }

			// -(FLIRThermalValue *)getThermalFusionMax;
			[Export("getThermalFusionMax")]
			//[Verify (MethodToProperty)]
			FLIRThermalValue ThermalFusionMax { get; }

			// -(void)setBlending:(double)level ColorMode:(VisualColorMode)colorMode;
			[Export("setBlending:ColorMode:")]
			void SetBlending(double level, VisualColorMode colorMode);

			// -(double)getBlendingLevel;
			[Export("getBlendingLevel")]
			//[Verify (MethodToProperty)]
			double BlendingLevel { get; }

			// -(VisualColorMode)getBlendingColorMode;
			[Export("getBlendingColorMode")]
			//[Verify (MethodToProperty)]
			VisualColorMode BlendingColorMode { get; }
		}

		// @interface FLIRScale : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRScale
		{
			// -(void)setRangeWithMin:(double)min andMax:(double)max;
			[Export("setRangeWithMin:andMax:")]
			void SetRangeWithMin(double min, double max);

			// -(void)enableAutoAdjust;
			[Export("enableAutoAdjust")]
			void EnableAutoAdjust();

			// -(double)getRangeMin;
			[Export("getRangeMin")]
			//[Verify (MethodToProperty)]
			double RangeMin { get; }

			// -(double)getRangeMax;
			[Export("getRangeMax")]
			//[Verify (MethodToProperty)]
			double RangeMax { get; }

			// -(UIImage *)getImage;
			[Export("getImage")]
			//[Verify (MethodToProperty)]
			UIImage Image { get; }

			// -(BOOL)isAutoAdjustEnabled;
			[Export("isAutoAdjustEnabled")]
			//[Verify (MethodToProperty)]
			bool IsAutoAdjustEnabled { get; }

			// -(void)setRangeMax:(double)max;
			[Export("setRangeMax:")]
			void SetRangeMax(double max);

			// -(void)setRangeMin:(double)min;
			[Export("setRangeMin:")]
			void SetRangeMin(double min);
		}

		// @interface FLIRThermalImage : FLIRImageBase
		[BaseType(typeof(FLIRImageBase))]
		interface FLIRThermalImage
		{
			// @property (readonly, nonatomic) FLIRMeasurementCollection * Measurements;
			[Export("Measurements")]
			FLIRMeasurementCollection Measurements { get; }

			// @property (readonly, nonatomic) FLIRPaletteManager * PaletteManager;
			[Export("PaletteManager")]
			FLIRPaletteManager PaletteManager { get; }

			// @property (readwrite, nonatomic) FLIRPalette * Palette;
			[Export("Palette", ArgumentSemantic.Assign)]
			FLIRPalette Palette { get; set; }

			// -(FLIRImageParameters *)getImageParameters;
			[Export("getImageParameters")]
			//[Verify (MethodToProperty)]
			FLIRImageParameters ImageParameters { get; }

			// -(NSArray *)getExternalSensors;
			[Export("getExternalSensors")]
			//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
			NSObject[] ExternalSensors { get; }

			// -(UIImage *)getImage;
			[Export("getImage")]
			//[Verify (MethodToProperty)]
			UIImage Image { get; }

			// -(FLIRImageStatistics *)getImageStatistics;
			[Export("getImageStatistics")]
			//[Verify (MethodToProperty)]
			FLIRImageStatistics ImageStatistics { get; }

			// -(FLIRScale *)getScale;
			[Export("getScale")]
			//[Verify (MethodToProperty)]
			FLIRScale Scale { get; }

			// -(FLIRFusion *)getFusion;
			[Export("getFusion")]
			//[Verify (MethodToProperty)]
			FLIRFusion Fusion { get; }

			// -(ColorDistribution)getColorDistribution;
			[Export("getColorDistribution")]
			//[Verify (MethodToProperty)]
			ColorDistribution ColorDistribution { get; }

			// -(void)setColorDistribution:(ColorDistribution)value;
			[Export("setColorDistribution:")]
			void SetColorDistribution(ColorDistribution value);

			// -(CameraInformation_t)getCameraInformation;
			[Export("getCameraInformation")]
			//[Verify (MethodToProperty)]
			CameraInformation_t CameraInformation { get; }

			// -(DistanceUnit)getDistanceUnit;
			[Export("getDistanceUnit")]
			//[Verify (MethodToProperty)]
			DistanceUnit DistanceUnit { get; }

			// -(UIImage *)getPhoto;
			[Export("getPhoto")]
			//[Verify (MethodToProperty)]
			UIImage Photo { get; }

			// -(TemperatureUnit)getTemperatureUnit;
			[Export("getTemperatureUnit")]
			//[Verify (MethodToProperty)]
			TemperatureUnit TemperatureUnit { get; }

			// -(NSDictionary<NSString *,NSString *> *)getTextAnnotations;
			[Export("getTextAnnotations")]
			//[Verify (MethodToProperty)]
			NSDictionary<NSString, NSString> TextAnnotations { get; }

			// -(void)setTextAnnotations:(NSDictionary<NSString *,NSString *> *)annotations;
			[Export("setTextAnnotations:")]
			void SetTextAnnotations(NSDictionary<NSString, NSString> annotations);

			// -(double)getValueAt:(CGPoint)point;
			[Export("getValueAt:")]
			double GetValueAt(CGPoint point);

			// -(NSArray<NSNumber *> *)getValues:(NSArray<NSValue *> *)points;
			[Export("getValues:")]
			NSNumber[] GetValues(NSValue[] points);

			// -(void)setDistanceUnit:(DistanceUnit)value;
			[Export("setDistanceUnit:")]
			void SetDistanceUnit(DistanceUnit value);

			// -(void)setTemperatureUnit:(TemperatureUnit)value;
			[Export("setTemperatureUnit:")]
			void SetTemperatureUnit(TemperatureUnit value);

			// -(void)saveAs:(NSString *)fileName imageViewWithOverlay:(UIImageView *)overlay;
			[Export("saveAs:imageViewWithOverlay:")]
			void SaveAs(string fileName, UIImageView overlay);

			// -(void)saveAs:(NSString *)fileName imageWithOverlay:(UIImage *)imageWithOverlay;
			[Export("saveAs:imageWithOverlay:")]
			void SaveAs(string fileName, UIImage imageWithOverlay);

			// -(void)saveAs:(NSString *)fileName;
			[Export("saveAs:")]
			void SaveAs(string fileName);
		}

		// typedef void (^FLIRThermalImageBlock)(FLIRThermalImage * _Nonnull);
		delegate void FLIRThermalImageBlock(FLIRThermalImage arg0);

		// @interface FLIRCamera : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCamera
		{
			[Wrap("WeakDelegate")]
			[NullAllowed]
			NSObject Delegate { get; set; }

			// @property (weak) id _Nullable delegate;
			[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
			NSObject WeakDelegate { get; set; }

			// -(void)connect:(FLIRIdentity * _Nonnull)identity;
			[Export("connect:")]
			void Connect(FLIRIdentity identity);

			// -(void)disconnect;
			[Export("disconnect")]
			void Disconnect();

			// -(FLIRConnectionStatus)getConnectionStatus;
			[Export("getConnectionStatus")]
			//[Verify (MethodToProperty)]
			FLIRConnectionStatus ConnectionStatus { get; }

			// -(FLIRIdentity * _Nullable)getIdentity;
			[NullAllowed, Export("getIdentity")]
			//[Verify (MethodToProperty)]
			FLIRIdentity Identity { get; }

			// -(FLIRRemoteControl * _Nullable)getRemoteControl;
			[NullAllowed, Export("getRemoteControl")]
			//[Verify (MethodToProperty)]
			FLIRRemoteControl RemoteControl { get; }

			// -(void)subscribeStream;
			[Export("subscribeStream")]
			void SubscribeStream();

			// -(void)unsubscribeStream;
			[Export("unsubscribeStream")]
			void UnsubscribeStream();

			// -(void)withImage:(FLIRThermalImageBlock _Nonnull)imageBlock;
			[Export("withImage:")]
			void WithImage(FLIRThermalImageBlock imageBlock);

			// -(BOOL)isGrabbing;
			[Export("isGrabbing")]
			//[Verify (MethodToProperty)]
			bool IsGrabbing { get; }

			// +(NSString * _Nonnull)statusToString:(FLIRConnectionStatus)status;
			[Static]
			[Export("statusToString:")]
			string StatusToString(FLIRConnectionStatus status);
		}

		// @protocol FLIRDataReceivedDelegate <NSObject>
		[Protocol, Model(AutoGeneratedName = true)]
		[BaseType(typeof(NSObject))]
		interface FLIRDataReceivedDelegate
		{
			// @required -(void)onConnectionStatusChanged:(FLIRCamera * _Nonnull)camera Status:(FLIRConnectionStatus)status withError:(NSError * _Nullable)error;
			[Abstract]
			[Export("onConnectionStatusChanged:Status:withError:")]
			void OnConnectionStatusChanged(FLIRCamera camera, FLIRConnectionStatus status, [NullAllowed] NSError error);

			// @optional -(void)imageReceived;
			[Export("imageReceived")]
			void ImageReceived();
		}

		// @interface FLIRCameraDeviceInfo : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCameraDeviceInfo
		{
			// @property (readonly) NSString * hostName;
			[Export("hostName")]
			string HostName { get; }

			// @property (readonly) NSString * productName;
			[Export("productName")]
			string ProductName { get; }

			// @property (readonly) NSString * ipAddress;
			[Export("ipAddress")]
			string IpAddress { get; }

			// @property (readonly) NSNumber * imageWidth;
			[Export("imageWidth")]
			NSNumber ImageWidth { get; }

			// @property (readonly) NSNumber * imageHeight;
			[Export("imageHeight")]
			NSNumber ImageHeight { get; }

			// @property (readonly) NSNetService * netService;
			[Export("netService")]
			NSNetService NetService { get; }

			// -(void)create:(id)source;
			[Export("create:")]
			void Create(NSObject source);
		}

		// @interface FLIRCameraEvent : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCameraEvent
		{
			// -(instancetype)initWithCameraDeviceInfo:(FLIRCameraDeviceInfo *)cameraDeviceInfo;
			[Export("initWithCameraDeviceInfo:")]
			IntPtr Constructor(FLIRCameraDeviceInfo cameraDeviceInfo);

			// -(instancetype)initWithCameraIpAddress:(NSString *)ipAddress;
			[Export("initWithCameraIpAddress:")]
			IntPtr Constructor(string ipAddress);

			// -(instancetype)initWithIdentity:(FLIRIdentity *)identity;
			[Export("initWithIdentity:")]
			IntPtr Constructor(FLIRIdentity identity);

			// -(BOOL)listenForEvent:(CameraEvent)eventID;
			[Export("listenForEvent:")]
			bool ListenForEvent(CameraEvent eventID);

			// -(void)stopListening;
			[Export("stopListening")]
			void StopListening();
		}

		// @protocol FLIRCameraImportEventDelegate <NSObject>
		[Protocol, Model(AutoGeneratedName = true)]
		[BaseType(typeof(NSObject))]
		interface FLIRCameraImportEventDelegate
		{
			// @required -(void)fileAdded:(id)event;
			[Abstract]
			[Export("fileAdded:")]
			void FileAdded(NSObject @event);

			// @required -(void)fileError:(id)event;
			[Abstract]
			[Export("fileError:")]
			void FileError(NSObject @event);

			// @required -(void)importError:(NSDictionary *)e;
			[Abstract]
			[Export("importError:")]
			void ImportError(NSDictionary e);

			// @required -(void)fileProgress:(int)progress forFileNumber:(int)number;
			[Abstract]
			[Export("fileProgress:forFileNumber:")]
			void FileProgress(int progress, int number);
		}

		// @interface FLIRFileObject : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRFileObject
		{
			// @property (nonatomic) NSString * name;
			[Export("name")]
			string Name { get; set; }

			// @property (nonatomic) NSString * url;
			[Export("url")]
			string Url { get; set; }

			// @property (nonatomic) NSDate * time;
			[Export("time", ArgumentSemantic.Assign)]
			NSDate Time { get; set; }

			// @property (nonatomic) long long size;
			[Export("size")]
			long Size { get; set; }

			// @property (nonatomic) _Bool isDirectory;
			[Export("isDirectory")]
			bool IsDirectory { get; set; }
		}

		// @interface FLIRCameraImport : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRCameraImport
		{
			// -(NSMutableDictionary *)getImages:(NSString *)path __attribute__((deprecated("")));
			[Export("getImages:")]
			NSMutableDictionary GetImages(string path);

			// -(BOOL)startImport:(NSArray *)pathsList withDestPath:(NSString *)destPath;
			[Export("startImport:withDestPath:")]
			//[Verify (StronglyTypedNSArray)]
			bool StartImport(NSObject[] pathsList, string destPath);

			// -(void)cancelImport;
			[Export("cancelImport")]
			void CancelImport();

			[Wrap("WeakDelegate")]
			NSObject Delegate { get; set; }

			// @property (nonatomic, weak) id delegate;
			[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
			NSObject WeakDelegate { get; set; }

			// -(NSArray *)listImages:(NSString *)ipAddress;
			[Export("listImages:")]
			//[Verify (StronglyTypedNSArray)]
			NSObject[] ListImages(string ipAddress);

			// -(NSArray *)listImages:(NSString *)ipAddress workFolder:(NSString *)folder;
			[Export("listImages:workFolder:")]
			//[Verify (StronglyTypedNSArray)]
			NSObject[] ListImages(string ipAddress, string folder);

			// -(NSArray *)listWorkfolders:(NSString *)ipAddress;
			[Export("listWorkfolders:")]
			//[Verify (StronglyTypedNSArray)]
			NSObject[] ListWorkfolders(string ipAddress);
		}

		// @protocol FLIRDiscoveryEventDelegate <NSObject>
		[Protocol, Model(AutoGeneratedName = true)]
		[BaseType(typeof(NSObject))]
		interface FLIRDiscoveryEventDelegate
		{
			// @required -(void)cameraFound:(FLIRIdentity * _Nonnull)cameraIdentity;
			[Abstract]
			[Export("cameraFound:")]
			void CameraFound(FLIRIdentity cameraIdentity);

			// @required -(void)discoveryError:(NSString * _Nonnull)error netServiceError:(int)nsnetserviceserror on:(FLIRCommunicationInterface)iface;
			[Abstract]
			[Export("discoveryError:netServiceError:on:")]
			void DiscoveryError(string error, int nsnetserviceserror, FLIRCommunicationInterface iface);

			// @optional -(void)cameraLost:(FLIRIdentity * _Nonnull)cameraIdentity;
			[Export("cameraLost:")]
			void CameraLost(FLIRIdentity cameraIdentity);

			// @optional -(void)discoveryFinished:(FLIRCommunicationInterface)iface;
			[Export("discoveryFinished:")]
			void DiscoveryFinished(FLIRCommunicationInterface iface);
		}

		// @interface FLIRDiscovery : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRDiscovery
		{
			// -(void)start:(FLIRCommunicationInterface)iface;
			[Export("start:")]
			void Start(FLIRCommunicationInterface iface);

			// -(void)stop;
			[Export("stop")]
			void Stop();

			// -(BOOL)isDiscovering;
			[Export("isDiscovering")]
			//[Verify (MethodToProperty)]
			bool IsDiscovering { get; }

			[Wrap("WeakDelegate")]
			[NullAllowed]
			NSObject Delegate { get; set; }

			// @property (assign, nonatomic) id _Nullable delegate;
			[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
			NSObject WeakDelegate { get; set; }
		}

		// @interface FLIRMeterLinkDeviceInfo : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeterLinkDeviceInfo
		{
			// @property (nonatomic) _Bool isAutoPowerOff;
			[Export("isAutoPowerOff")]
			bool IsAutoPowerOff { get; set; }

			// @property (nonatomic) _Bool isTriggerPressed;
			[Export("isTriggerPressed")]
			bool IsTriggerPressed { get; set; }

			// @property (nonatomic) _Bool isSecondTriggerPressed;
			[Export("isSecondTriggerPressed")]
			bool IsSecondTriggerPressed { get; set; }

			// @property (nonatomic) _Bool isBatteryLow;
			[Export("isBatteryLow")]
			bool IsBatteryLow { get; set; }

			// @property (nonatomic) MLMeterType meterType;
			[Export("meterType", ArgumentSemantic.Assign)]
			MLMeterType MeterType { get; set; }

			// @property (nonatomic) NSUInteger channelCount;
			[Export("channelCount")]
			nuint ChannelCount { get; set; }

			// @property (nonatomic) NSString * modelName;
			[Export("modelName")]
			string ModelName { get; set; }

			// @property (nonatomic) NSString * serialNumber;
			[Export("serialNumber")]
			string SerialNumber { get; set; }

			// -(NSString *)MLMeterTypeString;
			[Export("MLMeterTypeString")]
			//[Verify (MethodToProperty)]
			string MLMeterTypeString { get; }
		}

		// @interface FLIRMeterLinkDeviceChannel : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeterLinkDeviceChannel
		{
			// @property (nonatomic) MLSensorQuantity quantity;
			[Export("quantity", ArgumentSemantic.Assign)]
			MLSensorQuantity Quantity { get; set; }

			// @property (nonatomic) MLSensorAuxInfo auxInfo;
			[Export("auxInfo", ArgumentSemantic.Assign)]
			MLSensorAuxInfo AuxInfo { get; set; }

			// @property (nonatomic) MLSensorMeasureInfo measureInfo;
			[Export("measureInfo", ArgumentSemantic.Assign)]
			MLSensorMeasureInfo MeasureInfo { get; set; }

			// @property (nonatomic) double value;
			[Export("value")]
			double Value { get; set; }

			// @property (nonatomic) time_t timeStamp;
			[Export("timeStamp")]
			nint TimeStamp { get; set; }

			// @property (nonatomic) NSUInteger timeStampMilli;
			[Export("timeStampMilli")]
			nuint TimeStampMilli { get; set; }

			// @property (nonatomic) NSUInteger precision;
			[Export("precision")]
			nuint Precision { get; set; }

			// @property (nonatomic) _Bool isDifference;
			[Export("isDifference")]
			bool IsDifference { get; set; }

			// @property (nonatomic) _Bool isValueValid;
			[Export("isValueValid")]
			bool IsValueValid { get; set; }

			// @property (nonatomic) _Bool isActive;
			[Export("isActive")]
			bool IsActive { get; set; }

			// @property (nonatomic) NSString * rawQuantity;
			[Export("rawQuantity")]
			string RawQuantity { get; set; }

			// @property (nonatomic) NSString * rawUnit;
			[Export("rawUnit")]
			string RawUnit { get; set; }

			// @property (nonatomic) NSNumber * _Nullable index;
			[NullAllowed, Export("index", ArgumentSemantic.Assign)]
			NSNumber Index { get; set; }

			// @property (nonatomic) NSNumber * unitPrefix;
			[Export("unitPrefix", ArgumentSemantic.Assign)]
			NSNumber UnitPrefix { get; set; }

			// -(NSString *)MLSensorMeasureInfoString;
			[Export("MLSensorMeasureInfoString")]
			//[Verify (MethodToProperty)]
			string MLSensorMeasureInfoString { get; }

			// -(NSString *)MLSensorAuxInfoString;
			[Export("MLSensorAuxInfoString")]
			//[Verify (MethodToProperty)]
			string MLSensorAuxInfoString { get; }

			// -(NSString *)MLSensorQuantityString;
			[Export("MLSensorQuantityString")]
			//[Verify (MethodToProperty)]
			string MLSensorQuantityString { get; }

			// -(NSString *)MLSensorValueString;
			[Export("MLSensorValueString")]
			//[Verify (MethodToProperty)]
			string MLSensorValueString { get; }
		}

		// @interface FLIRMeterLinkDevice : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeterLinkDevice
		{
			// @property (nonatomic) int channel;
			[Export("channel")]
			int Channel { get; set; }

			// @property (nonatomic) NSUUID * identifier __attribute__((availability(ios, introduced=7.0)));
			[iOS(7, 0)]
			[Export("identifier", ArgumentSemantic.Assign)]
			NSUuid Identifier { get; set; }

			// @property (nonatomic) FLIRMeterLinkDeviceInfo * deviceInfo;
			[Export("deviceInfo", ArgumentSemantic.Assign)]
			FLIRMeterLinkDeviceInfo DeviceInfo { get; set; }

			// @property (nonatomic) NSMutableArray * channels;
			[Export("channels", ArgumentSemantic.Assign)]
			NSMutableArray Channels { get; set; }
		}

		// @protocol FLIRMeterLinkDelegate <NSObject>
		[Protocol, Model(AutoGeneratedName = true)]
		[BaseType(typeof(NSObject))]
		interface FLIRMeterLinkDelegate
		{
			// @required -(void)deviceDiscovered:(FLIRMeterLinkDevice *)device;
			[Abstract]
			[Export("deviceDiscovered:")]
			void DeviceDiscovered(FLIRMeterLinkDevice device);

			// @required -(void)deviceDisappeared:(FLIRMeterLinkDevice *)device;
			[Abstract]
			[Export("deviceDisappeared:")]
			void DeviceDisappeared(FLIRMeterLinkDevice device);

			// @required -(void)deviceConnected:(FLIRMeterLinkDevice *)device;
			[Abstract]
			[Export("deviceConnected:")]
			void DeviceConnected(FLIRMeterLinkDevice device);

			// @required -(void)deviceDisconnected:(FLIRMeterLinkDevice *)device;
			[Abstract]
			[Export("deviceDisconnected:")]
			void DeviceDisconnected(FLIRMeterLinkDevice device);

			// @required -(void)deviceUpdated:(FLIRMeterLinkDevice *)device;
			[Abstract]
			[Export("deviceUpdated:")]
			void DeviceUpdated(FLIRMeterLinkDevice device);

			// @required -(void)mlState:(FLIRMeterLinkState)state;
			[Abstract]
			[Export("mlState:")]
			void MlState(FLIRMeterLinkState state);

			// @required -(void)dataRecordingReceived:(FLIRMeterLinkDevice *)device data:(id)data CSVString:(NSString *)csvString;
			[Abstract]
			[Export("dataRecordingReceived:data:CSVString:")]
			void DataRecordingReceived(FLIRMeterLinkDevice device, NSObject data, string csvString);

			// @required -(void)imageReceived:(FLIRMeterLinkDevice *)device image:(NSData *)image;
			[Abstract]
			[Export("imageReceived:image:")]
			void ImageReceived(FLIRMeterLinkDevice device, NSData image);

			// @required -(void)transferProgress:(FLIRMeterLinkDevice *)device filetype:(FLIRMeterLinkFileType)type progressCurrent:(int)current progressTotal:(int)total;
			[Abstract]
			[Export("transferProgress:filetype:progressCurrent:progressTotal:")]
			void TransferProgress(FLIRMeterLinkDevice device, FLIRMeterLinkFileType type, int current, int total);

			// @required -(void)parserError:(FLIRMeterLinkDevice *)device parseError:(FLIRMeterLinkParseError)error;
			[Abstract]
			[Export("parserError:parseError:")]
			void ParserError(FLIRMeterLinkDevice device, FLIRMeterLinkParseError error);

			// @required -(void)receivedPacket:(NSData *)data;
			[Abstract]
			[Export("receivedPacket:")]
			void ReceivedPacket(NSData data);
		}

		// @interface FLIRMeterLinkManager : NSObject
		[BaseType(typeof(NSObject))]
		interface FLIRMeterLinkManager
		{
			// -(instancetype)initWithDelegate:(id<FLIRMeterLinkDelegate>)delegate;
			[Export("initWithDelegate:")]
			IntPtr Constructor(FLIRMeterLinkDelegate @delegate);

			// -(void)startScanning;
			[Export("startScanning")]
			void StartScanning();

			// -(void)stopScanning;
			[Export("stopScanning")]
			void StopScanning();

			// -(void)connectDevice:(FLIRMeterLinkDevice *)device;
			[Export("connectDevice:")]
			void ConnectDevice(FLIRMeterLinkDevice device);

			// -(void)disconnectDevice:(FLIRMeterLinkDevice *)device;
			[Export("disconnectDevice:")]
			void DisconnectDevice(FLIRMeterLinkDevice device);

			// -(void)setDecimalSeparator:(NSString *)decimalSeparator;
			[Export("setDecimalSeparator:")]
			void SetDecimalSeparator(string decimalSeparator);
		}

		// @interface FLIRThermalImageFile : FLIRThermalImage
		[BaseType(typeof(FLIRThermalImage))]
		interface FLIRThermalImageFile
		{
			// -(int)open:(NSString *)fileName;
			[Export("open:")]
			int Open(string fileName);

			// -(_Bool)isThermalImage:(NSString *)fileName;
			[Export("isThermalImage:")]
			bool IsThermalImage(string fileName);

			// -(NSString *)getAbsolutePath;
			[Export("getAbsolutePath")]
			//[Verify (MethodToProperty)]
			string AbsolutePath { get; }

			// -(NSString *)getFileName;
			[Export("getFileName")]
			//[Verify (MethodToProperty)]
			string FileName { get; }

			// -(NSDate *)getDateTaken;
			[Export("getDateTaken")]
			//[Verify (MethodToProperty)]
			NSDate DateTaken { get; }

			// -(void)save;
			[Export("save")]
			void Save();
		}

		// @interface FlirBinder : NSObject
		[BaseType(typeof(NSObject))]
		interface FlirBinder
		{
		}

		[Static]
		//[Verify (ConstantsInterfaceAssociation)]
		partial interface Constants
		{
			// extern double MeterLinkVersionNumber;
			[Field("MeterLinkVersionNumber", "__Internal")]
			double MeterLinkVersionNumber { get; }

			// extern const unsigned char [] MeterLinkVersionString;
			//[Field("MeterLinkVersionString", "__Internal")]
			//byte[] MeterLinkVersionString { get; }

			// extern const double ThermalSDKVersionNumber;
			[Field("ThermalSDKVersionNumber", "__Internal")]
			double ThermalSDKVersionNumber { get; }

			// extern const unsigned char [] ThermalSDKVersionString;
			//[Field("ThermalSDKVersionString", "__Internal")]
			//byte[] ThermalSDKVersionString { get; }

			// extern const char [] ThermalSDKCommitHash;
			//[Field("ThermalSDKCommitHash", "__Internal")]
			//sbyte[] ThermalSDKCommitHash { get; }
		}
	//}

	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. VisualStudio auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see https://aka.ms/ios-binding
	//
}

