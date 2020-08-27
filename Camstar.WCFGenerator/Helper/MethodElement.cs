// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.MethodElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class MethodElement : ConfigurationElement
  {
    private const string NameProperty = "Name";
    private const string ExposedTypeProperty = "ExposedType";

    [ConfigurationProperty("Name")]
    public string Name
    {
      get
      {
        return (string) this[nameof (Name)];
      }
      set
      {
        this[nameof (Name)] = (object) value;
      }
    }

    [ConfigurationProperty("ExposedType", DefaultValue = ExposedMethodStateType.NonExposed)]
    public ExposedMethodStateType ExposedType
    {
      get
      {
        return (ExposedMethodStateType) this[nameof (ExposedType)];
      }
      set
      {
        this[nameof (ExposedType)] = (object) value;
      }
    }
  }
}
