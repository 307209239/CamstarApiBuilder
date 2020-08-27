// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.Launcher
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator.Helper
{
  public class Launcher : Runner
  {
    public GeneratorSettings Settings
    {
      get
      {
        return this._Settings;
      }
    }

    public Launcher(GeneratorSettings settings)
      : base(settings)
    {
    }

    public Launcher()
      : this(new GeneratorSettings())
    {
    }

    public Launcher(string path)
      : this(new GeneratorSettings(path))
    {
    }

    public void SaveServices()
    {
      if (!this._Settings.IsGenerateAll)
        this._Settings.SaveServices(this.GetRootService());
      else
        this._Settings.SaveForAllServices(this.GetRootService());
      if (!this._Settings.IsGenerateSilverlight)
        return;
      this._Settings.SaveSilverlightServices(this.GetRootSilverlightService());
    }

    public void Open(string path)
    {
      this._Settings = new GeneratorSettings(path);
      this.Init();
    }
  }
}
