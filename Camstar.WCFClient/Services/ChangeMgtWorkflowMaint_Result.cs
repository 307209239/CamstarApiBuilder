// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeMgtWorkflowMaint_Result
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
  public class ChangeMgtWorkflowMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ChangeMgtWorkflowMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ChangeMgtWorkflowMaint_Environment _Environment;

    public ChangeMgtWorkflowMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ChangeMgtWorkflowMaint) this.PropertyGet(nameof (Value));
      }
    }

    public ChangeMgtWorkflowMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ChangeMgtWorkflowMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
