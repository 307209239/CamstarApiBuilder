// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISourcePage
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
  public class UISourcePage : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Links")]
    protected UITargetLink[] _Links;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Conditions")]
    protected UITargetCondition[] _Conditions;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UISourcePage && object.Equals((object) this._Sequence, (object) ((UISourcePage) obj)._Sequence) && (object.Equals((object) this._ExportImportKey, (object) ((UISourcePage) obj)._ExportImportKey) && this.CompareArrays((Array) this._Links, (Array) ((UISourcePage) obj)._Links)) && (this.CompareArrays((Array) this._Conditions, (Array) ((UISourcePage) obj)._Conditions) && object.Equals((object) this._UIVirtualPage, (object) ((UISourcePage) obj)._UIVirtualPage) && object.Equals((object) this._IsFrozen, (object) ((UISourcePage) obj)._IsFrozen)) && base.Equals(obj);
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

    public UITargetLink[] Links
    {
      [param: In] set
      {
        this.PropertySet(nameof (Links), (object) value);
      }
      get
      {
        return (UITargetLink[]) this.PropertyGet(nameof (Links));
      }
    }

    public UITargetCondition[] Conditions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Conditions), (object) value);
      }
      get
      {
        return (UITargetCondition[]) this.PropertyGet(nameof (Conditions));
      }
    }

    public NamedObjectRef UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIVirtualPage));
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
