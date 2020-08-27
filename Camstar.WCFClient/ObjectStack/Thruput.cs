// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Thruput
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
  public class Thruput : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Thruput_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_ServiceDetails")]
    protected ThruputDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_SummaryThruput")]
    protected Primitive<bool> _SummaryThruput;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_ThruputAllQty")]
    protected Primitive<bool> _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_QtyRemaining")]
    protected Primitive<double> _QtyRemaining;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_ContainerLevel")]
    protected NamedObjectRef _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Operation")]
    protected new NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_QtyProcessed")]
    protected Primitive<double> _QtyProcessed;

    public override bool Equals(object obj)
    {
      return obj is Thruput && object.Equals((object) this._UOM2, (object) ((Thruput) obj)._UOM2) && (object.Equals((object) this._Qty2, (object) ((Thruput) obj)._Qty2) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((Thruput) obj)._ServiceDetails)) && (object.Equals((object) this._SummaryThruput, (object) ((Thruput) obj)._SummaryThruput) && object.Equals((object) this._ThruputAllQty, (object) ((Thruput) obj)._ThruputAllQty) && (object.Equals((object) this._UnitCount, (object) ((Thruput) obj)._UnitCount) && object.Equals((object) this._ChildCount, (object) ((Thruput) obj)._ChildCount))) && (object.Equals((object) this._Resource, (object) ((Thruput) obj)._Resource) && object.Equals((object) this._Qty, (object) ((Thruput) obj)._Qty) && (object.Equals((object) this._ThruputReportingLevel, (object) ((Thruput) obj)._ThruputReportingLevel) && object.Equals((object) this._QtyRemaining, (object) ((Thruput) obj)._QtyRemaining)) && (object.Equals((object) this._ContainerLevel, (object) ((Thruput) obj)._ContainerLevel) && object.Equals((object) this._Operation, (object) ((Thruput) obj)._Operation) && object.Equals((object) this._QtyProcessed, (object) ((Thruput) obj)._QtyProcessed))) && base.Equals(obj);
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

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public ThruputDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ThruputDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<bool> SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Primitive<bool> ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public NamedObjectRef ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public Primitive<double> QtyRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemaining), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRemaining));
      }
    }

    public NamedObjectRef ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public Primitive<double> QtyProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyProcessed), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyProcessed));
      }
    }
  }
}
