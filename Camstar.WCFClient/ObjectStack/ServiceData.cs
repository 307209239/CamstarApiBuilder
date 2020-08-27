// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ServiceData
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (GetMaintenanceStatusDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MfgDataDetail))]
  [KnownType(typeof (V4_AuditTrailSecPermission))]
  [KnownType(typeof (ContainerStatusDetails))]
  [KnownType(typeof (BatchInquiryDetail))]
  [KnownType(typeof (ObjectAlternateKey))]
  [KnownType(typeof (ObjectField))]
  [KnownType(typeof (SubentityInstance))]
  [KnownType(typeof (CDOInstanceInfo))]
  [KnownType(typeof (CDOField))]
  [KnownType(typeof (ChangePackageInquiryDetail))]
  [KnownType(typeof (ServiceDetails))]
  [KnownType(typeof (ChangePackageHeader))]
  [KnownType(typeof (DelegationTaskInquiryDetail))]
  [KnownType(typeof (ExportImportStatus))]
  [KnownType(typeof (ExportImportLogDetail))]
  [KnownType(typeof (AttachedDocuments))]
  [KnownType(typeof (ChangePackageDetails))]
  [KnownType(typeof (CurrentStatusStartDetails))]
  [KnownType(typeof (AuditTrailTrivialFieldValue))]
  [KnownType(typeof (ProcessTimerInquiryDetail))]
  [KnownType(typeof (QualityObjectStatusDetail))]
  [KnownType(typeof (SystemInfoDetail))]
  [KnownType(typeof (WorkspaceDetail))]
  [KnownType(typeof (RecipeExpressionFields))]
  [KnownType(typeof (ProcessSequenceValidation))]
  [KnownType(typeof (ProcessListDetail))]
  [KnownType(typeof (ToDoListDetail))]
  [KnownType(typeof (ReworkStatusStartDetails))]
  [KnownType(typeof (TrackObjCurrentStatusStartDtls))]
  [KnownType(typeof (ResourceStatusDetails))]
  [KnownType(typeof (V4_PermissionEntry))]
  [KnownType(typeof (ActionsMenuInquiryDetails))]
  [KnownType(typeof (ApprovalCycleInquiryDetails))]
  [KnownType(typeof (AuditTrailField))]
  [KnownType(typeof (AuditTrailSubentityInfo))]
  [Serializable]
  public class ServiceData : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;

    public override bool Equals(object obj)
    {
      return obj is ServiceData && object.Equals((object) this._ExportImportKey, (object) ((ServiceData) obj)._ExportImportKey) && base.Equals(obj);
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
  }
}
