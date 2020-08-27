// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIProviderComponentInquiry
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
  public class UIProviderComponentInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_ActivityGUID")]
    protected Primitive<string> _ActivityGUID;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_VirtualPageName")]
    protected Primitive<string> _VirtualPageName;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_SharedContent")]
    protected Primitive<string> _SharedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_RequestedContent")]
    protected Primitive<string> _RequestedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_StateGUID")]
    protected Primitive<string> _StateGUID;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_UIVirtualPage")]
    protected UIVirtualPage _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_UIVirtualPageRef")]
    protected NamedObjectRef _UIVirtualPageRef;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_UserPersonalization")]
    protected UIPersonalization _UserPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_UIMode")]
    protected Enumeration<UIModeEnum, int> _UIMode;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_PersonalizationIndex")]
    protected Primitive<int> _PersonalizationIndex;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_PageFlowName")]
    protected Primitive<string> _PageFlowName;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_OwnerName")]
    protected Primitive<string> _OwnerName;

    public override bool Equals(object obj)
    {
      return obj is UIProviderComponentInquiry && object.Equals((object) this._ActivityGUID, (object) ((UIProviderComponentInquiry) obj)._ActivityGUID) && (object.Equals((object) this._VirtualPageName, (object) ((UIProviderComponentInquiry) obj)._VirtualPageName) && object.Equals((object) this._SharedContent, (object) ((UIProviderComponentInquiry) obj)._SharedContent)) && (object.Equals((object) this._RequestedContent, (object) ((UIProviderComponentInquiry) obj)._RequestedContent) && object.Equals((object) this._StateGUID, (object) ((UIProviderComponentInquiry) obj)._StateGUID) && (object.Equals((object) this._UIVirtualPage, (object) ((UIProviderComponentInquiry) obj)._UIVirtualPage) && object.Equals((object) this._UIVirtualPageRef, (object) ((UIProviderComponentInquiry) obj)._UIVirtualPageRef))) && (object.Equals((object) this._UserPersonalization, (object) ((UIProviderComponentInquiry) obj)._UserPersonalization) && object.Equals((object) this._UIMode, (object) ((UIProviderComponentInquiry) obj)._UIMode) && (object.Equals((object) this._PersonalizationIndex, (object) ((UIProviderComponentInquiry) obj)._PersonalizationIndex) && object.Equals((object) this._Owner, (object) ((UIProviderComponentInquiry) obj)._Owner)) && (object.Equals((object) this._PageFlowName, (object) ((UIProviderComponentInquiry) obj)._PageFlowName) && object.Equals((object) this._OwnerName, (object) ((UIProviderComponentInquiry) obj)._OwnerName))) && base.Equals(obj);
    }

    public Primitive<string> ActivityGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityGUID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ActivityGUID));
      }
    }

    public Primitive<string> VirtualPageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (VirtualPageName));
      }
    }

    public Primitive<string> SharedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (SharedContent), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SharedContent));
      }
    }

    public Primitive<string> RequestedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestedContent), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RequestedContent));
      }
    }

    public Primitive<string> StateGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (StateGUID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StateGUID));
      }
    }

    public UIVirtualPage UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (UIVirtualPage) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public NamedObjectRef UIVirtualPageRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPageRef), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIVirtualPageRef));
      }
    }

    public UIPersonalization UserPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalization) this.PropertyGet(nameof (UserPersonalization));
      }
    }

    public Enumeration<UIModeEnum, int> UIMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIMode), (object) value);
      }
      get
      {
        return (Enumeration<UIModeEnum, int>) this.PropertyGet(nameof (UIMode));
      }
    }

    public Primitive<int> PersonalizationIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (PersonalizationIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PersonalizationIndex));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public Primitive<string> PageFlowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PageFlowName));
      }
    }

    public Primitive<string> OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OwnerName));
      }
    }
  }
}
