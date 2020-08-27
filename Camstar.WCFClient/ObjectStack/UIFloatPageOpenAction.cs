// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageOpenAction
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
  public class UIFloatPageOpenAction : UIAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_ButtonsLayout")]
    protected UIFloatPageLayout _ButtonsLayout;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_InitContractHandler")]
    protected Primitive<string> _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_DataContractMap")]
    protected UITargetLink[] _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_FrameLocation")]
    protected UIFloatPageLocation _FrameLocation;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_ExecuteOnSubmit")]
    protected Primitive<bool> _ExecuteOnSubmit;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_ShowButtons")]
    protected Primitive<bool> _ShowButtons;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_CloseButtonOnly")]
    protected Primitive<bool> _CloseButtonOnly;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageOpenAction && object.Equals((object) this._ButtonsLayout, (object) ((UIFloatPageOpenAction) obj)._ButtonsLayout) && (object.Equals((object) this._UIVirtualPage, (object) ((UIFloatPageOpenAction) obj)._UIVirtualPage) && object.Equals((object) this._InitContractHandler, (object) ((UIFloatPageOpenAction) obj)._InitContractHandler)) && (this.CompareArrays((Array) this._DataContractMap, (Array) ((UIFloatPageOpenAction) obj)._DataContractMap) && object.Equals((object) this._FrameLocation, (object) ((UIFloatPageOpenAction) obj)._FrameLocation) && (object.Equals((object) this._ExecuteOnSubmit, (object) ((UIFloatPageOpenAction) obj)._ExecuteOnSubmit) && object.Equals((object) this._ShowButtons, (object) ((UIFloatPageOpenAction) obj)._ShowButtons))) && (object.Equals((object) this._CloseButtonOnly, (object) ((UIFloatPageOpenAction) obj)._CloseButtonOnly) && object.Equals((object) this._Name, (object) ((UIFloatPageOpenAction) obj)._Name)) && base.Equals(obj);
    }

    public UIFloatPageLayout ButtonsLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonsLayout), (object) value);
      }
      get
      {
        return (UIFloatPageLayout) this.PropertyGet(nameof (ButtonsLayout));
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

    public UITargetLink[] DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLink[]) this.PropertyGet(nameof (DataContractMap));
      }
    }

    public UIFloatPageLocation FrameLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FrameLocation), (object) value);
      }
      get
      {
        return (UIFloatPageLocation) this.PropertyGet(nameof (FrameLocation));
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
