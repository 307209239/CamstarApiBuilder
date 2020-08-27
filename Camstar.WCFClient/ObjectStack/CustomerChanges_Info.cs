// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerChanges_Info
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
  public class CustomerChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_WebSite")]
    protected Info _WebSite;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_AddressLine1")]
    protected Info _AddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_CustomerContacts")]
    protected CustomerContactChanges_Info _CustomerContacts;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_AddressLine2")]
    protected Info _AddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_Country")]
    protected Info _Country;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_ZipCode")]
    protected Info _ZipCode;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_City")]
    protected Info _City;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_Company")]
    protected Info _Company;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_PhoneNumber")]
    protected Info _PhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_FaxNumber")]
    protected Info _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_State")]
    protected Info _State;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Info_Name")]
    protected new Info _Name;

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info WebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebSite), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebSite));
      }
    }

    public Info AddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine1), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AddressLine1));
      }
    }

    public CustomerContactChanges_Info CustomerContacts
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerContacts), (object) value);
      }
      get
      {
        return (CustomerContactChanges_Info) this.PropertyGet(nameof (CustomerContacts));
      }
    }

    public Info AddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AddressLine2));
      }
    }

    public Info Country
    {
      [param: In] set
      {
        this.PropertySet(nameof (Country), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Country));
      }
    }

    public Info ZipCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ZipCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ZipCode));
      }
    }

    public Info City
    {
      [param: In] set
      {
        this.PropertySet(nameof (City), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (City));
      }
    }

    public Info Company
    {
      [param: In] set
      {
        this.PropertySet(nameof (Company), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Company));
      }
    }

    public Info PhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhoneNumber));
      }
    }

    public Info FaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (FaxNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FaxNumber));
      }
    }

    public Info State
    {
      [param: In] set
      {
        this.PropertySet(nameof (State), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (State));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
