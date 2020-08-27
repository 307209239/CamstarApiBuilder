// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkCenterChanges_Environment
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
  public class WorkCenterChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_MfgCalendar")]
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1049935, false, false, true, null)]
    protected Environment _MfgCalendar;
    [Metadata("URL", "", false, false, false, "String", 1050307, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_Image")]
    protected Environment _Image;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [Metadata("Definition of the prioritization rules for the order that material is processed on the shop floor.  A dispatch rule can contain separate details for different types of transactions.", "DispatchRule", false, false, false, "NamedObjectRef", 1050380, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_DispatchRule")]
    protected Environment _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_FastQueueTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048963, false, false, false, null)]
    protected Environment _FastQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_NormalQueueTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048967, false, false, false, null)]
    protected Environment _NormalQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050129, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_ObjectToChange")]
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_DispatchMethod")]
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048962, false, false, false, null)]
    protected Environment _DispatchMethod;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Environment_WorkSchedule")]
    [Metadata("This is not implemented in the current version of InSite.", "WorkSchedule", false, false, false, "NamedObjectRef", 1048969, false, false, true, null)]
    protected Environment _WorkSchedule;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Environment MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public Environment Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Image));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Environment DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Environment FastQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastQueueTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FastQueueTime));
      }
    }

    public Environment NormalQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalQueueTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NormalQueueTime));
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

    public Environment DispatchMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchMethod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispatchMethod));
      }
    }

    public Environment WorkSchedule
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkSchedule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkSchedule));
      }
    }
  }
}
