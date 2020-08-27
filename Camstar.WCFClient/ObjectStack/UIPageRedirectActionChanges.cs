// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageRedirectActionChanges
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
  public class UIPageRedirectActionChanges : UIRedirectActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageRedirectActionChanges && object.Equals((object) this._ListItemToChange, (object) ((UIPageRedirectActionChanges) obj)._ListItemToChange) && (object.Equals((object) this._UIVirtualPage, (object) ((UIPageRedirectActionChanges) obj)._UIVirtualPage) && object.Equals((object) this._ObjectToChange, (object) ((UIPageRedirectActionChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((UIPageRedirectActionChanges) obj)._Name) && base.Equals(obj);
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
