// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteThruputHistoryDetails
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
  public class CompleteThruputHistoryDetails : CompleteMaintHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQty2Limit")]
    protected Primitive<double> _LastThruputQty2Limit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQty2Warning")]
    protected Primitive<double> _LastThruputQty2Warning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_ThruputQty2")]
    protected Primitive<double> _ThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQty2Due")]
    protected Primitive<double> _LastThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQtyLimit")]
    protected Primitive<double> _LastThruputQtyLimit;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_ThruputQty")]
    protected Primitive<double> _ThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQtyWarning")]
    protected Primitive<double> _LastThruputQtyWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_LastThruputQtyDue")]
    protected Primitive<double> _LastThruputQtyDue;

    public override bool Equals(object obj)
    {
      return obj is CompleteThruputHistoryDetails && object.Equals((object) this._LastThruputQty2Limit, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQty2Limit) && (object.Equals((object) this._LastThruputQty2Warning, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQty2Warning) && object.Equals((object) this._ThruputQty2, (object) ((CompleteThruputHistoryDetails) obj)._ThruputQty2)) && (object.Equals((object) this._UOM, (object) ((CompleteThruputHistoryDetails) obj)._UOM) && object.Equals((object) this._LastThruputQty2Due, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQty2Due) && (object.Equals((object) this._UOM2, (object) ((CompleteThruputHistoryDetails) obj)._UOM2) && object.Equals((object) this._LastThruputQtyLimit, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQtyLimit))) && (object.Equals((object) this._ThruputQty, (object) ((CompleteThruputHistoryDetails) obj)._ThruputQty) && object.Equals((object) this._LastThruputQtyWarning, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQtyWarning) && object.Equals((object) this._LastThruputQtyDue, (object) ((CompleteThruputHistoryDetails) obj)._LastThruputQtyDue)) && base.Equals(obj);
    }

    public Primitive<double> LastThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Limit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQty2Limit));
      }
    }

    public Primitive<double> LastThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Warning), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQty2Warning));
      }
    }

    public Primitive<double> ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputQty2));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<double> LastThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Due), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQty2Due));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public Primitive<double> LastThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQtyLimit));
      }
    }

    public Primitive<double> ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Primitive<double> LastThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyWarning), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQtyWarning));
      }
    }

    public Primitive<double> LastThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyDue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LastThruputQtyDue));
      }
    }
  }
}
