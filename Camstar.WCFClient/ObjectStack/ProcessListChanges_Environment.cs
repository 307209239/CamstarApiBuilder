// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListChanges_Environment
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
  public class ProcessListChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_ReportInstruction")]
    [Metadata("Instruction", "", false, false, false, "String", 1053065, false, false, false, null)]
    protected Environment _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_Instruction")]
    [Metadata("Instruction", "", false, false, false, "String", 1050514, false, false, false, null)]
    protected Environment _Instruction;
    [Metadata("Enumeration for Execution Mode.\r\n1 = Sequential\r\n2 = Non-Sequential", "ExecutionModeEnum", false, true, false, "Integer", 1050515, false, false, true, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_ExecutionMode")]
    protected Environment _ExecutionMode;
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1050518, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_WorkstationGroup")]
    protected Environment _WorkstationGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_PrerequisiteTaskList")]
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, false, false, "RevisionedObjectRef", 1050516, false, false, true, null)]
    protected Environment _PrerequisiteTaskList;
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessListBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_Tasks")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItemChanges", false, true, false, "ProcessItemChanges", 1050574, false, true, false, null)]
    protected ProcessItemChanges_Environment _Tasks;
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050517, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_Workstation")]
    protected Environment _Workstation;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050234, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    protected new Environment _IsRevOfRcd;

    public Environment ReportInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportInstruction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportInstruction));
      }
    }

    public Environment Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instruction));
      }
    }

    public Environment ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Environment WorkstationGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkstationGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkstationGroup));
      }
    }

    public Environment PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public ProcessItemChanges_Environment Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges_Environment) this.PropertyGet(nameof (Tasks));
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

    public Environment Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workstation));
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

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
