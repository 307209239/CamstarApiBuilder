// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeSecondaryQty
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
  public class SerializeSecondaryQty : Serialize
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_ChildQty2")]
    protected new Primitive<double> _ChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_ChildUOM2")]
    protected new NamedObjectRef _ChildUOM2;

    public override bool Equals(object obj)
    {
      return obj is SerializeSecondaryQty && object.Equals((object) this._ChildQty2, (object) ((SerializeSecondaryQty) obj)._ChildQty2) && object.Equals((object) this._ChildUOM2, (object) ((SerializeSecondaryQty) obj)._ChildUOM2) && base.Equals(obj);
    }

    public new Primitive<double> ChildQty2
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

    public new NamedObjectRef ChildUOM2
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
  }
}
