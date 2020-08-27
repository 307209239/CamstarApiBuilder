// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistoryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (IssueHistoryDetail_Environment))]
  [KnownType(typeof (EventFailureCauseHistoryDetail_Environment))]
  [KnownType(typeof (CombineHistoryDetail_Environment))]
  [KnownType(typeof (DispositionHistoryDetail_Environment))]
  [KnownType(typeof (DecisionTreeHistoryDetail_Environment))]
  [KnownType(typeof (CompleteMaintHistoryDetails_Environment))]
  [KnownType(typeof (DPCollectionPointHistory_Environment))]
  [KnownType(typeof (SPCChartHistoryDetail_Environment))]
  [KnownType(typeof (ComponentReplaceHistoryDetail_Environment))]
  [KnownType(typeof (EventHistoryDetail_Environment))]
  [KnownType(typeof (ReorderProcessObjectHistDetail_Environment))]
  [KnownType(typeof (ComputationParamHistory_Environment))]
  [KnownType(typeof (EventLotHistoryDetail_Environment))]
  [KnownType(typeof (DPCollectionSampleHistory_Environment))]
  [KnownType(typeof (SuspectDeviceHistoryDetail_Environment))]
  [KnownType(typeof (ProcessTimerHistoryDetail_Environment))]
  [KnownType(typeof (CAPAHistoryDetail_Environment))]
  [KnownType(typeof (EventCheckBoxFieldHistDetail_Environment))]
  [KnownType(typeof (ContainerAttrHistoryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SPCViolationHistoryDetail_Environment))]
  [KnownType(typeof (DocAttachmentsHistoryDetails_Environment))]
  [KnownType(typeof (NCRDefectHistoryDetails_Environment))]
  [KnownType(typeof (ESigHistoryDetail_Environment))]
  [KnownType(typeof (QualityCustomHistoryDetail_Environment))]
  [KnownType(typeof (CPModelingInstanceHistDtl_Environment))]
  [KnownType(typeof (RegulatoryReportHistoryDetail_Environment))]
  [KnownType(typeof (IssueActualsHistory_Environment))]
  [KnownType(typeof (DefectHistoryDetail_Environment))]
  [KnownType(typeof (ThruputHistoryDetail_Environment))]
  [KnownType(typeof (QualityCrossRefHistory_Environment))]
  [KnownType(typeof (ExecuteChecklistHistoryDtl_Environment))]
  [KnownType(typeof (CPTargetSystemHistDtl_Environment))]
  [KnownType(typeof (ChangeAttributeHistoryDetails_Environment))]
  [KnownType(typeof (WIPMsgHistoryDetail_Environment))]
  [KnownType(typeof (EventDataHistoryDetail_Environment))]
  [KnownType(typeof (ExecuteChklstResponseHistDtl_Environment))]
  [KnownType(typeof (EventLogHistoryDetail_Environment))]
  [KnownType(typeof (ChgAttributeHistoryObject_Environment))]
  [KnownType(typeof (SerializeHistoryDetails_Environment))]
  [KnownType(typeof (SplitHistoryDetails_Environment))]
  [KnownType(typeof (RemovalHistoryDetail_Environment))]
  [KnownType(typeof (FailureCauseDataHistoryDetails_Environment))]
  [KnownType(typeof (DPCollectionGroupHistory_Environment))]
  [KnownType(typeof (EventFailureActionHistoryDtl_Environment))]
  [KnownType(typeof (ChecklistEntryHistoryDetail_Environment))]
  [KnownType(typeof (QtyHistoryDetails_Environment))]
  [KnownType(typeof (FailurePlanDataHistoryDetails_Environment))]
  [KnownType(typeof (CustomerHistoryDetail_Environment))]
  [KnownType(typeof (NCRCommentsHistory_Environment))]
  [KnownType(typeof (LabelHistoryDetail_Environment))]
  [KnownType(typeof (FailureDataHistoryDetails_Environment))]
  [KnownType(typeof (ChgContainerAttrHistDetail_Environment))]
  [KnownType(typeof (EventComponentHistoryDetail_Environment))]
  [KnownType(typeof (EventDispositionHistoryDetail_Environment))]
  [KnownType(typeof (CollectSamplingHistoryDetails_Environment))]
  [KnownType(typeof (HoldReleaseHistoryDetail_Environment))]
  [KnownType(typeof (NCRUpdateHistoryDetail_Environment))]
  [KnownType(typeof (EventFailureHistoryDetail_Environment))]
  [KnownType(typeof (StartContAttrHistoryDetail_Environment))]
  [KnownType(typeof (CollectSamplingTestDtlHistory_Environment))]
  [Serializable]
  public class ServiceHistoryDetail_Environment : HistoryDetails_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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
