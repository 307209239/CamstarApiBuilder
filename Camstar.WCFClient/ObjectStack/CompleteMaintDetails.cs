// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteMaintDetails
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
  public class CompleteMaintDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_MaintenanceStatus")]
    protected SubentityRef _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_LastMaintCompletionDate")]
    protected Primitive<DateTime> _LastMaintCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_DocumentSet")]
    protected DocumentSet _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "CompleteMaintDetails_DocumentEntries")]
    protected DocumentEntry[] _DocumentEntries;

    public override bool Equals(object obj)
    {
      return obj is CompleteMaintDetails && object.Equals((object) this._DataCollectionDef, (object) ((CompleteMaintDetails) obj)._DataCollectionDef) && (object.Equals((object) this._MaintenanceReq, (object) ((CompleteMaintDetails) obj)._MaintenanceReq) && object.Equals((object) this._Comments, (object) ((CompleteMaintDetails) obj)._Comments)) && (object.Equals((object) this._MaintenanceStatus, (object) ((CompleteMaintDetails) obj)._MaintenanceStatus) && object.Equals((object) this._LastMaintCompletionDate, (object) ((CompleteMaintDetails) obj)._LastMaintCompletionDate) && (object.Equals((object) this._DocumentSet, (object) ((CompleteMaintDetails) obj)._DocumentSet) && this.CompareArrays((Array) this._DocumentEntries, (Array) ((CompleteMaintDetails) obj)._DocumentEntries))) && base.Equals(obj);
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

    public SubentityRef MaintenanceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceStatus), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (MaintenanceStatus));
      }
    }

    public Primitive<DateTime> LastMaintCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMaintCompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMaintCompletionDate));
      }
    }

    public DocumentSet DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (DocumentSet) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public DocumentEntry[] DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry[]) this.PropertyGet(nameof (DocumentEntries));
      }
    }
  }
}
