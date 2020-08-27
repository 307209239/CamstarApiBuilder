// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerContactChanges_Environment
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
  public class CustomerContactChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("E-mail Address", "", false, false, false, "String", 1049963, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_EmailAddress")]
    protected Environment _EmailAddress;
    [Metadata("Contact information for a Customer.", "CustomerContactChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_ObjectToChange")]
    [Metadata("Contact information for a Customer.", "CustomerContact", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_PrimaryContact")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051214, false, false, false, "0")]
    protected Environment _PrimaryContact;
    [Metadata("Generic String", "", false, false, false, "String", 1051113, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_FaxNumber")]
    protected Environment _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_PhoneNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051111, false, false, false, null)]
    protected Environment _PhoneNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1051213, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_CellPhoneNumber")]
    protected Environment _CellPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerContactChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048617, false, false, false, null)]
    protected new Environment _Name;

    public Environment EmailAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmailAddress), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmailAddress));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment PrimaryContact
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrimaryContact), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrimaryContact));
      }
    }

    public Environment FaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (FaxNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FaxNumber));
      }
    }

    public Environment PhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhoneNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhoneNumber));
      }
    }

    public Environment CellPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellPhoneNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CellPhoneNumber));
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
