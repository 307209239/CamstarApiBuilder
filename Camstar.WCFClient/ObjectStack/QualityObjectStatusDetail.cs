// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectStatusDetail
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
  public class QualityObjectStatusDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Attachments")]
    protected DocAttachments _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Status")]
    protected Enumeration<QualityStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_AttachmentsID")]
    protected SubentityRef _AttachmentsID;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CrossReferenceItems")]
    protected NamedObjectRef[] _CrossReferenceItems;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_StatusName")]
    protected Primitive<string> _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CARResolutionActionName")]
    protected Primitive<string> _CARResolutionActionName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_SubclassificationName")]
    protected Primitive<string> _SubclassificationName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CategoryName")]
    protected Primitive<string> _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ProcessModelStageName")]
    protected Primitive<string> _ProcessModelStageName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ClassificationName")]
    protected Primitive<string> _ClassificationName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_EntryForApproval")]
    protected SubentityRef _EntryForApproval;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CompletionApprovalSheet")]
    protected NamedSubentityRef _CompletionApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CmpltRoutingResolutionAction")]
    protected Enumeration<ResolutionActionEnum, int> _CmpltRoutingResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_RiskAssessment")]
    protected RiskAssessment _RiskAssessment;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CompletionRoutingInfo")]
    protected SubentityRef _CompletionRoutingInfo;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ProcessModelStage")]
    protected Enumeration<StageEnum, int> _ProcessModelStage;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CompletionApprovalStatus")]
    protected Enumeration<ApprovalStatusEnum, int> _CompletionApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CARResolutionAction")]
    protected Enumeration<CARResolutionActionEnum, int> _CARResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ProcessModel")]
    protected NamedSubentityRef _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CmpltRoutingResolutionCode")]
    protected NamedObjectRef _CmpltRoutingResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ChecklistAssigned")]
    protected Primitive<bool> _ChecklistAssigned;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ChecklistSaved")]
    protected Primitive<bool> _ChecklistSaved;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_IsCARRequiredToClose")]
    protected Primitive<bool> _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ClosureDateGMT")]
    protected Primitive<DateTime> _ClosureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ClosureDate")]
    protected Primitive<DateTime> _ClosureDate;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_UserHasRole")]
    protected Primitive<bool> _UserHasRole;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_UserIsOwner")]
    protected Primitive<bool> _UserIsOwner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_IsApprovalRequired")]
    protected Primitive<bool> _IsApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ReportedDateGMT")]
    protected Primitive<DateTime> _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CloseDescription")]
    protected Primitive<string> _CloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Reporter")]
    protected NamedObjectRef _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_CmpltRoutingCloseDescription")]
    protected Primitive<string> _CmpltRoutingCloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_ClosedBy")]
    protected NamedObjectRef _ClosedBy;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Initiator")]
    protected NamedObjectRef _Initiator;

    public override bool Equals(object obj)
    {
      return obj is QualityObjectStatusDetail && object.Equals((object) this._Attachments, (object) ((QualityObjectStatusDetail) obj)._Attachments) && (object.Equals((object) this._Status, (object) ((QualityObjectStatusDetail) obj)._Status) && object.Equals((object) this._Role, (object) ((QualityObjectStatusDetail) obj)._Role)) && (object.Equals((object) this._AttachmentsID, (object) ((QualityObjectStatusDetail) obj)._AttachmentsID) && this.CompareArrays((Array) this._CrossReferenceItems, (Array) ((QualityObjectStatusDetail) obj)._CrossReferenceItems) && (object.Equals((object) this._StatusName, (object) ((QualityObjectStatusDetail) obj)._StatusName) && object.Equals((object) this._CARResolutionActionName, (object) ((QualityObjectStatusDetail) obj)._CARResolutionActionName))) && (object.Equals((object) this._SubclassificationName, (object) ((QualityObjectStatusDetail) obj)._SubclassificationName) && object.Equals((object) this._Category, (object) ((QualityObjectStatusDetail) obj)._Category) && (object.Equals((object) this._PriorityLevel, (object) ((QualityObjectStatusDetail) obj)._PriorityLevel) && object.Equals((object) this._CategoryName, (object) ((QualityObjectStatusDetail) obj)._CategoryName)) && (object.Equals((object) this._ProcessModelStageName, (object) ((QualityObjectStatusDetail) obj)._ProcessModelStageName) && object.Equals((object) this._ClassificationName, (object) ((QualityObjectStatusDetail) obj)._ClassificationName) && (object.Equals((object) this._ReporterOrganization, (object) ((QualityObjectStatusDetail) obj)._ReporterOrganization) && object.Equals((object) this._InitiatorOrganization, (object) ((QualityObjectStatusDetail) obj)._InitiatorOrganization)))) && (object.Equals((object) this._EntryForApproval, (object) ((QualityObjectStatusDetail) obj)._EntryForApproval) && object.Equals((object) this._Organization, (object) ((QualityObjectStatusDetail) obj)._Organization) && (object.Equals((object) this._CompletionApprovalSheet, (object) ((QualityObjectStatusDetail) obj)._CompletionApprovalSheet) && object.Equals((object) this._QualityResolutionCode, (object) ((QualityObjectStatusDetail) obj)._QualityResolutionCode)) && (object.Equals((object) this._CmpltRoutingResolutionAction, (object) ((QualityObjectStatusDetail) obj)._CmpltRoutingResolutionAction) && object.Equals((object) this._RiskAssessment, (object) ((QualityObjectStatusDetail) obj)._RiskAssessment) && (object.Equals((object) this._CompletionRoutingInfo, (object) ((QualityObjectStatusDetail) obj)._CompletionRoutingInfo) && object.Equals((object) this._ProcessModelStage, (object) ((QualityObjectStatusDetail) obj)._ProcessModelStage))) && (object.Equals((object) this._CompletionApprovalStatus, (object) ((QualityObjectStatusDetail) obj)._CompletionApprovalStatus) && object.Equals((object) this._SubClassification, (object) ((QualityObjectStatusDetail) obj)._SubClassification) && (object.Equals((object) this._BriefDescription, (object) ((QualityObjectStatusDetail) obj)._BriefDescription) && object.Equals((object) this._Classification, (object) ((QualityObjectStatusDetail) obj)._Classification)) && (object.Equals((object) this._CARResolutionAction, (object) ((QualityObjectStatusDetail) obj)._CARResolutionAction) && object.Equals((object) this._ProcessModel, (object) ((QualityObjectStatusDetail) obj)._ProcessModel) && (object.Equals((object) this._CmpltRoutingResolutionCode, (object) ((QualityObjectStatusDetail) obj)._CmpltRoutingResolutionCode) && object.Equals((object) this._ChecklistAssigned, (object) ((QualityObjectStatusDetail) obj)._ChecklistAssigned))))) && (object.Equals((object) this._ChecklistSaved, (object) ((QualityObjectStatusDetail) obj)._ChecklistSaved) && object.Equals((object) this._IsCARRequiredToClose, (object) ((QualityObjectStatusDetail) obj)._IsCARRequiredToClose) && (object.Equals((object) this._OccurrenceDateGMT, (object) ((QualityObjectStatusDetail) obj)._OccurrenceDateGMT) && object.Equals((object) this._ClosureDateGMT, (object) ((QualityObjectStatusDetail) obj)._ClosureDateGMT)) && (object.Equals((object) this._ClosureDate, (object) ((QualityObjectStatusDetail) obj)._ClosureDate) && object.Equals((object) this._UserHasRole, (object) ((QualityObjectStatusDetail) obj)._UserHasRole) && (object.Equals((object) this._UserIsOwner, (object) ((QualityObjectStatusDetail) obj)._UserIsOwner) && object.Equals((object) this._IsApprovalRequired, (object) ((QualityObjectStatusDetail) obj)._IsApprovalRequired))) && (object.Equals((object) this._TriageComplete, (object) ((QualityObjectStatusDetail) obj)._TriageComplete) && object.Equals((object) this._ReportedDateGMT, (object) ((QualityObjectStatusDetail) obj)._ReportedDateGMT) && (object.Equals((object) this._Description, (object) ((QualityObjectStatusDetail) obj)._Description) && object.Equals((object) this._CloseDescription, (object) ((QualityObjectStatusDetail) obj)._CloseDescription)) && (object.Equals((object) this._DiscoveryArea, (object) ((QualityObjectStatusDetail) obj)._DiscoveryArea) && object.Equals((object) this._Reporter, (object) ((QualityObjectStatusDetail) obj)._Reporter) && (object.Equals((object) this._CmpltRoutingCloseDescription, (object) ((QualityObjectStatusDetail) obj)._CmpltRoutingCloseDescription) && object.Equals((object) this._ClosedBy, (object) ((QualityObjectStatusDetail) obj)._ClosedBy)))) && (object.Equals((object) this._Owner, (object) ((QualityObjectStatusDetail) obj)._Owner) && object.Equals((object) this._Initiator, (object) ((QualityObjectStatusDetail) obj)._Initiator))) && base.Equals(obj);
    }

    public DocAttachments Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments) this.PropertyGet(nameof (Attachments));
      }
    }

    public Enumeration<QualityStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<QualityStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public SubentityRef AttachmentsID
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsID), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (AttachmentsID));
      }
    }

    public NamedObjectRef[] CrossReferenceItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReferenceItems), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (CrossReferenceItems));
      }
    }

    public Primitive<string> StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusName));
      }
    }

    public Primitive<string> CARResolutionActionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionActionName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CARResolutionActionName));
      }
    }

    public Primitive<string> SubclassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubclassificationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubclassificationName));
      }
    }

    public Enumeration<CategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (Category));
      }
    }

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Primitive<string> CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Primitive<string> ProcessModelStageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessModelStageName));
      }
    }

    public Primitive<string> ClassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ClassificationName));
      }
    }

    public NamedObjectRef ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public NamedObjectRef InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public SubentityRef EntryForApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryForApproval), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EntryForApproval));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public NamedSubentityRef CompletionApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (CompletionApprovalSheet));
      }
    }

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Enumeration<ResolutionActionEnum, int> CmpltRoutingResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (CmpltRoutingResolutionAction));
      }
    }

    public RiskAssessment RiskAssessment
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessment), (object) value);
      }
      get
      {
        return (RiskAssessment) this.PropertyGet(nameof (RiskAssessment));
      }
    }

    public SubentityRef CompletionRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionRoutingInfo), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (CompletionRoutingInfo));
      }
    }

    public Enumeration<StageEnum, int> ProcessModelStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (ProcessModelStage));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> CompletionApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalStatus), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (CompletionApprovalStatus));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Primitive<string> BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public Enumeration<CARResolutionActionEnum, int> CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<CARResolutionActionEnum, int>) this.PropertyGet(nameof (CARResolutionAction));
      }
    }

    public NamedSubentityRef ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public NamedObjectRef CmpltRoutingResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CmpltRoutingResolutionCode));
      }
    }

    public Primitive<bool> ChecklistAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistAssigned), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ChecklistAssigned));
      }
    }

    public Primitive<bool> ChecklistSaved
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistSaved), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ChecklistSaved));
      }
    }

    public Primitive<bool> IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Primitive<DateTime> OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Primitive<DateTime> ClosureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ClosureDateGMT));
      }
    }

    public Primitive<DateTime> ClosureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ClosureDate));
      }
    }

    public Primitive<bool> UserHasRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserHasRole), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UserHasRole));
      }
    }

    public Primitive<bool> UserIsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserIsOwner), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UserIsOwner));
      }
    }

    public Primitive<bool> IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsApprovalRequired));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Primitive<DateTime> ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportedDateGMT));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }

    public Primitive<string> DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public NamedObjectRef Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Reporter));
      }
    }

    public Primitive<string> CmpltRoutingCloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingCloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CmpltRoutingCloseDescription));
      }
    }

    public NamedObjectRef ClosedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ClosedBy));
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

    public NamedObjectRef Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Initiator));
      }
    }
  }
}
