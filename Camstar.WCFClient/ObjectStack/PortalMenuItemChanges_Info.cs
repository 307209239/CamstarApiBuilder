// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PortalMenuCommandChanges_Info))]
  [KnownType(typeof (PortalMenuSubMenuChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PortalMenuItemChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_LabelName")]
    protected Info _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_Caption")]
    protected Info _Caption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelName));
      }
    }

    public Info Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Caption));
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

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
