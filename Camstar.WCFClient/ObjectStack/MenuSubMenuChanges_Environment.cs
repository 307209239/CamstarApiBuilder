// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuSubMenuChanges_Environment
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
  public class MenuSubMenuChanges_Environment : MenuItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Environment_MenuDefinition")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, false, "NamedObjectRef", 1049604, false, false, true, null)]
    protected new Environment _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a Submenu defines a reference to another MenuDefinition.", "MenuSubMenu", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An instance of a Submenu defines a reference to another MenuDefinition.", "MenuSubMenuChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1049809, false, false, false, "2")]
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Environment_MenuItemType")]
    protected new Environment _MenuItemType;

    public new Environment MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuItemType));
      }
    }
  }
}
