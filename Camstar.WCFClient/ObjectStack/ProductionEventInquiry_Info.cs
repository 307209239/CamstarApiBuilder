// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionEventInquiry_Info
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
  public class ProductionEventInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ProductionEvent")]
    protected Info _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_OccuredToDate")]
    protected Info _OccuredToDate;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ReportFrom")]
    protected Info _ReportFrom;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ReportTo")]
    protected Info _ReportTo;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_OccuredFromDate")]
    protected Info _OccuredFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ProductRevFilter")]
    protected Info _ProductRevFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ContainerFilter")]
    protected Info _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_ProductFilter")]
    protected Info _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Info_IdentifierFilter")]
    protected Info _IdentifierFilter;

    public Info ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductionEvent));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info OccuredToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccuredToDate));
      }
    }

    public Info ReportFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFrom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportFrom));
      }
    }

    public Info ReportTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportTo));
      }
    }

    public Info OccuredFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccuredFromDate));
      }
    }

    public Info ProductRevFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRevFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRevFilter));
      }
    }

    public Info ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public Info ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Info IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IdentifierFilter));
      }
    }
  }
}
