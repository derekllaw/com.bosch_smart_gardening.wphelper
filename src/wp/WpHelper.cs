using System;
using Windows.Graphics.Display;

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
        result = new PluginResult(PluginResult.Status.OK, upperCase);
      } else
      {
        result = new PluginResult(PluginResult.Status.ERROR, upperCase);
      }

      Windows.Graphics.Display.DisplayInformation.AutoRotationPreferences = Windows.Graphics.Display.DisplayOrientations.Portrait;

      DispatchCommandResult(result);
    }
  }
}
