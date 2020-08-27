// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenance_Environment
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
  public class CompleteMaintenance_Environment : ResourceTxn_Environment
  {
    [Metadata("Contains information used to mark a MaintenanceStatus for a resource as completed.", "CompleteMaintDetails", false, false, false, "CompleteMaintDetails", 1050736, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_ServiceDetails")]
    protected CompleteMaintDetails_Environment _ServiceDetails;
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, true, false, "RevisionedObjectRef", 1050704, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_MaintenanceReq")]
    protected Environment _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_DataCollectionDefs")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1049794, false, true, false, null)]
    protected Environment _DataCollectionDefs;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_DataCollectionDef")]
    protected new Environment _DataCollectionDef;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050735, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_ResetAll")]
    protected Environment _ResetAll;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050751, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_Environment_ForceMaintenance")]
    protected Environment _ForceMaintenance;

    public CompleteMaintDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CompleteMaintDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public Environment DataCollectionDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDefs));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Environment ResetAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetAll), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResetAll));
      }
    }

    public Environment ForceMaintenance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceMaintenance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForceMaintenance));
      }
    }
  }
}
