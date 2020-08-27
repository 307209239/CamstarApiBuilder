// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Associate_Environment
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
  public class Associate_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Associate_Environment_EligibleContainersInquiry")]
    [Metadata("The EligibleContainersInquiry service can be used to retrieve Containers based on a set of eligibility criteria (based on the particular type of service for which the Containers are being selected) and for a set of filtering criteria.", "EligibleContainersInquiry", false, false, false, "EligibleContainersInquiry", 1052664, true, false, false, null)]
    protected EligibleContainersInquiry_Environment _EligibleContainersInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Environment_ChildContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049641, false, true, true, null)]
    protected Environment _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "Associate_Environment_AssociatedContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _AssociatedContainers;

    public EligibleContainersInquiry_Environment EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry_Environment) this.PropertyGet(nameof (EligibleContainersInquiry));
      }
    }

    public Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainers));
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

    public Environment AssociatedContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedContainers));
      }
    }
  }
}
