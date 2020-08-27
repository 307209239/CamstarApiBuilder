// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuDefinitionChanges
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
  public class MenuDefinitionChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_MenuItems")]
    protected MenuItemChanges[] _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_CategoryId")]
    protected Enumeration<MenuCategoryEnum, int> _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_MenuItemProxy")]
    protected MenuItemChanges _MenuItemProxy;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_PortalTabOption")]
    protected Enumeration<PortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is MenuDefinitionChanges && this.CompareArrays((Array) this._MenuItems, (Array) ((MenuDefinitionChanges) obj)._MenuItems) && (object.Equals((object) this._CategoryId, (object) ((MenuDefinitionChanges) obj)._CategoryId) && object.Equals((object) this._ObjectToChange, (object) ((MenuDefinitionChanges) obj)._ObjectToChange)) && (object.Equals((object) this._MenuItemProxy, (object) ((MenuDefinitionChanges) obj)._MenuItemProxy) && object.Equals((object) this._PortalTab, (object) ((MenuDefinitionChanges) obj)._PortalTab) && (object.Equals((object) this._PortalTabOption, (object) ((MenuDefinitionChanges) obj)._PortalTabOption) && object.Equals((object) this._Name, (object) ((MenuDefinitionChanges) obj)._Name))) && base.Equals(obj);
    }

    public MenuItemChanges[] MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (MenuItemChanges[]) this.PropertyGet(nameof (MenuItems));
      }
    }

    public Enumeration<MenuCategoryEnum, int> CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Enumeration<MenuCategoryEnum, int>) this.PropertyGet(nameof (CategoryId));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public MenuItemChanges MenuItemProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemProxy), (object) value);
      }
      get
      {
        return (MenuItemChanges) this.PropertyGet(nameof (MenuItemProxy));
      }
    }

    public NamedObjectRef PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Enumeration<PortalTabOptionEnum, int> PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Enumeration<PortalTabOptionEnum, int>) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
