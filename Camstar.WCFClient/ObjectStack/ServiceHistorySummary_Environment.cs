// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistorySummary_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MovementHistory_Environment))]
  [KnownType(typeof (UpdateCAPAHistory_Environment))]
  [KnownType(typeof (DelegateTaskHistory_Environment))]
  [KnownType(typeof (UpdateSamplingLotHistory_Environment))]
  [KnownType(typeof (AddSPCAnnotationHistory_Environment))]
  [KnownType(typeof (ApprovalSheetHistory_Environment))]
  [KnownType(typeof (SignApprovalHistory_Environment))]
  [KnownType(typeof (AssignChecklistHistory_Environment))]
  [KnownType(typeof (AssignChecklistToEventHistory_Environment))]
  [KnownType(typeof (AssociateHistory_Environment))]
  [KnownType(typeof (AttachDocumentHistory_Environment))]
  [KnownType(typeof (ChangeAttributeHistory_Environment))]
  [KnownType(typeof (ChangeCategoryHistory_Environment))]
  [KnownType(typeof (ChangeOwnerHistory_Environment))]
  [KnownType(typeof (ChangeProcessHistory_Environment))]
  [KnownType(typeof (ChgContainerAttrHistory_Environment))]
  [KnownType(typeof (CloseQualityObjectHistory_Environment))]
  [KnownType(typeof (CollectDataHistory_Environment))]
  [KnownType(typeof (CollectDataPointsHistory_Environment))]
  [KnownType(typeof (CollectSamplingDataHistory_Environment))]
  [KnownType(typeof (CombineHistory_Environment))]
  [KnownType(typeof (CompleteMaintenanceHistory_Environment))]
  [KnownType(typeof (CompleteRiskAssessmentHistory_Environment))]
  [KnownType(typeof (ComponentDistributeHistory_Environment))]
  [KnownType(typeof (ComponentIssueHistory_Environment))]
  [KnownType(typeof (ComponentRemoveHistory_Environment))]
  [KnownType(typeof (ComponentReplaceHistory_Environment))]
  [KnownType(typeof (ContainerAttrMaintHistory_Environment))]
  [KnownType(typeof (ContainerStatusChangeHistory_Environment))]
  [KnownType(typeof (CreateCAPAHistory_Environment))]
  [KnownType(typeof (CreateEventHistory_Environment))]
  [KnownType(typeof (CreateSamplingLotHistory_Environment))]
  [KnownType(typeof (DefectHistory_Environment))]
  [KnownType(typeof (ComputationHistory_Environment))]
  [KnownType(typeof (DisassociateHistory_Environment))]
  [KnownType(typeof (DocAttachmentsHistory_Environment))]
  [KnownType(typeof (ESigHistorySummary_Environment))]
  [KnownType(typeof (ExecuteChecklistHistory_Environment))]
  [KnownType(typeof (ExecuteTaskHistory_Environment))]
  [KnownType(typeof (HoldReleaseHistory_Environment))]
  [KnownType(typeof (LabelHistorySummary_Environment))]
  [KnownType(typeof (NCRCreateHistory_Environment))]
  [KnownType(typeof (NCREscalateHistory_Environment))]
  [KnownType(typeof (NCRUpdateHistory_Environment))]
  [KnownType(typeof (OpenQualityObjectHistory_Environment))]
  [KnownType(typeof (PrintLabelHistory_Environment))]
  [KnownType(typeof (ProcessObjectTxnHistory_Environment))]
  [KnownType(typeof (ProcessTimerHistory_Environment))]
  [KnownType(typeof (QtyHistory_Environment))]
  [KnownType(typeof (RecordDecisionTreeHistory_Environment))]
  [KnownType(typeof (RecordSPCViolationHistory_Environment))]
  [KnownType(typeof (ReprintLabelHistory_Environment))]
  [KnownType(typeof (ResourceStatusHistory_Environment))]
  [KnownType(typeof (ResourceThruputHistory_Environment))]
  [KnownType(typeof (SerializeHistory_Environment))]
  [KnownType(typeof (SplitHistory_Environment))]
  [KnownType(typeof (TrackableObjectHistory_Environment))]
  [KnownType(typeof (TrackableObjectMovementHistory_Environment))]
  [KnownType(typeof (TrackTargetDeploymentHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (TriageQualityObjectHistory_Environment))]
  [KnownType(typeof (UpdateEventDetailsHistory_Environment))]
  [KnownType(typeof (UpdateEventHistory_Environment))]
  [Serializable]
  public class ServiceHistorySummary_Environment : HistoryDetails_Environment
  {
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Environment_HistoryDetails")]
    protected ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

    public ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
