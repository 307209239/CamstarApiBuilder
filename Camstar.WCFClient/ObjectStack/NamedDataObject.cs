// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObject
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
  public class NamedDataObject : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_WhereUsed")]
    protected SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_DisplayName")]
    protected Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_ModelingInstanceLocks")]
    protected SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_FilterTags")]
    protected Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_AssociatedPackages")]
    protected Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_InstanceLocked")]
    protected Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_ChangeHistory")]
    protected ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObject_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NamedDataObject && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((NamedDataObject) obj)._ESigHistoryDetails) && (this.CompareArrays((Array) this._WhereUsed, (Array) ((NamedDataObject) obj)._WhereUsed) && object.Equals((object) this._DisplayName, (object) ((NamedDataObject) obj)._DisplayName)) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((NamedDataObject) obj)._ModelingInstanceLocks) && object.Equals((object) this._FilterTags, (object) ((NamedDataObject) obj)._FilterTags) && (object.Equals((object) this._AssociatedPackages, (object) ((NamedDataObject) obj)._AssociatedPackages) && object.Equals((object) this._InstanceLocked, (object) ((NamedDataObject) obj)._InstanceLocked))) && (object.Equals((object) this._Description, (object) ((NamedDataObject) obj)._Description) && object.Equals((object) this._ChangeHistory, (object) ((NamedDataObject) obj)._ChangeHistory) && (object.Equals((object) this._IconId, (object) ((NamedDataObject) obj)._IconId) && object.Equals((object) this._Notes, (object) ((NamedDataObject) obj)._Notes)) && (object.Equals((object) this._Name, (object) ((NamedDataObject) obj)._Name) && object.Equals((object) this._IsFrozen, (object) ((NamedDataObject) obj)._IsFrozen))) && base.Equals(obj);
    }

    public ModelingESigHistoryDetail[] ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (ModelingESigHistoryDetail[]) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public SubentityRef[] WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public SubentityRef[] ModelingInstanceLocks
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

    public Primitive<string> FilterTags
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

    public Primitive<int> AssociatedPackages
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

    public Primitive<bool> InstanceLocked
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

    public Primitive<string> Description
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

    public ChangeHistory ChangeHistory
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

    public Primitive<int> IconId
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

    public Primitive<string> Notes
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

    public Primitive<string> Name
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
