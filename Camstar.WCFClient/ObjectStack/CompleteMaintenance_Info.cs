// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenance_Info
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
  public class CompleteMaintenance_Info : ResourceTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_ServiceDetails")]
    protected CompleteMaintDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_MaintenanceReq")]
    protected Info _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_DataCollectionDefs")]
    protected Info _DataCollectionDefs;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_ResetAll")]
    protected Info _ResetAll;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Info_ForceMaintenance")]
    protected Info _ForceMaintenance;

    public CompleteMaintDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CompleteMaintDetails_Info) this.PropertyGet(nameof (ServiceDetails));
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

    public Info DataCollectionDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDefs));
      }
    }

    public new Info DataCollectionDef
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

    public Info ResetAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetAll), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResetAll));
      }
    }

    public Info ForceMaintenance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceMaintenance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForceMaintenance));
      }
    }
  }
}
