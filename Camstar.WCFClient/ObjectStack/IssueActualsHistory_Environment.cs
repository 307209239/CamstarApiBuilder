// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (IssueActualsHistoryQuantity_Environment))]
  [KnownType(typeof (IssueActualsHistorySerial_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (IssueActualsHistoryLotStock_Environment))]
  [KnownType(typeof (IssueActualsHistoryBulk_Environment))]
  [KnownType(typeof (IssueActualsHistoryStock_Environment))]
  [Serializable]
  public class IssueActualsHistory_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_IssueDifferenceReason")]
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, true, "NamedObjectRef", 1049467, false, false, false, null)]
    protected Environment _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, false, null)]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_IssueReason")]
    [Metadata("A list of reason codes that describe the purpose of a component issue.", "IssueReason", false, false, false, "NamedObjectRef", 1049455, false, false, false, null)]
    protected Environment _IssueReason;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, false, "NamedObjectRef", 1049453, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_SubstitutionReason")]
    protected Environment _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_Qty2Issued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049452, false, false, false, null)]
    protected Environment _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049704, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ToContainer")]
    protected Environment _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_IssuedFrom")]
    [Metadata("Generic String", "", false, false, true, "String", 1050419, false, false, false, null)]
    protected Environment _IssuedFrom;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052681, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_DefectsRecorded")]
    protected Environment _DefectsRecorded;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051944, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ManualOverride")]
    protected Environment _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_IsAutoWeightEntry")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051930, false, false, false, "0")]
    protected Environment _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049705, false, false, false, null)]
    protected Environment _ToLocation;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1049279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_ProductDescription")]
    protected Environment _ProductDescription;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049564, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_QtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049451, false, false, false, null)]
    protected Environment _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistory_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    protected Environment _Resource;

    public Environment IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDifferenceReason));
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

    public Environment IssueReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueReason));
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

    public Environment SubstitutionReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstitutionReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubstitutionReason));
      }
    }

    public Environment Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Issued));
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

    public Environment ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainer));
      }
    }

    public Environment IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Environment DefectsRecorded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectsRecorded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefectsRecorded));
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

    public Environment ManualOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ManualOverride));
      }
    }

    public Environment IsAutoWeightEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAutoWeightEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAutoWeightEntry));
      }
    }

    public Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public Environment ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductDescription));
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

    public Environment QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
