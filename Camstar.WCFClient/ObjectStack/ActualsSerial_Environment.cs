// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsSerial_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CompDistributeActualSerial_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ActualsSerial_Environment : IssueActuals_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049452, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_Qty2Issued")]
    protected new Environment _Qty2Issued;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051865, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_FromCarrier")]
    protected Environment _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_FromBatch")]
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1051864, false, false, false, null)]
    protected Environment _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_FromContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049456, false, false, true, null)]
    protected Environment _FromContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049400, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_ToContainer")]
    protected new Environment _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_QtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049451, false, false, false, null)]
    protected new Environment _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    protected new Environment _ToLocation;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049689, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_FromLocation")]
    protected Environment _FromLocation;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Environment_Product")]
    protected new Environment _Product;

    public new Environment Qty2Issued
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

    public Environment FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public Environment FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromBatch));
      }
    }

    public Environment FromContainer
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

    public new Environment QtyIssued
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

    public Environment FromLocation
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

    public new Environment Product
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
