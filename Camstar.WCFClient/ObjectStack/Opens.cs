// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Opens
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
  public class Opens : ContainerStatusChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "Opens_Services")]
    protected Open[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "Opens_IncludeChildren")]
    protected new Primitive<bool> _IncludeChildren;

    public override bool Equals(object obj)
    {
      return obj is Opens && this.CompareArrays((Array) this._Services, (Array) ((Opens) obj)._Services) && object.Equals((object) this._IncludeChildren, (object) ((Opens) obj)._IncludeChildren) && base.Equals(obj);
    }

    public Open[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Open[]) this.PropertyGet(nameof (Services));
      }
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
