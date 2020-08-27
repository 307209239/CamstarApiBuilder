// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTag
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
  public class FilterTag : UserCode
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_InstanceID")]
    protected NamedObjectRef _InstanceID;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "FilterTag_Notes")]
    protected new Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is FilterTag && object.Equals((object) this._FilterTags, (object) ((FilterTag) obj)._FilterTags) && (object.Equals((object) this._InstanceID, (object) ((FilterTag) obj)._InstanceID) && object.Equals((object) this._IconId, (object) ((FilterTag) obj)._IconId)) && (object.Equals((object) this._IsFrozen, (object) ((FilterTag) obj)._IsFrozen) && object.Equals((object) this._ChangeHistory, (object) ((FilterTag) obj)._ChangeHistory) && (object.Equals((object) this._Name, (object) ((FilterTag) obj)._Name) && object.Equals((object) this._Description, (object) ((FilterTag) obj)._Description))) && object.Equals((object) this._Notes, (object) ((FilterTag) obj)._Notes) && base.Equals(obj);
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

    public NamedObjectRef InstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceID), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InstanceID));
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
