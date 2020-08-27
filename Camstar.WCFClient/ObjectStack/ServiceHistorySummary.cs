// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistorySummary
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProcessTimerHistory))]
  [KnownType(typeof (ResourceStatusHistory))]
  [KnownType(typeof (SerializeHistory))]
  [KnownType(typeof (SplitHistory))]
  [KnownType(typeof (TrackableObjectHistory))]
  [KnownType(typeof (TrackableObjectMovementHistory))]
  [KnownType(typeof (TrackTargetDeploymentHistory))]
  [KnownType(typeof (TriageQualityObjectHistory))]
  [KnownType(typeof (UpdateCAPAHistory))]
  [KnownType(typeof (UpdateEventDetailsHistory))]
  [KnownType(typeof (UpdateEventHistory))]
  [KnownType(typeof (UpdateSamplingLotHistory))]
  [KnownType(typeof (ComputationHistory))]
  [KnownType(typeof (AddSPCAnnotationHistory))]
  [KnownType(typeof (ApprovalSheetHistory))]
  [KnownType(typeof (SignApprovalHistory))]
  [KnownType(typeof (AssignChecklistHistory))]
  [KnownType(typeof (AssignChecklistToEventHistory))]
  [KnownType(typeof (AssociateHistory))]
  [KnownType(typeof (AttachDocumentHistory))]
  [KnownType(typeof (ChangeAttributeHistory))]
  [KnownType(typeof (ChangeCategoryHistory))]
  [KnownType(typeof (ChangeOwnerHistory))]
  [KnownType(typeof (ChangeProcessHistory))]
  [KnownType(typeof (ReprintLabelHistory))]
  [KnownType(typeof (CloseQualityObjectHistory))]
  [KnownType(typeof (CollectDataHistory))]
  [KnownType(typeof (CollectDataPointsHistory))]
  [KnownType(typeof (CollectSamplingDataHistory))]
  [KnownType(typeof (CombineHistory))]
  [KnownType(typeof (CompleteMaintenanceHistory))]
  [KnownType(typeof (CompleteRiskAssessmentHistory))]
  [KnownType(typeof (ComponentDistributeHistory))]
  [KnownType(typeof (ResourceThruputHistory))]
  [KnownType(typeof (ComponentIssueHistory))]
  [KnownType(typeof (ComponentRemoveHistory))]
  [KnownType(typeof (ComponentReplaceHistory))]
  [KnownType(typeof (ContainerAttrMaintHistory))]
  [KnownType(typeof (ContainerStatusChangeHistory))]
  [KnownType(typeof (CreateCAPAHistory))]
  [KnownType(typeof (CreateEventHistory))]
  [KnownType(typeof (CreateSamplingLotHistory))]
  [KnownType(typeof (DefectHistory))]
  [KnownType(typeof (DelegateTaskHistory))]
  [KnownType(typeof (ChgContainerAttrHistory))]
  [KnownType(typeof (DisassociateHistory))]
  [KnownType(typeof (DocAttachmentsHistory))]
  [KnownType(typeof (ESigHistorySummary))]
  [KnownType(typeof (ExecuteChecklistHistory))]
  [KnownType(typeof (ExecuteTaskHistory))]
  [KnownType(typeof (HoldReleaseHistory))]
  [KnownType(typeof (LabelHistorySummary))]
  [KnownType(typeof (MovementHistory))]
  [KnownType(typeof (NCRCreateHistory))]
  [KnownType(typeof (NCREscalateHistory))]
  [KnownType(typeof (NCRUpdateHistory))]
  [KnownType(typeof (OpenQualityObjectHistory))]
  [KnownType(typeof (PrintLabelHistory))]
  [KnownType(typeof (ProcessObjectTxnHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (QtyHistory))]
  [KnownType(typeof (RecordDecisionTreeHistory))]
  [KnownType(typeof (RecordSPCViolationHistory))]
  [Serializable]
  public class ServiceHistorySummary : Camstar.WCF.ObjectStack.HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_HistoryDetails")]
    protected ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistorySummary_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ServiceHistorySummary && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ServiceHistorySummary) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ServiceHistorySummary) obj)._ExportImportKey) && object.Equals((object) this._DisplayName, (object) ((ServiceHistorySummary) obj)._DisplayName)) && object.Equals((object) this._HistoryId, (object) ((ServiceHistorySummary) obj)._HistoryId) && base.Equals(obj);
    }

    public ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Primitive<string> DisplayName
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

    public new BaseObjectRef HistoryId
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
  }
}
