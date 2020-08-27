// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatusDetails_Environment
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
  public class GetMaintenanceStatusDetails_Environment : ServiceData_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050724, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_ThruputQty2")]
    protected Environment _ThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceClass")]
    [Metadata("Defines the relationship between a Maintenance Requirement and a group of Resources.", "MaintenanceClass", false, false, true, "NamedObjectRef", 1050702, false, false, false, null)]
    protected Environment _MaintenanceClass;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050718, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQty2Warning")]
    protected Environment _NextThruputQty2Warning;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050716, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQty2Due")]
    protected Environment _NextThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQty2Limit")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050717, false, false, false, null)]
    protected Environment _NextThruputQty2Limit;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_UOM2")]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceReq")]
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, false, true, "RevisionedObjectRef", 1050704, false, false, false, null)]
    protected Environment _MaintenanceReq;
    [Metadata("Maintains the current status of the Resources as it applies to maintenance.", "MaintenanceStatus", false, false, true, "SubentityRef", 1050713, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceStatus")]
    protected Environment _MaintenanceStatus;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1050725, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceType")]
    [Metadata("Generic String", "", false, false, true, "String", 1050764, false, false, false, null)]
    protected Environment _MaintenanceType;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050714, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateLimit")]
    protected Environment _NextDateLimit;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050715, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateWarning")]
    protected Environment _NextDateWarning;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateDue")]
    protected Environment _NextDateDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_Due")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050712, false, false, false, "0")]
    protected Environment _Due;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateWarningGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052552, false, false, false, null)]
    protected Environment _NextDateWarningGMT;
    [Metadata("Generic String", "", false, false, true, "String", 1050680, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceReqDisplayName")]
    protected Environment _MaintenanceReqDisplayName;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052544, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateDueGMT")]
    protected Environment _NextDateDueGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050722, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_PastDue")]
    protected Environment _PastDue;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050814, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_Completed")]
    protected Environment _Completed;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_Warning")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050640, false, false, false, "0")]
    protected Environment _Warning;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceState")]
    [Metadata("Generic String", "", false, false, false, "String", 1050763, false, false, false, null)]
    protected Environment _MaintenanceState;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_Availability")]
    [Metadata("Generic String", "", false, false, false, "String", 1048655, false, false, false, null)]
    protected Environment _Availability;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052551, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextDateLimitGMT")]
    protected Environment _NextDateLimitGMT;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_ResourceStatusCodeName")]
    protected Environment _ResourceStatusCodeName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_UOM2Name")]
    protected Environment _UOM2Name;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQtyDue")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050719, false, false, false, null)]
    protected Environment _NextThruputQtyDue;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050702, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceClassName")]
    protected Environment _MaintenanceClassName;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQtyLimit")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050720, false, false, false, null)]
    protected Environment _NextThruputQtyLimit;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_NextThruputQtyWarning")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050721, false, false, false, null)]
    protected Environment _NextThruputQtyWarning;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050723, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_ThruputQty")]
    protected Environment _ThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceReqName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050704, false, false, false, null)]
    protected Environment _MaintenanceReqName;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, true, "NamedObjectRef", 1049247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_ResourceStatusCode")]
    protected Environment _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_UOMName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, false, null)]
    protected Environment _UOMName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_ResourceName")]
    protected Environment _ResourceName;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1052909, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatusDetails_Environment_MaintenanceReqRev")]
    protected Environment _MaintenanceReqRev;

    public Environment ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputQty2));
      }
    }

    public Environment MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public Environment NextThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Warning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQty2Warning));
      }
    }

    public Environment NextThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Due), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQty2Due));
      }
    }

    public Environment NextThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQty2Limit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQty2Limit));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
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

    public Environment MaintenanceStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceStatus));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceType));
      }
    }

    public Environment NextDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateLimit));
      }
    }

    public Environment NextDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateWarning));
      }
    }

    public Environment NextDateDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateDue));
      }
    }

    public Environment Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (Due), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Due));
      }
    }

    public Environment NextDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateWarningGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateWarningGMT));
      }
    }

    public Environment MaintenanceReqDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReqDisplayName));
      }
    }

    public Environment NextDateDueGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateDueGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateDueGMT));
      }
    }

    public Environment PastDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PastDue));
      }
    }

    public Environment Completed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Completed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Completed));
      }
    }

    public Environment Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Warning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Warning));
      }
    }

    public Environment MaintenanceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceState));
      }
    }

    public Environment Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Availability));
      }
    }

    public Environment NextDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextDateLimitGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextDateLimitGMT));
      }
    }

    public Environment ResourceStatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCodeName));
      }
    }

    public Environment UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2Name));
      }
    }

    public Environment NextThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQtyDue));
      }
    }

    public Environment MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceClassName));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment NextThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQtyLimit));
      }
    }

    public Environment NextThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextThruputQtyWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextThruputQtyWarning));
      }
    }

    public Environment ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Environment MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReqName));
      }
    }

    public Environment ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
      }
    }

    public Environment ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Environment MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }
  }
}
