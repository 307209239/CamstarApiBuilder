// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkg_Info
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
  public class UpdateChangePkg_Info : ChangeMgtTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_CollaboratorDetails")]
    protected CollaboratorDetails_Info _CollaboratorDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_PackageCreationTemplate")]
    protected Info _PackageCreationTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_ServiceDetail")]
    protected UpdateChangePkgDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_ApprovalSheetDetails")]
    protected ApprovalSheetDetails_Info _ApprovalSheetDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_ChangePackage")]
    protected new Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_Reason")]
    protected Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_IsUpdateChangePkg")]
    protected Info _IsUpdateChangePkg;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_UseContentCollaborators")]
    protected Info _UseContentCollaborators;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_NotifyOwnerAllStateChanges")]
    protected Info _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_HasSpecApprovals")]
    protected Info _HasSpecApprovals;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_PreReqChangePkgs")]
    protected Info _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_NotifyOwnerRoleAllStateChgs")]
    protected Info _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_ECOECN")]
    protected Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_LockInstances")]
    protected Info _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_WorkflowDescription")]
    protected Info _WorkflowDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkg_Info_Owner")]
    protected Info _Owner;

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

    public CollaboratorDetails_Info CollaboratorDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorDetails), (object) value);
      }
      get
      {
        return (CollaboratorDetails_Info) this.PropertyGet(nameof (CollaboratorDetails));
      }
    }

    public Info PackageCreationTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageCreationTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PackageCreationTemplate));
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

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public UpdateChangePkgDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (UpdateChangePkgDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public Info Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Priority));
      }
    }

    public ApprovalSheetDetails_Info ApprovalSheetDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetDetails), (object) value);
      }
      get
      {
        return (ApprovalSheetDetails_Info) this.PropertyGet(nameof (ApprovalSheetDetails));
      }
    }

    public new Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Info Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Reason));
      }
    }

    public Info RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public Info IsUpdateChangePkg
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsUpdateChangePkg), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsUpdateChangePkg));
      }
    }

    public Info UseContentCollaborators
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseContentCollaborators), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseContentCollaborators));
      }
    }

    public Info NotifyOwnerAllStateChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerAllStateChanges), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotifyOwnerAllStateChanges));
      }
    }

    public Info HasSpecApprovals
    {
      [param: In] set
      {
        this.PropertySet(nameof (HasSpecApprovals), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HasSpecApprovals));
      }
    }

    public Info PreReqChangePkgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreReqChangePkgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreReqChangePkgs));
      }
    }

    public Info NotifyOwnerRoleAllStateChgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerRoleAllStateChgs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotifyOwnerRoleAllStateChgs));
      }
    }

    public Info ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ECOECN));
      }
    }

    public Info LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Info WorkflowDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowDescription));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
