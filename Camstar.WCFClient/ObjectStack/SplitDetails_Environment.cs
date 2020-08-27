// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitDetails_Environment
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
  public class SplitDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_AttributeChanges")]
    [Metadata("Contains information on a container field that is to be updated. Base CDO for those field type specific detail CDOs with  new value for the container field.", "ChangeAttributeDetails", false, false, false, "SubentityRef", 1049404, false, true, false, null)]
    protected Environment _AttributeChanges;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_ToContainerName")]
    [Metadata("Generic String", "", false, false, false, "String", 1048741, false, false, false, null)]
    protected Environment _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_ToContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049400, false, false, true, null)]
    protected Environment _ToContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048769, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_ChildContainers")]
    protected Environment _ChildContainers;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_AdjustThruput")]
    protected Environment _AdjustThruput;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SplitDetails_Environment_Qty")]
    protected Environment _Qty;

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

    public Environment AttributeChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeChanges), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeChanges));
      }
    }

    public Environment ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainerName));
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

    public Environment AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdjustThruput));
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
  }
}
