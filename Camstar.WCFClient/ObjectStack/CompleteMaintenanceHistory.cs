// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenanceHistory
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
  public class CompleteMaintenanceHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_HistoryDetails")]
    protected CompleteMaintHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_ResetAll")]
    protected Primitive<bool> _ResetAll;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_ForceMaintenance")]
    protected Primitive<bool> _ForceMaintenance;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenanceHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is CompleteMaintenanceHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CompleteMaintenanceHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((CompleteMaintenanceHistory) obj)._ExportImportKey) && object.Equals((object) this._ResetAll, (object) ((CompleteMaintenanceHistory) obj)._ResetAll)) && (object.Equals((object) this._ForceMaintenance, (object) ((CompleteMaintenanceHistory) obj)._ForceMaintenance) && object.Equals((object) this._HistoryId, (object) ((CompleteMaintenanceHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public CompleteMaintHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CompleteMaintHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<bool> ResetAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetAll), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ResetAll));
      }
    }

    public Primitive<bool> ForceMaintenance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceMaintenance), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ForceMaintenance));
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
