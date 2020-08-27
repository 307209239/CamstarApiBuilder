// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserResponseYesNoField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeviceEvaluatedField))]
  [KnownType(typeof (DeviceAvailableField))]
  [KnownType(typeof (ReportFiledWithFDAField))]
  [KnownType(typeof (HealthProfessionalField))]
  [KnownType(typeof (DeviceReturnedField))]
  [KnownType(typeof (AdverseEventField))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ProductProblemField))]
  [Serializable]
  public class UserResponseYesNoField : EventCheckBoxField
  {
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoField_No")]
    protected Primitive<bool> _No;
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoField_Yes")]
    protected Primitive<bool> _Yes;

    public override bool Equals(object obj)
    {
      return obj is UserResponseYesNoField && object.Equals((object) this._No, (object) ((UserResponseYesNoField) obj)._No) && object.Equals((object) this._Yes, (object) ((UserResponseYesNoField) obj)._Yes) && base.Equals(obj);
    }

    public Primitive<bool> No
    {
      [param: In] set
      {
        this.PropertySet(nameof (No), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (No));
      }
    }

    public Primitive<bool> Yes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Yes));
      }
    }
  }
}
