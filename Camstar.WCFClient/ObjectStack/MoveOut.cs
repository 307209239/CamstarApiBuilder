// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveOut
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
  public class MoveOut : CompoundTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Thruput")]
    protected Thruput _Thruput;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ChangeQty")]
    protected ChangeQty _ChangeQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Move")]
    protected MoveStd _Move;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_MoveAllQty")]
    protected Primitive<bool> _MoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Close")]
    protected Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_OverrideCurrentStatus")]
    protected Primitive<bool> _OverrideCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ToLocation")]
    protected NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ToResource")]
    protected NamedObjectRef _ToResource;
    [DataMember(EmitDefaultValue = false, Name = "MoveOut_ToStep")]
    protected NamedSubentityRef _ToStep;

    public override bool Equals(object obj)
    {
      return obj is MoveOut && object.Equals((object) this._Step, (object) ((MoveOut) obj)._Step) && (object.Equals((object) this._Thruput, (object) ((MoveOut) obj)._Thruput) && object.Equals((object) this._Qty2, (object) ((MoveOut) obj)._Qty2)) && (object.Equals((object) this._ChangeQty, (object) ((MoveOut) obj)._ChangeQty) && object.Equals((object) this._MfgProcessOverrides, (object) ((MoveOut) obj)._MfgProcessOverrides) && (object.Equals((object) this._Move, (object) ((MoveOut) obj)._Move) && object.Equals((object) this._PrintQueue, (object) ((MoveOut) obj)._PrintQueue))) && (object.Equals((object) this._MoveAllQty, (object) ((MoveOut) obj)._MoveAllQty) && object.Equals((object) this._ChildCount, (object) ((MoveOut) obj)._ChildCount) && (object.Equals((object) this._UnitCount, (object) ((MoveOut) obj)._UnitCount) && object.Equals((object) this._Close, (object) ((MoveOut) obj)._Close)) && (object.Equals((object) this._OverrideCurrentStatus, (object) ((MoveOut) obj)._OverrideCurrentStatus) && object.Equals((object) this._Container, (object) ((MoveOut) obj)._Container) && (object.Equals((object) this._ToLocation, (object) ((MoveOut) obj)._ToLocation) && object.Equals((object) this._Resource, (object) ((MoveOut) obj)._Resource)))) && (object.Equals((object) this._Operation, (object) ((MoveOut) obj)._Operation) && object.Equals((object) this._Qty, (object) ((MoveOut) obj)._Qty) && (object.Equals((object) this._ThruputReportingLevel, (object) ((MoveOut) obj)._ThruputReportingLevel) && object.Equals((object) this._Path, (object) ((MoveOut) obj)._Path)) && (object.Equals((object) this._ToResource, (object) ((MoveOut) obj)._ToResource) && object.Equals((object) this._ToStep, (object) ((MoveOut) obj)._ToStep))) && base.Equals(obj);
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

    public ChangeQty ChangeQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQty), (object) value);
      }
      get
      {
        return (ChangeQty) this.PropertyGet(nameof (ChangeQty));
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

    public NamedObjectRef ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ThruputReportingLevel));
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
  }
}
