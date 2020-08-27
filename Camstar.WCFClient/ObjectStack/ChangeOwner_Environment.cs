// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeOwner_Environment
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
  public class ChangeOwner_Environment : QualityTxn_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Environment_Role")]
    protected Environment _Role;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051655, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052050, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Environment_CurrentRole")]
    protected Environment _CurrentRole;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ChangeOwner_Environment_CurrentOwner")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052080, false, false, false, null)]
    protected Environment _CurrentOwner;

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Environment CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentRole));
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

    public Environment CurrentOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentOwner));
      }
    }
  }
}
