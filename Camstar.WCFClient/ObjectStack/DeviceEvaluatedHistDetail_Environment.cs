// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceEvaluatedHistDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DeviceEvaluatedHistDetail_Environment : UserResponseYesNoFieldHistDet_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Environment_SummaryAttached")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051319, false, false, false, "0")]
    protected Environment _SummaryAttached;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Environment_NotReturned")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051318, false, false, false, "0")]
    protected Environment _NotReturned;
    [Metadata("Generic String", "", false, false, true, "String", 1051317, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Environment_EvaluationCode")]
    protected Environment _EvaluationCode;

    public Environment SummaryAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryAttached), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SummaryAttached));
      }
    }

    public Environment NotReturned
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotReturned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotReturned));
      }
    }

    public Environment EvaluationCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (EvaluationCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EvaluationCode));
      }
    }
  }
}
