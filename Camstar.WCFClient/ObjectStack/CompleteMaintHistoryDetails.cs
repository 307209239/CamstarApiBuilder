// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintHistoryDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CompleteRecurDateHistDetails))]
  [KnownType(typeof (CompleteDateHistoryDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompleteThruputHistoryDetails))]
  [Serializable]
  public class CompleteMaintHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_DocumentSet")]
    protected NamedObjectRef _DocumentSet;

    public override bool Equals(object obj)
    {
      return obj is CompleteMaintHistoryDetails && object.Equals((object) this._ExportImportKey, (object) ((CompleteMaintHistoryDetails) obj)._ExportImportKey) && (object.Equals((object) this._DataCollectionDef, (object) ((CompleteMaintHistoryDetails) obj)._DataCollectionDef) && object.Equals((object) this._Comments, (object) ((CompleteMaintHistoryDetails) obj)._Comments)) && (object.Equals((object) this._MaintenanceReq, (object) ((CompleteMaintHistoryDetails) obj)._MaintenanceReq) && object.Equals((object) this._HistoryId, (object) ((CompleteMaintHistoryDetails) obj)._HistoryId) && object.Equals((object) this._DocumentSet, (object) ((CompleteMaintHistoryDetails) obj)._DocumentSet)) && base.Equals(obj);
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

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public RevisionedObjectRef MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MaintenanceReq));
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

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }
  }
}
