// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailDistributionChanges_Environment
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
  public class EMailDistributionChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1051685, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Environment_RoleRecipients")]
    protected Environment _RoleRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Environment_ExternalRecipients")]
    [Metadata("E-mail Address", "", false, false, false, "String", 1051166, false, true, true, null)]
    protected Environment _ExternalRecipients;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Environment_ObjectToChange")]
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051696, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailDistributionChanges_Environment_EmployeeRecipients")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051165, false, true, true, null)]
    protected Environment _EmployeeRecipients;

    public Environment RoleRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleRecipients), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RoleRecipients));
      }
    }

    public Environment ExternalRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternalRecipients), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExternalRecipients));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment EmployeeRecipients
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeRecipients), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeRecipients));
      }
    }
  }
}
