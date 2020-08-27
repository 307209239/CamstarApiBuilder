// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageOpenActionChanges
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
  public class UIFloatPageOpenActionChanges : UIActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_DataContractMap")]
    protected UITargetLinkChanges[] _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_InitContractHandler")]
    protected Primitive<string> _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_ButtonsLayout")]
    protected UIFloatPageLayoutChanges _ButtonsLayout;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_FrameLocation")]
    protected UIFloatPageLocationChanges _FrameLocation;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_ExecuteOnSubmit")]
    protected Primitive<bool> _ExecuteOnSubmit;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_ShowButtons")]
    protected Primitive<bool> _ShowButtons;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_CloseButtonOnly")]
    protected Primitive<bool> _CloseButtonOnly;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageOpenActionChanges && this.CompareArrays((Array) this._DataContractMap, (Array) ((UIFloatPageOpenActionChanges) obj)._DataContractMap) && (object.Equals((object) this._ListItemToChange, (object) ((UIFloatPageOpenActionChanges) obj)._ListItemToChange) && object.Equals((object) this._InitContractHandler, (object) ((UIFloatPageOpenActionChanges) obj)._InitContractHandler)) && (object.Equals((object) this._ButtonsLayout, (object) ((UIFloatPageOpenActionChanges) obj)._ButtonsLayout) && object.Equals((object) this._UIVirtualPage, (object) ((UIFloatPageOpenActionChanges) obj)._UIVirtualPage) && (object.Equals((object) this._FrameLocation, (object) ((UIFloatPageOpenActionChanges) obj)._FrameLocation) && object.Equals((object) this._ObjectToChange, (object) ((UIFloatPageOpenActionChanges) obj)._ObjectToChange))) && (object.Equals((object) this._ExecuteOnSubmit, (object) ((UIFloatPageOpenActionChanges) obj)._ExecuteOnSubmit) && object.Equals((object) this._ShowButtons, (object) ((UIFloatPageOpenActionChanges) obj)._ShowButtons) && (object.Equals((object) this._CloseButtonOnly, (object) ((UIFloatPageOpenActionChanges) obj)._CloseButtonOnly) && object.Equals((object) this._Name, (object) ((UIFloatPageOpenActionChanges) obj)._Name))) && base.Equals(obj);
    }

    public UITargetLinkChanges[] DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges[]) this.PropertyGet(nameof (DataContractMap));
      }
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

    public Primitive<string> InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InitContractHandler));
      }
    }

    public UIFloatPageLayoutChanges ButtonsLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonsLayout), (object) value);
      }
      get
      {
        return (UIFloatPageLayoutChanges) this.PropertyGet(nameof (ButtonsLayout));
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

    public UIFloatPageLocationChanges FrameLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FrameLocation), (object) value);
      }
      get
      {
        return (UIFloatPageLocationChanges) this.PropertyGet(nameof (FrameLocation));
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

    public Primitive<bool> ExecuteOnSubmit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteOnSubmit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ExecuteOnSubmit));
      }
    }

    public Primitive<bool> ShowButtons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowButtons), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowButtons));
      }
    }

    public Primitive<bool> CloseButtonOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButtonOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseButtonOnly));
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
