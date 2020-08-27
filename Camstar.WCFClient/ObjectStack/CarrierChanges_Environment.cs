// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CarrierChanges_Environment
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
  public class CarrierChanges_Environment : ResourceChanges_Environment
  {
    [Metadata("Carrier Family is used to differentiate between types of Carriers such as 100 L Drum, Glass Tray, Metallic Tray, etc.", "CarrierFamily", false, false, false, "NamedObjectRef", 1052143, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Environment_ResourceFamily")]
    protected new Environment _ResourceFamily;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1052110, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Environment_ChildResources")]
    protected new Environment _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Environment_ParentResource")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1052109, false, false, true, null)]
    protected new Environment _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Environment_ObjectToChange")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051801, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public new Environment ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new Environment ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentResource));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
