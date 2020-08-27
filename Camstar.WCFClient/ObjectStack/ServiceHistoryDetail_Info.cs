// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistoryDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (QualityCustomHistoryDetail_Info))]
  [KnownType(typeof (IssueActualsHistory_Info))]
  [KnownType(typeof (SPCChartHistoryDetail_Info))]
  [KnownType(typeof (WIPMsgHistoryDetail_Info))]
  [KnownType(typeof (ChangeAttributeHistoryDetails_Info))]
  [KnownType(typeof (EventLotHistoryDetail_Info))]
  [KnownType(typeof (ChgAttributeHistoryObject_Info))]
  [KnownType(typeof (SuspectDeviceHistoryDetail_Info))]
  [KnownType(typeof (RemovalHistoryDetail_Info))]
  [KnownType(typeof (DocAttachmentsHistoryDetails_Info))]
  [KnownType(typeof (ChecklistEntryHistoryDetail_Info))]
  [KnownType(typeof (NCRDefectHistoryDetails_Info))]
  [KnownType(typeof (ChgContainerAttrHistDetail_Info))]
  [KnownType(typeof (NCRUpdateHistoryDetail_Info))]
  [KnownType(typeof (SplitHistoryDetails_Info))]
  [KnownType(typeof (CollectSamplingHistoryDetails_Info))]
  [KnownType(typeof (DPCollectionSampleHistory_Info))]
  [KnownType(typeof (ESigHistoryDetail_Info))]
  [KnownType(typeof (CollectSamplingTestDtlHistory_Info))]
  [KnownType(typeof (EventLogHistoryDetail_Info))]
  [KnownType(typeof (CombineHistoryDetail_Info))]
  [KnownType(typeof (DPCollectionGroupHistory_Info))]
  [KnownType(typeof (CompleteMaintHistoryDetails_Info))]
  [KnownType(typeof (DefectHistoryDetail_Info))]
  [KnownType(typeof (ComponentReplaceHistoryDetail_Info))]
  [KnownType(typeof (EventFailureActionHistoryDtl_Info))]
  [KnownType(typeof (ComputationParamHistory_Info))]
  [KnownType(typeof (ThruputHistoryDetail_Info))]
  [KnownType(typeof (EventDataHistoryDetail_Info))]
  [KnownType(typeof (ContainerAttrHistoryDetail_Info))]
  [KnownType(typeof (EventCheckBoxFieldHistDetail_Info))]
  [KnownType(typeof (EventDispositionHistoryDetail_Info))]
  [KnownType(typeof (SPCViolationHistoryDetail_Info))]
  [KnownType(typeof (EventComponentHistoryDetail_Info))]
  [KnownType(typeof (CPModelingInstanceHistDtl_Info))]
  [KnownType(typeof (DispositionHistoryDetail_Info))]
  [KnownType(typeof (RegulatoryReportHistoryDetail_Info))]
  [KnownType(typeof (ProcessTimerHistoryDetail_Info))]
  [KnownType(typeof (IssueHistoryDetail_Info))]
  [KnownType(typeof (CPTargetSystemHistDtl_Info))]
  [KnownType(typeof (ExecuteChecklistHistoryDtl_Info))]
  [KnownType(typeof (DecisionTreeHistoryDetail_Info))]
  [KnownType(typeof (ExecuteChklstResponseHistDtl_Info))]
  [KnownType(typeof (DPCollectionPointHistory_Info))]
  [KnownType(typeof (QtyHistoryDetails_Info))]
  [KnownType(typeof (CustomerHistoryDetail_Info))]
  [KnownType(typeof (FailureCauseDataHistoryDetails_Info))]
  [KnownType(typeof (NCRCommentsHistory_Info))]
  [KnownType(typeof (QualityCrossRefHistory_Info))]
  [KnownType(typeof (StartContAttrHistoryDetail_Info))]
  [KnownType(typeof (EventHistoryDetail_Info))]
  [KnownType(typeof (FailurePlanDataHistoryDetails_Info))]
  [KnownType(typeof (CAPAHistoryDetail_Info))]
  [KnownType(typeof (FailureDataHistoryDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EventFailureHistoryDetail_Info))]
  [KnownType(typeof (HoldReleaseHistoryDetail_Info))]
  [KnownType(typeof (ReorderProcessObjectHistDetail_Info))]
  [KnownType(typeof (LabelHistoryDetail_Info))]
  [KnownType(typeof (EventFailureCauseHistoryDetail_Info))]
  [KnownType(typeof (SerializeHistoryDetails_Info))]
  [Serializable]
  public class ServiceHistoryDetail_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;

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
