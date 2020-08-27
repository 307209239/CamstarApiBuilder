// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceData_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResourceStatusDetails_Info))]
  [KnownType(typeof (ApprovalCycleInquiryDetails_Info))]
  [KnownType(typeof (GetMaintenanceStatusDetails_Info))]
  [KnownType(typeof (ContainerStatusDetails_Info))]
  [KnownType(typeof (BatchInquiryDetail_Info))]
  [KnownType(typeof (ObjectAlternateKey_Info))]
  [KnownType(typeof (V4_AuditTrailSecPermission_Info))]
  [KnownType(typeof (ObjectField_Info))]
  [KnownType(typeof (SubentityInstance_Info))]
  [KnownType(typeof (CDOInstanceInfo_Info))]
  [KnownType(typeof (CDOField_Info))]
  [KnownType(typeof (ChangePackageInquiryDetail_Info))]
  [KnownType(typeof (ServiceDetails_Info))]
  [KnownType(typeof (ChangePackageHeader_Info))]
  [KnownType(typeof (DelegationTaskInquiryDetail_Info))]
  [KnownType(typeof (ExportImportStatus_Info))]
  [KnownType(typeof (ExportImportLogDetail_Info))]
  [KnownType(typeof (AttachedDocuments_Info))]
  [KnownType(typeof (ChangePackageDetails_Info))]
  [KnownType(typeof (ProcessListDetail_Info))]
  [KnownType(typeof (AuditTrailTrivialFieldValue_Info))]
  [KnownType(typeof (ToDoListDetail_Info))]
  [KnownType(typeof (ProcessTimerInquiryDetail_Info))]
  [KnownType(typeof (QualityObjectStatusDetail_Info))]
  [KnownType(typeof (SystemInfoDetail_Info))]
  [KnownType(typeof (WorkspaceDetail_Info))]
  [KnownType(typeof (RecipeExpressionFields_Info))]
  [KnownType(typeof (ProcessSequenceValidation_Info))]
  [KnownType(typeof (MfgDataDetail_Info))]
  [KnownType(typeof (CurrentStatusStartDetails_Info))]
  [KnownType(typeof (ReworkStatusStartDetails_Info))]
  [KnownType(typeof (TrackObjCurrentStatusStartDtls_Info))]
  [KnownType(typeof (V4_PermissionEntry_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ActionsMenuInquiryDetails_Info))]
  [KnownType(typeof (AuditTrailField_Info))]
  [KnownType(typeof (AuditTrailSubentityInfo_Info))]
  [Serializable]
  public class ServiceData_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;

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
  }
}
