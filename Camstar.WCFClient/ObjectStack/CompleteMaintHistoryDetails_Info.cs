// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintHistoryDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompleteDateHistoryDetails_Info))]
  [KnownType(typeof (CompleteThruputHistoryDetails_Info))]
  [KnownType(typeof (CompleteRecurDateHistDetails_Info))]
  [Serializable]
  public class CompleteMaintHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_MaintenanceReq")]
    protected Info _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintHistoryDetails_Info_DocumentSet")]
    protected Info _DocumentSet;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }
  }
}
