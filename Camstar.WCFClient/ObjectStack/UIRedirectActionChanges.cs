// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectActionChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIPageFlowActionChanges))]
  [KnownType(typeof (UIPageRedirectActionChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UIPageMappingActionChanges))]
  [Serializable]
  public class UIRedirectActionChanges : UIActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_PortalTabOption")]
    protected Enumeration<UIPortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_DataContractMap")]
    protected UITargetLinkChanges[] _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_InitContractHandler")]
    protected Primitive<string> _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_DenyDataContract")]
    protected Primitive<bool> _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_ForceRedirect")]
    protected Primitive<bool> _ForceRedirect;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIRedirectActionChanges && object.Equals((object) this._PortalTabOption, (object) ((UIRedirectActionChanges) obj)._PortalTabOption) && (object.Equals((object) this._PortalTab, (object) ((UIRedirectActionChanges) obj)._PortalTab) && object.Equals((object) this._ObjectToChange, (object) ((UIRedirectActionChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._DataContractMap, (Array) ((UIRedirectActionChanges) obj)._DataContractMap) && object.Equals((object) this._InitContractHandler, (object) ((UIRedirectActionChanges) obj)._InitContractHandler) && (object.Equals((object) this._ListItemToChange, (object) ((UIRedirectActionChanges) obj)._ListItemToChange) && object.Equals((object) this._DenyDataContract, (object) ((UIRedirectActionChanges) obj)._DenyDataContract))) && (object.Equals((object) this._ForceRedirect, (object) ((UIRedirectActionChanges) obj)._ForceRedirect) && object.Equals((object) this._Name, (object) ((UIRedirectActionChanges) obj)._Name)) && base.Equals(obj);
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

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UITargetLinkChanges[] DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges[]) this.PropertyGet(nameof (DataContractMap));
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

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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
