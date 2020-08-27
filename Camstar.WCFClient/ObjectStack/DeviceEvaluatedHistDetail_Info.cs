// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceEvaluatedHistDetail_Info
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
  public class DeviceEvaluatedHistDetail_Info : UserResponseYesNoFieldHistDet_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Info_SummaryAttached")]
    protected Info _SummaryAttached;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Info_NotReturned")]
    protected Info _NotReturned;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedHistDetail_Info_EvaluationCode")]
    protected Info _EvaluationCode;

    public Info SummaryAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryAttached), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SummaryAttached));
      }
    }

    public Info NotReturned
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotReturned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotReturned));
      }
    }

    public Info EvaluationCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (EvaluationCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EvaluationCode));
      }
    }
  }
}
