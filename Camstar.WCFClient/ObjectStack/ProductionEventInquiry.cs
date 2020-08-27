// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionEventInquiry
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
  public class ProductionEventInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ProductionEvent")]
    protected NamedObjectRef _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_OccuredToDate")]
    protected Primitive<DateTime> _OccuredToDate;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ReportFrom")]
    protected Primitive<DateTime> _ReportFrom;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ReportTo")]
    protected Primitive<DateTime> _ReportTo;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_OccuredFromDate")]
    protected Primitive<DateTime> _OccuredFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ProductRevFilter")]
    protected Primitive<string> _ProductRevFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ContainerFilter")]
    protected Primitive<string> _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_ProductFilter")]
    protected RevisionedObjectRef _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_IdentifierFilter")]
    protected Primitive<string> _IdentifierFilter;

    public override bool Equals(object obj)
    {
      return obj is ProductionEventInquiry && object.Equals((object) this._ProductionEvent, (object) ((ProductionEventInquiry) obj)._ProductionEvent) && (object.Equals((object) this._Container, (object) ((ProductionEventInquiry) obj)._Container) && object.Equals((object) this._OccuredToDate, (object) ((ProductionEventInquiry) obj)._OccuredToDate)) && (object.Equals((object) this._ReportFrom, (object) ((ProductionEventInquiry) obj)._ReportFrom) && object.Equals((object) this._ReportTo, (object) ((ProductionEventInquiry) obj)._ReportTo) && (object.Equals((object) this._OccuredFromDate, (object) ((ProductionEventInquiry) obj)._OccuredFromDate) && object.Equals((object) this._ProductRevFilter, (object) ((ProductionEventInquiry) obj)._ProductRevFilter))) && (object.Equals((object) this._ContainerFilter, (object) ((ProductionEventInquiry) obj)._ContainerFilter) && object.Equals((object) this._ProductFilter, (object) ((ProductionEventInquiry) obj)._ProductFilter) && object.Equals((object) this._IdentifierFilter, (object) ((ProductionEventInquiry) obj)._IdentifierFilter)) && base.Equals(obj);
    }

    public NamedObjectRef ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProductionEvent));
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

    public Primitive<DateTime> OccuredToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccuredToDate));
      }
    }

    public Primitive<DateTime> ReportFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFrom), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportFrom));
      }
    }

    public Primitive<DateTime> ReportTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTo), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportTo));
      }
    }

    public Primitive<DateTime> OccuredFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccuredFromDate));
      }
    }

    public Primitive<string> ProductRevFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRevFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRevFilter));
      }
    }

    public Primitive<string> ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public RevisionedObjectRef ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Primitive<string> IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IdentifierFilter));
      }
    }
  }
}
