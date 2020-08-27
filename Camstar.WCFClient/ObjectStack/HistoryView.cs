// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryView
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
  public class HistoryView : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_HistViewHistMainlineDtl")]
    protected HistViewHistMainlineDtl _HistViewHistMainlineDtl;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_HistViewDtls")]
    protected HistViewDtl[] _HistViewDtls;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;

    public override bool Equals(object obj)
    {
      return obj is HistoryView && object.Equals((object) this._HistViewHistMainlineDtl, (object) ((HistoryView) obj)._HistViewHistMainlineDtl) && (this.CompareArrays((Array) this._HistViewDtls, (Array) ((HistoryView) obj)._HistViewDtls) && object.Equals((object) this._FilterTags, (object) ((HistoryView) obj)._FilterTags)) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((HistoryView) obj)._ModelingInstanceLocks) && object.Equals((object) this._InstanceLocked, (object) ((HistoryView) obj)._InstanceLocked) && (object.Equals((object) this._AssociatedPackages, (object) ((HistoryView) obj)._AssociatedPackages) && object.Equals((object) this._Description, (object) ((HistoryView) obj)._Description))) && (object.Equals((object) this._Notes, (object) ((HistoryView) obj)._Notes) && object.Equals((object) this._IconId, (object) ((HistoryView) obj)._IconId) && (object.Equals((object) this._Name, (object) ((HistoryView) obj)._Name) && object.Equals((object) this._IsFrozen, (object) ((HistoryView) obj)._IsFrozen)) && object.Equals((object) this._ChangeHistory, (object) ((HistoryView) obj)._ChangeHistory)) && base.Equals(obj);
    }

    public HistViewHistMainlineDtl HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtl) this.PropertyGet(nameof (HistViewHistMainlineDtl));
      }
    }

    public HistViewDtl[] HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtl[]) this.PropertyGet(nameof (HistViewDtls));
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
  }
}
