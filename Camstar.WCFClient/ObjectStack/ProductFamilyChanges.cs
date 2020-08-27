// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductFamilyChanges
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
  public class ProductFamilyChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_StdStartUOM2")]
    protected NamedObjectRef _StdStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_StdStartQty2")]
    protected Primitive<double> _StdStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_StdStartUOM")]
    protected NamedObjectRef _StdStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_ContainerNumberingRule")]
    protected NamedObjectRef _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_StdCost")]
    protected Primitive<double> _StdCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_PlannedCost")]
    protected Primitive<double> _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_StdStartQty")]
    protected Primitive<double> _StdStartQty;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_CurrentCost")]
    protected Primitive<double> _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Products")]
    protected RevisionedObjectRef[] _Products;

    public override bool Equals(object obj)
    {
      return obj is ProductFamilyChanges && object.Equals((object) this._WIPMsgDefMgr, (object) ((ProductFamilyChanges) obj)._WIPMsgDefMgr) && (object.Equals((object) this._TrainingReqGroup, (object) ((ProductFamilyChanges) obj)._TrainingReqGroup) && object.Equals((object) this._StdStartUOM2, (object) ((ProductFamilyChanges) obj)._StdStartUOM2)) && (object.Equals((object) this._StdStartQty2, (object) ((ProductFamilyChanges) obj)._StdStartQty2) && object.Equals((object) this._StdStartUOM, (object) ((ProductFamilyChanges) obj)._StdStartUOM) && (object.Equals((object) this._ContainerNumberingRule, (object) ((ProductFamilyChanges) obj)._ContainerNumberingRule) && object.Equals((object) this._SamplingPlan, (object) ((ProductFamilyChanges) obj)._SamplingPlan))) && (object.Equals((object) this._StdCost, (object) ((ProductFamilyChanges) obj)._StdCost) && object.Equals((object) this._PlannedCost, (object) ((ProductFamilyChanges) obj)._PlannedCost) && (object.Equals((object) this._Name, (object) ((ProductFamilyChanges) obj)._Name) && object.Equals((object) this._StdStartQty, (object) ((ProductFamilyChanges) obj)._StdStartQty)) && (object.Equals((object) this._CurrentCost, (object) ((ProductFamilyChanges) obj)._CurrentCost) && object.Equals((object) this._Workflow, (object) ((ProductFamilyChanges) obj)._Workflow) && (object.Equals((object) this._DocumentSet, (object) ((ProductFamilyChanges) obj)._DocumentSet) && object.Equals((object) this._ObjectToChange, (object) ((ProductFamilyChanges) obj)._ObjectToChange)))) && this.CompareArrays((Array) this._Products, (Array) ((ProductFamilyChanges) obj)._Products) && base.Equals(obj);
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NamedObjectRef StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public Primitive<double> StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdStartQty2));
      }
    }

    public NamedObjectRef StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public NamedObjectRef ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Primitive<double> StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdCost));
      }
    }

    public Primitive<double> PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (PlannedCost));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Primitive<double> StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Primitive<double> CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CurrentCost));
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

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef[] Products
    {
      [param: In] set
      {
        this.PropertySet(nameof (Products), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (Products));
      }
    }
  }
}
