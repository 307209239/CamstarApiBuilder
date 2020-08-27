// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryMainline_Info
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
  public class HistoryMainline_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_LabelDetails")]
    protected LabelHistoryDetail_Info _LabelDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_WIPMsgHistoryDetails")]
    protected WIPMsgHistoryDetail_Info _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_MfgProcessOverrides")]
    protected Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ESigDetails")]
    protected ESigHistoryDetail_Info _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ESigSummaries")]
    protected Info _ESigSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_MassUpdates")]
    protected Info _MassUpdates;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ComputationHistory")]
    protected ComputationHistory_Info _ComputationHistory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_LabelSummaries")]
    protected Info _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_DisplayName")]
    protected Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ParametricDetail")]
    protected ParametricDetail_Info _ParametricDetail;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_HistoryDetails")]
    protected HistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_AdditionalESigReqs")]
    protected Info _AdditionalESigReqs;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_CalendarShift")]
    protected Info _CalendarShift;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_AttachmentsDetails")]
    protected DocAttachmentsHistoryDetails_Info _AttachmentsDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_AttributeDetails")]
    protected Info _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_BaseTxnType")]
    protected Info _BaseTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_TxnType")]
    protected Info _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_AttachDocumentHistories")]
    protected Info _AttachDocumentHistories;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_CompoundTxnType")]
    protected Info _CompoundTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_BizRuleHistory")]
    protected Info _BizRuleHistory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Server")]
    protected Info _Server;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_LocalReworkIncluded")]
    protected Info _LocalReworkIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ReversalStatus")]
    protected Info _ReversalStatus;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_HistoryId")]
    protected Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_BonusIncluded")]
    protected Info _BonusIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_StepPass")]
    protected Info _StepPass;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_DefectIncluded")]
    protected Info _DefectIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_LossIncluded")]
    protected Info _LossIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_InRework")]
    protected Info _InRework;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_SystemDateGMT")]
    protected Info _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_TxnDateGMT")]
    protected Info _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_BinningIncluded")]
    protected Info _BinningIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Implicit")]
    protected Info _Implicit;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_TxnDate")]
    protected Info _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Client")]
    protected Info _Client;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_MfgDate")]
    protected Info _MfgDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Application")]
    protected Info _Application;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_QualityESigConfirmed")]
    protected Info _QualityESigConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_SystemDate")]
    protected Info _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ShiftName")]
    protected Info _ShiftName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Authorizations")]
    protected Info _Authorizations;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_IconId")]
    protected Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ResourceAvailability")]
    protected Info _ResourceAvailability;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_ResourceStatusReason")]
    protected Info _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Login")]
    protected Info _Login;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Employee")]
    protected Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Info_Product")]
    protected Info _Product;

    public LabelHistoryDetail_Info LabelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelDetails), (object) value);
      }
      get
      {
        return (LabelHistoryDetail_Info) this.PropertyGet(nameof (LabelDetails));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
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

    public Info Comments
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

    public WIPMsgHistoryDetail_Info WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (WIPMsgHistoryDetail_Info) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public Info MfgProcessOverrides
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

    public ESigHistoryDetail_Info ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail_Info) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public Info ESigSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigSummaries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigSummaries));
      }
    }

    public Info MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public ComputationHistory_Info ComputationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationHistory), (object) value);
      }
      get
      {
        return (ComputationHistory_Info) this.PropertyGet(nameof (ComputationHistory));
      }
    }

    public Info LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public ParametricDetail_Info ParametricDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDetail), (object) value);
      }
      get
      {
        return (ParametricDetail_Info) this.PropertyGet(nameof (ParametricDetail));
      }
    }

    public HistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (HistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info CalendarShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarShift), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalendarShift));
      }
    }

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public DocAttachmentsHistoryDetails_Info AttachmentsDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails_Info) this.PropertyGet(nameof (AttachmentsDetails));
      }
    }

    public Info AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public Info Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Batch));
      }
    }

    public Info BaseTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseTxnType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BaseTxnType));
      }
    }

    public Info TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnType));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public Info CompoundTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompoundTxnType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompoundTxnType));
      }
    }

    public Info BizRuleHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BizRuleHistory));
      }
    }

    public Info Server
    {
      [param: In] set
      {
        this.PropertySet(nameof (Server), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Server));
      }
    }

    public Info LocalReworkIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkIncluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LocalReworkIncluded));
      }
    }

    public Info ReversalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReversalStatus));
      }
    }

    public Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info BonusIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusIncluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BonusIncluded));
      }
    }

    public Info StepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StepPass));
      }
    }

    public Info DefectIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectIncluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefectIncluded));
      }
    }

    public Info LossIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossIncluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LossIncluded));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InRework));
      }
    }

    public Info SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public Info TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Info BinningIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinningIncluded), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BinningIncluded));
      }
    }

    public Info Implicit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Implicit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Implicit));
      }
    }

    public Info TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDate));
      }
    }

    public Info Client
    {
      [param: In] set
      {
        this.PropertySet(nameof (Client), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Client));
      }
    }

    public Info MfgDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgDate));
      }
    }

    public Info Application
    {
      [param: In] set
      {
        this.PropertySet(nameof (Application), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Application));
      }
    }

    public Info QualityESigConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigConfirmed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityESigConfirmed));
      }
    }

    public Info SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SystemDate));
      }
    }

    public Info ShiftName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShiftName));
      }
    }

    public Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Info Authorizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Authorizations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Authorizations));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info Factory
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

    public Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
      }
    }

    public Info ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceAvailability));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
      }
    }

    public Info Login
    {
      [param: In] set
      {
        this.PropertySet(nameof (Login), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Login));
      }
    }

    public Info Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Employee));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
