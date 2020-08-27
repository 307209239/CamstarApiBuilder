// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryMainline
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
  public class HistoryMainline : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_LabelDetails")]
    protected LabelHistoryDetail[] _LabelDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_WIPMsgHistoryDetails")]
    protected WIPMsgHistoryDetail[] _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_MfgProcessOverrides")]
    protected RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ESigDetails")]
    protected ESigHistoryDetail[] _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ESigSummaries")]
    protected SubentityRef[] _ESigSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_MassUpdates")]
    protected Primitive<string>[] _MassUpdates;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ComputationHistory")]
    protected ComputationHistory _ComputationHistory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_LabelSummaries")]
    protected SubentityRef[] _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_DisplayName")]
    protected Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ParametricDetail")]
    protected ParametricDetail _ParametricDetail;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_HistoryDetails")]
    protected Camstar.WCF.ObjectStack.HistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_AdditionalESigReqs")]
    protected NamedObjectRef[] _AdditionalESigReqs;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_CalendarShift")]
    protected SubentityRef _CalendarShift;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_AttachmentsDetails")]
    protected DocAttachmentsHistoryDetails[] _AttachmentsDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_AttributeDetails")]
    protected SubentityRef[] _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_BaseTxnType")]
    protected Enumeration<ServiceNameEnum, string> _BaseTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_TxnType")]
    protected Enumeration<ServiceNameEnum, string> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_AttachDocumentHistories")]
    protected SubentityRef[] _AttachDocumentHistories;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_CompoundTxnType")]
    protected Enumeration<ServiceNameEnum, string> _CompoundTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_BizRuleHistory")]
    protected SubentityRef[] _BizRuleHistory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Server")]
    protected Primitive<int> _Server;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_LocalReworkIncluded")]
    protected Primitive<bool> _LocalReworkIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ReversalStatus")]
    protected Primitive<int> _ReversalStatus;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_HistoryId")]
    protected BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_BonusIncluded")]
    protected Primitive<bool> _BonusIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_StepPass")]
    protected Primitive<int> _StepPass;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_DefectIncluded")]
    protected Primitive<bool> _DefectIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_LossIncluded")]
    protected Primitive<bool> _LossIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_InRework")]
    protected Primitive<bool> _InRework;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_SystemDateGMT")]
    protected Primitive<DateTime> _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_TxnDateGMT")]
    protected Primitive<DateTime> _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_BinningIncluded")]
    protected Primitive<bool> _BinningIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Implicit")]
    protected Primitive<bool> _Implicit;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_TxnDate")]
    protected Primitive<DateTime> _TxnDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Client")]
    protected Primitive<int> _Client;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_MfgDate")]
    protected Primitive<DateTime> _MfgDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Application")]
    protected Primitive<int> _Application;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_QualityESigConfirmed")]
    protected Primitive<bool> _QualityESigConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_SystemDate")]
    protected Primitive<DateTime> _SystemDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ShiftName")]
    protected Primitive<string> _ShiftName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Authorizations")]
    protected NamedObjectRef[] _Authorizations;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ResourceAvailability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _ResourceAvailability;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_ResourceStatusReason")]
    protected NamedObjectRef _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Login")]
    protected NamedObjectRef _Login;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Employee")]
    protected NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is HistoryMainline && this.CompareArrays((Array) this._LabelDetails, (Array) ((HistoryMainline) obj)._LabelDetails) && (object.Equals((object) this._Spec, (object) ((HistoryMainline) obj)._Spec) && object.Equals((object) this._ESigRequirement, (object) ((HistoryMainline) obj)._ESigRequirement)) && (object.Equals((object) this._Comments, (object) ((HistoryMainline) obj)._Comments) && this.CompareArrays((Array) this._WIPMsgHistoryDetails, (Array) ((HistoryMainline) obj)._WIPMsgHistoryDetails) && (object.Equals((object) this._MfgProcessOverrides, (object) ((HistoryMainline) obj)._MfgProcessOverrides) && this.CompareArrays((Array) this._ESigDetails, (Array) ((HistoryMainline) obj)._ESigDetails))) && (this.CompareArrays((Array) this._ESigSummaries, (Array) ((HistoryMainline) obj)._ESigSummaries) && this.CompareArrays((Array) this._MassUpdates, (Array) ((HistoryMainline) obj)._MassUpdates) && (object.Equals((object) this._ComputationHistory, (object) ((HistoryMainline) obj)._ComputationHistory) && this.CompareArrays((Array) this._LabelSummaries, (Array) ((HistoryMainline) obj)._LabelSummaries)) && (object.Equals((object) this._DisplayName, (object) ((HistoryMainline) obj)._DisplayName) && object.Equals((object) this._ParametricDetail, (object) ((HistoryMainline) obj)._ParametricDetail) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((HistoryMainline) obj)._HistoryDetails) && this.CompareArrays((Array) this._AdditionalESigReqs, (Array) ((HistoryMainline) obj)._AdditionalESigReqs)))) && (object.Equals((object) this._CalendarShift, (object) ((HistoryMainline) obj)._CalendarShift) && object.Equals((object) this._WorkflowStep, (object) ((HistoryMainline) obj)._WorkflowStep) && (this.CompareArrays((Array) this._AttachmentsDetails, (Array) ((HistoryMainline) obj)._AttachmentsDetails) && this.CompareArrays((Array) this._AttributeDetails, (Array) ((HistoryMainline) obj)._AttributeDetails)) && (object.Equals((object) this._Batch, (object) ((HistoryMainline) obj)._Batch) && object.Equals((object) this._BaseTxnType, (object) ((HistoryMainline) obj)._BaseTxnType) && (object.Equals((object) this._TxnType, (object) ((HistoryMainline) obj)._TxnType) && object.Equals((object) this._Carrier, (object) ((HistoryMainline) obj)._Carrier))) && (this.CompareArrays((Array) this._AttachDocumentHistories, (Array) ((HistoryMainline) obj)._AttachDocumentHistories) && object.Equals((object) this._CompoundTxnType, (object) ((HistoryMainline) obj)._CompoundTxnType) && (this.CompareArrays((Array) this._BizRuleHistory, (Array) ((HistoryMainline) obj)._BizRuleHistory) && object.Equals((object) this._Server, (object) ((HistoryMainline) obj)._Server)) && (object.Equals((object) this._LocalReworkIncluded, (object) ((HistoryMainline) obj)._LocalReworkIncluded) && object.Equals((object) this._ReversalStatus, (object) ((HistoryMainline) obj)._ReversalStatus) && (object.Equals((object) this._HistoryId, (object) ((HistoryMainline) obj)._HistoryId) && object.Equals((object) this._BonusIncluded, (object) ((HistoryMainline) obj)._BonusIncluded))))) && (object.Equals((object) this._StepPass, (object) ((HistoryMainline) obj)._StepPass) && object.Equals((object) this._DefectIncluded, (object) ((HistoryMainline) obj)._DefectIncluded) && (object.Equals((object) this._LossIncluded, (object) ((HistoryMainline) obj)._LossIncluded) && object.Equals((object) this._Container, (object) ((HistoryMainline) obj)._Container)) && (object.Equals((object) this._InRework, (object) ((HistoryMainline) obj)._InRework) && object.Equals((object) this._SystemDateGMT, (object) ((HistoryMainline) obj)._SystemDateGMT) && (object.Equals((object) this._TxnDateGMT, (object) ((HistoryMainline) obj)._TxnDateGMT) && object.Equals((object) this._BinningIncluded, (object) ((HistoryMainline) obj)._BinningIncluded))) && (object.Equals((object) this._Implicit, (object) ((HistoryMainline) obj)._Implicit) && object.Equals((object) this._TxnDate, (object) ((HistoryMainline) obj)._TxnDate) && (object.Equals((object) this._Client, (object) ((HistoryMainline) obj)._Client) && object.Equals((object) this._MfgDate, (object) ((HistoryMainline) obj)._MfgDate)) && (object.Equals((object) this._Application, (object) ((HistoryMainline) obj)._Application) && object.Equals((object) this._QualityESigConfirmed, (object) ((HistoryMainline) obj)._QualityESigConfirmed) && (object.Equals((object) this._SystemDate, (object) ((HistoryMainline) obj)._SystemDate) && object.Equals((object) this._ShiftName, (object) ((HistoryMainline) obj)._ShiftName)))) && (object.Equals((object) this._ResourceStatusCode, (object) ((HistoryMainline) obj)._ResourceStatusCode) && this.CompareArrays((Array) this._Authorizations, (Array) ((HistoryMainline) obj)._Authorizations) && (object.Equals((object) this._Resource, (object) ((HistoryMainline) obj)._Resource) && object.Equals((object) this._Status, (object) ((HistoryMainline) obj)._Status)) && (object.Equals((object) this._Operation, (object) ((HistoryMainline) obj)._Operation) && object.Equals((object) this._Factory, (object) ((HistoryMainline) obj)._Factory) && (object.Equals((object) this._IconId, (object) ((HistoryMainline) obj)._IconId) && object.Equals((object) this._User, (object) ((HistoryMainline) obj)._User))) && (object.Equals((object) this._ResourceAvailability, (object) ((HistoryMainline) obj)._ResourceAvailability) && object.Equals((object) this._Owner, (object) ((HistoryMainline) obj)._Owner) && (object.Equals((object) this._ResourceStatusReason, (object) ((HistoryMainline) obj)._ResourceStatusReason) && object.Equals((object) this._Workstation, (object) ((HistoryMainline) obj)._Workstation)) && (object.Equals((object) this._Login, (object) ((HistoryMainline) obj)._Login) && object.Equals((object) this._Employee, (object) ((HistoryMainline) obj)._Employee) && object.Equals((object) this._Product, (object) ((HistoryMainline) obj)._Product))))) && base.Equals(obj);
    }

    public LabelHistoryDetail[] LabelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelDetails), (object) value);
      }
      get
      {
        return (LabelHistoryDetail[]) this.PropertyGet(nameof (LabelDetails));
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

    public Primitive<string> Comments
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

    public WIPMsgHistoryDetail[] WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (WIPMsgHistoryDetail[]) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public RevisionedObjectRef MfgProcessOverrides
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

    public ESigHistoryDetail[] ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail[]) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public SubentityRef[] ESigSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigSummaries), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ESigSummaries));
      }
    }

    public Primitive<string>[] MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public ComputationHistory ComputationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationHistory), (object) value);
      }
      get
      {
        return (ComputationHistory) this.PropertyGet(nameof (ComputationHistory));
      }
    }

    public SubentityRef[] LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public ParametricDetail ParametricDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDetail), (object) value);
      }
      get
      {
        return (ParametricDetail) this.PropertyGet(nameof (ParametricDetail));
      }
    }

    public Camstar.WCF.ObjectStack.HistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.HistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public SubentityRef CalendarShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarShift), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CalendarShift));
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

    public DocAttachmentsHistoryDetails[] AttachmentsDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails[]) this.PropertyGet(nameof (AttachmentsDetails));
      }
    }

    public SubentityRef[] AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public ContainerRef Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Batch));
      }
    }

    public Enumeration<ServiceNameEnum, string> BaseTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseTxnType), (object) value);
      }
      get
      {
        return (Enumeration<ServiceNameEnum, string>) this.PropertyGet(nameof (BaseTxnType));
      }
    }

    public Enumeration<ServiceNameEnum, string> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Enumeration<ServiceNameEnum, string>) this.PropertyGet(nameof (TxnType));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public SubentityRef[] AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public Enumeration<ServiceNameEnum, string> CompoundTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompoundTxnType), (object) value);
      }
      get
      {
        return (Enumeration<ServiceNameEnum, string>) this.PropertyGet(nameof (CompoundTxnType));
      }
    }

    public SubentityRef[] BizRuleHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHistory), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (BizRuleHistory));
      }
    }

    public Primitive<int> Server
    {
      [param: In] set
      {
        this.PropertySet(nameof (Server), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Server));
      }
    }

    public Primitive<bool> LocalReworkIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkIncluded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LocalReworkIncluded));
      }
    }

    public Primitive<int> ReversalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalStatus), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ReversalStatus));
      }
    }

    public BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<bool> BonusIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusIncluded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BonusIncluded));
      }
    }

    public Primitive<int> StepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPass), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StepPass));
      }
    }

    public Primitive<bool> DefectIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectIncluded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DefectIncluded));
      }
    }

    public Primitive<bool> LossIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossIncluded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LossIncluded));
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

    public Primitive<bool> InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InRework));
      }
    }

    public Primitive<DateTime> SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public Primitive<DateTime> TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Primitive<bool> BinningIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinningIncluded), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BinningIncluded));
      }
    }

    public Primitive<bool> Implicit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Implicit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Implicit));
      }
    }

    public Primitive<DateTime> TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDate));
      }
    }

    public Primitive<int> Client
    {
      [param: In] set
      {
        this.PropertySet(nameof (Client), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Client));
      }
    }

    public Primitive<DateTime> MfgDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MfgDate));
      }
    }

    public Primitive<int> Application
    {
      [param: In] set
      {
        this.PropertySet(nameof (Application), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Application));
      }
    }

    public Primitive<bool> QualityESigConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigConfirmed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (QualityESigConfirmed));
      }
    }

    public Primitive<DateTime> SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SystemDate));
      }
    }

    public Primitive<string> ShiftName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ShiftName));
      }
    }

    public NamedObjectRef ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public NamedObjectRef[] Authorizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Authorizations), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Authorizations));
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

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (ResourceAvailability));
      }
    }

    public NamedObjectRef Owner
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

    public NamedObjectRef ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }

    public NamedObjectRef Login
    {
      [param: In] set
      {
        this.PropertySet(nameof (Login), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Login));
      }
    }

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }

    public RevisionedObjectRef Product
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
  }
}
