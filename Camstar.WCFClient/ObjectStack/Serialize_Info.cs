// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Serialize_Info
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
  public class Serialize_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ChildUOM")]
    protected Info _ChildUOM;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ChildQty2")]
    protected Info _ChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ChildUOM2")]
    protected Info _ChildUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ServiceDetails")]
    protected SerializeDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ValidateContainerNames")]
    protected Info _ValidateContainerNames;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ActualChildCount")]
    protected Info _ActualChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_Info_ChildQty")]
    protected Info _ChildQty;

    public Info ChildUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildUOM));
      }
    }

    public Info ChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildQty2));
      }
    }

    public Info ChildUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildUOM2));
      }
    }

    public SerializeDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (SerializeDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info ValidateContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateContainerNames), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValidateContainerNames));
      }
    }

    public Info ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public Info ChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildQty));
      }
    }
  }
}
