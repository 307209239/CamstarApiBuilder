// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessSequenceValidation
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskSequenceValidation))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeSequenceValidation))]
  [Serializable]
  public class ProcessSequenceValidation : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_CompletedTaskDetails")]
    protected CompletedTaskDetail[] _CompletedTaskDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_LastCompletedTask")]
    protected NamedSubentityRef _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_LastCompletedTaskInTaskList")]
    protected NamedSubentityRef _LastCompletedTaskInTaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_ProcessItem")]
    protected NamedSubentityRef _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_ProductionProcess")]
    protected RevisionedObjectRef _ProductionProcess;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_ProcessList")]
    protected RevisionedObjectRef _ProcessList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Container")]
    protected ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is ProcessSequenceValidation && this.CompareArrays((Array) this._CompletedTaskDetails, (Array) ((ProcessSequenceValidation) obj)._CompletedTaskDetails) && (object.Equals((object) this._LastCompletedTask, (object) ((ProcessSequenceValidation) obj)._LastCompletedTask) && object.Equals((object) this._LastCompletedTaskInTaskList, (object) ((ProcessSequenceValidation) obj)._LastCompletedTaskInTaskList)) && (object.Equals((object) this._ProcessItem, (object) ((ProcessSequenceValidation) obj)._ProcessItem) && object.Equals((object) this._ProductionProcess, (object) ((ProcessSequenceValidation) obj)._ProductionProcess) && (object.Equals((object) this._ProcessList, (object) ((ProcessSequenceValidation) obj)._ProcessList) && object.Equals((object) this._Container, (object) ((ProcessSequenceValidation) obj)._Container))) && base.Equals(obj);
    }

    public CompletedTaskDetail[] CompletedTaskDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTaskDetails), (object) value);
      }
      get
      {
        return (CompletedTaskDetail[]) this.PropertyGet(nameof (CompletedTaskDetails));
      }
    }

    public NamedSubentityRef LastCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTask), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (LastCompletedTask));
      }
    }

    public NamedSubentityRef LastCompletedTaskInTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTaskInTaskList), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (LastCompletedTaskInTaskList));
      }
    }

    public NamedSubentityRef ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public RevisionedObjectRef ProductionProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionProcess), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProductionProcess));
      }
    }

    public RevisionedObjectRef ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessList));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
