using System;

namespace WPCordovaClassLib.Cordova.Commands
{
  public class WpHelper : BaseCommand
  {
    public void ToUpper(string options)
    {
      string upperCase = JSON.JsonHelper.Deserialize<string[]>(options)[0].ToUpper();
      PluginResult result;
      if (upperCase != "")
      {
        result = new PluginResult(PluginResult.Status.OK, "portrait");
      } else
      {
        result = new PluginResult(PluginResult.Status.ERROR, upperCase);
      }

      this.Dispatcher.BeginInvoke((Action)(() =>
      {
        this.SuppoertedOrientations = SupportedPageOrientation.Portrait;
      }));

      DispatchCommandResult(result);
    }
  }
}
