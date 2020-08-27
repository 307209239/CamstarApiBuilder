// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillChanges
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
  public class BillChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_ChangeHistory")]
    protected new ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_MaterialListItem")]
    protected MaterialListItemChanges _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_BillType")]
    protected NamedObjectRef _BillType;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_WIPMsgDefMgr")]
    protected new WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_MaterialList")]
    protected MaterialListItemChanges[] _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Status")]
    protected new Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "BillChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BillChanges && object.Equals((object) this._ChangeHistory, (object) ((BillChanges) obj)._ChangeHistory) && (object.Equals((object) this._MaterialListItem, (object) ((BillChanges) obj)._MaterialListItem) && object.Equals((object) this._BillType, (object) ((BillChanges) obj)._BillType)) && (object.Equals((object) this._Base, (object) ((BillChanges) obj)._Base) && object.Equals((object) this._WIPMsgDefMgr, (object) ((BillChanges) obj)._WIPMsgDefMgr) && (object.Equals((object) this._ObjectToChange, (object) ((BillChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._MaterialList, (Array) ((BillChanges) obj)._MaterialList))) && (object.Equals((object) this._IsRevOfRcd, (object) ((BillChanges) obj)._IsRevOfRcd) && object.Equals((object) this._IsFrozen, (object) ((BillChanges) obj)._IsFrozen) && (object.Equals((object) this._Status, (object) ((BillChanges) obj)._Status) && object.Equals((object) this._Description, (object) ((BillChanges) obj)._Description)) && (object.Equals((object) this._Revision, (object) ((BillChanges) obj)._Revision) && object.Equals((object) this._Name, (object) ((BillChanges) obj)._Name))) && base.Equals(obj);
    }

    public new ChangeHistoryChanges ChangeHistory
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

    public MaterialListItemChanges MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (MaterialListItemChanges) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public NamedObjectRef BillType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BillType));
      }
    }

    public new RevisionedObjectRef Base
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

    public new WIPMsgDefMgrChanges WIPMsgDefMgr
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

    public new RevisionedObjectRef ObjectToChange
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

    public MaterialListItemChanges[] MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MaterialListItemChanges[]) this.PropertyGet(nameof (MaterialList));
      }
    }

    public new Primitive<bool> IsRevOfRcd
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

    public new Enumeration<StatusEnum, int> Status
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

    public new Primitive<string> Revision
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
