// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPortalProfileChanges_Environment
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
  public class UIPortalProfileChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_MasterPage")]
    [Metadata("URL", "", false, false, false, "String", 1051551, false, false, false, null)]
    protected Environment _MasterPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_PortalHomePage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051760, false, false, true, null)]
    protected Environment _PortalHomePage;
    [Metadata("User preferences for Camstar Portal UI", "UIPortalProfileChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("User preferences for Camstar Portal UI", "UIPortalProfile", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_PortalMobileHomePage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 16779348, false, false, true, null)]
    protected Environment _PortalMobileHomePage;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051552, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_Theme")]
    protected Environment _Theme;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment MasterPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterPage));
      }
    }

    public Environment PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalHomePage));
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

    public Environment PortalMobileHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileHomePage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalMobileHomePage));
      }
    }

    public Environment Theme
    {
      [param: In] set
      {
        this.PropertySet(nameof (Theme), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Theme));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
