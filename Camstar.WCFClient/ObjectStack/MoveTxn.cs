// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveTxn
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
  public class MoveTxn : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToWorkflowStack")]
    protected NamedSubentityRef[] _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_NavigationMode")]
    protected Enumeration<WorkflowNavigationModeEnum, int> _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToSpecStep")]
    protected NamedSubentityRef _ToSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ClearToWorkflowStack")]
    protected Primitive<bool> _ClearToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_OverrideCurrentStatus")]
    protected Primitive<bool> _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_TrackStepPass")]
    protected Primitive<bool> _TrackStepPass;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Close")]
    protected Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_MoveAllQty")]
    protected Primitive<bool> _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToResource")]
    protected NamedObjectRef _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToFactory")]
    protected NamedObjectRef _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveTxn_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;

    public override bool Equals(object obj)
    {
      return obj is MoveTxn && this.CompareArrays((Array) this._ToWorkflowStack, (Array) ((MoveTxn) obj)._ToWorkflowStack) && (object.Equals((object) this._Step, (object) ((MoveTxn) obj)._Step) && object.Equals((object) this._Qty2, (object) ((MoveTxn) obj)._Qty2)) && (object.Equals((object) this._Spec, (object) ((MoveTxn) obj)._Spec) && object.Equals((object) this._NavigationMode, (object) ((MoveTxn) obj)._NavigationMode) && (object.Equals((object) this._ToSpecStep, (object) ((MoveTxn) obj)._ToSpecStep) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((MoveTxn) obj)._WorkflowStack))) && (object.Equals((object) this._Path, (object) ((MoveTxn) obj)._Path) && object.Equals((object) this._ClearToWorkflowStack, (object) ((MoveTxn) obj)._ClearToWorkflowStack) && (object.Equals((object) this._UseDispatch, (object) ((MoveTxn) obj)._UseDispatch) && object.Equals((object) this._OverrideCurrentStatus, (object) ((MoveTxn) obj)._OverrideCurrentStatus)) && (object.Equals((object) this._TrackStepPass, (object) ((MoveTxn) obj)._TrackStepPass) && object.Equals((object) this._UnitCount, (object) ((MoveTxn) obj)._UnitCount) && (object.Equals((object) this._ChildCount, (object) ((MoveTxn) obj)._ChildCount) && object.Equals((object) this._Container, (object) ((MoveTxn) obj)._Container)))) && (object.Equals((object) this._Close, (object) ((MoveTxn) obj)._Close) && object.Equals((object) this._MoveAllQty, (object) ((MoveTxn) obj)._MoveAllQty) && (object.Equals((object) this._ToLocation, (object) ((MoveTxn) obj)._ToLocation) && object.Equals((object) this._Qty, (object) ((MoveTxn) obj)._Qty)) && (object.Equals((object) this._Resource, (object) ((MoveTxn) obj)._Resource) && object.Equals((object) this._ToResource, (object) ((MoveTxn) obj)._ToResource) && (object.Equals((object) this._ToFactory, (object) ((MoveTxn) obj)._ToFactory) && object.Equals((object) this._ToStep, (object) ((MoveTxn) obj)._ToStep))) && (object.Equals((object) this._Location, (object) ((MoveTxn) obj)._Location) && object.Equals((object) this._ToWorkflow, (object) ((MoveTxn) obj)._ToWorkflow))) && base.Equals(obj);
    }

    public NamedSubentityRef[] ToWorkflowStack
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

    public NamedSubentityRef Step
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

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public RevisionedObjectRef Spec
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

    public Enumeration<WorkflowNavigationModeEnum, int> NavigationMode
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

    public NamedSubentityRef ToSpecStep
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

    public NamedSubentityRef[] WorkflowStack
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

    public NamedSubentityRef Path
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

    public Primitive<bool> ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClearToWorkflowStack));
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

    public Primitive<bool> OverrideCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideCurrentStatus), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OverrideCurrentStatus));
      }
    }

    public Primitive<bool> TrackStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackStepPass), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TrackStepPass));
      }
    }

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public new ContainerRef Container
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

    public Primitive<bool> Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Close));
      }
    }

    public Primitive<bool> MoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MoveAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (MoveAllQty));
      }
    }

    public NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef ToResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToResource));
      }
    }

    public NamedObjectRef ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToFactory));
      }
    }

    public NamedSubentityRef ToStep
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

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public RevisionedObjectRef ToWorkflow
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
  }
}
