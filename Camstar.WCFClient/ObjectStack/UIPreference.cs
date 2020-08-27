// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPreference
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
  public class UIPreference : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_UIPrefFieldDefs")]
    protected UIPrefFieldDef[] _UIPrefFieldDefs;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIPreference_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPreference && this.CompareArrays((Array) this._UIPrefFieldDefs, (Array) ((UIPreference) obj)._UIPrefFieldDefs) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((UIPreference) obj)._ModelingInstanceLocks) && object.Equals((object) this._FilterTags, (object) ((UIPreference) obj)._FilterTags)) && (object.Equals((object) this._InstanceLocked, (object) ((UIPreference) obj)._InstanceLocked) && object.Equals((object) this._AssociatedPackages, (object) ((UIPreference) obj)._AssociatedPackages) && (object.Equals((object) this._IconId, (object) ((UIPreference) obj)._IconId) && object.Equals((object) this._ChangeHistory, (object) ((UIPreference) obj)._ChangeHistory))) && (object.Equals((object) this._Description, (object) ((UIPreference) obj)._Description) && object.Equals((object) this._Notes, (object) ((UIPreference) obj)._Notes) && (object.Equals((object) this._IsFrozen, (object) ((UIPreference) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((UIPreference) obj)._Name))) && base.Equals(obj);
    }

    public UIPrefFieldDef[] UIPrefFieldDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPrefFieldDefs), (object) value);
      }
      get
      {
        return (UIPrefFieldDef[]) this.PropertyGet(nameof (UIPrefFieldDefs));
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
