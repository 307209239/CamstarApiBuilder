// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageOpenActionChanges_Environment
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
  public class UIFloatPageOpenActionChanges_Environment : UIActionChanges_Environment
  {
    [Metadata("UI Target Link", "UITargetLinkChanges", false, false, false, "UITargetLinkChanges", 1052806, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_DataContractMap")]
    protected UITargetLinkChanges_Environment _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_ListItemToChange")]
    [Metadata("UI Float Page Open Action", "UIFloatPageOpenActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_InitContractHandler")]
    protected Environment _InitContractHandler;
    [Metadata("UI Float Page Layout", "UIFloatPageLayoutChanges", false, false, false, "UIFloatPageLayoutChanges", 1052812, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_ButtonsLayout")]
    protected UIFloatPageLayoutChanges_Environment _ButtonsLayout;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051633, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_UIVirtualPage")]
    protected Environment _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_FrameLocation")]
    [Metadata("UI Float Page Location", "UIFloatPageLocationChanges", false, false, false, "UIFloatPageLocationChanges", 1052810, false, false, false, null)]
    protected UIFloatPageLocationChanges_Environment _FrameLocation;
    [Metadata("UI Float Page Open Action", "UIFloatPageOpenAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_ExecuteOnSubmit")]
    protected Environment _ExecuteOnSubmit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052799, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_ShowButtons")]
    protected Environment _ShowButtons;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_CloseButtonOnly")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052800, false, false, false, "0")]
    protected Environment _CloseButtonOnly;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052780, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageOpenActionChanges_Environment_Name")]
    protected new Environment _Name;

    public UITargetLinkChanges_Environment DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Environment) this.PropertyGet(nameof (DataContractMap));
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

    public UIFloatPageLayoutChanges_Environment ButtonsLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonsLayout), (object) value);
      }
      get
      {
        return (UIFloatPageLayoutChanges_Environment) this.PropertyGet(nameof (ButtonsLayout));
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

    public UIFloatPageLocationChanges_Environment FrameLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FrameLocation), (object) value);
      }
      get
      {
        return (UIFloatPageLocationChanges_Environment) this.PropertyGet(nameof (FrameLocation));
      }
    }

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
