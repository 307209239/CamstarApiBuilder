// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuChanges_Environment
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
  public class ActionsMenuChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Actions menus are used to create set of items linked to UIVirtualPages.", "ActionsMenu", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_Environment_MenuItems")]
    [Metadata("An instance of a ActionsMenuItemis used to define an entry within a ActionsMenu. Each ActionsMenuItem defines a reference to UIVirtualPage.", "ActionsMenuItemChanges", false, false, false, "ActionsMenuItemChanges", 1052554, false, true, false, null)]
    protected ActionsMenuItemChanges_Environment _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052553, false, false, false, null)]
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

    public ActionsMenuItemChanges_Environment MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (ActionsMenuItemChanges_Environment) this.PropertyGet(nameof (MenuItems));
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
