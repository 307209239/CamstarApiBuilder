// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatuses_Info
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
  public class GetMaintenanceStatuses_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_StatusDetails")]
    protected GetMaintenanceStatusDetails_Info _StatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_MaintenanceClass")]
    protected Info _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_MaintenanceStatus")]
    protected Info _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_Qty2Used")]
    protected Info _Qty2Used;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_WithinWarning")]
    protected Info _WithinWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_RemainingQty2Percent")]
    protected Info _RemainingQty2Percent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_RemainingQtyPercent")]
    protected Info _RemainingQtyPercent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_NoState")]
    protected Info _NoState;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_PastDue")]
    protected Info _PastDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_WithinTolerance")]
    protected Info _WithinTolerance;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_RemainingDays")]
    protected Info _RemainingDays;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_QtyUsed")]
    protected Info _QtyUsed;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Info_Availability")]
    protected Info _Availability;

    public GetMaintenanceStatusDetails_Info StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (GetMaintenanceStatusDetails_Info) this.PropertyGet(nameof (StatusDetails));
      }
    }

    public Info MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceClass));
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

    public Info Qty2Used
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Used), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Used));
      }
    }

    public Info WithinWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WithinWarning));
      }
    }

    public Info RemainingQty2Percent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQty2Percent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemainingQty2Percent));
      }
    }

    public Info RemainingQtyPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQtyPercent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemainingQtyPercent));
      }
    }

    public Info NoState
    {
      [param: In] set
      {
        this.PropertySet(nameof (NoState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NoState));
      }
    }

    public Info PastDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PastDue));
      }
    }

    public Info WithinTolerance
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinTolerance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WithinTolerance));
      }
    }

    public Info RemainingDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingDays), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemainingDays));
      }
    }

    public Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info QtyUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUsed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyUsed));
      }
    }

    public Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }
  }
}
