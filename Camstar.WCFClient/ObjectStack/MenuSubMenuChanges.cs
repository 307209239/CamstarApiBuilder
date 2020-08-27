// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuSubMenuChanges
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
  public class MenuSubMenuChanges : MenuItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_MenuDefinition")]
    protected new NamedObjectRef _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_MenuItemType")]
    protected new Primitive<int> _MenuItemType;

    public override bool Equals(object obj)
    {
      return obj is MenuSubMenuChanges && object.Equals((object) this._MenuDefinition, (object) ((MenuSubMenuChanges) obj)._MenuDefinition) && (object.Equals((object) this._ObjectToChange, (object) ((MenuSubMenuChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((MenuSubMenuChanges) obj)._ListItemToChange)) && object.Equals((object) this._MenuItemType, (object) ((MenuSubMenuChanges) obj)._MenuItemType) && base.Equals(obj);
    }

    public new NamedObjectRef MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MenuDefinition));
      }
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

    public new Primitive<int> MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MenuItemType));
      }
    }
  }
}
