// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgObjectDetails))]
  [KnownType(typeof (ChgIntegerListDetails))]
  [KnownType(typeof (ChgTimeStampDetails))]
  [KnownType(typeof (ChgBooleanListDetails))]
  [KnownType(typeof (ChgBooleanDetails))]
  [KnownType(typeof (ChgFixedListDetails))]
  [KnownType(typeof (ChgStringListDetails))]
  [KnownType(typeof (ChgTimeStampListDetails))]
  [KnownType(typeof (ChgFixedDetails))]
  [KnownType(typeof (ChgFloatListDetails))]
  [KnownType(typeof (ChgStringDetails))]
  [KnownType(typeof (ChgObjectListDetails))]
  [KnownType(typeof (ChgFloatDetails))]
  [KnownType(typeof (ChgDurationListDetails))]
  [KnownType(typeof (ChgDurationDetails))]
  [KnownType(typeof (ChgIntegerDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChangeAttributeDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeDetails_FieldName")]
    protected Primitive<string> _FieldName;

    public override bool Equals(object obj)
    {
      return obj is ChangeAttributeDetails && object.Equals((object) this._FieldName, (object) ((ChangeAttributeDetails) obj)._FieldName) && base.Equals(obj);
    }

    public Primitive<string> FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
