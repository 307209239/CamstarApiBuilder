﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLayoutChanges_Info
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
  public class UIFloatPageLayoutChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Info_CloseButton")]
    protected ButtonLabelChanges_Info _CloseButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Info_OKButton")]
    protected ButtonLabelChanges_Info _OKButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public ButtonLabelChanges_Info CloseButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges_Info) this.PropertyGet(nameof (CloseButton));
      }
    }

    public ButtonLabelChanges_Info OKButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (OKButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges_Info) this.PropertyGet(nameof (OKButton));
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
