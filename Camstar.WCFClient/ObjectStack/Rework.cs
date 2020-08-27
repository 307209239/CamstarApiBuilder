// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Rework
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
  public class Rework : MoveTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Rework_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Path")]
    protected new NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "Rework_NavigationMode")]
    protected new Enumeration<WorkflowNavigationModeEnum, int> _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "Rework_ReEntryWorkflowStack")]
    protected NamedSubentityRef[] _ReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "Rework_UseReEntryWorkflowStack")]
    protected Primitive<bool> _UseReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "Rework_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Rework_ReEntryWorkflow")]
    protected RevisionedObjectRef _ReEntryWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "Rework_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "Rework_EndReworkWorkflow")]
    protected RevisionedObjectRef _EndReworkWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "Rework_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "Rework_ToStep")]
    protected new NamedSubentityRef _ToStep;

    public override bool Equals(object obj)
    {
      return obj is Rework && object.Equals((object) this._ReEntryStep, (object) ((Rework) obj)._ReEntryStep) && (object.Equals((object) this._Path, (object) ((Rework) obj)._Path) && object.Equals((object) this._NavigationMode, (object) ((Rework) obj)._NavigationMode)) && (this.CompareArrays((Array) this._ReEntryWorkflowStack, (Array) ((Rework) obj)._ReEntryWorkflowStack) && object.Equals((object) this._UseReEntryWorkflowStack, (object) ((Rework) obj)._UseReEntryWorkflowStack) && (object.Equals((object) this._UseDispatch, (object) ((Rework) obj)._UseDispatch) && object.Equals((object) this._ReEntryWorkflow, (object) ((Rework) obj)._ReEntryWorkflow))) && (object.Equals((object) this._EndReworkStep, (object) ((Rework) obj)._EndReworkStep) && object.Equals((object) this._EndReworkWorkflow, (object) ((Rework) obj)._EndReworkWorkflow) && (object.Equals((object) this._ReworkReason, (object) ((Rework) obj)._ReworkReason) && object.Equals((object) this._ToStep, (object) ((Rework) obj)._ToStep))) && base.Equals(obj);
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public new NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }

    public new Enumeration<WorkflowNavigationModeEnum, int> NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Enumeration<WorkflowNavigationModeEnum, int>) this.PropertyGet(nameof (NavigationMode));
      }
    }

    public NamedSubentityRef[] ReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ReEntryWorkflowStack));
      }
    }

    public Primitive<bool> UseReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseReEntryWorkflowStack));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public RevisionedObjectRef ReEntryWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ReEntryWorkflow));
      }
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public RevisionedObjectRef EndReworkWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (EndReworkWorkflow));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public new NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }
  }
}
