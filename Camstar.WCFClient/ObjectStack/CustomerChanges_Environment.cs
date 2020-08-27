// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerChanges_Environment
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
  public class CustomerChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_WebSite")]
    [Metadata("URL", "", false, false, false, "String", 1051121, false, false, false, null)]
    protected Environment _WebSite;
    [Metadata("Address", "", false, false, false, "String", 1051102, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_AddressLine1")]
    protected Environment _AddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_CustomerContacts")]
    [Metadata("Contact information for a Customer.", "CustomerContactChanges", false, false, false, "CustomerContactChanges", 1051210, false, true, false, null)]
    protected CustomerContactChanges_Environment _CustomerContacts;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_AddressLine2")]
    [Metadata("Address", "", false, false, false, "String", 1051216, false, false, false, null)]
    protected Environment _AddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_Country")]
    [Metadata("Generic String", "", false, false, false, "String", 1051116, false, false, false, null)]
    protected Environment _Country;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_ZipCode")]
    [Metadata("Generic String", "", false, false, false, "String", 1051217, false, false, false, null)]
    protected Environment _ZipCode;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_City")]
    [Metadata("Generic String", "", false, false, false, "String", 1051104, false, false, false, null)]
    protected Environment _City;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_Company")]
    [Metadata("Generic String", "", false, false, false, "String", 1049118, false, false, false, null)]
    protected Environment _Company;
    [Metadata("Generic String", "", false, false, false, "String", 1051111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_PhoneNumber")]
    protected Environment _PhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_FaxNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051113, false, false, false, null)]
    protected Environment _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_State")]
    [Metadata("Generic String", "", false, false, false, "String", 1051106, false, false, false, null)]
    protected Environment _State;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049632, false, false, false, null)]
    protected new Environment _Name;

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
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

    public Environment WebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebSite), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebSite));
      }
    }

    public Environment AddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine1), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AddressLine1));
      }
    }

    public CustomerContactChanges_Environment CustomerContacts
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerContacts), (object) value);
      }
      get
      {
        return (CustomerContactChanges_Environment) this.PropertyGet(nameof (CustomerContacts));
      }
    }

    public Environment AddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AddressLine2));
      }
    }

    public Environment Country
    {
      [param: In] set
      {
        this.PropertySet(nameof (Country), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Country));
      }
    }

    public Environment ZipCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ZipCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ZipCode));
      }
    }

    public Environment City
    {
      [param: In] set
      {
        this.PropertySet(nameof (City), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (City));
      }
    }

    public Environment Company
    {
      [param: In] set
      {
        this.PropertySet(nameof (Company), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Company));
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

    public Environment State
    {
      [param: In] set
      {
        this.PropertySet(nameof (State), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (State));
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
