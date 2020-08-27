// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessSequenceValidation_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskSequenceValidation_Environment))]
  [KnownType(typeof (RecipeSequenceValidation_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ProcessSequenceValidation_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_CompletedTaskDetails")]
    [Metadata("Details of the completed task.", "CompletedTaskDetail", false, false, true, "CompletedTaskDetail", 1051872, false, true, false, null)]
    protected CompletedTaskDetail_Environment _CompletedTaskDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_LastCompletedTask")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050555, false, false, false, null)]
    protected Environment _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_LastCompletedTaskInTaskList")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1051873, false, false, false, null)]
    protected Environment _LastCompletedTaskInTaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_ProcessItem")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1051870, false, false, false, null)]
    protected Environment _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_ProductionProcess")]
    [Metadata("Encapsulates logic for different types of processes.", "ProductionProcess", false, false, false, "RevisionedObjectRef", 1051889, false, false, false, null)]
    protected Environment _ProductionProcess;
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, false, true, "RevisionedObjectRef", 1051890, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_ProcessList")]
    protected Environment _ProcessList;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Environment_Container")]
    protected Environment _Container;

    public CompletedTaskDetail_Environment CompletedTaskDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTaskDetails), (object) value);
      }
      get
      {
        return (CompletedTaskDetail_Environment) this.PropertyGet(nameof (CompletedTaskDetails));
      }
    }

    public Environment LastCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedTask));
      }
    }

    public Environment LastCompletedTaskInTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTaskInTaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedTaskInTaskList));
      }
    }

    public Environment ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public Environment ProductionProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductionProcess));
      }
    }

    public Environment ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessList));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }
  }
}
