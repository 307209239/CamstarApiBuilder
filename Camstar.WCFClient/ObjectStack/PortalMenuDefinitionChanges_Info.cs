// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuDefinitionChanges_Info
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
  public class PortalMenuDefinitionChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Info_MenuItems")]
    protected PortalMenuItemChanges_Info _MenuItems;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuDefinitionChanges_Info_Name")]
    protected new Info _Name;

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

    public PortalMenuItemChanges_Info MenuItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItems), (object) value);
      }
      get
      {
        return (PortalMenuItemChanges_Info) this.PropertyGet(nameof (MenuItems));
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
