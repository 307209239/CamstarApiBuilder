// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializePrimaryQty
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
  public class SerializePrimaryQty : Serialize
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_ChildUOM")]
    protected new NamedObjectRef _ChildUOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_ChildQty")]
    protected new Primitive<double> _ChildQty;

    public override bool Equals(object obj)
    {
      return obj is SerializePrimaryQty && object.Equals((object) this._ChildUOM, (object) ((SerializePrimaryQty) obj)._ChildUOM) && object.Equals((object) this._ChildQty, (object) ((SerializePrimaryQty) obj)._ChildQty) && base.Equals(obj);
    }

    public new NamedObjectRef ChildUOM
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

    public new Primitive<double> ChildQty
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
