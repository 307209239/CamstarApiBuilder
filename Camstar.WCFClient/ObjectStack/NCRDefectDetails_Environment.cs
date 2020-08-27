// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRDefectDetails_Environment
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
  public class NCRDefectDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "SubentityRef", 1049764, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_ActualComponentIssue")]
    protected Environment _ActualComponentIssue;
    [Metadata("The NCRDefectData represents all of the tracked and untracked components have been marked in the EventLotDetails.", "NCRDefectData", false, false, false, "SubentityRef", 1052533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_NCRDefectData")]
    protected Environment _NCRDefectData;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_Container")]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_IsDefect")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052534, false, false, false, "0")]
    protected Environment _IsDefect;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_Lot")]
    [Metadata("Generic String", "", false, false, false, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_ReferenceDesignator")]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "NCRDefectDetails_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;

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

    public Environment NCRDefectData
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRDefectData));
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

    public Environment IsDefect
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefect), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDefect));
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
