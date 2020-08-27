// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTaskHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ExecuteRecipeTaskHistory_Environment))]
  [Serializable]
  public class ExecuteTaskHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_TaskType")]
    [Metadata("Enumeration for TaskType.\r\n1 = Start Process Task\r\n2 = End Process Task\r\n3 = Regular Process Task", "TaskTypeEnum", false, false, true, "Integer", 1050512, false, false, false, null)]
    protected Environment _TaskType;
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, true, "NamedObjectRef", 1050473, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_TrainingReqGroup")]
    protected Environment _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_TaskComments")]
    [Metadata("Comments", "", false, false, true, "String", 1050548, false, false, false, null)]
    protected Environment _TaskComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1052900, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_TaskListSequence")]
    protected Environment _TaskListSequence;
    [Metadata("Instruction", "", false, false, true, "String", 1050514, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_Instruction")]
    protected Environment _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_TaskList")]
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, false, true, "RevisionedObjectRef", 1050520, false, false, false, null)]
    protected Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_ElectronicProcedure")]
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcess", false, false, true, "RevisionedObjectRef", 1050523, false, false, false, null)]
    protected Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_Task")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050503, false, false, false, null)]
    protected Environment _Task;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050549, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_PrerequisiteTasks")]
    protected Environment _PrerequisiteTasks;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050546, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_Pass")]
    protected Environment _Pass;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050517, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_Workstation")]
    protected Environment _Workstation;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1048646, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050547, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Environment_WorkCell")]
    protected Environment _WorkCell;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskType));
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

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment TaskComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskComments));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment TaskListSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskListSequence));
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

    public Environment TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskList));
      }
    }

    public Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
      }
    }

    public Environment PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Pass));
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

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Environment WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCell));
      }
    }
  }
}
