// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceData_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ProcessSequenceValidation_Environment))]
  [KnownType(typeof (ObjectAlternateKey_Environment))]
  [KnownType(typeof (TrackObjCurrentStatusStartDtls_Environment))]
  [KnownType(typeof (ServiceDetails_Environment))]
  [KnownType(typeof (ProcessTimerInquiryDetail_Environment))]
  [KnownType(typeof (SubentityInstance_Environment))]
  [KnownType(typeof (QualityObjectStatusDetail_Environment))]
  [KnownType(typeof (ChangePackageHeader_Environment))]
  [KnownType(typeof (SystemInfoDetail_Environment))]
  [KnownType(typeof (V4_AuditTrailSecPermission_Environment))]
  [KnownType(typeof (WorkspaceDetail_Environment))]
  [KnownType(typeof (DelegationTaskInquiryDetail_Environment))]
  [KnownType(typeof (RecipeExpressionFields_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MfgDataDetail_Environment))]
  [KnownType(typeof (ProcessListDetail_Environment))]
  [KnownType(typeof (CDOInstanceInfo_Environment))]
  [KnownType(typeof (CurrentStatusStartDetails_Environment))]
  [KnownType(typeof (ExportImportLogDetail_Environment))]
  [KnownType(typeof (ReworkStatusStartDetails_Environment))]
  [KnownType(typeof (ContainerStatusDetails_Environment))]
  [KnownType(typeof (ResourceStatusDetails_Environment))]
  [KnownType(typeof (AttachedDocuments_Environment))]
  [KnownType(typeof (V4_PermissionEntry_Environment))]
  [KnownType(typeof (CDOField_Environment))]
  [KnownType(typeof (ExportImportStatus_Environment))]
  [KnownType(typeof (BatchInquiryDetail_Environment))]
  [KnownType(typeof (ChangePackageDetails_Environment))]
  [KnownType(typeof (ActionsMenuInquiryDetails_Environment))]
  [KnownType(typeof (ToDoListDetail_Environment))]
  [KnownType(typeof (ApprovalCycleInquiryDetails_Environment))]
  [KnownType(typeof (ObjectField_Environment))]
  [KnownType(typeof (AuditTrailField_Environment))]
  [KnownType(typeof (GetMaintenanceStatusDetails_Environment))]
  [KnownType(typeof (AuditTrailSubentityInfo_Environment))]
  [KnownType(typeof (ChangePackageInquiryDetail_Environment))]
  [KnownType(typeof (AuditTrailTrivialFieldValue_Environment))]
  [Serializable]
  public class ServiceData_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16777762, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ServiceData_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;

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
  }
}
