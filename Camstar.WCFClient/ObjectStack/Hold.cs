// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Hold
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
  public class Hold : HoldStatusTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Hold_HoldReason")]
    protected new NamedObjectRef _HoldReason;

    public override bool Equals(object obj)
    {
      return obj is Hold && object.Equals((object) this._HoldReason, (object) ((Hold) obj)._HoldReason) && base.Equals(obj);
    }

    public new NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }
  }
}
