// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLayout_Environment
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
  public class UIFloatPageLayout_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Button Label", "ButtonLabel", false, false, false, "ButtonLabel", 1052814, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_Environment_CloseButton")]
    protected ButtonLabel_Environment _CloseButton;
    [Metadata("Button Label", "ButtonLabel", false, false, false, "ButtonLabel", 1052815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_Environment_OKButton")]
    protected ButtonLabel_Environment _OKButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayout_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ButtonLabel_Environment CloseButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButton), (object) value);
      }
      get
      {
        return (ButtonLabel_Environment) this.PropertyGet(nameof (CloseButton));
      }
    }

    public ButtonLabel_Environment OKButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (OKButton), (object) value);
      }
      get
      {
        return (ButtonLabel_Environment) this.PropertyGet(nameof (OKButton));
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
