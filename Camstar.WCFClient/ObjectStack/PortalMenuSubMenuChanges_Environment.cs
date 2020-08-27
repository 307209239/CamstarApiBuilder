// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuSubMenuChanges_Environment
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
  public class PortalMenuSubMenuChanges_Environment : PortalMenuItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a Sub Menu defines a reference to another PortalMenuDefinition.", "PortalMenuSubMenu", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An instance of a Sub Menu defines a reference to another PortalMenuDefinition.", "PortalMenuSubMenuChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface in Liberty.", "PortalMenuDefinition", false, false, false, "NamedObjectRef", 1049604, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuSubMenuChanges_Environment_MenuDefinition")]
    protected Environment _MenuDefinition;

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

    public Environment MenuDefinition
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
  }
}
