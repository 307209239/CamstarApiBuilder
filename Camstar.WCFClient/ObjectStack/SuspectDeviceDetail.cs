// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SuspectDeviceDetail
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
  public class SuspectDeviceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_SuspectDeviceData")]
    protected SubentityRef _SuspectDeviceData;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_CatalogNumber")]
    protected Primitive<string> _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_ExpirationDateGMT")]
    protected Primitive<DateTime> _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_LotNumber")]
    protected Primitive<string> _LotNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_DeviceManufactureDate")]
    protected Primitive<DateTime> _DeviceManufactureDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_ModelNumber")]
    protected Primitive<string> _ModelNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_ConcomitantProductName")]
    protected Primitive<string> _ConcomitantProductName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_SerialNumber")]
    protected Primitive<string> _SerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_DeviceManufactureDateGMT")]
    protected Primitive<DateTime> _DeviceManufactureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_OtherNumber")]
    protected Primitive<string> _OtherNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_SuspectDeviceRev")]
    protected Primitive<string> _SuspectDeviceRev;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_SuspectDeviceName")]
    protected Primitive<string> _SuspectDeviceName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_BrandName")]
    protected Primitive<string> _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_CommonDeviceName")]
    protected Primitive<string> _CommonDeviceName;

    public override bool Equals(object obj)
    {
      return obj is SuspectDeviceDetail && object.Equals((object) this._SuspectDeviceData, (object) ((SuspectDeviceDetail) obj)._SuspectDeviceData) && (object.Equals((object) this._CatalogNumber, (object) ((SuspectDeviceDetail) obj)._CatalogNumber) && object.Equals((object) this._ExpirationDateGMT, (object) ((SuspectDeviceDetail) obj)._ExpirationDateGMT)) && (object.Equals((object) this._LotNumber, (object) ((SuspectDeviceDetail) obj)._LotNumber) && object.Equals((object) this._DeviceManufactureDate, (object) ((SuspectDeviceDetail) obj)._DeviceManufactureDate) && (object.Equals((object) this._ExpirationDate, (object) ((SuspectDeviceDetail) obj)._ExpirationDate) && object.Equals((object) this._ModelNumber, (object) ((SuspectDeviceDetail) obj)._ModelNumber))) && (object.Equals((object) this._ConcomitantProductName, (object) ((SuspectDeviceDetail) obj)._ConcomitantProductName) && object.Equals((object) this._SerialNumber, (object) ((SuspectDeviceDetail) obj)._SerialNumber) && (object.Equals((object) this._DeviceManufactureDateGMT, (object) ((SuspectDeviceDetail) obj)._DeviceManufactureDateGMT) && object.Equals((object) this._OtherNumber, (object) ((SuspectDeviceDetail) obj)._OtherNumber)) && (object.Equals((object) this._SuspectDeviceRev, (object) ((SuspectDeviceDetail) obj)._SuspectDeviceRev) && object.Equals((object) this._SuspectDeviceName, (object) ((SuspectDeviceDetail) obj)._SuspectDeviceName) && (object.Equals((object) this._BrandName, (object) ((SuspectDeviceDetail) obj)._BrandName) && object.Equals((object) this._CommonDeviceName, (object) ((SuspectDeviceDetail) obj)._CommonDeviceName)))) && base.Equals(obj);
    }

    public SubentityRef SuspectDeviceData
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (SuspectDeviceData));
      }
    }

    public Primitive<string> CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Primitive<DateTime> ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Primitive<string> LotNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LotNumber));
      }
    }

    public Primitive<DateTime> DeviceManufactureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DeviceManufactureDate));
      }
    }

    public Primitive<DateTime> ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Primitive<string> ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Primitive<string> ConcomitantProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ConcomitantProductName));
      }
    }

    public Primitive<string> SerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SerialNumber));
      }
    }

    public Primitive<DateTime> DeviceManufactureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DeviceManufactureDateGMT));
      }
    }

    public Primitive<string> OtherNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OtherNumber));
      }
    }

    public Primitive<string> SuspectDeviceRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SuspectDeviceRev));
      }
    }

    public Primitive<string> SuspectDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SuspectDeviceName));
      }
    }

    public Primitive<string> BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BrandName));
      }
    }

    public Primitive<string> CommonDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommonDeviceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CommonDeviceName));
      }
    }
  }
}
