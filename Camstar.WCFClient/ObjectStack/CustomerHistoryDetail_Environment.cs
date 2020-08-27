// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerHistoryDetail_Environment
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
  public class CustomerHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("E-mail Address", "", false, false, true, "String", 1051250, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ContactEMail")]
    protected Environment _ContactEMail;
    [Metadata("URL", "", false, false, true, "String", 1051121, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerWebSite")]
    protected Environment _CustomerWebSite;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Address", "", false, false, true, "String", 1051102, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerAddressLine1")]
    protected Environment _CustomerAddressLine1;
    [Metadata("Address", "", false, false, true, "String", 1051216, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerAddressLine2")]
    protected Environment _CustomerAddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerFaxNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1052246, false, false, false, null)]
    protected Environment _CustomerFaxNumber;
    [Metadata("Generic String", "", false, false, true, "String", 1051251, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerPostalCode")]
    protected Environment _CustomerPostalCode;
    [Metadata("Generic String", "", false, false, true, "String", 1052245, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ContactFaxNumber")]
    protected Environment _ContactFaxNumber;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic String", "", false, false, true, "String", 1051106, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerState")]
    protected Environment _CustomerState;
    [Metadata("Generic String", "", false, false, true, "String", 1051116, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerCountry")]
    protected Environment _CustomerCountry;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ContactCellPhone")]
    [Metadata("Generic String", "", false, false, true, "String", 1051213, false, false, false, null)]
    protected Environment _ContactCellPhone;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerCity")]
    [Metadata("Generic String", "", false, false, true, "String", 1051104, false, false, false, null)]
    protected Environment _CustomerCity;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ContactFullName")]
    [Metadata("Generic String", "", false, false, true, "String", 1048617, false, false, false, null)]
    protected Environment _ContactFullName;
    [Metadata("Generic String", "", false, false, true, "String", 1052248, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_ContactPhoneNumber")]
    protected Environment _ContactPhoneNumber;
    [Metadata("Generic String", "", false, false, true, "String", 1052247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerPhoneNumber")]
    protected Environment _CustomerPhoneNumber;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049632, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Environment_CustomerName")]
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
