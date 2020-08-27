// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMaintenanceStatuses_Environment
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
  public class GetMaintenanceStatuses_Environment : Inquiry_Environment
  {
    [Metadata("Returns details for a Maintenance service.", "GetMaintenanceStatusDetails", false, false, false, "GetMaintenanceStatusDetails", 1050732, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_StatusDetails")]
    protected GetMaintenanceStatusDetails_Environment _StatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_MaintenanceClass")]
    [Metadata("Defines the relationship between a Maintenance Requirement and a group of Resources.", "MaintenanceClass", false, false, false, "NamedObjectRef", 1050702, false, false, true, null)]
    protected Environment _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_MaintenanceStatus")]
    [Metadata("Maintains the current status of the Resources as it applies to maintenance.", "MaintenanceStatus", false, false, false, "SubentityRef", 1050713, false, false, true, null)]
    protected Environment _MaintenanceStatus;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050727, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_Qty2Used")]
    protected Environment _Qty2Used;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050734, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_WithinWarning")]
    protected Environment _WithinWarning;
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, false, "Fixed", 1050730, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_RemainingQty2Percent")]
    protected Environment _RemainingQty2Percent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_RemainingQtyPercent")]
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, false, "Fixed", 1050731, false, false, false, null)]
    protected Environment _RemainingQtyPercent;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_NoState")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052970, false, false, false, "1")]
    protected Environment _NoState;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050726, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_PastDue")]
    protected Environment _PastDue;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_WithinTolerance")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050733, false, false, false, "1")]
    protected Environment _WithinTolerance;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_RemainingDays")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050729, false, false, false, null)]
    protected Environment _RemainingDays;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_ResourceStatusCode")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, true, null)]
    protected Environment _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050728, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_QtyUsed")]
    protected Environment _QtyUsed;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, false, "Integer", 1048655, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMaintenanceStatuses_Environment_Availability")]
    protected Environment _Availability;

    public GetMaintenanceStatusDetails_Environment StatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusDetails), (object) value);
      }
      get
      {
        return (GetMaintenanceStatusDetails_Environment) this.PropertyGet(nameof (StatusDetails));
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

    public Environment Qty2Used
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Used), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Used));
      }
    }

    public Environment WithinWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WithinWarning));
      }
    }

    public Environment RemainingQty2Percent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQty2Percent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemainingQty2Percent));
      }
    }

    public Environment RemainingQtyPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingQtyPercent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemainingQtyPercent));
      }
    }

    public Environment NoState
    {
      [param: In] set
      {
        this.PropertySet(nameof (NoState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NoState));
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

    public Environment WithinTolerance
    {
      [param: In] set
      {
        this.PropertySet(nameof (WithinTolerance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WithinTolerance));
      }
    }

    public Environment RemainingDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemainingDays), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemainingDays));
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

    public Environment QtyUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyUsed));
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
  }
}
