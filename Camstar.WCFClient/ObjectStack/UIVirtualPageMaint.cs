// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPageMaint
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
  public class UIVirtualPageMaint : UIProviderComponentMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_ContentAction")]
    protected Enumeration<ContentActionEnum, int> _ContentAction;
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_ObjectChanges")]
    protected UIVirtualPageChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is UIVirtualPageMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((UIVirtualPageMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((UIVirtualPageMaint) obj)._ObjectToChange) && object.Equals((object) this._ContentAction, (object) ((UIVirtualPageMaint) obj)._ContentAction)) && object.Equals((object) this._ObjectChanges, (object) ((UIVirtualPageMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<ContentActionEnum, int> ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Enumeration<ContentActionEnum, int>) this.PropertyGet(nameof (ContentAction));
      }
    }

    public UIVirtualPageChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UIVirtualPageChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
