// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CombineFromDetail_Environment
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
  public class CombineFromDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_Qty2")]
    protected Environment _Qty2;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049402, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_CloseWhenEmpty")]
    protected Environment _CloseWhenEmpty;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049409, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_CombineAllQty")]
    protected Environment _CombineAllQty;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_ChildContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048769, false, true, true, null)]
    protected Environment _ChildContainers;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049397, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_FromContainer")]
    protected Environment _FromContainer;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_UOMName")]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
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

    public Environment CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Environment CombineAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CombineAllQty));
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

    public Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
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
