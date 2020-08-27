// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgLots_Environment
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
  public class GetMfgLots_Environment : GetMfgData_Environment
  {
    [Metadata("MfgLotDetail", "MfgLotDetail", false, false, true, "MfgLotDetail", 1052006, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_MfgDataDetails")]
    protected MfgLotDetail_Environment _MfgDataDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052515, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_IncludeWhereUsed")]
    protected Environment _IncludeWhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_ToStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052005, false, false, false, null)]
    protected Environment _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_FromStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052004, false, false, false, null)]
    protected Environment _FromStartDate;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_Factory")]
    protected Environment _Factory;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_Operation")]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_WorkCenter")]
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, true, null)]
    protected Environment _WorkCenter;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetMfgLots_Environment_Product")]
    protected Environment _Product;

    public MfgLotDetail_Environment MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgLotDetail_Environment) this.PropertyGet(nameof (MfgDataDetails));
      }
    }

    public Environment IncludeWhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeWhereUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeWhereUsed));
      }
    }

    public Environment ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStartDate));
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

    public Environment FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
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
