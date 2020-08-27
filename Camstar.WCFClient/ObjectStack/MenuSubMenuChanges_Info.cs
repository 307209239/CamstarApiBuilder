// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuSubMenuChanges_Info
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
  public class MenuSubMenuChanges_Info : MenuItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Info_MenuDefinition")]
    protected new Info _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuSubMenuChanges_Info_MenuItemType")]
    protected new Info _MenuItemType;

    public new Info MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuItemType));
      }
    }
  }
}
