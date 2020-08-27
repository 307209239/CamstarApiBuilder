// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Serialize
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
  public class Serialize : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ChildUOM")]
    protected NamedObjectRef _ChildUOM;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ChildQty2")]
    protected Primitive<double> _ChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ChildUOM2")]
    protected NamedObjectRef _ChildUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ServiceDetails")]
    protected SerializeDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ValidateContainerNames")]
    protected Primitive<bool> _ValidateContainerNames;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ActualChildCount")]
    protected Primitive<int> _ActualChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Serialize_ChildQty")]
    protected Primitive<double> _ChildQty;

    public override bool Equals(object obj)
    {
      return obj is Serialize && object.Equals((object) this._ChildUOM, (object) ((Serialize) obj)._ChildUOM) && (object.Equals((object) this._ChildQty2, (object) ((Serialize) obj)._ChildQty2) && object.Equals((object) this._ChildUOM2, (object) ((Serialize) obj)._ChildUOM2)) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((Serialize) obj)._ServiceDetails) && object.Equals((object) this._ValidateContainerNames, (object) ((Serialize) obj)._ValidateContainerNames) && (object.Equals((object) this._ActualChildCount, (object) ((Serialize) obj)._ActualChildCount) && object.Equals((object) this._ChildQty, (object) ((Serialize) obj)._ChildQty))) && base.Equals(obj);
    }

    public NamedObjectRef ChildUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChildUOM));
      }
    }

    public Primitive<double> ChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ChildQty2));
      }
    }

    public NamedObjectRef ChildUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChildUOM2));
      }
    }

    public SerializeDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (SerializeDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<bool> ValidateContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidateContainerNames), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ValidateContainerNames));
      }
    }

    public Primitive<int> ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public Primitive<double> ChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ChildQty));
      }
    }
  }
}
