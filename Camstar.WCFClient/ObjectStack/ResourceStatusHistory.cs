// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusHistory
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
  public class ResourceStatusHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldResourceState")]
    protected Enumeration<ResourceStateEnum, int> _OldResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_ResourceState")]
    protected Enumeration<ResourceStateEnum, int> _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldLastStatusChangeDateGMT")]
    protected Primitive<DateTime> _OldLastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_UpdateLastStatusChangeDate")]
    protected Primitive<int> _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldLastActivityDate")]
    protected Primitive<DateTime> _OldLastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldLastStatusChangeDate")]
    protected Primitive<DateTime> _OldLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_LastStatusChangeDate")]
    protected Primitive<DateTime> _LastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldUpdateLastStatusChangeDate")]
    protected Primitive<int> _OldUpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldLastActivityDateGMT")]
    protected Primitive<DateTime> _OldLastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_LastStatusChangeDateGMT")]
    protected Primitive<DateTime> _LastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldResourceStatusReasonCode")]
    protected NamedObjectRef _OldResourceStatusReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldResourceStatusCode")]
    protected NamedObjectRef _OldResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldSetup")]
    protected RevisionedObjectRef _OldSetup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_ResourceStatusReasonCode")]
    protected NamedObjectRef _ResourceStatusReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldRun")]
    protected Primitive<string> _OldRun;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Availability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldProduct")]
    protected RevisionedObjectRef _OldProduct;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_OldAvailability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _OldAvailability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Setup")]
    protected RevisionedObjectRef _Setup;

    public override bool Equals(object obj)
    {
      return obj is ResourceStatusHistory && object.Equals((object) this._ExportImportKey, (object) ((ResourceStatusHistory) obj)._ExportImportKey) && (object.Equals((object) this._OldResourceState, (object) ((ResourceStatusHistory) obj)._OldResourceState) && object.Equals((object) this._ResourceState, (object) ((ResourceStatusHistory) obj)._ResourceState)) && (object.Equals((object) this._OldLastStatusChangeDateGMT, (object) ((ResourceStatusHistory) obj)._OldLastStatusChangeDateGMT) && object.Equals((object) this._UpdateLastStatusChangeDate, (object) ((ResourceStatusHistory) obj)._UpdateLastStatusChangeDate) && (object.Equals((object) this._OldLastActivityDate, (object) ((ResourceStatusHistory) obj)._OldLastActivityDate) && object.Equals((object) this._OldLastStatusChangeDate, (object) ((ResourceStatusHistory) obj)._OldLastStatusChangeDate))) && (object.Equals((object) this._LastStatusChangeDate, (object) ((ResourceStatusHistory) obj)._LastStatusChangeDate) && object.Equals((object) this._OldUpdateLastStatusChangeDate, (object) ((ResourceStatusHistory) obj)._OldUpdateLastStatusChangeDate) && (object.Equals((object) this._HistoryId, (object) ((ResourceStatusHistory) obj)._HistoryId) && object.Equals((object) this._OldLastActivityDateGMT, (object) ((ResourceStatusHistory) obj)._OldLastActivityDateGMT)) && (object.Equals((object) this._LastStatusChangeDateGMT, (object) ((ResourceStatusHistory) obj)._LastStatusChangeDateGMT) && object.Equals((object) this._OldResourceStatusReasonCode, (object) ((ResourceStatusHistory) obj)._OldResourceStatusReasonCode) && (object.Equals((object) this._OldResourceStatusCode, (object) ((ResourceStatusHistory) obj)._OldResourceStatusCode) && object.Equals((object) this._OldSetup, (object) ((ResourceStatusHistory) obj)._OldSetup)))) && (object.Equals((object) this._ResourceStatusReasonCode, (object) ((ResourceStatusHistory) obj)._ResourceStatusReasonCode) && object.Equals((object) this._Run, (object) ((ResourceStatusHistory) obj)._Run) && (object.Equals((object) this._OldRun, (object) ((ResourceStatusHistory) obj)._OldRun) && object.Equals((object) this._ResourceStatusCode, (object) ((ResourceStatusHistory) obj)._ResourceStatusCode)) && (object.Equals((object) this._Availability, (object) ((ResourceStatusHistory) obj)._Availability) && object.Equals((object) this._Product, (object) ((ResourceStatusHistory) obj)._Product) && (object.Equals((object) this._OldProduct, (object) ((ResourceStatusHistory) obj)._OldProduct) && object.Equals((object) this._OldAvailability, (object) ((ResourceStatusHistory) obj)._OldAvailability))) && object.Equals((object) this._Setup, (object) ((ResourceStatusHistory) obj)._Setup)) && base.Equals(obj);
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

    public Enumeration<ResourceStateEnum, int> OldResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceState), (object) value);
      }
      get
      {
        return (Enumeration<ResourceStateEnum, int>) this.PropertyGet(nameof (OldResourceState));
      }
    }

    public Enumeration<ResourceStateEnum, int> ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Enumeration<ResourceStateEnum, int>) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Primitive<DateTime> OldLastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OldLastStatusChangeDateGMT));
      }
    }

    public Primitive<int> UpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UpdateLastStatusChangeDate));
      }
    }

    public Primitive<DateTime> OldLastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OldLastActivityDate));
      }
    }

    public Primitive<DateTime> OldLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OldLastStatusChangeDate));
      }
    }

    public Primitive<DateTime> LastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastStatusChangeDate));
      }
    }

    public Primitive<int> OldUpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldUpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (OldUpdateLastStatusChangeDate));
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

    public Primitive<DateTime> OldLastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OldLastActivityDateGMT));
      }
    }

    public Primitive<DateTime> LastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastStatusChangeDateGMT));
      }
    }

    public NamedObjectRef OldResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OldResourceStatusReasonCode));
      }
    }

    public NamedObjectRef OldResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OldResourceStatusCode));
      }
    }

    public RevisionedObjectRef OldSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldSetup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (OldSetup));
      }
    }

    public NamedObjectRef ResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReasonCode));
      }
    }

    public Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public Primitive<string> OldRun
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldRun), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OldRun));
      }
    }

    public NamedObjectRef ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (Availability));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public RevisionedObjectRef OldProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (OldProduct));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> OldAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldAvailability), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (OldAvailability));
      }
    }

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }
  }
}
