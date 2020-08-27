// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SiteChanges_Environment
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
  public class SiteChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_EMailTransport")]
    [Metadata("Describes the transport mechanism by which to send the outbound XML document", "DataTransport", false, false, false, "NamedObjectRef", 1049905, false, false, true, null)]
    protected Environment _EMailTransport;
    [Metadata("Describes the transport mechanism by which to send the outbound XML document", "DataTransport", false, false, false, "NamedObjectRef", 1049912, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_DefaultDataTransport")]
    protected Environment _DefaultDataTransport;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_URL")]
    [Metadata("URL", "", false, true, false, "String", 1049620, false, false, false, null)]
    protected Environment _URL;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_Password")]
    [Metadata("Password", "", false, true, false, "EncryptedField", 1048862, false, false, false, null)]
    protected Environment _Password;
    [Metadata("A site is defined as an independent InSite entity within a manufacturing organization. While a factory is a physical facilities concept, a site is a self contained IT structure based on a single transaction processing database, along with the associated InSite servers that provide the capability to generate transactions in the database. A factory could have one or more sites; and a site could run one or more factories.", "Site", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1048864, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_User")]
    protected Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050091, false, false, false, null)]
    protected new Environment _Name;

    public Environment EMailTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailTransport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailTransport));
      }
    }

    public Environment DefaultDataTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultDataTransport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultDataTransport));
      }
    }

    public Environment URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (URL));
      }
    }

    public Environment Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Password));
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

    public Environment User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (User));
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
  }
}
