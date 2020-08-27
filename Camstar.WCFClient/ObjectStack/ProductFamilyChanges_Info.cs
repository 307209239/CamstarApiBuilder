// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductFamilyChanges_Info
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
  public class ProductFamilyChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_StdStartUOM2")]
    protected Info _StdStartUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_StdStartQty2")]
    protected Info _StdStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_StdStartUOM")]
    protected Info _StdStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_ContainerNumberingRule")]
    protected Info _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_StdCost")]
    protected Info _StdCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_PlannedCost")]
    protected Info _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_StdStartQty")]
    protected Info _StdStartQty;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_CurrentCost")]
    protected Info _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Info_Products")]
    protected Info _Products;

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public Info StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartQty2));
      }
    }

    public Info StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public Info ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Info StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdCost));
      }
    }

    public Info PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedCost));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Info CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentCost));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Products
    {
      [param: In] set
      {
        this.PropertySet(nameof (Products), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Products));
      }
    }
  }
}
