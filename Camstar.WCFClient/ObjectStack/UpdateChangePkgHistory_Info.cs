// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkgHistory_Info
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
  public class UpdateChangePkgHistory_Info : ChangePackageHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_OwnerRole")]
    protected new Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_TargetSystems")]
    protected Info _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_Reason")]
    protected new Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_Instances")]
    protected Info _Instances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_Priority")]
    protected new Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_PackageType")]
    protected Info _PackageType;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_RecommendedDeploymentDate")]
    protected Info _RecommendedDeploymentDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_NotifyOwnerAllStateChanges")]
    protected new Info _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_NotifyOwnerRoleAllStateChgs")]
    protected new Info _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_ECOECN")]
    protected new Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_Locklnstances")]
    protected new Info _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Info_ChangePackageName")]
    protected new Info _ChangePackageName;

    public new Info OwnerRole
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

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public new Info Reason
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

    public Info Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instances));
      }
    }

    public new Info Priority
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

    public new Info NotifyOwnerAllStateChanges
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

    public new Info NotifyOwnerRoleAllStateChgs
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

    public new Info ECOECN
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

    public new Info Locklnstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locklnstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Locklnstances));
      }
    }

    public new Info Owner
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

    public new Info ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
