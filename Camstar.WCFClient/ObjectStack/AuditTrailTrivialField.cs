// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailTrivialField
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
  public class AuditTrailTrivialField : AuditTrailField
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_FieldValues")]
    protected AuditTrailTrivialFieldValue[] _FieldValues;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_FieldSubType")]
    protected Enumeration<DataTypeEnum, int> _FieldSubType;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_FieldType")]
    protected Enumeration<DataTypeEnum, int> _FieldType;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailTrivialField && this.CompareArrays((Array) this._FieldValues, (Array) ((AuditTrailTrivialField) obj)._FieldValues) && (object.Equals((object) this._FieldSubType, (object) ((AuditTrailTrivialField) obj)._FieldSubType) && object.Equals((object) this._FieldType, (object) ((AuditTrailTrivialField) obj)._FieldType)) && base.Equals(obj);
    }

    public AuditTrailTrivialFieldValue[] FieldValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValues), (object) value);
      }
      get
      {
        return (AuditTrailTrivialFieldValue[]) this.PropertyGet(nameof (FieldValues));
      }
    }

    public Enumeration<DataTypeEnum, int> FieldSubType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSubType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (FieldSubType));
      }
    }

    public Enumeration<DataTypeEnum, int> FieldType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldType), (object) value);
      }
      get
      {
        return (Enumeration<DataTypeEnum, int>) this.PropertyGet(nameof (FieldType));
      }
    }
  }
}
