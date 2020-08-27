// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SuspectDeviceHistoryDetail
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
  public class SuspectDeviceHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_CatalogNumber")]
    protected Primitive<string> _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_OtherNumber")]
    protected Primitive<string> _OtherNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_LotNumber")]
    protected Primitive<string> _LotNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_ConcomitantProductName")]
    protected Primitive<string> _ConcomitantProductName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_ModelNumber")]
    protected Primitive<string> _ModelNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_SerialNumber")]
    protected Primitive<string> _SerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_ExpirationDate")]
    protected Primitive<DateTime> _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_ExpirationDateGMT")]
    protected Primitive<DateTime> _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_DeviceManufactureDateGMT")]
    protected Primitive<DateTime> _DeviceManufactureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_DeviceManufactureDate")]
    protected Primitive<DateTime> _DeviceManufactureDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_BrandName")]
    protected Primitive<string> _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_SuspectDeviceName")]
    protected Primitive<string> _SuspectDeviceName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_SuspectDeviceRev")]
    protected Primitive<string> _SuspectDeviceRev;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_CommonDeviceName")]
    protected Primitive<string> _CommonDeviceName;

    public override bool Equals(object obj)
    {
      return obj is SuspectDeviceHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((SuspectDeviceHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((SuspectDeviceHistoryDetail) obj)._HistoryId) && object.Equals((object) this._CatalogNumber, (object) ((SuspectDeviceHistoryDetail) obj)._CatalogNumber)) && (object.Equals((object) this._OtherNumber, (object) ((SuspectDeviceHistoryDetail) obj)._OtherNumber) && object.Equals((object) this._LotNumber, (object) ((SuspectDeviceHistoryDetail) obj)._LotNumber) && (object.Equals((object) this._ConcomitantProductName, (object) ((SuspectDeviceHistoryDetail) obj)._ConcomitantProductName) && object.Equals((object) this._ModelNumber, (object) ((SuspectDeviceHistoryDetail) obj)._ModelNumber))) && (object.Equals((object) this._SerialNumber, (object) ((SuspectDeviceHistoryDetail) obj)._SerialNumber) && object.Equals((object) this._ExpirationDate, (object) ((SuspectDeviceHistoryDetail) obj)._ExpirationDate) && (object.Equals((object) this._ExpirationDateGMT, (object) ((SuspectDeviceHistoryDetail) obj)._ExpirationDateGMT) && object.Equals((object) this._DeviceManufactureDateGMT, (object) ((SuspectDeviceHistoryDetail) obj)._DeviceManufactureDateGMT)) && (object.Equals((object) this._DeviceManufactureDate, (object) ((SuspectDeviceHistoryDetail) obj)._DeviceManufactureDate) && object.Equals((object) this._BrandName, (object) ((SuspectDeviceHistoryDetail) obj)._BrandName) && (object.Equals((object) this._SuspectDeviceName, (object) ((SuspectDeviceHistoryDetail) obj)._SuspectDeviceName) && object.Equals((object) this._SuspectDeviceRev, (object) ((SuspectDeviceHistoryDetail) obj)._SuspectDeviceRev)))) && object.Equals((object) this._CommonDeviceName, (object) ((SuspectDeviceHistoryDetail) obj)._CommonDeviceName) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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
