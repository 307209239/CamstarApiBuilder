// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TransferRework
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
  public class TransferRework : Rework
  {
    [DataMember(EmitDefaultValue = false, Name = "TransferRework_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;

    public override bool Equals(object obj)
    {
      return obj is TransferRework && object.Equals((object) this._UseDispatch, (object) ((TransferRework) obj)._UseDispatch) && base.Equals(obj);
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }
  }
}
