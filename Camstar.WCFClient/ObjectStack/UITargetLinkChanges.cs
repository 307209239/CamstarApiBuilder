// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetLinkChanges
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
  public class UITargetLinkChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_TargetMember")]
    protected Primitive<string> _TargetMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_SourceMember")]
    protected Primitive<string> _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLinkChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UITargetLinkChanges && object.Equals((object) this._ListItemToChange, (object) ((UITargetLinkChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((UITargetLinkChanges) obj)._ObjectToChange) && object.Equals((object) this._TargetMember, (object) ((UITargetLinkChanges) obj)._TargetMember)) && (object.Equals((object) this._SourceMember, (object) ((UITargetLinkChanges) obj)._SourceMember) && object.Equals((object) this._IsFrozen, (object) ((UITargetLinkChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public Primitive<string> TargetMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetMember));
      }
    }

    public Primitive<string> SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceMember));
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
