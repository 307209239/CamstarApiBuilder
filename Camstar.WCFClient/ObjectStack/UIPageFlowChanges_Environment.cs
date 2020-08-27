// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowChanges_Environment
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
  public class UIPageFlowChanges_Environment : UIProviderComponentChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_DLL")]
    [Metadata("LongString", "", false, false, false, "String", 1051530, false, false, false, null)]
    protected Environment _DLL;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_Name")]
    [Metadata("FileName - used for fields that specify files.", "", false, true, false, "String", 1051495, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_XOML")]
    [Metadata("LongString", "", false, false, false, "String", 1051499, false, false, false, null)]
    protected Environment _XOML;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_Layout")]
    [Metadata("LongString", "", false, false, false, "String", 1051497, false, false, false, null)]
    protected Environment _Layout;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_Rules")]
    [Metadata("LongString", "", false, false, false, "String", 1051498, false, false, false, null)]
    protected Environment _Rules;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_CSCodeBehind")]
    [Metadata("LongString", "", false, false, false, "String", 1051496, false, false, false, null)]
    protected Environment _CSCodeBehind;
    [Metadata("UI PageFlow State", "UIPageFlowStateChanges", false, false, false, "UIPageFlowStateChanges", 1051503, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_PageFlowStates")]
    protected UIPageFlowStateChanges_Environment _PageFlowStates;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_ObjectToChange")]
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051501, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Environment_StartPage")]
    protected Environment _StartPage;

    public Environment DLL
    {
      [param: In] set
      {
        this.PropertySet(nameof (DLL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DLL));
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

    public Environment XOML
    {
      [param: In] set
      {
        this.PropertySet(nameof (XOML), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (XOML));
      }
    }

    public Environment Layout
    {
      [param: In] set
      {
        this.PropertySet(nameof (Layout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Layout));
      }
    }

    public Environment Rules
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rules), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rules));
      }
    }

    public Environment CSCodeBehind
    {
      [param: In] set
      {
        this.PropertySet(nameof (CSCodeBehind), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CSCodeBehind));
      }
    }

    public UIPageFlowStateChanges_Environment PageFlowStates
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowStates), (object) value);
      }
      get
      {
        return (UIPageFlowStateChanges_Environment) this.PropertyGet(nameof (PageFlowStates));
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

    public Environment StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartPage));
      }
    }
  }
}
