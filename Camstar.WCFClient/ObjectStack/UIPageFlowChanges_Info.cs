// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowChanges_Info
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
  public class UIPageFlowChanges_Info : UIProviderComponentChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_DLL")]
    protected Info _DLL;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_XOML")]
    protected Info _XOML;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_Layout")]
    protected Info _Layout;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_Rules")]
    protected Info _Rules;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_CSCodeBehind")]
    protected Info _CSCodeBehind;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_PageFlowStates")]
    protected UIPageFlowStateChanges_Info _PageFlowStates;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Info_StartPage")]
    protected Info _StartPage;

    public Info DLL
    {
      [param: In] set
      {
        this.PropertySet(nameof (DLL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DLL));
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

    public Info XOML
    {
      [param: In] set
      {
        this.PropertySet(nameof (XOML), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (XOML));
      }
    }

    public Info Layout
    {
      [param: In] set
      {
        this.PropertySet(nameof (Layout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Layout));
      }
    }

    public Info Rules
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rules), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rules));
      }
    }

    public Info CSCodeBehind
    {
      [param: In] set
      {
        this.PropertySet(nameof (CSCodeBehind), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CSCodeBehind));
      }
    }

    public UIPageFlowStateChanges_Info PageFlowStates
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowStates), (object) value);
      }
      get
      {
        return (UIPageFlowStateChanges_Info) this.PropertyGet(nameof (PageFlowStates));
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

    public Info StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartPage));
      }
    }
  }
}
