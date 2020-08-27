// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartChangePkg_Info
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
  public class StartChangePkg_Info : BPStartTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_Workflow")]
    protected new Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_PackageCreationTemplate")]
    protected Info _PackageCreationTemplate;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_Reason")]
    protected Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_ServiceDetail")]
    protected StartChangePkgDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_CurrentStatusDetails")]
    protected Info _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_LockInstances")]
    protected Info _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_NotifyOwnerAllStateChanges")]
    protected Info _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_NotifyOwnerRoleAllStateChgs")]
    protected Info _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_ECOECN")]
    protected Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_PreReqChangePkgs")]
    protected Info _PreReqChangePkgs;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_WorkflowDescription")]
    protected Info _WorkflowDescription;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartChangePkg_Info_TrackableName")]
    protected new Info _TrackableName;

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

    public new Info Workflow
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

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
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

    public StartChangePkgDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (StartChangePkgDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public Info CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStatusDetails));
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

    public new Info TrackableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableName));
      }
    }
  }
}
