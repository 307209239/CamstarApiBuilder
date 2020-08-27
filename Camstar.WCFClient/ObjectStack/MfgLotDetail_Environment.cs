// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgLotDetail_Environment
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
  public class MfgLotDetail_Environment : MfgDataDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_OriginalStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Status")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048671, false, false, false, null)]
    protected Environment _Status;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Product")]
    protected Environment _Product;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Factory")]
    protected Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_UOM")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049043, false, false, false, null)]
    protected Environment _Lot;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_Operation")]
    protected Environment _Operation;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048644, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_WorkCenter")]
    protected Environment _WorkCenter;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1050390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_ProductRev")]
    protected Environment _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "MfgLotDetail_Environment_StatusName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048671, false, false, false, null)]
    protected Environment _StatusName;

    public Environment OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
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

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Environment StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusName));
      }
    }
  }
}
