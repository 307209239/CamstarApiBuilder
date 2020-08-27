// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MovePathSelector
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
  public class MovePathSelector : PathSelector
  {
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_Expression")]
    protected new Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_Path")]
    protected new NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "MovePathSelector_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is MovePathSelector && object.Equals((object) this._Expression, (object) ((MovePathSelector) obj)._Expression) && (object.Equals((object) this._Path, (object) ((MovePathSelector) obj)._Path) && object.Equals((object) this._IsFrozen, (object) ((MovePathSelector) obj)._IsFrozen)) && base.Equals(obj);
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
