// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceHistoryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueHistoryDetail))]
  [KnownType(typeof (SPCViolationHistoryDetail))]
  [KnownType(typeof (SplitHistoryDetails))]
  [KnownType(typeof (StartContAttrHistoryDetail))]
  [KnownType(typeof (SuspectDeviceHistoryDetail))]
  [KnownType(typeof (ThruputHistoryDetail))]
  [KnownType(typeof (DecisionTreeHistoryDetail))]
  [KnownType(typeof (LabelHistoryDetail))]
  [KnownType(typeof (WIPMsgHistoryDetail))]
  [KnownType(typeof (ESigHistoryDetail))]
  [KnownType(typeof (DefectHistoryDetail))]
  [KnownType(typeof (EventDataHistoryDetail))]
  [KnownType(typeof (DispositionHistoryDetail))]
  [KnownType(typeof (NCRCommentsHistory))]
  [KnownType(typeof (EventFailureHistoryDetail))]
  [KnownType(typeof (EventFailureCauseHistoryDetail))]
  [KnownType(typeof (EventLotHistoryDetail))]
  [KnownType(typeof (DocAttachmentsHistoryDetails))]
  [KnownType(typeof (NCRDefectHistoryDetails))]
  [KnownType(typeof (EventLogHistoryDetail))]
  [KnownType(typeof (DPCollectionGroupHistory))]
  [KnownType(typeof (EventFailureActionHistoryDtl))]
  [KnownType(typeof (DPCollectionPointHistory))]
  [KnownType(typeof (EventDispositionHistoryDetail))]
  [KnownType(typeof (ProcessTimerHistoryDetail))]
  [KnownType(typeof (EventHistoryDetail))]
  [KnownType(typeof (QtyHistoryDetails))]
  [KnownType(typeof (QualityCrossRefHistory))]
  [KnownType(typeof (CAPAHistoryDetail))]
  [KnownType(typeof (QualityCustomHistoryDetail))]
  [KnownType(typeof (IssueActualsHistory))]
  [KnownType(typeof (SPCChartHistoryDetail))]
  [KnownType(typeof (NCRUpdateHistoryDetail))]
  [KnownType(typeof (ChangeAttributeHistoryDetails))]
  [KnownType(typeof (ChgAttributeHistoryObject))]
  [KnownType(typeof (RemovalHistoryDetail))]
  [KnownType(typeof (ChecklistEntryHistoryDetail))]
  [KnownType(typeof (ChgContainerAttrHistDetail))]
  [KnownType(typeof (DPCollectionSampleHistory))]
  [KnownType(typeof (CollectSamplingHistoryDetails))]
  [KnownType(typeof (CollectSamplingTestDtlHistory))]
  [KnownType(typeof (CombineHistoryDetail))]
  [KnownType(typeof (CompleteMaintHistoryDetails))]
  [KnownType(typeof (ComponentReplaceHistoryDetail))]
  [KnownType(typeof (ComputationParamHistory))]
  [KnownType(typeof (ContainerAttrHistoryDetail))]
  [KnownType(typeof (EventCheckBoxFieldHistDetail))]
  [KnownType(typeof (CPModelingInstanceHistDtl))]
  [KnownType(typeof (EventComponentHistoryDetail))]
  [KnownType(typeof (SerializeHistoryDetails))]
  [KnownType(typeof (ExecuteChecklistHistoryDtl))]
  [KnownType(typeof (CPTargetSystemHistDtl))]
  [KnownType(typeof (ExecuteChklstResponseHistDtl))]
  [KnownType(typeof (CustomerHistoryDetail))]
  [KnownType(typeof (FailureCauseDataHistoryDetails))]
  [KnownType(typeof (RegulatoryReportHistoryDetail))]
  [KnownType(typeof (FailurePlanDataHistoryDetails))]
  [KnownType(typeof (FailureDataHistoryDetails))]
  [KnownType(typeof (HoldReleaseHistoryDetail))]
  [KnownType(typeof (ReorderProcessObjectHistDetail))]
  [Serializable]
  public class ServiceHistoryDetail : HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ServiceHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ServiceHistoryDetail && object.Equals((object) this._DisplayName, (object) ((ServiceHistoryDetail) obj)._DisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((ServiceHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((ServiceHistoryDetail) obj)._HistoryId)) && base.Equals(obj);
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
