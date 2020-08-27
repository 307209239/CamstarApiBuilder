// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SuspectDeviceDetail_Environment
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
  public class SuspectDeviceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The product (SuspectDevice) data assigned to an Event.", "SuspectDeviceData", false, false, false, "SubentityRef", 1051435, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_SuspectDeviceData")]
    protected Environment _SuspectDeviceData;
    [Metadata("Generic String", "", false, false, false, "String", 1051220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_CatalogNumber")]
    protected Environment _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_ExpirationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051257, false, false, false, null)]
    protected Environment _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_LotNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051258, false, false, false, null)]
    protected Environment _LotNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_DeviceManufactureDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051255, false, false, false, null)]
    protected Environment _DeviceManufactureDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_ExpirationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050479, false, false, false, null)]
    protected Environment _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_ModelNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051223, false, false, false, null)]
    protected Environment _ModelNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1051254, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_ConcomitantProductName")]
    protected Environment _ConcomitantProductName;
    [Metadata("Generic String", "", false, false, false, "String", 1051260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_SerialNumber")]
    protected Environment _SerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_DeviceManufactureDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051256, false, false, false, null)]
    protected Environment _DeviceManufactureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_OtherNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051259, false, false, false, null)]
    protected Environment _OtherNumber;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1051261, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_SuspectDeviceRev")]
    protected Environment _SuspectDeviceRev;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_SuspectDeviceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048625, false, false, true, null)]
    protected Environment _SuspectDeviceName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_BrandName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051252, false, false, false, null)]
    protected Environment _BrandName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051253, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceDetail_Environment_CommonDeviceName")]
    protected Environment _CommonDeviceName;

    public Environment SuspectDeviceData
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SuspectDeviceData));
      }
    }

    public Environment CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Environment ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Environment LotNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotNumber));
      }
    }

    public Environment DeviceManufactureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceManufactureDate));
      }
    }

    public Environment ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Environment ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Environment ConcomitantProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConcomitantProductName));
      }
    }

    public Environment SerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SerialNumber));
      }
    }

    public Environment DeviceManufactureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceManufactureDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceManufactureDateGMT));
      }
    }

    public Environment OtherNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OtherNumber));
      }
    }

    public Environment SuspectDeviceRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SuspectDeviceRev));
      }
    }

    public Environment SuspectDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SuspectDeviceName));
      }
    }

    public Environment BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BrandName));
      }
    }

    public Environment CommonDeviceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommonDeviceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CommonDeviceName));
      }
    }
  }
}
