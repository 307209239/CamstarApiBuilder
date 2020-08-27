// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDefectHistoryDetail_Environment
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
  public class ComponentDefectHistoryDetail_Environment : DefectHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_ReasonCode")]
    [Metadata("The user code for component defect reason.", "ComponentDefectReason", false, false, false, "NamedObjectRef", 1049479, false, false, false, null)]
    protected new Environment _ReasonCode;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_ActualComponentIssue")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "SubentityRef", 1049764, false, false, false, null)]
    protected Environment _ActualComponentIssue;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_StockPoint")]
    [Metadata("Generic String", "", false, false, true, "String", 1049482, false, false, false, null)]
    protected Environment _StockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, true, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [Metadata("Generic String", "", false, false, true, "String", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_Lot")]
    [Metadata("Generic String", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048790, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_DefectCount")]
    protected new Environment _DefectCount;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049480, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_Comment")]
    protected new Environment _Comment;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDefectHistoryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;

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

    public Environment ActualComponentIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualComponentIssue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualComponentIssue));
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

    public new Environment DefectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefectCount));
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

    public new Environment Comment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comment));
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
