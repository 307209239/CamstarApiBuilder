// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StartChangePkg_Result
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StartChangePkg_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected StartChangePkg _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected StartChangePkg_Environment _Environment;

    public StartChangePkg Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (StartChangePkg) this.PropertyGet(nameof (Value));
      }
    }

    public StartChangePkg_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (StartChangePkg_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
