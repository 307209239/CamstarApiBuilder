// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDef
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
  public class ActionDef : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_ActionType")]
    protected Enumeration<ActionTypeEnum, int> _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_UIAction")]
    protected UIAction _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_ActionRules")]
    protected NamedObjectRef[] _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_SourcePages")]
    protected UISourcePage[] _SourcePages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Notes")]
    protected new Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is ActionDef && object.Equals((object) this._ActionType, (object) ((ActionDef) obj)._ActionType) && (object.Equals((object) this._UIAction, (object) ((ActionDef) obj)._UIAction) && object.Equals((object) this._FilterTags, (object) ((ActionDef) obj)._FilterTags)) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((ActionDef) obj)._ModelingInstanceLocks) && this.CompareArrays((Array) this._ActionRules, (Array) ((ActionDef) obj)._ActionRules) && (this.CompareArrays((Array) this._SourcePages, (Array) ((ActionDef) obj)._SourcePages) && object.Equals((object) this._AssociatedPackages, (object) ((ActionDef) obj)._AssociatedPackages))) && (object.Equals((object) this._InstanceLocked, (object) ((ActionDef) obj)._InstanceLocked) && object.Equals((object) this._ChangeHistory, (object) ((ActionDef) obj)._ChangeHistory) && (object.Equals((object) this._Name, (object) ((ActionDef) obj)._Name) && object.Equals((object) this._IconId, (object) ((ActionDef) obj)._IconId)) && (object.Equals((object) this._IsFrozen, (object) ((ActionDef) obj)._IsFrozen) && object.Equals((object) this._Description, (object) ((ActionDef) obj)._Description) && object.Equals((object) this._Notes, (object) ((ActionDef) obj)._Notes))) && base.Equals(obj);
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

    public UIAction UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIAction) this.PropertyGet(nameof (UIAction));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
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

    public UISourcePage[] SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePage[]) this.PropertyGet(nameof (SourcePages));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
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

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new Primitive<bool> IsFrozen
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

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
