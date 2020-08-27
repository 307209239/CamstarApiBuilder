// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathSelectorChanges
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
  public class ReworkPathSelectorChanges : PathSelectorChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathSelectorChanges_Path")]
    protected new NamedSubentityRef _Path;

    public override bool Equals(object obj)
    {
      return obj is ReworkPathSelectorChanges && object.Equals((object) this._Path, (object) ((ReworkPathSelectorChanges) obj)._Path) && base.Equals(obj);
    }

    public new NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
      }
    }
  }
}
