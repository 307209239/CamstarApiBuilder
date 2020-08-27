// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageOpenActionChanges_Info
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
  public class UIFloatPageOpenActionChanges_Info : UIActionChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_DataContractMap")]
    protected UITargetLinkChanges_Info _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_InitContractHandler")]
    protected Info _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_ButtonsLayout")]
    protected UIFloatPageLayoutChanges_Info _ButtonsLayout;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_UIVirtualPage")]
    protected Info _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_FrameLocation")]
    protected UIFloatPageLocationChanges_Info _FrameLocation;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_ExecuteOnSubmit")]
    protected Info _ExecuteOnSubmit;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_ShowButtons")]
    protected Info _ShowButtons;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_CloseButtonOnly")]
    protected Info _CloseButtonOnly;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Info_Name")]
    protected new Info _Name;

    public UITargetLinkChanges_Info DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Info) this.PropertyGet(nameof (DataContractMap));
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

    public Info InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitContractHandler));
      }
    }

    public UIFloatPageLayoutChanges_Info ButtonsLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonsLayout), (object) value);
      }
      get
      {
        return (UIFloatPageLayoutChanges_Info) this.PropertyGet(nameof (ButtonsLayout));
      }
    }

    public Info UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public UIFloatPageLocationChanges_Info FrameLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FrameLocation), (object) value);
      }
      get
      {
        return (UIFloatPageLocationChanges_Info) this.PropertyGet(nameof (FrameLocation));
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

    public Info ExecuteOnSubmit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteOnSubmit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecuteOnSubmit));
      }
    }

    public Info ShowButtons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowButtons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowButtons));
      }
    }

    public Info CloseButtonOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButtonOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseButtonOnly));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
