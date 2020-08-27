// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionEventInquiry_Environment
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
  public class ProductionEventInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ProductionEvent")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1052906, false, false, true, null)]
    protected Environment _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_OccuredToDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052905, false, false, false, null)]
    protected Environment _OccuredToDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052902, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ReportFrom")]
    protected Environment _ReportFrom;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052903, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ReportTo")]
    protected Environment _ReportTo;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_OccuredFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052904, false, false, false, null)]
    protected Environment _OccuredFromDate;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ProductRevFilter")]
    protected Environment _ProductRevFilter;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ContainerFilter")]
    protected Environment _ContainerFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_ProductFilter")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ProductionEventInquiry_Environment_IdentifierFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052901, false, false, true, null)]
    protected Environment _IdentifierFilter;

    public Environment ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductionEvent));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment OccuredToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredToDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccuredToDate));
      }
    }

    public Environment ReportFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFrom), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportFrom));
      }
    }

    public Environment ReportTo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportTo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportTo));
      }
    }

    public Environment OccuredFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccuredFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccuredFromDate));
      }
    }

    public Environment ProductRevFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRevFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRevFilter));
      }
    }

    public Environment ContainerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerFilter));
      }
    }

    public Environment ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductFilter));
      }
    }

    public Environment IdentifierFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IdentifierFilter));
      }
    }
  }
}
