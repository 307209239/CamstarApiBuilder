// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageOpenAction_Environment
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
  public class UIFloatPageOpenAction_Environment : UIAction_Environment
  {
    [Metadata("UI Float Page Layout", "UIFloatPageLayout", false, false, false, "UIFloatPageLayout", 1052812, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_ButtonsLayout")]
    protected UIFloatPageLayout_Environment _ButtonsLayout;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_UIVirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, true, "NamedObjectRef", 1051633, false, false, false, null)]
    protected Environment _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_InitContractHandler")]
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052796, false, false, false, null)]
    protected Environment _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_DataContractMap")]
    [Metadata("Storages Links definition for UITarget", "UITargetLink", false, false, false, "UITargetLink", 1052806, false, true, false, null)]
    protected UITargetLink_Environment _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_FrameLocation")]
    [Metadata("UI Float Page Location", "UIFloatPageLocation", false, false, false, "UIFloatPageLocation", 1052810, false, false, false, null)]
    protected UIFloatPageLocation_Environment _FrameLocation;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_ExecuteOnSubmit")]
    protected Environment _ExecuteOnSubmit;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052799, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_ShowButtons")]
    protected Environment _ShowButtons;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052800, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_CloseButtonOnly")]
    protected Environment _CloseButtonOnly;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052780, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenAction_Environment_Name")]
    protected new Environment _Name;

    public UIFloatPageLayout_Environment ButtonsLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonsLayout), (object) value);
      }
      get
      {
        return (UIFloatPageLayout_Environment) this.PropertyGet(nameof (ButtonsLayout));
      }
    }

    public Environment UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public Environment InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitContractHandler));
      }
    }

    public UITargetLink_Environment DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLink_Environment) this.PropertyGet(nameof (DataContractMap));
      }
    }

    public UIFloatPageLocation_Environment FrameLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FrameLocation), (object) value);
      }
      get
      {
        return (UIFloatPageLocation_Environment) this.PropertyGet(nameof (FrameLocation));
      }
    }

    public Environment ExecuteOnSubmit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteOnSubmit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecuteOnSubmit));
      }
    }

    public Environment ShowButtons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowButtons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowButtons));
      }
    }

    public Environment CloseButtonOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButtonOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseButtonOnly));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
