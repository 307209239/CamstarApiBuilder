// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UnitStartDetails
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
  public class UnitStartDetails : StartDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_StartReason")]
    protected new NamedObjectRef _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_SpecStep")]
    protected NamedSubentityRef _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_UnitCount")]
    protected new Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "UnitStartDetails_Qty")]
    protected new Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is UnitStartDetails && object.Equals((object) this._StartReason, (object) ((UnitStartDetails) obj)._StartReason) && (object.Equals((object) this._SpecStep, (object) ((UnitStartDetails) obj)._SpecStep) && object.Equals((object) this._UOM, (object) ((UnitStartDetails) obj)._UOM)) && (object.Equals((object) this._UnitCount, (object) ((UnitStartDetails) obj)._UnitCount) && object.Equals((object) this._Location, (object) ((UnitStartDetails) obj)._Location) && (object.Equals((object) this._Owner, (object) ((UnitStartDetails) obj)._Owner) && object.Equals((object) this._Resource, (object) ((UnitStartDetails) obj)._Resource))) && (object.Equals((object) this._Factory, (object) ((UnitStartDetails) obj)._Factory) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((UnitStartDetails) obj)._WorkflowStack) && (object.Equals((object) this._Workflow, (object) ((UnitStartDetails) obj)._Workflow) && object.Equals((object) this._WorkflowStep, (object) ((UnitStartDetails) obj)._WorkflowStep)) && (object.Equals((object) this._Product, (object) ((UnitStartDetails) obj)._Product) && object.Equals((object) this._Qty, (object) ((UnitStartDetails) obj)._Qty))) && base.Equals(obj);
    }

    public new NamedObjectRef StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartReason));
      }
    }

    public NamedSubentityRef SpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (SpecStep));
      }
    }

    public new NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public new Primitive<int> UnitCount
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

    public new NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
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

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
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

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public new Primitive<double> Qty
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
  }
}
