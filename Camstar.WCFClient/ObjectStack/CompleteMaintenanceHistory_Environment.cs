// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenanceHistory_Environment
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
  public class CompleteMaintenanceHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Environment_HistoryDetails")]
    [Metadata("The CompleteMaintHistoryDetails History CDO contains the information on how the details field was filled out for the CompleteMaintenance transaction, and also contains information on the value of the field prior to the transaction.", "CompleteMaintHistoryDetails", false, false, false, "CompleteMaintHistoryDetails", 1049096, false, true, false, null)]
    protected CompleteMaintHistoryDetails_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Environment_ResetAll")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050735, false, false, false, "0")]
    protected Environment _ResetAll;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Environment_ForceMaintenance")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050751, false, false, false, "0")]
    protected Environment _ForceMaintenance;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public CompleteMaintHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CompleteMaintHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
