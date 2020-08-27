// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReportingCustomerDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContactCustomerDetail))]
  [Serializable]
  public class CustomerDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_ContactEMail")]
    protected Primitive<string> _ContactEMail;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerWebSite")]
    protected Primitive<string> _CustomerWebSite;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerAddressLine2")]
    protected Primitive<string> _CustomerAddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerAddressLine1")]
    protected Primitive<string> _CustomerAddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerFaxNumber")]
    protected Primitive<string> _CustomerFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerPhoneNumber")]
    protected Primitive<string> _CustomerPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerCountry")]
    protected Primitive<string> _CustomerCountry;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerCity")]
    protected Primitive<string> _CustomerCity;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_ContactPhoneNumber")]
    protected Primitive<string> _ContactPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_ContactCellPhone")]
    protected Primitive<string> _ContactCellPhone;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerPostalCode")]
    protected Primitive<string> _CustomerPostalCode;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_ContactFaxNumber")]
    protected Primitive<string> _ContactFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerState")]
    protected Primitive<string> _CustomerState;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_ContactFullName")]
    protected Primitive<string> _ContactFullName;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_CustomerName")]
    protected Primitive<string> _CustomerName;

    public override bool Equals(object obj)
    {
      return obj is CustomerDetail && object.Equals((object) this._ContactEMail, (object) ((CustomerDetail) obj)._ContactEMail) && (object.Equals((object) this._CustomerWebSite, (object) ((CustomerDetail) obj)._CustomerWebSite) && object.Equals((object) this._CustomerAddressLine2, (object) ((CustomerDetail) obj)._CustomerAddressLine2)) && (object.Equals((object) this._CustomerAddressLine1, (object) ((CustomerDetail) obj)._CustomerAddressLine1) && object.Equals((object) this._CustomerFaxNumber, (object) ((CustomerDetail) obj)._CustomerFaxNumber) && (object.Equals((object) this._CustomerPhoneNumber, (object) ((CustomerDetail) obj)._CustomerPhoneNumber) && object.Equals((object) this._CustomerCountry, (object) ((CustomerDetail) obj)._CustomerCountry))) && (object.Equals((object) this._CustomerCity, (object) ((CustomerDetail) obj)._CustomerCity) && object.Equals((object) this._ContactPhoneNumber, (object) ((CustomerDetail) obj)._ContactPhoneNumber) && (object.Equals((object) this._ContactCellPhone, (object) ((CustomerDetail) obj)._ContactCellPhone) && object.Equals((object) this._CustomerPostalCode, (object) ((CustomerDetail) obj)._CustomerPostalCode)) && (object.Equals((object) this._ContactFaxNumber, (object) ((CustomerDetail) obj)._ContactFaxNumber) && object.Equals((object) this._CustomerState, (object) ((CustomerDetail) obj)._CustomerState) && (object.Equals((object) this._ContactFullName, (object) ((CustomerDetail) obj)._ContactFullName) && object.Equals((object) this._CustomerName, (object) ((CustomerDetail) obj)._CustomerName)))) && base.Equals(obj);
    }

    public Primitive<string> ContactEMail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactEMail), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactEMail));
      }
    }

    public Primitive<string> CustomerWebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerWebSite), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerWebSite));
      }
    }

    public Primitive<string> CustomerAddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine2), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerAddressLine2));
      }
    }

    public Primitive<string> CustomerAddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine1), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerAddressLine1));
      }
    }

    public Primitive<string> CustomerFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerFaxNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerFaxNumber));
      }
    }

    public Primitive<string> CustomerPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerPhoneNumber));
      }
    }

    public Primitive<string> CustomerCountry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCountry), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerCountry));
      }
    }

    public Primitive<string> CustomerCity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCity), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerCity));
      }
    }

    public Primitive<string> ContactPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactPhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactPhoneNumber));
      }
    }

    public Primitive<string> ContactCellPhone
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCellPhone), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactCellPhone));
      }
    }

    public Primitive<string> CustomerPostalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPostalCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerPostalCode));
      }
    }

    public Primitive<string> ContactFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFaxNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactFaxNumber));
      }
    }

    public Primitive<string> CustomerState
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerState), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerState));
      }
    }

    public Primitive<string> ContactFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFullName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactFullName));
      }
    }

    public Primitive<string> CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomerName));
      }
    }
  }
}
