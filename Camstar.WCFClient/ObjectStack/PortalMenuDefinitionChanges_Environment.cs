// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuDefinitionChanges_Environment
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
  public class PortalMenuDefinitionChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Environment_ObjectToChange")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Environment_MenuItems")]
    [Metadata("An instance of a PortalMenuItem is used to define an entry within a PortalMenuDefinition. Each PortalMenuItem defines either a command to execute or a reference to another PortalMenuDefinition.", "PortalMenuItemChanges", false, false, false, "PortalMenuItemChanges", 1049384, false, true, false, null)]
    protected PortalMenuItemChanges_Environment _MenuItems;
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1052686, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Environment_PortalTab")]
    protected Environment _PortalTab;
    [Metadata("Determines the TabOption when a new page is opened.", "PortalTabOptionEnum", false, false, false, "Integer", 1052707, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Environment_PortalTabOption")]
    protected Environment _PortalTabOption;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050066, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Environment_Name")]
    protected new Environment _Name;

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

    public PortalMenuItemChanges_Environment MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (PortalMenuItemChanges_Environment) this.PropertyGet(nameof (MenuItems));
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
