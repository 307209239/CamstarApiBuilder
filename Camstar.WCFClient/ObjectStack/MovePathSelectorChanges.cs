// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovePathSelectorChanges
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
  public class MovePathSelectorChanges : PathSelectorChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Expression")]
    protected new Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelectorChanges_Path")]
    protected new NamedSubentityRef _Path;

    public override bool Equals(object obj)
    {
      return obj is MovePathSelectorChanges && object.Equals((object) this._Expression, (object) ((MovePathSelectorChanges) obj)._Expression) && object.Equals((object) this._Path, (object) ((MovePathSelectorChanges) obj)._Path) && base.Equals(obj);
    }

    public new Primitive<string> Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Expression));
      }
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
