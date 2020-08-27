// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TargetSystemMaint_Result
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
  public class TargetSystemMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected TargetSystemMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected TargetSystemMaint_Environment _Environment;

    public TargetSystemMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (TargetSystemMaint) this.PropertyGet(nameof (Value));
      }
    }

    public TargetSystemMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (TargetSystemMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
