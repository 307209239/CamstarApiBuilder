// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenProcessObject
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
  public class OpenProcessObject : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObject_ChildOpenOption")]
    protected Enumeration<ChildOpenOptionEnum, int> _ChildOpenOption;

    public override bool Equals(object obj)
    {
      return obj is OpenProcessObject && object.Equals((object) this._ChildOpenOption, (object) ((OpenProcessObject) obj)._ChildOpenOption) && base.Equals(obj);
    }

    public Enumeration<ChildOpenOptionEnum, int> ChildOpenOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildOpenOption), (object) value);
      }
      get
      {
        return (Enumeration<ChildOpenOptionEnum, int>) this.PropertyGet(nameof (ChildOpenOption));
      }
    }
  }
}
