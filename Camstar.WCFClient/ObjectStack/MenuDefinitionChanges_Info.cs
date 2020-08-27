// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuDefinitionChanges_Info
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
  public class MenuDefinitionChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_MenuItems")]
    protected MenuItemChanges_Info _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_CategoryId")]
    protected Info _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_MenuItemProxy")]
    protected MenuItemChanges_Info _MenuItemProxy;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "MenuDefinitionChanges_Info_Name")]
    protected new Info _Name;

    public MenuItemChanges_Info MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (MenuItemChanges_Info) this.PropertyGet(nameof (MenuItems));
      }
    }

    public Info CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryId));
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

    public MenuItemChanges_Info MenuItemProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemProxy), (object) value);
      }
      get
      {
        return (MenuItemChanges_Info) this.PropertyGet(nameof (MenuItemProxy));
      }
    }

    public Info PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Info PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
