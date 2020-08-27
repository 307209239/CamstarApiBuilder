// Decompiled with JetBrains decompiler
// Type: WCFBuilderLauncher.Program
// Assembly: WCFBuilderLauncher, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: 0C9A82E8-C5F9-48B8-8E4E-AA2ED3DE8C67
// Assembly location: E:\WCFServicesGenerator\WCFBuilderLauncher.exe

using Camstar.WCF.Generator;
using Camstar.WCF.Generator.Helper;
using System;

namespace WCFBuilderLauncher
{
  internal class Program
  {
    [STAThread]
    private static int Main(string[] args)
    {
      int num = 0;
      bool flag = false;
      bool? nullable = new bool?();
      string path1 = string.Empty;
      string path2 = string.Empty;
      foreach (string str in args)
      {
        if (str.Equals("-nogui", StringComparison.OrdinalIgnoreCase))
          flag = true;
        if (str.Equals("-n", StringComparison.OrdinalIgnoreCase))
          flag = true;
        if (str.StartsWith("-OverrideSettingsWith:", StringComparison.OrdinalIgnoreCase))
          path1 = str.Substring("-OverrideSettingsWith:".Length);
        if (str.StartsWith("-o:", StringComparison.OrdinalIgnoreCase))
          path1 = str.Substring(3);
        if (str.StartsWith("-SettingsFile:", StringComparison.OrdinalIgnoreCase))
          path2 = str.Substring("-SettingsFile:".Length);
        if (str.StartsWith("-s:", StringComparison.OrdinalIgnoreCase))
          path2 = str.Substring(3);
        if (str.StartsWith("-nosilverlight", StringComparison.OrdinalIgnoreCase))
          nullable = new bool?(true);
      }
      if (flag)
      {
        try
        {
          GeneratorSettings settings = new GeneratorSettings(path2);
          if (!string.IsNullOrEmpty(path1))
          {
            GeneratorSettings generatorSettings = new GeneratorSettings(path1);
            settings.Address = generatorSettings.Address;
            settings.ClientOutputConfigPath = generatorSettings.ClientOutputConfigPath;
            settings.ClientOutputDirectory = generatorSettings.ClientOutputDirectory;
            settings.ClientSilverlightOutputDirectory = generatorSettings.ClientSilverlightOutputDirectory;
            settings.DatabaseConnectionString = generatorSettings.DatabaseConnectionString;
            settings.IsGenerateAll = generatorSettings.IsGenerateAll;
            settings.IsGetFromRegistry = generatorSettings.IsGetFromRegistry;
            settings.IsGenerateSilverlight = generatorSettings.IsGenerateSilverlight;
            settings.DefaultServerConnectionString = generatorSettings.DefaultServerConnectionString;
            settings.ServerOutputDirectory = generatorSettings.ServerOutputDirectory;
            settings.LogNaming = generatorSettings.LogNaming;
            settings.LogPath = generatorSettings.LogPath;
            settings.LogXmlDocument = generatorSettings.LogXmlDocument;
            settings.ProcessTxnGUID = generatorSettings.ProcessTxnGUID;
          }
          if (nullable.HasValue)
            settings.IsGenerateSilverlight = false;
          Console.WriteLine("Generation has started...");
          Runner runner = new Runner(settings);
          runner.Init();
          Console.Write("Generation has finished with:\n" + (object) runner.Generate() + "\n");
        }
        catch (WCFGeneratorException ex)
        {
          Console.WriteLine(ex.InnerException.Message);
          Console.WriteLine(ex.Message);
          num = -1;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
          num = -1;
        }
      }
      else
        AppDomain.CreateDomain("WCF", AppDomain.CurrentDomain.Evidence, AppDomain.CurrentDomain.SetupInformation).Load("WCFBuilder").EntryPoint.Invoke((object) null, new object[1]
        {
          (object) new string[0]
        });
      return num;
    }
  }
}
