// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShopFloor_Info
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
  public class ShopFloor_Info : Update_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_MfgCalendar")]
    protected Info _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_LabelSummaries")]
    protected LabelSummary_Info _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_WIPMsgMgr")]
    protected new WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ParametricDataControl")]
    protected Info _ParametricDataControl;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_TrainingRequirements")]
    protected Info _TrainingRequirements;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_DispatchRule")]
    protected Info _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_CalledByTransactionTask")]
    protected Info _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_AdditionalESigReqs")]
    protected Info _AdditionalESigReqs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ParametricData")]
    protected ParametricData_Info _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ComputationDetail")]
    protected ComputationDetail_Info _ComputationDetail;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ESigDetails")]
    protected ESigServiceDetail_Info _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ActionSource")]
    protected Info _ActionSource;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_SamplingPlanDetails")]
    protected Info _SamplingPlanDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_WebPart")]
    protected Info _WebPart;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ActionDetails")]
    protected ActionDetails_Info _ActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_IsRemoteService")]
    protected new Info _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ParametricDataDefType")]
    protected Info _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessESignatures")]
    protected Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessMaintMgmt")]
    protected Info _ProcessMaintMgmt;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_HasUserDataCollection")]
    protected Info _HasUserDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessTrainingReqs")]
    protected Info _ProcessTrainingReqs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessNCRs")]
    protected Info _ProcessNCRs;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_EnforceDispatch")]
    protected Info _EnforceDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessEProcedures")]
    protected Info _ProcessEProcedures;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_HasDataCollection")]
    protected Info _HasDataCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_TaskContainer")]
    protected Info _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_UseDispatch")]
    protected Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_ProcessMasterRecipe")]
    protected Info _ProcessMasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_PrintLabels")]
    protected Info _PrintLabels;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_HasDPCollection")]
    protected Info _HasDPCollection;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_SampleQty")]
    protected Info _SampleQty;
    [DataMember(EmitDefaultValue = false, Name = "ShopFloor_Info_MfgOrder")]
    protected Info _MfgOrder;

    public Info MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LabelSummary_Info LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary_Info) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public new WIPMsgMgr_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info ParametricDataControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataControl));
      }
    }

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info TrainingRequirements
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirements), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingRequirements));
      }
    }

    public Info DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public Info CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info AdditionalESigReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalESigReqs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdditionalESigReqs));
      }
    }

    public ParametricData_Info ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData_Info) this.PropertyGet(nameof (ParametricData));
      }
    }

    public ComputationDetail_Info ComputationDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationDetail), (object) value);
      }
      get
      {
        return (ComputationDetail_Info) this.PropertyGet(nameof (ComputationDetail));
      }
    }

    public ESigServiceDetail_Info ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Info) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
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

    public Info ActionSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionSource));
      }
    }

    public Info SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public Info WebPart
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebPart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebPart));
      }
    }

    public ActionDetails_Info ActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionDetails), (object) value);
      }
      get
      {
        return (ActionDetails_Info) this.PropertyGet(nameof (ActionDetails));
      }
    }

    public new Info IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Info ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Info ProcessMaintMgmt
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMaintMgmt), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessMaintMgmt));
      }
    }

    public Info HasUserDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasUserDataCollection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasUserDataCollection));
      }
    }

    public Info ProcessTrainingReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTrainingReqs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTrainingReqs));
      }
    }

    public Info ProcessNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessNCRs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessNCRs));
      }
    }

    public Info EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnforceDispatch));
      }
    }

    public Info ProcessEProcedures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessEProcedures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessEProcedures));
      }
    }

    public Info HasDataCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDataCollection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasDataCollection));
      }
    }

    public Info TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Info ProcessMasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessMasterRecipe), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessMasterRecipe));
      }
    }

    public Info PrintLabels
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintLabels), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintLabels));
      }
    }

    public Info HasDPCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasDPCollection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasDPCollection));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info SampleQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleQty));
      }
    }

    public Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
