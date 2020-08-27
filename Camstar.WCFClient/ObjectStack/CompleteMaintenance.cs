// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintenance
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
  public class CompleteMaintenance : ResourceTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_ServiceDetails")]
    protected CompleteMaintDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_DataCollectionDefs")]
    protected RevisionedObjectRef[] _DataCollectionDefs;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_ResetAll")]
    protected Primitive<bool> _ResetAll;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintenance_ForceMaintenance")]
    protected Primitive<bool> _ForceMaintenance;

    public override bool Equals(object obj)
    {
      return obj is CompleteMaintenance && this.CompareArrays((Array) this._ServiceDetails, (Array) ((CompleteMaintenance) obj)._ServiceDetails) && (object.Equals((object) this._MaintenanceReq, (object) ((CompleteMaintenance) obj)._MaintenanceReq) && this.CompareArrays((Array) this._DataCollectionDefs, (Array) ((CompleteMaintenance) obj)._DataCollectionDefs)) && (object.Equals((object) this._DataCollectionDef, (object) ((CompleteMaintenance) obj)._DataCollectionDef) && object.Equals((object) this._ResetAll, (object) ((CompleteMaintenance) obj)._ResetAll) && object.Equals((object) this._ForceMaintenance, (object) ((CompleteMaintenance) obj)._ForceMaintenance)) && base.Equals(obj);
    }

    public CompleteMaintDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CompleteMaintDetails[]) this.PropertyGet(nameof (ServiceDetails));
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

    public RevisionedObjectRef[] DataCollectionDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefs), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (DataCollectionDefs));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
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
  }
}
