// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObjectChanges
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
  public class NamedDataObjectChanges : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_AttachDocumentDetails")]
    protected Camstar.WCF.ObjectStack.AttachDocumentDetails[] _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_FilterTags")]
    protected Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_AssociatedPackages")]
    protected Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_UseRORProxy")]
    protected Primitive<bool>[] _UseRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_AttachAsRORProxy")]
    protected Primitive<bool>[] _AttachAsRORProxy;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_UseROR")]
    protected Primitive<bool>[] _UseROR;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_IsNDO")]
    protected Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_InstanceLocked")]
    protected Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_ObjectToChange")]
    protected NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NamedDataObjectChanges && object.Equals((object) this._ChangeHistory, (object) ((NamedDataObjectChanges) obj)._ChangeHistory) && (this.CompareArrays((Array) this._AttachDocumentDetails, (Array) ((NamedDataObjectChanges) obj)._AttachDocumentDetails) && object.Equals((object) this._FilterTags, (object) ((NamedDataObjectChanges) obj)._FilterTags)) && (object.Equals((object) this._AssociatedPackages, (object) ((NamedDataObjectChanges) obj)._AssociatedPackages) && this.CompareArrays((Array) this._UseRORProxy, (Array) ((NamedDataObjectChanges) obj)._UseRORProxy) && (object.Equals((object) this._IsContainer, (object) ((NamedDataObjectChanges) obj)._IsContainer) && this.CompareArrays((Array) this._AttachAsRORProxy, (Array) ((NamedDataObjectChanges) obj)._AttachAsRORProxy))) && (this.CompareArrays((Array) this._UseROR, (Array) ((NamedDataObjectChanges) obj)._UseROR) && object.Equals((object) this._IsNDO, (object) ((NamedDataObjectChanges) obj)._IsNDO) && (object.Equals((object) this._InstanceLocked, (object) ((NamedDataObjectChanges) obj)._InstanceLocked) && object.Equals((object) this._IsRDO, (object) ((NamedDataObjectChanges) obj)._IsRDO)) && (object.Equals((object) this._ObjectToChange, (object) ((NamedDataObjectChanges) obj)._ObjectToChange) && object.Equals((object) this._Notes, (object) ((NamedDataObjectChanges) obj)._Notes) && (object.Equals((object) this._IconId, (object) ((NamedDataObjectChanges) obj)._IconId) && object.Equals((object) this._Name, (object) ((NamedDataObjectChanges) obj)._Name)))) && (object.Equals((object) this._Description, (object) ((NamedDataObjectChanges) obj)._Description) && object.Equals((object) this._IsFrozen, (object) ((NamedDataObjectChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Camstar.WCF.ObjectStack.AttachDocumentDetails[] AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.AttachDocumentDetails[]) this.PropertyGet(nameof (AttachDocumentDetails));
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

    public Primitive<bool>[] UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (UseRORProxy));
      }
    }

    public Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Primitive<bool>[] AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Primitive<bool>[] UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Primitive<bool>[]) this.PropertyGet(nameof (UseROR));
      }
    }

    public Primitive<bool> IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNDO));
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

    public Primitive<bool> IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRDO));
      }
    }

    public NamedObjectRef ObjectToChange
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
