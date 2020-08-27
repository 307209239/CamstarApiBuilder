// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Open
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
  public class Open : ContainerStatusChange
  {
    [DataMember(EmitDefaultValue = false, Name = "Open_IncludeChildren")]
    protected new Primitive<bool> _IncludeChildren;

    public override bool Equals(object obj)
    {
      return obj is Open && object.Equals((object) this._IncludeChildren, (object) ((Open) obj)._IncludeChildren) && base.Equals(obj);
    }

    public new Primitive<bool> IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
