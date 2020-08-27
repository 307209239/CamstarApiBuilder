// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageRedirectAction
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
  public class UIPageRedirectAction : UIRedirectAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectAction_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageRedirectAction && object.Equals((object) this._UIVirtualPage, (object) ((UIPageRedirectAction) obj)._UIVirtualPage) && object.Equals((object) this._Name, (object) ((UIPageRedirectAction) obj)._Name) && base.Equals(obj);
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
