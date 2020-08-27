// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveStdChangePkg
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
  public class MoveStdChangePkg : BPMoveStd
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_WorkflowNavigator")]
    protected new SubentityRef _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Step")]
    protected new NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_WorkflowStack")]
    protected new NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_ToSpecStep")]
    protected new NamedSubentityRef _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_ToWorkflow")]
    protected new RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_ToWorkflowStack")]
    protected new NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_TrackableObject")]
    protected NamedObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;

    public override bool Equals(object obj)
    {
      return obj is MoveStdChangePkg && object.Equals((object) this._WorkflowNavigator, (object) ((MoveStdChangePkg) obj)._WorkflowNavigator) && (object.Equals((object) this._Step, (object) ((MoveStdChangePkg) obj)._Step) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((MoveStdChangePkg) obj)._WorkflowStack)) && (object.Equals((object) this._ToSpecStep, (object) ((MoveStdChangePkg) obj)._ToSpecStep) && object.Equals((object) this._Spec, (object) ((MoveStdChangePkg) obj)._Spec) && (object.Equals((object) this._ToWorkflow, (object) ((MoveStdChangePkg) obj)._ToWorkflow) && this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((MoveStdChangePkg) obj)._ToWorkflowStack))) && (object.Equals((object) this._TrackableObject, (object) ((MoveStdChangePkg) obj)._TrackableObject) && object.Equals((object) this._ChangePackageHeader, (object) ((MoveStdChangePkg) obj)._ChangePackageHeader)) && base.Equals(obj);
    }

    public new SubentityRef WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public new NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public new NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public new NamedSubentityRef ToSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSpecStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToSpecStep));
      }
    }

    public new RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new RevisionedObjectRef ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public new NamedSubentityRef[] ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public NamedObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public ChangePackageHeader ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }
  }
}
