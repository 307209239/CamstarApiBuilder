// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerChanges
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
  public class CustomerChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_WebSite")]
    protected Primitive<string> _WebSite;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_AddressLine1")]
    protected Primitive<string> _AddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_CustomerContacts")]
    protected CustomerContactChanges[] _CustomerContacts;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_AddressLine2")]
    protected Primitive<string> _AddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Country")]
    protected Primitive<string> _Country;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_ZipCode")]
    protected Primitive<string> _ZipCode;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_City")]
    protected Primitive<string> _City;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Company")]
    protected Primitive<string> _Company;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_PhoneNumber")]
    protected Primitive<string> _PhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_FaxNumber")]
    protected Primitive<string> _FaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_State")]
    protected Primitive<string> _State;
    [DataMember(EmitDefaultValue = false, Name = "CustomerChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is CustomerChanges && object.Equals((object) this._WIPMsgDefMgr, (object) ((CustomerChanges) obj)._WIPMsgDefMgr) && (object.Equals((object) this._ObjectToChange, (object) ((CustomerChanges) obj)._ObjectToChange) && object.Equals((object) this._WebSite, (object) ((CustomerChanges) obj)._WebSite)) && (object.Equals((object) this._AddressLine1, (object) ((CustomerChanges) obj)._AddressLine1) && this.CompareArrays((Array) this._CustomerContacts, (Array) ((CustomerChanges) obj)._CustomerContacts) && (object.Equals((object) this._AddressLine2, (object) ((CustomerChanges) obj)._AddressLine2) && object.Equals((object) this._Country, (object) ((CustomerChanges) obj)._Country))) && (object.Equals((object) this._ZipCode, (object) ((CustomerChanges) obj)._ZipCode) && object.Equals((object) this._City, (object) ((CustomerChanges) obj)._City) && (object.Equals((object) this._Company, (object) ((CustomerChanges) obj)._Company) && object.Equals((object) this._PhoneNumber, (object) ((CustomerChanges) obj)._PhoneNumber)) && (object.Equals((object) this._FaxNumber, (object) ((CustomerChanges) obj)._FaxNumber) && object.Equals((object) this._State, (object) ((CustomerChanges) obj)._State) && object.Equals((object) this._Name, (object) ((CustomerChanges) obj)._Name))) && base.Equals(obj);
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> WebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebSite), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WebSite));
      }
    }

    public Primitive<string> AddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine1), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AddressLine1));
      }
    }

    public CustomerContactChanges[] CustomerContacts
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerContacts), (object) value);
      }
      get
      {
        return (CustomerContactChanges[]) this.PropertyGet(nameof (CustomerContacts));
      }
    }

    public Primitive<string> AddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddressLine2), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AddressLine2));
      }
    }

    public Primitive<string> Country
    {
      [param: In] set
      {
        this.PropertySet(nameof (Country), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Country));
      }
    }

    public Primitive<string> ZipCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ZipCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ZipCode));
      }
    }

    public Primitive<string> City
    {
      [param: In] set
      {
        this.PropertySet(nameof (City), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (City));
      }
    }

    public Primitive<string> Company
    {
      [param: In] set
      {
        this.PropertySet(nameof (Company), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Company));
      }
    }

    public Primitive<string> PhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PhoneNumber));
      }
    }

    public Primitive<string> FaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (FaxNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FaxNumber));
      }
    }

    public Primitive<string> State
    {
      [param: In] set
      {
        this.PropertySet(nameof (State), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (State));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
