// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PortalMenuSubMenuChanges))]
  [KnownType(typeof (PortalMenuCommandChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PortalMenuItemChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Caption")]
    protected Primitive<string> _Caption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_PortalTabOption")]
    protected Enumeration<PortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is PortalMenuItemChanges && object.Equals((object) this._LabelName, (object) ((PortalMenuItemChanges) obj)._LabelName) && (object.Equals((object) this._Caption, (object) ((PortalMenuItemChanges) obj)._Caption) && object.Equals((object) this._ListItemToChange, (object) ((PortalMenuItemChanges) obj)._ListItemToChange)) && (object.Equals((object) this._PortalTab, (object) ((PortalMenuItemChanges) obj)._PortalTab) && object.Equals((object) this._ObjectToChange, (object) ((PortalMenuItemChanges) obj)._ObjectToChange) && (object.Equals((object) this._PortalTabOption, (object) ((PortalMenuItemChanges) obj)._PortalTabOption) && object.Equals((object) this._Sequence, (object) ((PortalMenuItemChanges) obj)._Sequence))) && object.Equals((object) this._IsFrozen, (object) ((PortalMenuItemChanges) obj)._IsFrozen) && base.Equals(obj);
    }

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
      }
    }

    public Primitive<string> Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Caption));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<PortalTabOptionEnum, int> PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Enumeration<PortalTabOptionEnum, int>) this.PropertyGet(nameof (PortalTabOption));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
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
