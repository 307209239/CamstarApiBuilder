// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectMaint_Result
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
  public class ProcessObjectMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ProcessObjectMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ProcessObjectMaint_Environment _Environment;

    public ProcessObjectMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ProcessObjectMaint) this.PropertyGet(nameof (Value));
      }
    }

    public ProcessObjectMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ProcessObjectMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
