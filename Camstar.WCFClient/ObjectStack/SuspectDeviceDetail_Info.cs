// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SuspectDeviceDetail_Info
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
  public class SuspectDeviceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_SuspectDeviceData")]
    protected Info _SuspectDeviceData;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_CatalogNumber")]
    protected Info _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_ExpirationDateGMT")]
    protected Info _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_LotNumber")]
    protected Info _LotNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_DeviceManufactureDate")]
    protected Info _DeviceManufactureDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_ModelNumber")]
    protected Info _ModelNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_ConcomitantProductName")]
    protected Info _ConcomitantProductName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_SerialNumber")]
    protected Info _SerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_DeviceManufactureDateGMT")]
    protected Info _DeviceManufactureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_OtherNumber")]
    protected Info _OtherNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_SuspectDeviceRev")]
    protected Info _SuspectDeviceRev;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_SuspectDeviceName")]
    protected Info _SuspectDeviceName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_BrandName")]
    protected Info _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Info_CommonDeviceName")]
    protected Info _CommonDeviceName;

    public Info SuspectDeviceData
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SuspectDeviceData));
      }
    }

    public Info CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Info ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Info LotNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotNumber));
      }
    }

    public Info DeviceManufactureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceManufactureDate));
      }
    }

    public Info ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Info ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Info ConcomitantProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConcomitantProductName));
      }
    }

    public Info SerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SerialNumber));
      }
    }

    public Info DeviceManufactureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceManufactureDateGMT));
      }
    }

    public Info OtherNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OtherNumber));
      }
    }

    public Info SuspectDeviceRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SuspectDeviceRev));
      }
    }

    public Info SuspectDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SuspectDeviceName));
      }
    }

    public Info BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BrandName));
      }
    }

    public Info CommonDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommonDeviceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CommonDeviceName));
      }
    }
  }
}
