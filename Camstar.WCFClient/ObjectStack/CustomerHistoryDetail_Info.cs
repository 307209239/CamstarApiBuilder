// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CustomerHistoryDetail_Info
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
  public class CustomerHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ContactEMail")]
    protected Info _ContactEMail;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerWebSite")]
    protected Info _CustomerWebSite;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerAddressLine1")]
    protected Info _CustomerAddressLine1;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerAddressLine2")]
    protected Info _CustomerAddressLine2;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerFaxNumber")]
    protected Info _CustomerFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerPostalCode")]
    protected Info _CustomerPostalCode;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ContactFaxNumber")]
    protected Info _ContactFaxNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerState")]
    protected Info _CustomerState;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerCountry")]
    protected Info _CustomerCountry;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ContactCellPhone")]
    protected Info _ContactCellPhone;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerCity")]
    protected Info _CustomerCity;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ContactFullName")]
    protected Info _ContactFullName;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_ContactPhoneNumber")]
    protected Info _ContactPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerPhoneNumber")]
    protected Info _CustomerPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "CustomerHistoryDetail_Info_CustomerName")]
    protected Info _CustomerName;

    public Info ContactEMail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactEMail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactEMail));
      }
    }

    public Info CustomerWebSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerWebSite), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerWebSite));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info CustomerAddressLine1
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine1), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerAddressLine1));
      }
    }

    public Info CustomerAddressLine2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerAddressLine2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerAddressLine2));
      }
    }

    public Info CustomerFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerFaxNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerFaxNumber));
      }
    }

    public Info CustomerPostalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPostalCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerPostalCode));
      }
    }

    public Info ContactFaxNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFaxNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactFaxNumber));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info CustomerState
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerState));
      }
    }

    public Info CustomerCountry
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCountry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerCountry));
      }
    }

    public Info ContactCellPhone
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCellPhone), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactCellPhone));
      }
    }

    public Info CustomerCity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerCity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerCity));
      }
    }

    public Info ContactFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactFullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactFullName));
      }
    }

    public Info ContactPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactPhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactPhoneNumber));
      }
    }

    public Info CustomerPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerPhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerPhoneNumber));
      }
    }

    public Info CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomerName));
      }
    }
  }
}
