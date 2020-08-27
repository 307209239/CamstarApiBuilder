// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceInquiry_Environment
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
  public class ComponentReplaceInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, false, false, "IssueDetails", 1049844, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_IssueDetails")]
    protected IssueDetails_Environment _IssueDetails;
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, false, "NamedSubentityRef", 1049462, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_BOMLineItem")]
    protected Environment _BOMLineItem;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16779409, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_Qty2")]
    protected Environment _Qty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1052593, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1052672, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_UOM2")]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_ShowAsBuilt")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779351, false, false, false, "0")]
    protected Environment _ShowAsBuilt;
    [Metadata("Generic String", "", false, false, false, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_ObjectName")]
    protected Environment _ObjectName;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_ParentContainer")]
    protected Environment _ParentContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_Container")]
    protected Environment _Container;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_Qty")]
    protected Environment _Qty;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Environment_Product")]
    protected Environment _Product;

    public IssueDetails_Environment IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (IssueDetails));
      }
    }

    public Environment BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BOMLineItem));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
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

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment ShowAsBuilt
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAsBuilt), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAsBuilt));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Environment ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentContainer));
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
