// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssue_Environment
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
  public class ComponentIssue_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_ServiceDetails")]
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, true, false, "IssueDetails", 1049643, false, true, false, null)]
    protected IssueDetails_Environment _ServiceDetails;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_Carrier")]
    protected new Environment _Carrier;
    [Metadata("This field can be used to send in a single, flat issued component to the service.  Prior to any other processing for the service, the appropriate requirement will be retrieved, and an issue detail/issue actual will be built from the requirement/issued component in the normal format of the service.\r\nIt is expected that this field would be useful for the case that only one issued component is passed in, or where the service is running from an interface that doesn't provide state management for the requirements.\r\n", "IssueActualDetail", false, false, false, "IssueActualDetail", 1052597, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_IssueActualDetails")]
    protected IssueActualDetail_Environment _IssueActualDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049449, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_BillControl")]
    protected Environment _BillControl;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssue_Environment_Operation")]
    protected new Environment _Operation;

    public IssueDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public IssueActualDetail_Environment IssueActualDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualDetails), (object) value);
      }
      get
      {
        return (IssueActualDetail_Environment) this.PropertyGet(nameof (IssueActualDetails));
      }
    }

    public Environment AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowZeroQtys));
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

    public Environment BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillControl));
      }
    }

    public new Environment Operation
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
  }
}
