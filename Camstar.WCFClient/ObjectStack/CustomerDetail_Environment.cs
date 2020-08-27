// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReportingCustomerDetail_Environment))]
  [KnownType(typeof (ContactCustomerDetail_Environment))]
  [Serializable]
  public class CustomerDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("E-mail Address", "", false, false, false, "String", 1051250, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_ContactEMail")]
    protected Environment _ContactEMail;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerWebSite")]
    [Metadata("URL", "", false, false, false, "String", 1051121, false, false, false, null)]
    protected Environment _CustomerWebSite;
    [Metadata("Address", "", false, false, false, "String", 1051216, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerAddressLine2")]
    protected Environment _CustomerAddressLine2;
    [Metadata("Address", "", false, false, false, "String", 1051102, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerAddressLine1")]
    protected Environment _CustomerAddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerFaxNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051113, false, false, false, null)]
    protected Environment _CustomerFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerPhoneNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051111, false, false, false, null)]
    protected Environment _CustomerPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerCountry")]
    [Metadata("Generic String", "", false, false, false, "String", 1051116, false, false, false, null)]
    protected Environment _CustomerCountry;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerCity")]
    [Metadata("Generic String", "", false, false, false, "String", 1051104, false, false, false, null)]
    protected Environment _CustomerCity;
    [Metadata("Generic String", "", false, false, false, "String", 1051111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_ContactPhoneNumber")]
    protected Environment _ContactPhoneNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1051213, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_ContactCellPhone")]
    protected Environment _ContactCellPhone;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerPostalCode")]
    [Metadata("Generic String", "", false, false, false, "String", 1051251, false, false, false, null)]
    protected Environment _CustomerPostalCode;
    [Metadata("Generic String", "", false, false, false, "String", 1051113, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_ContactFaxNumber")]
    protected Environment _ContactFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerState")]
    [Metadata("Generic String", "", false, false, false, "String", 1051106, false, false, false, null)]
    protected Environment _CustomerState;
    [Metadata("Generic String", "", false, false, false, "String", 1048617, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_ContactFullName")]
    protected Environment _ContactFullName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049632, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerDetail_Environment_CustomerName")]
    protected Environment _CustomerName;

    public Environment ContactEMail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactEMail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactEMail));
      }
    }

    public Environment CustomerWebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerWebSite), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerWebSite));
      }
    }

    public Environment CustomerAddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerAddressLine2));
      }
    }

    public Environment CustomerAddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine1), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerAddressLine1));
      }
    }

    public Environment CustomerFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerFaxNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerFaxNumber));
      }
    }

    public Environment CustomerPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPhoneNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerPhoneNumber));
      }
    }

    public Environment CustomerCountry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCountry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerCountry));
      }
    }

    public Environment CustomerCity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerCity));
      }
    }

    public Environment ContactPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactPhoneNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactPhoneNumber));
      }
    }

    public Environment ContactCellPhone
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCellPhone), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactCellPhone));
      }
    }

    public Environment CustomerPostalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPostalCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerPostalCode));
      }
    }

    public Environment ContactFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFaxNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactFaxNumber));
      }
    }

    public Environment CustomerState
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerState));
      }
    }

    public Environment ContactFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFullName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactFullName));
      }
    }

    public Environment CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerName));
      }
    }
  }
}
