// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPortalProfileChanges_Info
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
  public class UIPortalProfileChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_MasterPage")]
    protected Info _MasterPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_PortalHomePage")]
    protected Info _PortalHomePage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_PortalMobileHomePage")]
    protected Info _PortalMobileHomePage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_Theme")]
    protected Info _Theme;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info MasterPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterPage));
      }
    }

    public Info PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalHomePage));
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

    public Info PortalMobileHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileHomePage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalMobileHomePage));
      }
    }

    public Info Theme
    {
      [param: In] set
      {
        this.PropertySet(nameof (Theme), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Theme));
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
