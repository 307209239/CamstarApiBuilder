// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistorySummary_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ComponentDistributeHistory_Info))]
  [KnownType(typeof (ResourceThruputHistory_Info))]
  [KnownType(typeof (ComponentIssueHistory_Info))]
  [KnownType(typeof (AssignChecklistToEventHistory_Info))]
  [KnownType(typeof (ComponentRemoveHistory_Info))]
  [KnownType(typeof (UpdateEventDetailsHistory_Info))]
  [KnownType(typeof (ComponentReplaceHistory_Info))]
  [KnownType(typeof (AssociateHistory_Info))]
  [KnownType(typeof (ContainerAttrMaintHistory_Info))]
  [KnownType(typeof (TrackableObjectMovementHistory_Info))]
  [KnownType(typeof (ContainerStatusChangeHistory_Info))]
  [KnownType(typeof (AttachDocumentHistory_Info))]
  [KnownType(typeof (CreateCAPAHistory_Info))]
  [KnownType(typeof (UpdateEventHistory_Info))]
  [KnownType(typeof (CreateEventHistory_Info))]
  [KnownType(typeof (ChangeAttributeHistory_Info))]
  [KnownType(typeof (CreateSamplingLotHistory_Info))]
  [KnownType(typeof (SplitHistory_Info))]
  [KnownType(typeof (DefectHistory_Info))]
  [KnownType(typeof (ChangeCategoryHistory_Info))]
  [KnownType(typeof (DelegateTaskHistory_Info))]
  [KnownType(typeof (UpdateSamplingLotHistory_Info))]
  [KnownType(typeof (ChangeOwnerHistory_Info))]
  [KnownType(typeof (TrackTargetDeploymentHistory_Info))]
  [KnownType(typeof (DisassociateHistory_Info))]
  [KnownType(typeof (NCREscalateHistory_Info))]
  [KnownType(typeof (TriageQualityObjectHistory_Info))]
  [KnownType(typeof (ResourceStatusHistory_Info))]
  [KnownType(typeof (DocAttachmentsHistory_Info))]
  [KnownType(typeof (ComputationHistory_Info))]
  [KnownType(typeof (ESigHistorySummary_Info))]
  [KnownType(typeof (ChgContainerAttrHistory_Info))]
  [KnownType(typeof (ExecuteChecklistHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ExecuteTaskHistory_Info))]
  [KnownType(typeof (CloseQualityObjectHistory_Info))]
  [KnownType(typeof (HoldReleaseHistory_Info))]
  [KnownType(typeof (SerializeHistory_Info))]
  [KnownType(typeof (LabelHistorySummary_Info))]
  [KnownType(typeof (CollectDataHistory_Info))]
  [KnownType(typeof (MovementHistory_Info))]
  [KnownType(typeof (AddSPCAnnotationHistory_Info))]
  [KnownType(typeof (NCRCreateHistory_Info))]
  [KnownType(typeof (CollectDataPointsHistory_Info))]
  [KnownType(typeof (ChangeProcessHistory_Info))]
  [KnownType(typeof (NCRUpdateHistory_Info))]
  [KnownType(typeof (CollectSamplingDataHistory_Info))]
  [KnownType(typeof (OpenQualityObjectHistory_Info))]
  [KnownType(typeof (ApprovalSheetHistory_Info))]
  [KnownType(typeof (PrintLabelHistory_Info))]
  [KnownType(typeof (CombineHistory_Info))]
  [KnownType(typeof (ProcessObjectTxnHistory_Info))]
  [KnownType(typeof (TrackableObjectHistory_Info))]
  [KnownType(typeof (ProcessTimerHistory_Info))]
  [KnownType(typeof (CompleteMaintenanceHistory_Info))]
  [KnownType(typeof (QtyHistory_Info))]
  [KnownType(typeof (SignApprovalHistory_Info))]
  [KnownType(typeof (RecordDecisionTreeHistory_Info))]
  [KnownType(typeof (CompleteRiskAssessmentHistory_Info))]
  [KnownType(typeof (RecordSPCViolationHistory_Info))]
  [KnownType(typeof (UpdateCAPAHistory_Info))]
  [KnownType(typeof (ReprintLabelHistory_Info))]
  [KnownType(typeof (AssignChecklistHistory_Info))]
  [Serializable]
  public class ServiceHistorySummary_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Info_HistoryDetails")]
    protected ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Info_HistoryId")]
    protected new Info _HistoryId;

    public ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info DisplayName
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

    public new Info HistoryId
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
  }
}
