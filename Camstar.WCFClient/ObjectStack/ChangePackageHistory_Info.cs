// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (AssignChangePkgContentHistory_Info))]
  [KnownType(typeof (UpdateChangePkgHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeployChangePkgHistory_Info))]
  [KnownType(typeof (StartChangePkgHistory_Info))]
  [KnownType(typeof (ActivateChangePkgHistory_Info))]
  [Serializable]
  public class ChangePackageHistory_Info : TrackableObjectHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_Reason")]
    protected Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_NotifyOwnerAllStateChanges")]
    protected Info _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_ECOECN")]
    protected Info _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_Locklnstances")]
    protected Info _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_NotifyOwnerRoleAllStateChgs")]
    protected Info _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_ChangePackageName")]
    protected Info _ChangePackageName;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Info_Owner")]
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

    public Info Locklnstances
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

    public Info ChangePackageName
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
