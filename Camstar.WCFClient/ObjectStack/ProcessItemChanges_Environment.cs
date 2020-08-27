// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskItemChanges_Environment))]
  [KnownType(typeof (RecipeItemChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ProcessItemChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_TaskType")]
    [Metadata("Enumeration for TaskType.\r\n1 = Start Process Task\r\n2 = End Process Task\r\n3 = Regular Process Task", "TaskTypeEnum", false, true, false, "Integer", 1050512, false, false, true, null)]
    protected Environment _TaskType;
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_ListItemToChange")]
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO.  SubEntityChanges are used as temporary holding places while the parent CDO is undergoing maintenance.", "SubentityChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1050417, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_ESigRequirement")]
    protected Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_Instruction")]
    [Metadata("Instruction", "", false, false, false, "String", 1050514, false, false, false, null)]
    protected Environment _Instruction;
    [Metadata("Instruction", "", false, false, false, "String", 1053065, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_ReportInstruction")]
    protected Environment _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_TaskUsage")]
    [Metadata("Enumeration of the Task Usage\r\n1 = Container\r\n2 = Batch", "TaskUsageEnum", false, false, false, "Integer", 1051883, false, false, true, "1")]
    protected Environment _TaskUsage;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItemChanges", false, false, false, "NamedSubentityRef", 1050549, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_PrerequisiteTasks")]
    protected Environment _PrerequisiteTasks;
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.", "Subentity", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_MinIterations")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050885, false, false, false, null)]
    protected Environment _MinIterations;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050558, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_MaxIterations")]
    protected Environment _MaxIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_AdvanceToNextTask")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052647, false, false, false, "1")]
    protected Environment _AdvanceToNextTask;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment ESigRequirement
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

    public Environment TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskUsage));
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

    public Environment MinIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinIterations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinIterations));
      }
    }

    public Environment MaxIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxIterations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxIterations));
      }
    }

    public Environment AdvanceToNextTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdvanceToNextTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdvanceToNextTask));
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
