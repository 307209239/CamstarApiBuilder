// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatuses
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
  public class GetMaintenanceStatuses : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_StatusDetails")]
    protected GetMaintenanceStatusDetails[] _StatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_MaintenanceClass")]
    protected NamedObjectRef _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_MaintenanceStatus")]
    protected SubentityRef _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Qty2Used")]
    protected Primitive<double> _Qty2Used;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_WithinWarning")]
    protected Primitive<bool> _WithinWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_RemainingQty2Percent")]
    protected Primitive<double> _RemainingQty2Percent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_RemainingQtyPercent")]
    protected Primitive<double> _RemainingQtyPercent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_NoState")]
    protected Primitive<bool> _NoState;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_PastDue")]
    protected Primitive<bool> _PastDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_WithinTolerance")]
    protected Primitive<bool> _WithinTolerance;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_RemainingDays")]
    protected Primitive<double> _RemainingDays;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_QtyUsed")]
    protected Primitive<double> _QtyUsed;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Availability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _Availability;

    public override bool Equals(object obj)
    {
      return obj is GetMaintenanceStatuses && this.CompareArrays((Array) this._StatusDetails, (Array) ((GetMaintenanceStatuses) obj)._StatusDetails) && (object.Equals((object) this._MaintenanceClass, (object) ((GetMaintenanceStatuses) obj)._MaintenanceClass) && object.Equals((object) this._MaintenanceStatus, (object) ((GetMaintenanceStatuses) obj)._MaintenanceStatus)) && (object.Equals((object) this._Qty2Used, (object) ((GetMaintenanceStatuses) obj)._Qty2Used) && object.Equals((object) this._WithinWarning, (object) ((GetMaintenanceStatuses) obj)._WithinWarning) && (object.Equals((object) this._RemainingQty2Percent, (object) ((GetMaintenanceStatuses) obj)._RemainingQty2Percent) && object.Equals((object) this._RemainingQtyPercent, (object) ((GetMaintenanceStatuses) obj)._RemainingQtyPercent))) && (object.Equals((object) this._NoState, (object) ((GetMaintenanceStatuses) obj)._NoState) && object.Equals((object) this._PastDue, (object) ((GetMaintenanceStatuses) obj)._PastDue) && (object.Equals((object) this._WithinTolerance, (object) ((GetMaintenanceStatuses) obj)._WithinTolerance) && object.Equals((object) this._RemainingDays, (object) ((GetMaintenanceStatuses) obj)._RemainingDays)) && (object.Equals((object) this._ResourceStatusCode, (object) ((GetMaintenanceStatuses) obj)._ResourceStatusCode) && object.Equals((object) this._Resource, (object) ((GetMaintenanceStatuses) obj)._Resource) && (object.Equals((object) this._QtyUsed, (object) ((GetMaintenanceStatuses) obj)._QtyUsed) && object.Equals((object) this._Availability, (object) ((GetMaintenanceStatuses) obj)._Availability)))) && base.Equals(obj);
    }

    public GetMaintenanceStatusDetails[] StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (GetMaintenanceStatusDetails[]) this.PropertyGet(nameof (StatusDetails));
      }
    }

    public NamedObjectRef MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MaintenanceClass));
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

    public Primitive<double> Qty2Used
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Used), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Used));
      }
    }

    public Primitive<bool> WithinWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinWarning), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (WithinWarning));
      }
    }

    public Primitive<double> RemainingQty2Percent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQty2Percent), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (RemainingQty2Percent));
      }
    }

    public Primitive<double> RemainingQtyPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQtyPercent), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (RemainingQtyPercent));
      }
    }

    public Primitive<bool> NoState
    {
      [param: In] set
      {
        this.PropertySet(nameof (NoState), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (NoState));
      }
    }

    public Primitive<bool> PastDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PastDue));
      }
    }

    public Primitive<bool> WithinTolerance
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinTolerance), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (WithinTolerance));
      }
    }

    public Primitive<double> RemainingDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingDays), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (RemainingDays));
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

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<double> QtyUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUsed), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyUsed));
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
  }
}
