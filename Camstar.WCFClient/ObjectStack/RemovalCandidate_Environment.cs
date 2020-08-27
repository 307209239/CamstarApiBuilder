// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidate_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalCandidateLotStock_Environment))]
  [KnownType(typeof (RemovalCandidateSerial_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalCandidateQuantity_Environment))]
  [KnownType(typeof (RemovalCandidateBulk_Environment))]
  [KnownType(typeof (RemovalCandidateStock_Environment))]
  [Serializable]
  public class RemovalCandidate_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_IssueActualHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "IssueActualsHistory", 1049872, false, false, false, null)]
    protected IssueActualsHistory_Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_NetQty2Issued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049685, false, false, false, null)]
    protected Environment _NetQty2Issued;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_IssueControl")]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_RemovalDetail")]
    [Metadata("The details of removing a component from a WIP container", "RemovalDetail", false, false, false, "RemovalDetail", 1049873, false, false, false, null)]
    protected RemovalDetail_Environment _RemovalDetail;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_Container")]
    protected Environment _Container;
    [Metadata("Generic String", "", false, false, false, "String", 1050419, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_IssuedFrom")]
    protected Environment _IssuedFrom;
    [Metadata("Generic String", "", false, false, true, "String", 1049491, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_IssueControlName")]
    protected Environment _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_IssuedLocation")]
    [Metadata("Generic String", "", false, false, false, "String", 1050930, false, false, false, null)]
    protected Environment _IssuedLocation;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049451, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_QtyIssued")]
    protected Environment _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_ProductDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1049279, false, false, false, null)]
    protected Environment _ProductDescription;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_Product")]
    protected Environment _Product;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052595, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Environment_NetQtyIssued")]
    protected Environment _NetQtyIssued;

    public IssueActualsHistory_Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Environment NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public RemovalDetail_Environment RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetail_Environment) this.PropertyGet(nameof (RemovalDetail));
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

    public Environment IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Environment IssuedLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedLocation));
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

    public Environment NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQtyIssued));
      }
    }
  }
}
