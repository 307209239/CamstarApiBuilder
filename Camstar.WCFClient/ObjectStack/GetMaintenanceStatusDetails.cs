// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatusDetails
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
  public class GetMaintenanceStatusDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_ThruputQty2")]
    protected Primitive<double> _ThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceClass")]
    protected NamedObjectRef _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQty2Warning")]
    protected Primitive<double> _NextThruputQty2Warning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQty2Due")]
    protected Primitive<double> _NextThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQty2Limit")]
    protected Primitive<double> _NextThruputQty2Limit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceStatus")]
    protected SubentityRef _MaintenanceStatus;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceType")]
    protected Primitive<string> _MaintenanceType;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateLimit")]
    protected Primitive<DateTime> _NextDateLimit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateWarning")]
    protected Primitive<DateTime> _NextDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateDue")]
    protected Primitive<DateTime> _NextDateDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Due")]
    protected Primitive<bool> _Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateWarningGMT")]
    protected Primitive<DateTime> _NextDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceReqDisplayName")]
    protected Primitive<string> _MaintenanceReqDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateDueGMT")]
    protected Primitive<DateTime> _NextDateDueGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_PastDue")]
    protected Primitive<bool> _PastDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Completed")]
    protected Primitive<bool> _Completed;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Warning")]
    protected Primitive<bool> _Warning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceState")]
    protected Primitive<string> _MaintenanceState;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Availability")]
    protected Primitive<string> _Availability;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextDateLimitGMT")]
    protected Primitive<DateTime> _NextDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_ResourceStatusCodeName")]
    protected Primitive<string> _ResourceStatusCodeName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_UOM2Name")]
    protected Primitive<string> _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQtyDue")]
    protected Primitive<double> _NextThruputQtyDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceClassName")]
    protected Primitive<string> _MaintenanceClassName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQtyLimit")]
    protected Primitive<double> _NextThruputQtyLimit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_NextThruputQtyWarning")]
    protected Primitive<double> _NextThruputQtyWarning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_ThruputQty")]
    protected Primitive<double> _ThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceReqName")]
    protected Primitive<string> _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_MaintenanceReqRev")]
    protected Primitive<string> _MaintenanceReqRev;

    public override bool Equals(object obj)
    {
      return obj is GetMaintenanceStatusDetails && object.Equals((object) this._ThruputQty2, (object) ((GetMaintenanceStatusDetails) obj)._ThruputQty2) && (object.Equals((object) this._MaintenanceClass, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceClass) && object.Equals((object) this._NextThruputQty2Warning, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQty2Warning)) && (object.Equals((object) this._NextThruputQty2Due, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQty2Due) && object.Equals((object) this._NextThruputQty2Limit, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQty2Limit) && (object.Equals((object) this._UOM2, (object) ((GetMaintenanceStatusDetails) obj)._UOM2) && object.Equals((object) this._MaintenanceReq, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceReq))) && (object.Equals((object) this._MaintenanceStatus, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceStatus) && object.Equals((object) this._UOM, (object) ((GetMaintenanceStatusDetails) obj)._UOM) && (object.Equals((object) this._MaintenanceType, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceType) && object.Equals((object) this._NextDateLimit, (object) ((GetMaintenanceStatusDetails) obj)._NextDateLimit)) && (object.Equals((object) this._NextDateWarning, (object) ((GetMaintenanceStatusDetails) obj)._NextDateWarning) && object.Equals((object) this._NextDateDue, (object) ((GetMaintenanceStatusDetails) obj)._NextDateDue) && (object.Equals((object) this._Due, (object) ((GetMaintenanceStatusDetails) obj)._Due) && object.Equals((object) this._NextDateWarningGMT, (object) ((GetMaintenanceStatusDetails) obj)._NextDateWarningGMT)))) && (object.Equals((object) this._MaintenanceReqDisplayName, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceReqDisplayName) && object.Equals((object) this._NextDateDueGMT, (object) ((GetMaintenanceStatusDetails) obj)._NextDateDueGMT) && (object.Equals((object) this._PastDue, (object) ((GetMaintenanceStatusDetails) obj)._PastDue) && object.Equals((object) this._Completed, (object) ((GetMaintenanceStatusDetails) obj)._Completed)) && (object.Equals((object) this._Warning, (object) ((GetMaintenanceStatusDetails) obj)._Warning) && object.Equals((object) this._MaintenanceState, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceState) && (object.Equals((object) this._Availability, (object) ((GetMaintenanceStatusDetails) obj)._Availability) && object.Equals((object) this._NextDateLimitGMT, (object) ((GetMaintenanceStatusDetails) obj)._NextDateLimitGMT))) && (object.Equals((object) this._ResourceStatusCodeName, (object) ((GetMaintenanceStatusDetails) obj)._ResourceStatusCodeName) && object.Equals((object) this._UOM2Name, (object) ((GetMaintenanceStatusDetails) obj)._UOM2Name) && (object.Equals((object) this._NextThruputQtyDue, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQtyDue) && object.Equals((object) this._MaintenanceClassName, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceClassName)) && (object.Equals((object) this._Resource, (object) ((GetMaintenanceStatusDetails) obj)._Resource) && object.Equals((object) this._NextThruputQtyLimit, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQtyLimit) && (object.Equals((object) this._NextThruputQtyWarning, (object) ((GetMaintenanceStatusDetails) obj)._NextThruputQtyWarning) && object.Equals((object) this._ThruputQty, (object) ((GetMaintenanceStatusDetails) obj)._ThruputQty))))) && (object.Equals((object) this._MaintenanceReqName, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceReqName) && object.Equals((object) this._ResourceStatusCode, (object) ((GetMaintenanceStatusDetails) obj)._ResourceStatusCode) && (object.Equals((object) this._UOMName, (object) ((GetMaintenanceStatusDetails) obj)._UOMName) && object.Equals((object) this._ResourceName, (object) ((GetMaintenanceStatusDetails) obj)._ResourceName)) && object.Equals((object) this._MaintenanceReqRev, (object) ((GetMaintenanceStatusDetails) obj)._MaintenanceReqRev)) && base.Equals(obj);
    }

    public Primitive<double> ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputQty2));
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

    public Primitive<double> NextThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Warning), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQty2Warning));
      }
    }

    public Primitive<double> NextThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Due), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQty2Due));
      }
    }

    public Primitive<double> NextThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Limit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQty2Limit));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
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

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<string> MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceType));
      }
    }

    public Primitive<DateTime> NextDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimit), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateLimit));
      }
    }

    public Primitive<DateTime> NextDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarning), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateWarning));
      }
    }

    public Primitive<DateTime> NextDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDue), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateDue));
      }
    }

    public Primitive<bool> Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (Due), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Due));
      }
    }

    public Primitive<DateTime> NextDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarningGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateWarningGMT));
      }
    }

    public Primitive<string> MaintenanceReqDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceReqDisplayName));
      }
    }

    public Primitive<DateTime> NextDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDueGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateDueGMT));
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

    public Primitive<bool> Completed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Completed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Completed));
      }
    }

    public Primitive<bool> Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Warning), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Warning));
      }
    }

    public Primitive<string> MaintenanceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceState), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceState));
      }
    }

    public Primitive<string> Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Availability));
      }
    }

    public Primitive<DateTime> NextDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimitGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextDateLimitGMT));
      }
    }

    public Primitive<string> ResourceStatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceStatusCodeName));
      }
    }

    public Primitive<string> UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public Primitive<double> NextThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyDue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQtyDue));
      }
    }

    public Primitive<string> MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceClassName));
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

    public Primitive<double> NextThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQtyLimit));
      }
    }

    public Primitive<double> NextThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyWarning), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NextThruputQtyWarning));
      }
    }

    public Primitive<double> ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Primitive<string> MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceReqName));
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

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }

    public Primitive<string> ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Primitive<string> MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }
  }
}
