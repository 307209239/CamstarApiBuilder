// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceEvaluatedField_Environment
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
  public class DeviceEvaluatedField_Environment : UserResponseYesNoField_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_Environment_NotReturned")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051318, false, false, false, "0")]
    protected Environment _NotReturned;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_Environment_EvaluationCode")]
    [Metadata("Generic String", "", false, false, false, "String", 1051317, false, false, false, null)]
    protected Environment _EvaluationCode;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_Environment_SummaryAttached")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051319, false, false, false, "0")]
    protected Environment _SummaryAttached;

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
  }
}
