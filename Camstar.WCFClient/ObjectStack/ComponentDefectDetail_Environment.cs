// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefectDetail_Environment
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
  public class ComponentDefectDetail_Environment : DefectDetail_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "IssueActualsHistory", 1049764, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_ActualComponentIssue")]
    protected IssueActualsHistory_Environment _ActualComponentIssue;
    [Metadata("The user code for component defect reason.", "ComponentDefectReason", false, true, false, "NamedObjectRef", 1049638, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_ReasonCode")]
    protected new Environment _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_StockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 1049482, false, false, false, null)]
    protected Environment _StockPoint;
    [Metadata("Generic String", "", false, false, false, "String", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_Lot")]
    [Metadata("Generic String", "", false, false, false, "String", 1049485, false, false, false, null)]
    protected Environment _Lot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049484, false, false, true, null)]
    protected new Environment _Container;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectDetail_Environment_Product")]
    protected Environment _Product;

    public IssueActualsHistory_Environment ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (ActualComponentIssue));
      }
    }

    public new Environment ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public Environment ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Environment StockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StockPoint));
      }
    }

    public Environment VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorItem));
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

    public new Environment Container
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
  }
}
