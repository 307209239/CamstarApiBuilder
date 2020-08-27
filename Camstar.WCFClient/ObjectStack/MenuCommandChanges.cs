// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuCommandChanges
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
  public class MenuCommandChanges : MenuItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuCommandChanges_Sequence")]
    protected new Primitive<int> _Sequence;

    public override bool Equals(object obj)
    {
      return obj is MenuCommandChanges && object.Equals((object) this._ObjectToChange, (object) ((MenuCommandChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((MenuCommandChanges) obj)._ListItemToChange) && object.Equals((object) this._Sequence, (object) ((MenuCommandChanges) obj)._Sequence)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }
  }
}
