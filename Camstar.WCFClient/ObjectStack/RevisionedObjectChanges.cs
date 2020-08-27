// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectChanges
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
  public class RevisionedObjectChanges : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_FilterTags")]
    protected Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_AttachDocumentDetails")]
    protected Camstar.WCF.ObjectStack.AttachDocumentDetails[] _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_ECO")]
    protected Primitive<string> _ECO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_InstanceLocked")]
    protected Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IsNDO")]
    protected Primitive<bool> _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Base")]
    protected RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_AssociatedPackages")]
    protected Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_CanChangeRevOfRcd")]
    protected Primitive<bool> _CanChangeRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_ObjectToChange")]
    protected RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IsRevOfRcd")]
    protected Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Status")]
    protected Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is RevisionedObjectChanges && object.Equals((object) this._WIPMsgDefMgr, (object) ((RevisionedObjectChanges) obj)._WIPMsgDefMgr) && (object.Equals((object) this._ChangeHistory, (object) ((RevisionedObjectChanges) obj)._ChangeHistory) && object.Equals((object) this._FilterTags, (object) ((RevisionedObjectChanges) obj)._FilterTags)) && (this.CompareArrays((Array) this._AttachDocumentDetails, (Array) ((RevisionedObjectChanges) obj)._AttachDocumentDetails) && object.Equals((object) this._ECO, (object) ((RevisionedObjectChanges) obj)._ECO) && (object.Equals((object) this._InstanceLocked, (object) ((RevisionedObjectChanges) obj)._InstanceLocked) && object.Equals((object) this._IsContainer, (object) ((RevisionedObjectChanges) obj)._IsContainer))) && (object.Equals((object) this._IsNDO, (object) ((RevisionedObjectChanges) obj)._IsNDO) && object.Equals((object) this._Base, (object) ((RevisionedObjectChanges) obj)._Base) && (object.Equals((object) this._AssociatedPackages, (object) ((RevisionedObjectChanges) obj)._AssociatedPackages) && object.Equals((object) this._IsRDO, (object) ((RevisionedObjectChanges) obj)._IsRDO)) && (object.Equals((object) this._CanChangeRevOfRcd, (object) ((RevisionedObjectChanges) obj)._CanChangeRevOfRcd) && object.Equals((object) this._ObjectToChange, (object) ((RevisionedObjectChanges) obj)._ObjectToChange) && (object.Equals((object) this._Notes, (object) ((RevisionedObjectChanges) obj)._Notes) && object.Equals((object) this._IsRevOfRcd, (object) ((RevisionedObjectChanges) obj)._IsRevOfRcd)))) && (object.Equals((object) this._Description, (object) ((RevisionedObjectChanges) obj)._Description) && object.Equals((object) this._IsFrozen, (object) ((RevisionedObjectChanges) obj)._IsFrozen) && (object.Equals((object) this._Revision, (object) ((RevisionedObjectChanges) obj)._Revision) && object.Equals((object) this._IconId, (object) ((RevisionedObjectChanges) obj)._IconId)) && (object.Equals((object) this._Name, (object) ((RevisionedObjectChanges) obj)._Name) && object.Equals((object) this._Status, (object) ((RevisionedObjectChanges) obj)._Status))) && base.Equals(obj);
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
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

    public Primitive<bool> CanChangeRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanChangeRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CanChangeRevOfRcd));
      }
    }

    public RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
