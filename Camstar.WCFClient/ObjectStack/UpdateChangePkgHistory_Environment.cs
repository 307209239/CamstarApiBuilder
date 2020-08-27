// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateChangePkgHistory_Environment
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
  public class UpdateChangePkgHistory_Environment : ChangePackageHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1053235, false, false, false, null)]
    protected new Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("History for Change Package Target System", "CPTargetSystemHistDtl", false, false, true, "SubentityRef", 1053270, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_TargetSystems")]
    protected Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_Reason")]
    [Metadata("Various reasons for creating a change package.", "ChangePackageReason", false, false, true, "NamedObjectRef", 1053247, false, false, false, null)]
    protected new Environment _Reason;
    [Metadata("History for Change Package Modeling Instance", "CPModelingInstanceHistDtl", false, false, true, "SubentityRef", 1053260, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_Instances")]
    protected Environment _Instances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_Priority")]
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, true, "NamedObjectRef", 1053246, false, false, false, null)]
    protected new Environment _Priority;
    [Metadata("Helps to clarify the type of package.", "PackageType", false, false, true, "NamedObjectRef", 16778882, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_PackageType")]
    protected Environment _PackageType;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778131, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_RecommendedDeploymentDate")]
    protected Environment _RecommendedDeploymentDate;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053238, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_NotifyOwnerAllStateChanges")]
    protected new Environment _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_NotifyOwnerRoleAllStateChgs")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053239, false, false, false, "0")]
    protected new Environment _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_ECOECN")]
    [Metadata("Generic String", "", false, false, true, "String", 1053236, false, false, false, null)]
    protected new Environment _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_Locklnstances")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053237, false, false, false, "0")]
    protected new Environment _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    protected new Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UpdateChangePkgHistory_Environment_ChangePackageName")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053234, false, false, false, null)]
    protected new Environment _ChangePackageName;

    public new Environment OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerRole));
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

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystems));
      }
    }

    public new Environment Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Reason));
      }
    }

    public Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public new Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
      }
    }

    public Environment PackageType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PackageType));
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

    public Environment RecommendedDeploymentDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecommendedDeploymentDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecommendedDeploymentDate));
      }
    }

    public new Environment NotifyOwnerAllStateChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerAllStateChanges), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotifyOwnerAllStateChanges));
      }
    }

    public new Environment NotifyOwnerRoleAllStateChgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotifyOwnerRoleAllStateChgs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotifyOwnerRoleAllStateChgs));
      }
    }

    public new Environment ECOECN
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECOECN), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ECOECN));
      }
    }

    public new Environment Locklnstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locklnstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Locklnstances));
      }
    }

    public new Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public new Environment ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
