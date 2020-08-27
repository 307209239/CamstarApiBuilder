// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLayout
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
  public class UIFloatPageLayout : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_CloseButton")]
    protected ButtonLabel _CloseButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_OKButton")]
    protected ButtonLabel _OKButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageLayout && object.Equals((object) this._ExportImportKey, (object) ((UIFloatPageLayout) obj)._ExportImportKey) && (object.Equals((object) this._CloseButton, (object) ((UIFloatPageLayout) obj)._CloseButton) && object.Equals((object) this._OKButton, (object) ((UIFloatPageLayout) obj)._OKButton)) && object.Equals((object) this._IsFrozen, (object) ((UIFloatPageLayout) obj)._IsFrozen) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ButtonLabel CloseButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButton), (object) value);
      }
      get
      {
        return (ButtonLabel) this.PropertyGet(nameof (CloseButton));
      }
    }

    public ButtonLabel OKButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (OKButton), (object) value);
      }
      get
      {
        return (ButtonLabel) this.PropertyGet(nameof (OKButton));
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
