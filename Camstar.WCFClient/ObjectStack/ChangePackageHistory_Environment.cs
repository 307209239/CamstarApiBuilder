// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UpdateChangePkgHistory_Environment))]
  [KnownType(typeof (DeployChangePkgHistory_Environment))]
  [KnownType(typeof (ActivateChangePkgHistory_Environment))]
  [KnownType(typeof (AssignChangePkgContentHistory_Environment))]
  [KnownType(typeof (StartChangePkgHistory_Environment))]
  [Serializable]
  public class ChangePackageHistory_Environment : TrackableObjectHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1053235, false, false, false, null)]
    protected Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, true, "NamedObjectRef", 1053246, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_Priority")]
    protected Environment _Priority;
    [Metadata("Various reasons for creating a change package.", "ChangePackageReason", false, false, true, "NamedObjectRef", 1053247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_Reason")]
    protected Environment _Reason;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_NotifyOwnerAllStateChanges")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053238, false, false, false, "0")]
    protected Environment _NotifyOwnerAllStateChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_ECOECN")]
    [Metadata("Generic String", "", false, false, true, "String", 1053236, false, false, false, null)]
    protected Environment _ECOECN;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_Locklnstances")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053237, false, false, false, "0")]
    protected Environment _Locklnstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_NotifyOwnerRoleAllStateChgs")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053239, false, false, false, "0")]
    protected Environment _NotifyOwnerRoleAllStateChgs;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053234, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_ChangePackageName")]
    protected Environment _ChangePackageName;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHistory_Environment_Owner")]
    protected Environment _Owner;

    public Environment OwnerRole
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

    public Environment Priority
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

    public Environment Reason
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

    public Environment NotifyOwnerAllStateChanges
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

    public Environment ECOECN
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

    public Environment Locklnstances
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

    public Environment NotifyOwnerRoleAllStateChgs
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

    public Environment ChangePackageName
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

    public Environment Owner
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
  }
}
