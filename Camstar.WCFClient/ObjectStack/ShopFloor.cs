// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShopFloor
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
  public class ShopFloor : Update
  {
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_MfgCalendar")]
    protected NamedObjectRef _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_LabelSummaries")]
    protected LabelSummary[] _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_WIPMsgMgr")]
    protected new WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ParametricDataControl")]
    protected Primitive<string> _ParametricDataControl;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_TrainingRequirements")]
    protected RevisionedObjectRef[] _TrainingRequirements;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_DispatchRule")]
    protected NamedObjectRef _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_CalledByTransactionTask")]
    protected NamedSubentityRef _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_AdditionalESigReqs")]
    protected NamedObjectRef[] _AdditionalESigReqs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ParametricData")]
    protected ParametricData _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ComputationDetail")]
    protected ComputationDetail _ComputationDetail;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ESigDetails")]
    protected ESigServiceDetail[] _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ActionSource")]
    protected NamedObjectRef _ActionSource;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_SamplingPlanDetails")]
    protected SubentityRef[] _SamplingPlanDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_WebPart")]
    protected NamedObjectRef _WebPart;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ActionDetails")]
    protected Camstar.WCF.ObjectStack.ActionDetails[] _ActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_IsRemoteService")]
    protected new Primitive<bool> _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ParametricDataDefType")]
    protected Primitive<int> _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessESignatures")]
    protected Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessMaintMgmt")]
    protected Primitive<bool> _ProcessMaintMgmt;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_HasUserDataCollection")]
    protected Primitive<bool> _HasUserDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessTrainingReqs")]
    protected Primitive<bool> _ProcessTrainingReqs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessNCRs")]
    protected Primitive<bool> _ProcessNCRs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_EnforceDispatch")]
    protected Primitive<bool> _EnforceDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessEProcedures")]
    protected Primitive<bool> _ProcessEProcedures;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_HasDataCollection")]
    protected Primitive<bool> _HasDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_TaskContainer")]
    protected ContainerRef _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_UseDispatch")]
    protected Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_ProcessMasterRecipe")]
    protected Primitive<bool> _ProcessMasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_PrintLabels")]
    protected Primitive<bool> _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_HasDPCollection")]
    protected Primitive<bool> _HasDPCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_SampleQty")]
    protected Primitive<double> _SampleQty;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_MfgOrder")]
    protected NamedObjectRef _MfgOrder;

    public override bool Equals(object obj)
    {
      return obj is ShopFloor && object.Equals((object) this._MfgCalendar, (object) ((ShopFloor) obj)._MfgCalendar) && (this.CompareArrays((Array) this._LabelSummaries, (Array) ((ShopFloor) obj)._LabelSummaries) && object.Equals((object) this._WIPMsgMgr, (object) ((ShopFloor) obj)._WIPMsgMgr)) && (object.Equals((object) this._DataCollectionDef, (object) ((ShopFloor) obj)._DataCollectionDef) && object.Equals((object) this._ParametricDataControl, (object) ((ShopFloor) obj)._ParametricDataControl) && (object.Equals((object) this._ESigRequirement, (object) ((ShopFloor) obj)._ESigRequirement) && object.Equals((object) this._Comments, (object) ((ShopFloor) obj)._Comments))) && (this.CompareArrays((Array) this._TrainingRequirements, (Array) ((ShopFloor) obj)._TrainingRequirements) && object.Equals((object) this._DispatchRule, (object) ((ShopFloor) obj)._DispatchRule) && (object.Equals((object) this._CalledByTransactionTask, (object) ((ShopFloor) obj)._CalledByTransactionTask) && object.Equals((object) this._PrintQueue, (object) ((ShopFloor) obj)._PrintQueue)) && (this.CompareArrays((Array) this._AdditionalESigReqs, (Array) ((ShopFloor) obj)._AdditionalESigReqs) && object.Equals((object) this._ParametricData, (object) ((ShopFloor) obj)._ParametricData) && (object.Equals((object) this._ComputationDetail, (object) ((ShopFloor) obj)._ComputationDetail) && this.CompareArrays((Array) this._ESigDetails, (Array) ((ShopFloor) obj)._ESigDetails)))) && (object.Equals((object) this._MfgProcessOverrides, (object) ((ShopFloor) obj)._MfgProcessOverrides) && object.Equals((object) this._SamplingPlan, (object) ((ShopFloor) obj)._SamplingPlan) && (object.Equals((object) this._ActionSource, (object) ((ShopFloor) obj)._ActionSource) && this.CompareArrays((Array) this._SamplingPlanDetails, (Array) ((ShopFloor) obj)._SamplingPlanDetails)) && (object.Equals((object) this._WebPart, (object) ((ShopFloor) obj)._WebPart) && this.CompareArrays((Array) this._ActionDetails, (Array) ((ShopFloor) obj)._ActionDetails) && (object.Equals((object) this._IsRemoteService, (object) ((ShopFloor) obj)._IsRemoteService) && object.Equals((object) this._ParametricDataDefType, (object) ((ShopFloor) obj)._ParametricDataDefType))) && (object.Equals((object) this._ProcessESignatures, (object) ((ShopFloor) obj)._ProcessESignatures) && object.Equals((object) this._ProcessMaintMgmt, (object) ((ShopFloor) obj)._ProcessMaintMgmt) && (object.Equals((object) this._HasUserDataCollection, (object) ((ShopFloor) obj)._HasUserDataCollection) && object.Equals((object) this._ProcessTrainingReqs, (object) ((ShopFloor) obj)._ProcessTrainingReqs)) && (object.Equals((object) this._ProcessNCRs, (object) ((ShopFloor) obj)._ProcessNCRs) && object.Equals((object) this._EnforceDispatch, (object) ((ShopFloor) obj)._EnforceDispatch) && (object.Equals((object) this._ProcessEProcedures, (object) ((ShopFloor) obj)._ProcessEProcedures) && object.Equals((object) this._HasDataCollection, (object) ((ShopFloor) obj)._HasDataCollection))))) && (object.Equals((object) this._TaskContainer, (object) ((ShopFloor) obj)._TaskContainer) && object.Equals((object) this._UseDispatch, (object) ((ShopFloor) obj)._UseDispatch) && (object.Equals((object) this._ProcessMasterRecipe, (object) ((ShopFloor) obj)._ProcessMasterRecipe) && object.Equals((object) this._PrintLabels, (object) ((ShopFloor) obj)._PrintLabels)) && (object.Equals((object) this._HasDPCollection, (object) ((ShopFloor) obj)._HasDPCollection) && object.Equals((object) this._Factory, (object) ((ShopFloor) obj)._Factory) && (object.Equals((object) this._SampleQty, (object) ((ShopFloor) obj)._SampleQty) && object.Equals((object) this._MfgOrder, (object) ((ShopFloor) obj)._MfgOrder)))) && base.Equals(obj);
    }

    public NamedObjectRef MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LabelSummary[] LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary[]) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public new WIPMsgMgr WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Primitive<string> ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public RevisionedObjectRef[] TrainingRequirements
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirements), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (TrainingRequirements));
      }
    }

    public NamedObjectRef DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public NamedSubentityRef CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public NamedObjectRef PrintQueue
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

    public NamedObjectRef[] AdditionalESigReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalESigReqs), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (AdditionalESigReqs));
      }
    }

    public ParametricData ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData) this.PropertyGet(nameof (ParametricData));
      }
    }

    public ComputationDetail ComputationDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationDetail), (object) value);
      }
      get
      {
        return (ComputationDetail) this.PropertyGet(nameof (ComputationDetail));
      }
    }

    public ESigServiceDetail[] ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail[]) this.PropertyGet(nameof (ESigDetails));
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

    public NamedObjectRef ActionSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionSource));
      }
    }

    public SubentityRef[] SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public NamedObjectRef WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WebPart));
      }
    }

    public Camstar.WCF.ObjectStack.ActionDetails[] ActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ActionDetails[]) this.PropertyGet(nameof (ActionDetails));
      }
    }

    public new Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Primitive<int> ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Primitive<bool> ProcessMaintMgmt
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMaintMgmt), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessMaintMgmt));
      }
    }

    public Primitive<bool> HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasUserDataCollection));
      }
    }

    public Primitive<bool> ProcessTrainingReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTrainingReqs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessTrainingReqs));
      }
    }

    public Primitive<bool> ProcessNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessNCRs), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessNCRs));
      }
    }

    public Primitive<bool> EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (EnforceDispatch));
      }
    }

    public Primitive<bool> ProcessEProcedures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessEProcedures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessEProcedures));
      }
    }

    public Primitive<bool> HasDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDataCollection), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasDataCollection));
      }
    }

    public ContainerRef TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public Primitive<bool> UseDispatch
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

    public Primitive<bool> ProcessMasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMasterRecipe), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessMasterRecipe));
      }
    }

    public Primitive<bool> PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Primitive<bool> HasDPCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDPCollection), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HasDPCollection));
      }
    }

    public new NamedObjectRef Factory
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

    public Primitive<double> SampleQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (SampleQty));
      }
    }

    public NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
