// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrierHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EmptyMaterialContainerHistory))]
  [Serializable]
  public class EmptyCarrierHistory : QtyHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierHistory_Carrier")]
    protected NamedObjectRef _Carrier;

    public override bool Equals(object obj)
    {
      return obj is EmptyCarrierHistory && object.Equals((object) this._Carrier, (object) ((EmptyCarrierHistory) obj)._Carrier) && base.Equals(obj);
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }
  }
}
