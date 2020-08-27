// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintDetails_Info
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
  public class CompleteMaintDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_MaintenanceReq")]
    protected Info _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_MaintenanceStatus")]
    protected Info _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_LastMaintCompletionDate")]
    protected Info _LastMaintCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_DocumentSet")]
    protected DocumentSet_Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Info_DocumentEntries")]
    protected DocumentEntry_Info _DocumentEntries;

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

    public Info MaintenanceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceStatus));
      }
    }

    public Info LastMaintCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMaintCompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMaintCompletionDate));
      }
    }

    public DocumentSet_Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (DocumentSet_Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public DocumentEntry_Info DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Info) this.PropertyGet(nameof (DocumentEntries));
      }
    }
  }
}
