// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPortalProfileChanges
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
  public class UIPortalProfileChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_MasterPage")]
    protected Primitive<string> _MasterPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_PortalHomePage")]
    protected NamedObjectRef _PortalHomePage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_PortalMobileHomePage")]
    protected NamedObjectRef _PortalMobileHomePage;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_Theme")]
    protected Primitive<string> _Theme;
    [DataMember(EmitDefaultValue = false, Name = "UIPortalProfileChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIPortalProfileChanges && object.Equals((object) this._MasterPage, (object) ((UIPortalProfileChanges) obj)._MasterPage) && (object.Equals((object) this._PortalHomePage, (object) ((UIPortalProfileChanges) obj)._PortalHomePage) && object.Equals((object) this._ListItemToChange, (object) ((UIPortalProfileChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((UIPortalProfileChanges) obj)._ObjectToChange) && object.Equals((object) this._PortalMobileHomePage, (object) ((UIPortalProfileChanges) obj)._PortalMobileHomePage) && (object.Equals((object) this._Theme, (object) ((UIPortalProfileChanges) obj)._Theme) && object.Equals((object) this._IsFrozen, (object) ((UIPortalProfileChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public Primitive<string> MasterPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterPage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MasterPage));
      }
    }

    public NamedObjectRef PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalHomePage));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef PortalMobileHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalMobileHomePage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalMobileHomePage));
      }
    }

    public Primitive<string> Theme
    {
      [param: In] set
      {
        this.PropertySet(nameof (Theme), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Theme));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
