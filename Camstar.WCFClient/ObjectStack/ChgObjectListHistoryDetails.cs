// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListHistoryDetails
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
  public class ChgObjectListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_NewDisplayValue")]
    protected new Primitive<string> _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_NewObjects")]
    protected NewObject[] _NewObjects;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_OldObjects")]
    protected OldObject[] _OldObjects;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_OldDisplayValue")]
    protected new Primitive<string> _OldDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_FieldName")]
    protected new Primitive<string> _FieldName;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_FieldID")]
    protected new Primitive<int> _FieldID;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ChgObjectListHistoryDetails && object.Equals((object) this._NewDisplayValue, (object) ((ChgObjectListHistoryDetails) obj)._NewDisplayValue) && (this.CompareArrays((Array) this._NewObjects, (Array) ((ChgObjectListHistoryDetails) obj)._NewObjects) && this.CompareArrays((Array) this._OldObjects, (Array) ((ChgObjectListHistoryDetails) obj)._OldObjects)) && (object.Equals((object) this._ExportImportKey, (object) ((ChgObjectListHistoryDetails) obj)._ExportImportKey) && object.Equals((object) this._OldDisplayValue, (object) ((ChgObjectListHistoryDetails) obj)._OldDisplayValue) && (object.Equals((object) this._FieldName, (object) ((ChgObjectListHistoryDetails) obj)._FieldName) && object.Equals((object) this._FieldID, (object) ((ChgObjectListHistoryDetails) obj)._FieldID))) && object.Equals((object) this._HistoryId, (object) ((ChgObjectListHistoryDetails) obj)._HistoryId) && base.Equals(obj);
    }

    public new Primitive<string> NewDisplayValue
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

    public NewObject[] NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (NewObject[]) this.PropertyGet(nameof (NewObjects));
      }
    }

    public OldObject[] OldObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObjects), (object) value);
      }
      get
      {
        return (OldObject[]) this.PropertyGet(nameof (OldObjects));
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

    public new Primitive<string> OldDisplayValue
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

    public new Primitive<string> FieldName
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

    public new Primitive<int> FieldID
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
  }
}
