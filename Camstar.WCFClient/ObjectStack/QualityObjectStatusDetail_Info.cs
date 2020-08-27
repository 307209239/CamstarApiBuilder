// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectStatusDetail_Info
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
  public class QualityObjectStatusDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Attachments")]
    protected DocAttachments_Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_AttachmentsID")]
    protected Info _AttachmentsID;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CrossReferenceItems")]
    protected Info _CrossReferenceItems;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_StatusName")]
    protected Info _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CARResolutionActionName")]
    protected Info _CARResolutionActionName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_SubclassificationName")]
    protected Info _SubclassificationName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CategoryName")]
    protected Info _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ProcessModelStageName")]
    protected Info _ProcessModelStageName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ClassificationName")]
    protected Info _ClassificationName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ReporterOrganization")]
    protected Info _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_InitiatorOrganization")]
    protected Info _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_EntryForApproval")]
    protected Info _EntryForApproval;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CompletionApprovalSheet")]
    protected Info _CompletionApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_QualityResolutionCode")]
    protected Info _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CmpltRoutingResolutionAction")]
    protected Info _CmpltRoutingResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_RiskAssessment")]
    protected RiskAssessment_Info _RiskAssessment;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CompletionRoutingInfo")]
    protected Info _CompletionRoutingInfo;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ProcessModelStage")]
    protected Info _ProcessModelStage;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CompletionApprovalStatus")]
    protected Info _CompletionApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CARResolutionAction")]
    protected Info _CARResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ProcessModel")]
    protected Info _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CmpltRoutingResolutionCode")]
    protected Info _CmpltRoutingResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ChecklistAssigned")]
    protected Info _ChecklistAssigned;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ChecklistSaved")]
    protected Info _ChecklistSaved;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_IsCARRequiredToClose")]
    protected Info _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ClosureDateGMT")]
    protected Info _ClosureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ClosureDate")]
    protected Info _ClosureDate;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_UserHasRole")]
    protected Info _UserHasRole;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_UserIsOwner")]
    protected Info _UserIsOwner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_IsApprovalRequired")]
    protected Info _IsApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ReportedDateGMT")]
    protected Info _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CloseDescription")]
    protected Info _CloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_DiscoveryArea")]
    protected Info _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Reporter")]
    protected Info _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_CmpltRoutingCloseDescription")]
    protected Info _CmpltRoutingCloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_ClosedBy")]
    protected Info _ClosedBy;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Info_Initiator")]
    protected Info _Initiator;

    public DocAttachments_Info Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments_Info) this.PropertyGet(nameof (Attachments));
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

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info AttachmentsID
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentsID));
      }
    }

    public Info CrossReferenceItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReferenceItems), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CrossReferenceItems));
      }
    }

    public Info StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusName));
      }
    }

    public Info CARResolutionActionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionActionName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CARResolutionActionName));
      }
    }

    public Info SubclassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubclassificationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubclassificationName));
      }
    }

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
      }
    }

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Info CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Info ProcessModelStageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModelStageName));
      }
    }

    public Info ClassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClassificationName));
      }
    }

    public Info ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public Info InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public Info EntryForApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryForApproval), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryForApproval));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info CompletionApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionApprovalSheet));
      }
    }

    public Info QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Info CmpltRoutingResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CmpltRoutingResolutionAction));
      }
    }

    public RiskAssessment_Info RiskAssessment
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessment), (object) value);
      }
      get
      {
        return (RiskAssessment_Info) this.PropertyGet(nameof (RiskAssessment));
      }
    }

    public Info CompletionRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionRoutingInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionRoutingInfo));
      }
    }

    public Info ProcessModelStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModelStage));
      }
    }

    public Info CompletionApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionApprovalStatus));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Info BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CARResolutionAction));
      }
    }

    public Info ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public Info CmpltRoutingResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CmpltRoutingResolutionCode));
      }
    }

    public Info ChecklistAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistAssigned), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistAssigned));
      }
    }

    public Info ChecklistSaved
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistSaved), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistSaved));
      }
    }

    public Info IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Info OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Info ClosureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClosureDateGMT));
      }
    }

    public Info ClosureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClosureDate));
      }
    }

    public Info UserHasRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserHasRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserHasRole));
      }
    }

    public Info UserIsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserIsOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserIsOwner));
      }
    }

    public Info IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsApprovalRequired));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportedDateGMT));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseDescription));
      }
    }

    public Info DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Info Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Reporter));
      }
    }

    public Info CmpltRoutingCloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingCloseDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CmpltRoutingCloseDescription));
      }
    }

    public Info ClosedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClosedBy));
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

    public Info Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Initiator));
      }
    }
  }
}
