// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveWithThruput
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
  public class MoveWithThruput : CompoundTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Move")]
    protected MoveStd _Move;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Thruput")]
    protected Thruput _Thruput;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_NavigationMode")]
    protected Enumeration<WorkflowNavigationModeEnum, int> _NavigationMode;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Close")]
    protected Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_MoveAllQty")]
    protected Primitive<bool> _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_OverrideCurrentStatus")]
    protected Primitive<bool> _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ThruputAllQty")]
    protected Primitive<bool> _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ToResource")]
    protected NamedObjectRef _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveWithThruput_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is MoveWithThruput && object.Equals((object) this._Move, (object) ((MoveWithThruput) obj)._Move) && (object.Equals((object) this._Thruput, (object) ((MoveWithThruput) obj)._Thruput) && object.Equals((object) this._MfgProcessOverrides, (object) ((MoveWithThruput) obj)._MfgProcessOverrides)) && (object.Equals((object) this._PrintQueue, (object) ((MoveWithThruput) obj)._PrintQueue) && object.Equals((object) this._Step, (object) ((MoveWithThruput) obj)._Step) && (object.Equals((object) this._NavigationMode, (object) ((MoveWithThruput) obj)._NavigationMode) && object.Equals((object) this._Close, (object) ((MoveWithThruput) obj)._Close))) && (object.Equals((object) this._MoveAllQty, (object) ((MoveWithThruput) obj)._MoveAllQty) && object.Equals((object) this._OverrideCurrentStatus, (object) ((MoveWithThruput) obj)._OverrideCurrentStatus) && (object.Equals((object) this._ThruputAllQty, (object) ((MoveWithThruput) obj)._ThruputAllQty) && object.Equals((object) this._UnitCount, (object) ((MoveWithThruput) obj)._UnitCount)) && (object.Equals((object) this._ChildCount, (object) ((MoveWithThruput) obj)._ChildCount) && object.Equals((object) this._Container, (object) ((MoveWithThruput) obj)._Container) && (object.Equals((object) this._ToResource, (object) ((MoveWithThruput) obj)._ToResource) && object.Equals((object) this._ToWorkflow, (object) ((MoveWithThruput) obj)._ToWorkflow)))) && (object.Equals((object) this._Operation, (object) ((MoveWithThruput) obj)._Operation) && object.Equals((object) this._Location, (object) ((MoveWithThruput) obj)._Location) && (object.Equals((object) this._Path, (object) ((MoveWithThruput) obj)._Path) && object.Equals((object) this._ToLocation, (object) ((MoveWithThruput) obj)._ToLocation)) && (object.Equals((object) this._ToStep, (object) ((MoveWithThruput) obj)._ToStep) && object.Equals((object) this._Resource, (object) ((MoveWithThruput) obj)._Resource))) && base.Equals(obj);
    }

    public MoveStd Move
    {
      [param: In] set
      {
        this.PropertySet(nameof (Move), (object) value);
      }
      get
      {
        return (MoveStd) this.PropertyGet(nameof (Move));
      }
    }

    public Thruput Thruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (Thruput), (object) value);
      }
      get
      {
        return (Thruput) this.PropertyGet(nameof (Thruput));
      }
    }

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
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

    public Primitive<bool> ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThruputAllQty));
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

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
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
  }
}
