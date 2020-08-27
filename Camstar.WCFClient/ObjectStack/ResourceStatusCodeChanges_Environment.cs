// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusCodeChanges_Environment
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
  public class ResourceStatusCodeChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_ResourceStatusReasons")]
    [Metadata("A User Code Object Group that represents a group of Resource Status Reasons.", "ResStatusReasonGroup", false, false, false, "NamedObjectRef", 1052857, false, false, true, null)]
    protected Environment _ResourceStatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_ResourceState")]
    [Metadata("Resource State definition:\r\n1. NonScheduled\r\n2. UnscheduleDown\r\n3. ScheduleDown\r\n4. Engineering\r\n5. Productive\r\n6. Standby", "ResourceStateEnum", false, false, false, "Integer", 1052999, false, false, true, null)]
    protected Environment _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_NextTxnType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1048994, false, false, false, null)]
    protected Environment _NextTxnType;
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1048995, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_StatusReasons")]
    protected Environment _StatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050112, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Environment_Availability")]
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, true, false, "Integer", 1048655, false, false, true, null)]
    protected Environment _Availability;

    public Environment ResourceStatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReasons));
      }
    }

    public Environment ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Environment NextTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextTxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextTxnType));
      }
    }

    public Environment StatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusReasons));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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
