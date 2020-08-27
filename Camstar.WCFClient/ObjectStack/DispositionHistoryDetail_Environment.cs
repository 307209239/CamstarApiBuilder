// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionHistoryDetail_Environment
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
  public class DispositionHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_QuantityDispositioned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052033, false, false, false, null)]
    protected Environment _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_QuantityAssigned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052022, false, false, false, null)]
    protected Environment _QuantityAssigned;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_LotQuantity")]
    protected Environment _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_QuantityConforming")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052105, false, false, false, null)]
    protected Environment _QuantityConforming;
    [Metadata("Generic String", "", false, false, true, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_UOMName")]
    protected Environment _UOMName;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionHistoryDetail_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;

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

    public Environment QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Environment QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public Environment LotQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotQuantity));
      }
    }

    public Environment QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
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

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }

    public Environment Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Lot));
      }
    }
  }
}
