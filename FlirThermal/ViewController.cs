using FlirThermalBinding;
using Foundation;
using System;
using UIKit;


namespace FlirThermal
{
  public partial class ViewController : UIViewController
  {
    FLIRDiscovery discovery;
    private FLIRCamera _camera ;
    private UIImageView flirImage;
    FLIRCommunicationInterface flirCom;
    public ViewController(IntPtr handle, FLIRDiscovery discovery) : base(handle)
    {
      this.discovery = discovery;
    }

    private void FlirConnectionChange(NSNotification status)
    {
      // if (status == FLIRConnectionStatus)
      // {
      //   
      // }
    }

    public override void ViewDidLoad()
    {
      Console.WriteLine(discovery.IsDiscovering);
      discovery.Start(flirCom & FLIRCommunicationInterface.Lightning);
      Console.WriteLine(discovery.IsDiscovering);
      base.ViewDidLoad();
      // Perform any additional setup after loading the view, typically from a nib.
    }

    public override void DidReceiveMemoryWarning()
    {
      base.DidReceiveMemoryWarning();
      // Release any cached data, images, etc that aren't in use.
    }
  }
}