// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetMapChanges
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
  public class ApprovalSheetMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_ResolutionAction")]
    protected Enumeration<ResolutionActionEnum, int> _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetMapChanges && object.Equals((object) this._ResolutionAction, (object) ((ApprovalSheetMapChanges) obj)._ResolutionAction) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((ApprovalSheetMapChanges) obj)._ApprovalSheetTemplate) && object.Equals((object) this._ListItemToChange, (object) ((ApprovalSheetMapChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((ApprovalSheetMapChanges) obj)._ObjectToChange) && object.Equals((object) this._ApprovalRequired, (object) ((ApprovalSheetMapChanges) obj)._ApprovalRequired) && object.Equals((object) this._IsFrozen, (object) ((ApprovalSheetMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Enumeration<ResolutionActionEnum, int> ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
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
