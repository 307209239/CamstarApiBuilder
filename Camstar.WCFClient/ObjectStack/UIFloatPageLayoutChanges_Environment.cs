// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLayoutChanges_Environment
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
  public class UIFloatPageLayoutChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("UI Float Page Layout", "UIFloatPageLayout", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Environment_CloseButton")]
    [Metadata("Button Label", "ButtonLabelChanges", false, false, false, "ButtonLabelChanges", 1052814, false, false, false, null)]
    protected ButtonLabelChanges_Environment _CloseButton;
    [Metadata("Button Label", "ButtonLabelChanges", false, false, false, "ButtonLabelChanges", 1052815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Environment_OKButton")]
    protected ButtonLabelChanges_Environment _OKButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Environment_ListItemToChange")]
    [Metadata("UI Float Page Layout", "UIFloatPageLayoutChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public ButtonLabelChanges_Environment CloseButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges_Environment) this.PropertyGet(nameof (CloseButton));
      }
    }

    public ButtonLabelChanges_Environment OKButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (OKButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges_Environment) this.PropertyGet(nameof (OKButton));
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
