// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeHistoryDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgStringHistoryDetails))]
  [KnownType(typeof (ChgDurationHistoryDetails))]
  [KnownType(typeof (ChgTimeStampListHistoryDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgFloatHistoryDetails))]
  [KnownType(typeof (ChgIntegerListHistoryDetails))]
  [KnownType(typeof (ChgDurationListHistoryDetails))]
  [KnownType(typeof (ChgFixedHistoryDetails))]
  [KnownType(typeof (ChgFixedListHistoryDetails))]
  [KnownType(typeof (ChgObjectHistoryDetails))]
  [KnownType(typeof (ChgStringListHistoryDetails))]
  [KnownType(typeof (ChgBooleanHistoryDetails))]
  [KnownType(typeof (ChgObjectListHistoryDetails))]
  [KnownType(typeof (ChgIntegerHistoryDetails))]
  [KnownType(typeof (ChgTimeStampHistoryDetails))]
  [KnownType(typeof (ChgFloatListHistoryDetails))]
  [KnownType(typeof (ChgBooleanListHistoryDetails))]
  [Serializable]
  public class ChangeAttributeHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_FieldName")]
    protected Primitive<string> _FieldName;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_OldDisplayValue")]
    protected Primitive<string> _OldDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_NewDisplayValue")]
    protected Primitive<string> _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeHistoryDetails_FieldID")]
    protected Primitive<int> _FieldID;

    public override bool Equals(object obj)
    {
      return obj is ChangeAttributeHistoryDetails && object.Equals((object) this._FieldName, (object) ((ChangeAttributeHistoryDetails) obj)._FieldName) && (object.Equals((object) this._ExportImportKey, (object) ((ChangeAttributeHistoryDetails) obj)._ExportImportKey) && object.Equals((object) this._OldDisplayValue, (object) ((ChangeAttributeHistoryDetails) obj)._OldDisplayValue)) && (object.Equals((object) this._NewDisplayValue, (object) ((ChangeAttributeHistoryDetails) obj)._NewDisplayValue) && object.Equals((object) this._HistoryId, (object) ((ChangeAttributeHistoryDetails) obj)._HistoryId) && object.Equals((object) this._FieldID, (object) ((ChangeAttributeHistoryDetails) obj)._FieldID)) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> OldDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDisplayValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OldDisplayValue));
      }
    }

    public Primitive<string> NewDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDisplayValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NewDisplayValue));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> FieldID
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FieldID));
      }
    }
  }
}
