// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ServiceSettingsElement
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class ServiceSettingsElement : ConfigurationElement
  {
    private const string NameProperty = "Name";
    private const string ExposedTypeProperty = "ExposedType";
    private const string MethodsProperty = "Methods";

    [ConfigurationProperty(null, Options = ConfigurationPropertyOptions.IsDefaultCollection)]
    public ServiceElementCollection Children
    {
      get
      {
        return (ServiceElementCollection) this[string.Empty];
      }
      set
      {
        this[string.Empty] = (object) value;
      }
    }

    [ConfigurationProperty("Methods")]
    public MethodElementCollection Methods
    {
      get
      {
        return (MethodElementCollection) this[nameof (Methods)];
      }
      set
      {
        this[nameof (Methods)] = (object) value;
      }
    }

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

    [ConfigurationProperty("ExposedType", DefaultValue = ExposedServiceStateType.NonExposed)]
    public ExposedServiceStateType ExposedType
    {
      get
      {
        return (ExposedServiceStateType) this[nameof (ExposedType)];
      }
      set
      {
        this[nameof (ExposedType)] = (object) value;
      }
    }
  }
}
