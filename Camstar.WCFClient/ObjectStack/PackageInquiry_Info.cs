// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageInquiry_Info
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
  public class PackageInquiry_Info : ChangePackageInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageStatuses")]
    protected Info _PackageStatuses;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageWorkflow")]
    protected Info _PackageWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageSteps")]
    protected Info _PackageSteps;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_TargetSystem")]
    protected Info _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageDetails")]
    protected PackageInquiryDetail_Info _PackageDetails;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackagePriorityCode")]
    protected Info _PackagePriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_IsApprover")]
    protected Info _IsApprover;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_IsCollaborator")]
    protected Info _IsCollaborator;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_IsOwner")]
    protected Info _IsOwner;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_HasApproverRole")]
    protected Info _HasApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_HasOwnerRole")]
    protected Info _HasOwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_SelectedObjectType")]
    protected Info _SelectedObjectType;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_IsApprovalCompleted")]
    protected Info _IsApprovalCompleted;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_IsCollaborationCompleted")]
    protected Info _IsCollaborationCompleted;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_SelectedInstance")]
    protected Info _SelectedInstance;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_HasCollaboratorRole")]
    protected Info _HasCollaboratorRole;
    [DataMember(EmitDefaultValue = false, Name = "PackageInquiry_Info_PackageOwner")]
    protected new Info _PackageOwner;

    public Info OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Info PackageStatuses
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageStatuses), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageStatuses));
      }
    }

    public Info PackageWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageWorkflow));
      }
    }

    public Info PackageSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageSteps), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageSteps));
      }
    }

    public Info TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public PackageInquiryDetail_Info PackageDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageDetails), (object) value);
      }
      get
      {
        return (PackageInquiryDetail_Info) this.PropertyGet(nameof (PackageDetails));
      }
    }

    public Info PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageType));
      }
    }

    public Info PackagePriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackagePriorityCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackagePriorityCode));
      }
    }

    public Info IsApprover
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprover), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsApprover));
      }
    }

    public Info IsCollaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCollaborator));
      }
    }

    public Info IsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsOwner));
      }
    }

    public Info HasApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasApproverRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasApproverRole));
      }
    }

    public Info HasOwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasOwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasOwnerRole));
      }
    }

    public Info SelectedObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedObjectType));
      }
    }

    public Info IsApprovalCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsApprovalCompleted));
      }
    }

    public Info IsCollaborationCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCollaborationCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsCollaborationCompleted));
      }
    }

    public Info SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public Info HasCollaboratorRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasCollaboratorRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasCollaboratorRole));
      }
    }

    public new Info PackageOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageOwner));
      }
    }
  }
}
