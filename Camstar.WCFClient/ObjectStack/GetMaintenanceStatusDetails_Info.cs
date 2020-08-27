// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatusDetails_Info
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
  public class GetMaintenanceStatusDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_ThruputQty2")]
    protected Info _ThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceClass")]
    protected Info _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQty2Warning")]
    protected Info _NextThruputQty2Warning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQty2Due")]
    protected Info _NextThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQty2Limit")]
    protected Info _NextThruputQty2Limit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceReq")]
    protected Info _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceStatus")]
    protected Info _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceType")]
    protected Info _MaintenanceType;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateLimit")]
    protected Info _NextDateLimit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateWarning")]
    protected Info _NextDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateDue")]
    protected Info _NextDateDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_Due")]
    protected Info _Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateWarningGMT")]
    protected Info _NextDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceReqDisplayName")]
    protected Info _MaintenanceReqDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateDueGMT")]
    protected Info _NextDateDueGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_PastDue")]
    protected Info _PastDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_Completed")]
    protected Info _Completed;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_Warning")]
    protected Info _Warning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceState")]
    protected Info _MaintenanceState;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_Availability")]
    protected Info _Availability;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextDateLimitGMT")]
    protected Info _NextDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_ResourceStatusCodeName")]
    protected Info _ResourceStatusCodeName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_UOM2Name")]
    protected Info _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQtyDue")]
    protected Info _NextThruputQtyDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceClassName")]
    protected Info _MaintenanceClassName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQtyLimit")]
    protected Info _NextThruputQtyLimit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_NextThruputQtyWarning")]
    protected Info _NextThruputQtyWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_ThruputQty")]
    protected Info _ThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceReqName")]
    protected Info _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_ResourceName")]
    protected Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Info_MaintenanceReqRev")]
    protected Info _MaintenanceReqRev;

    public Info ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputQty2));
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

    public Info NextThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Warning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQty2Warning));
      }
    }

    public Info NextThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Due), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQty2Due));
      }
    }

    public Info NextThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Limit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQty2Limit));
      }
    }

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
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

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceType));
      }
    }

    public Info NextDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateLimit));
      }
    }

    public Info NextDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateWarning));
      }
    }

    public Info NextDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateDue));
      }
    }

    public Info Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (Due), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Due));
      }
    }

    public Info NextDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarningGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateWarningGMT));
      }
    }

    public Info MaintenanceReqDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReqDisplayName));
      }
    }

    public Info NextDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDueGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateDueGMT));
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

    public Info Completed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Completed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Completed));
      }
    }

    public Info Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Warning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Warning));
      }
    }

    public Info MaintenanceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceState));
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

    public Info NextDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimitGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextDateLimitGMT));
      }
    }

    public Info ResourceStatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCodeName));
      }
    }

    public Info UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public Info NextThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQtyDue));
      }
    }

    public Info MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceClassName));
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

    public Info NextThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQtyLimit));
      }
    }

    public Info NextThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextThruputQtyWarning));
      }
    }

    public Info ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Info MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReqName));
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

    public Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }

    public Info ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Info MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }
  }
}
