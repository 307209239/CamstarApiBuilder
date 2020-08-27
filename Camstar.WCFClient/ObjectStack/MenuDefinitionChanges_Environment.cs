// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuDefinitionChanges_Environment
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
  public class MenuDefinitionChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("An instance of a MenuItem is used to define an entry within a MenuDefinition. Each MenuItem defines either a command to execute or a reference to another MenuDefinition.", "MenuItemChanges", false, false, false, "MenuItemChanges", 1049384, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_MenuItems")]
    protected MenuItemChanges_Environment _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_CategoryId")]
    [Metadata("MenuCategoryId -- used to determine which general UI style to follow.\r\n\r\nValid values and their meanings are:\r\n1 = Container Transactions\r\n2 = Resource Transactions\r\n3 = Inquiry Transactions\r\n4 = Query Transactions", "MenuCategoryEnum", false, false, false, "Integer", 1049636, false, false, true, null)]
    protected Environment _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_ObjectToChange")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_MenuItemProxy")]
    [Metadata("An instance of a MenuItem is used to define an entry within a MenuDefinition. Each MenuItem defines either a command to execute or a reference to another MenuDefinition.", "MenuItemChanges", false, false, false, "MenuItemChanges", 1049808, true, false, false, null)]
    protected MenuItemChanges_Environment _MenuItemProxy;
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1052686, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_PortalTab")]
    protected Environment _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_PortalTabOption")]
    [Metadata("Determines the TabOption when a new page is opened.", "PortalTabOptionEnum", false, false, false, "Integer", 1052707, false, false, true, null)]
    protected Environment _PortalTabOption;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050066, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Environment_Name")]
    protected new Environment _Name;

    public MenuItemChanges_Environment MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (MenuItemChanges_Environment) this.PropertyGet(nameof (MenuItems));
      }
    }

    public Environment CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryId));
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

    public MenuItemChanges_Environment MenuItemProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemProxy), (object) value);
      }
      get
      {
        return (MenuItemChanges_Environment) this.PropertyGet(nameof (MenuItemProxy));
      }
    }

    public Environment PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Environment PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
