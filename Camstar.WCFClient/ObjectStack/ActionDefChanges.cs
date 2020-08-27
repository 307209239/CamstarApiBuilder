// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDefChanges
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
  public class ActionDefChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_SourcePages")]
    protected UISourcePageChanges[] _SourcePages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_ActionRules")]
    protected NamedObjectRef[] _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_UIAction")]
    protected UIActionChanges _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_ActionType")]
    protected Enumeration<ActionTypeEnum, int> _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionDefChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActionDefChanges && this.CompareArrays((Array) this._SourcePages, (Array) ((ActionDefChanges) obj)._SourcePages) && (this.CompareArrays((Array) this._ActionRules, (Array) ((ActionDefChanges) obj)._ActionRules) && object.Equals((object) this._UIAction, (object) ((ActionDefChanges) obj)._UIAction)) && (object.Equals((object) this._ActionType, (object) ((ActionDefChanges) obj)._ActionType) && object.Equals((object) this._ObjectToChange, (object) ((ActionDefChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((ActionDefChanges) obj)._Name)) && base.Equals(obj);
    }

    public UISourcePageChanges[] SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePageChanges[]) this.PropertyGet(nameof (SourcePages));
      }
    }

    public NamedObjectRef[] ActionRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRules), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ActionRules));
      }
    }

    public UIActionChanges UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIActionChanges) this.PropertyGet(nameof (UIAction));
      }
    }

    public Enumeration<ActionTypeEnum, int> ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Enumeration<ActionTypeEnum, int>) this.PropertyGet(nameof (ActionType));
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
