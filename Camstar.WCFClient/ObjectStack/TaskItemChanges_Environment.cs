// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (InstructionItemChanges_Environment))]
  [KnownType(typeof (TransactionItemChanges_Environment))]
  [KnownType(typeof (ComputationItemChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TaskItemChanges_Environment : ProcessItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050417, false, false, true, null)]
    protected new Environment _ESigRequirement;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItemChanges", false, false, false, "NamedSubentityRef", 1050549, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_PrerequisiteTasks")]
    protected new Environment _PrerequisiteTasks;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_InstructionType")]
    [Metadata("Enumeration for the InstructionType.\r\n1 = Pass/Fail\r\n2 = Data Collection\r\n3 = Acknowledgement", "InstructionTypeEnum", false, false, false, "Integer", 1050525, false, false, true, null)]
    protected Environment _InstructionType;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_StartTimerTaskDtl")]
    [Metadata("StartTimerTaskDtlChanges", "StartTimerTaskDtlChanges", false, false, false, "StartTimerTaskDtlChanges", 16778410, false, true, false, null)]
    protected StartTimerTaskDtlChanges_Environment _StartTimerTaskDtl;
    [Metadata("EndTimerTaskDtlChanges", "EndTimerTaskDtlChanges", false, false, false, "EndTimerTaskDtlChanges", 16778409, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_EndTimerTaskDtl")]
    protected EndTimerTaskDtlChanges_Environment _EndTimerTaskDtl;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050503, false, false, false, null)]
    protected new Environment _Name;

    public new Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Environment PrerequisiteTasks
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstructionType));
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

    public StartTimerTaskDtlChanges_Environment StartTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTaskDtl), (object) value);
      }
      get
      {
        return (StartTimerTaskDtlChanges_Environment) this.PropertyGet(nameof (StartTimerTaskDtl));
      }
    }

    public EndTimerTaskDtlChanges_Environment EndTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTaskDtl), (object) value);
      }
      get
      {
        return (EndTimerTaskDtlChanges_Environment) this.PropertyGet(nameof (EndTimerTaskDtl));
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
  }
}
