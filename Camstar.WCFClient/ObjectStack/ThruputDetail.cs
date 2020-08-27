// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputDetail
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
  public class ThruputDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_ThruputAllQty")]
    protected Primitive<bool> _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ThruputDetail_ContainerLevel")]
    protected NamedObjectRef _ContainerLevel;

    public override bool Equals(object obj)
    {
      return obj is ThruputDetail && object.Equals((object) this._Qty2, (object) ((ThruputDetail) obj)._Qty2) && (object.Equals((object) this._ChildCount, (object) ((ThruputDetail) obj)._ChildCount) && object.Equals((object) this._UnitCount, (object) ((ThruputDetail) obj)._UnitCount)) && (object.Equals((object) this._ThruputAllQty, (object) ((ThruputDetail) obj)._ThruputAllQty) && object.Equals((object) this._Container, (object) ((ThruputDetail) obj)._Container) && (object.Equals((object) this._Qty, (object) ((ThruputDetail) obj)._Qty) && object.Equals((object) this._Operation, (object) ((ThruputDetail) obj)._Operation))) && (object.Equals((object) this._ThruputReportingLevel, (object) ((ThruputDetail) obj)._ThruputReportingLevel) && object.Equals((object) this._Resource, (object) ((ThruputDetail) obj)._Resource) && (object.Equals((object) this._Product, (object) ((ThruputDetail) obj)._Product) && object.Equals((object) this._ContainerLevel, (object) ((ThruputDetail) obj)._ContainerLevel))) && base.Equals(obj);
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public NamedObjectRef Operation
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

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
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
  }
}
