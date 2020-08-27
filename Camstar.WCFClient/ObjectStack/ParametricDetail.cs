// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ParametricDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointHistoryDetail))]
  [Serializable]
  public class ParametricDetail : HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_HasUserDataCollection")]
    protected Primitive<bool> _HasUserDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ParametricDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ParametricDetail && object.Equals((object) this._DataCollectionDef, (object) ((ParametricDetail) obj)._DataCollectionDef) && (object.Equals((object) this._ExportImportKey, (object) ((ParametricDetail) obj)._ExportImportKey) && object.Equals((object) this._HasUserDataCollection, (object) ((ParametricDetail) obj)._HasUserDataCollection)) && object.Equals((object) this._HistoryId, (object) ((ParametricDetail) obj)._HistoryId) && base.Equals(obj);
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
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

    public Primitive<bool> HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasUserDataCollection));
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
