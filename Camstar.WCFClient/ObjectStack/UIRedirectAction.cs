// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectAction
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIPageRedirectAction))]
  [KnownType(typeof (UIPageMappingAction))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UIPageFlowAction))]
  [Serializable]
  public class UIRedirectAction : UIAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_PortalTabOption")]
    protected Enumeration<UIPortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_InitContractHandler")]
    protected Primitive<string> _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_DataContractMap")]
    protected UITargetLink[] _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_DenyDataContract")]
    protected Primitive<bool> _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_ForceRedirect")]
    protected Primitive<bool> _ForceRedirect;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIRedirectAction && object.Equals((object) this._PortalTabOption, (object) ((UIRedirectAction) obj)._PortalTabOption) && (object.Equals((object) this._PortalTab, (object) ((UIRedirectAction) obj)._PortalTab) && object.Equals((object) this._InitContractHandler, (object) ((UIRedirectAction) obj)._InitContractHandler)) && (this.CompareArrays((Array) this._DataContractMap, (Array) ((UIRedirectAction) obj)._DataContractMap) && object.Equals((object) this._DenyDataContract, (object) ((UIRedirectAction) obj)._DenyDataContract) && (object.Equals((object) this._ForceRedirect, (object) ((UIRedirectAction) obj)._ForceRedirect) && object.Equals((object) this._Name, (object) ((UIRedirectAction) obj)._Name))) && base.Equals(obj);
    }

    public Enumeration<UIPortalTabOptionEnum, int> PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Enumeration<UIPortalTabOptionEnum, int>) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public NamedObjectRef PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Primitive<string> InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InitContractHandler));
      }
    }

    public UITargetLink[] DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLink[]) this.PropertyGet(nameof (DataContractMap));
      }
    }

    public Primitive<bool> DenyDataContract
    {
      [param: In] set
      {
        this.PropertySet(nameof (DenyDataContract), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DenyDataContract));
      }
    }

    public Primitive<bool> ForceRedirect
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRedirect), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ForceRedirect));
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
  }
}
