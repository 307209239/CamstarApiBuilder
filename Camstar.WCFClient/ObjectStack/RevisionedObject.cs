// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObject
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
  public class RevisionedObject : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_WhereUsed")]
    protected SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_DisplayName")]
    protected Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_ModelingInstanceLocks")]
    protected SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_FilterTags")]
    protected Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_InstanceLocked")]
    protected Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Base")]
    protected RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_ECO")]
    protected Primitive<string> _ECO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_AssociatedPackages")]
    protected Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_ChangeHistory")]
    protected ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_IsRevOfRcd")]
    protected Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_WIPMsgDefMgr")]
    protected WIPMsgDefMgr _WIPMsgDefMgr;

    public override bool Equals(object obj)
    {
      return obj is RevisionedObject && this.CompareArrays((Array) this._WhereUsed, (Array) ((RevisionedObject) obj)._WhereUsed) && (object.Equals((object) this._DisplayName, (object) ((RevisionedObject) obj)._DisplayName) && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((RevisionedObject) obj)._ESigHistoryDetails)) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((RevisionedObject) obj)._ModelingInstanceLocks) && object.Equals((object) this._FilterTags, (object) ((RevisionedObject) obj)._FilterTags) && (object.Equals((object) this._InstanceLocked, (object) ((RevisionedObject) obj)._InstanceLocked) && object.Equals((object) this._Base, (object) ((RevisionedObject) obj)._Base))) && (object.Equals((object) this._ECO, (object) ((RevisionedObject) obj)._ECO) && object.Equals((object) this._AssociatedPackages, (object) ((RevisionedObject) obj)._AssociatedPackages) && (object.Equals((object) this._Status, (object) ((RevisionedObject) obj)._Status) && object.Equals((object) this._ChangeHistory, (object) ((RevisionedObject) obj)._ChangeHistory)) && (object.Equals((object) this._Notes, (object) ((RevisionedObject) obj)._Notes) && object.Equals((object) this._IsFrozen, (object) ((RevisionedObject) obj)._IsFrozen) && (object.Equals((object) this._IsRevOfRcd, (object) ((RevisionedObject) obj)._IsRevOfRcd) && object.Equals((object) this._Description, (object) ((RevisionedObject) obj)._Description)))) && (object.Equals((object) this._Name, (object) ((RevisionedObject) obj)._Name) && object.Equals((object) this._IconId, (object) ((RevisionedObject) obj)._IconId) && (object.Equals((object) this._Revision, (object) ((RevisionedObject) obj)._Revision) && object.Equals((object) this._WIPMsgDefMgr, (object) ((RevisionedObject) obj)._WIPMsgDefMgr))) && base.Equals(obj);
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

    public RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Primitive<string> ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ECO));
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

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
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

    public Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
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

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public WIPMsgDefMgr WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }
  }
}
