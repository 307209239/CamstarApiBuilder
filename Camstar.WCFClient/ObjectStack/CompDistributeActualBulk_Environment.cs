// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeActualBulk_Environment
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
  public class CompDistributeActualBulk_Environment : ActualsBulk_Environment
  {
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Environment_Vendor")]
    protected new Environment _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Environment_FromContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049456, false, false, true, null)]
    protected new Environment _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Environment_ToContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049400, false, false, true, null)]
    protected new Environment _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    protected new Environment _ToLocation;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049689, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Environment_FromLocation")]
    protected new Environment _FromLocation;

    public new Environment Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Vendor));
      }
    }

    public new Environment FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromContainer));
      }
    }

    public new Environment ToContainer
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

    public new Environment ToLocation
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

    public new Environment FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}
