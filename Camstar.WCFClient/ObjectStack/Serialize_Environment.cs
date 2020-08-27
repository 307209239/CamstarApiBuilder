// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Serialize_Environment
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
  public class Serialize_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ChildUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049881, false, false, true, null)]
    protected Environment _ChildUOM;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049880, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ChildQty2")]
    protected Environment _ChildQty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049882, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ChildUOM2")]
    protected Environment _ChildUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ServiceDetails")]
    [Metadata("Details required for Serializing Containers", "SerializeDetails", false, false, false, "SerializeDetails", 1049843, false, true, false, null)]
    protected SerializeDetails_Environment _ServiceDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049883, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ValidateContainerNames")]
    protected Environment _ValidateContainerNames;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049878, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ActualChildCount")]
    protected Environment _ActualChildCount;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049879, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Environment_ChildQty")]
    protected Environment _ChildQty;

    public Environment ChildUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildUOM));
      }
    }

    public Environment ChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildQty2));
      }
    }

    public Environment ChildUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildUOM2));
      }
    }

    public SerializeDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (SerializeDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment ValidateContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateContainerNames), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidateContainerNames));
      }
    }

    public Environment ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public Environment ChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildQty));
      }
    }
  }
}
