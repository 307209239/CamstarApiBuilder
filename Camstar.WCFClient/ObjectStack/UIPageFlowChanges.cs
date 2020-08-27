// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowChanges
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
  public class UIPageFlowChanges : UIProviderComponentChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_DLL")]
    protected Primitive<string> _DLL;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_XOML")]
    protected Primitive<string> _XOML;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Layout")]
    protected Primitive<string> _Layout;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_Rules")]
    protected Primitive<string> _Rules;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_CSCodeBehind")]
    protected Primitive<string> _CSCodeBehind;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_PageFlowStates")]
    protected UIPageFlowStateChanges[] _PageFlowStates;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowChanges_StartPage")]
    protected NamedObjectRef _StartPage;

    public override bool Equals(object obj)
    {
      return obj is UIPageFlowChanges && object.Equals((object) this._DLL, (object) ((UIPageFlowChanges) obj)._DLL) && (object.Equals((object) this._Name, (object) ((UIPageFlowChanges) obj)._Name) && object.Equals((object) this._XOML, (object) ((UIPageFlowChanges) obj)._XOML)) && (object.Equals((object) this._Layout, (object) ((UIPageFlowChanges) obj)._Layout) && object.Equals((object) this._Rules, (object) ((UIPageFlowChanges) obj)._Rules) && (object.Equals((object) this._CSCodeBehind, (object) ((UIPageFlowChanges) obj)._CSCodeBehind) && this.CompareArrays((Array) this._PageFlowStates, (Array) ((UIPageFlowChanges) obj)._PageFlowStates))) && (object.Equals((object) this._ObjectToChange, (object) ((UIPageFlowChanges) obj)._ObjectToChange) && object.Equals((object) this._StartPage, (object) ((UIPageFlowChanges) obj)._StartPage)) && base.Equals(obj);
    }

    public Primitive<string> DLL
    {
      [param: In] set
      {
        this.PropertySet(nameof (DLL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DLL));
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

    public Primitive<string> XOML
    {
      [param: In] set
      {
        this.PropertySet(nameof (XOML), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (XOML));
      }
    }

    public Primitive<string> Layout
    {
      [param: In] set
      {
        this.PropertySet(nameof (Layout), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Layout));
      }
    }

    public Primitive<string> Rules
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rules), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Rules));
      }
    }

    public Primitive<string> CSCodeBehind
    {
      [param: In] set
      {
        this.PropertySet(nameof (CSCodeBehind), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CSCodeBehind));
      }
    }

    public UIPageFlowStateChanges[] PageFlowStates
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowStates), (object) value);
      }
      get
      {
        return (UIPageFlowStateChanges[]) this.PropertyGet(nameof (PageFlowStates));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StartPage));
      }
    }
  }
}
