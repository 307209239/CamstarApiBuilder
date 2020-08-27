// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceEvaluatedField
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
  public class DeviceEvaluatedField : UserResponseYesNoField
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_NotReturned")]
    protected Primitive<bool> _NotReturned;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_EvaluationCode")]
    protected Primitive<string> _EvaluationCode;
    [DataMember(EmitDefaultValue = false, Name = "DeviceEvaluatedField_SummaryAttached")]
    protected Primitive<bool> _SummaryAttached;

    public override bool Equals(object obj)
    {
      return obj is DeviceEvaluatedField && object.Equals((object) this._NotReturned, (object) ((DeviceEvaluatedField) obj)._NotReturned) && (object.Equals((object) this._EvaluationCode, (object) ((DeviceEvaluatedField) obj)._EvaluationCode) && object.Equals((object) this._SummaryAttached, (object) ((DeviceEvaluatedField) obj)._SummaryAttached)) && base.Equals(obj);
    }

    public Primitive<bool> NotReturned
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotReturned), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NotReturned));
      }
    }

    public Primitive<string> EvaluationCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (EvaluationCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EvaluationCode));
      }
    }

    public Primitive<bool> SummaryAttached
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryAttached), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SummaryAttached));
      }
    }
  }
}
