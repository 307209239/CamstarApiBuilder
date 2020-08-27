// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SuspectDeviceHistoryDetail_Environment
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
  public class SuspectDeviceHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic String", "", false, false, true, "String", 1051220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_CatalogNumber")]
    protected Environment _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_OtherNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1051259, false, false, false, null)]
    protected Environment _OtherNumber;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_LotNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1051258, false, false, false, null)]
    protected Environment _LotNumber;
    [Metadata("Generic String", "", false, false, true, "String", 1051254, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_ConcomitantProductName")]
    protected Environment _ConcomitantProductName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_ModelNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1051223, false, false, false, null)]
    protected Environment _ModelNumber;
    [Metadata("Generic String", "", false, false, true, "String", 1051260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_SerialNumber")]
    protected Environment _SerialNumber;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050479, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_ExpirationDate")]
    protected Environment _ExpirationDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051257, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_ExpirationDateGMT")]
    protected Environment _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_DeviceManufactureDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051256, false, false, false, null)]
    protected Environment _DeviceManufactureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_DeviceManufactureDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051255, false, false, false, null)]
    protected Environment _DeviceManufactureDate;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_BrandName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051252, false, false, false, null)]
    protected Environment _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_SuspectDeviceName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    protected Environment _SuspectDeviceName;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_SuspectDeviceRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1051261, false, false, false, null)]
    protected Environment _SuspectDeviceRev;
    [DataMember(EmitDefaultValue = false, Name = "SuspectDeviceHistoryDetail_Environment_CommonDeviceName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051253, false, false, false, null)]
    protected Environment _CommonDeviceName;

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
