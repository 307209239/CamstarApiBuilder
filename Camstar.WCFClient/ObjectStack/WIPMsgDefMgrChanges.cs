// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgrChanges
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
  public class WIPMsgDefMgrChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_WIPMsgKeyItem")]
    protected WIPMsgKeyChanges _WIPMsgKeyItem;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_LabelKeys")]
    protected WIPMsgLabelKeyChanges[] _LabelKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_OperationKeys")]
    protected WIPMsgOperationKeyChanges[] _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_AllKey")]
    protected WIPMsgKeyChanges _AllKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_WIPMsgDetailItem")]
    protected WIPMsgDetailChanges _WIPMsgDetailItem;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_WIPMsgDetailBuf")]
    protected Primitive<string> _WIPMsgDetailBuf;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_WIPMsgEntity")]
    protected BaseObjectRef _WIPMsgEntity;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_WIPMsgType")]
    protected Primitive<int> _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_MaintCDOType")]
    protected Primitive<string> _MaintCDOType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgDefMgrChanges && object.Equals((object) this._WIPMsgKeyItem, (object) ((WIPMsgDefMgrChanges) obj)._WIPMsgKeyItem) && (this.CompareArrays((Array) this._LabelKeys, (Array) ((WIPMsgDefMgrChanges) obj)._LabelKeys) && this.CompareArrays((Array) this._OperationKeys, (Array) ((WIPMsgDefMgrChanges) obj)._OperationKeys)) && (object.Equals((object) this._AllKey, (object) ((WIPMsgDefMgrChanges) obj)._AllKey) && object.Equals((object) this._ChangeHistory, (object) ((WIPMsgDefMgrChanges) obj)._ChangeHistory) && (object.Equals((object) this._WIPMsgDetailItem, (object) ((WIPMsgDefMgrChanges) obj)._WIPMsgDetailItem) && object.Equals((object) this._WIPMsgDetailBuf, (object) ((WIPMsgDefMgrChanges) obj)._WIPMsgDetailBuf))) && (object.Equals((object) this._WIPMsgEntity, (object) ((WIPMsgDefMgrChanges) obj)._WIPMsgEntity) && object.Equals((object) this._WIPMsgType, (object) ((WIPMsgDefMgrChanges) obj)._WIPMsgType) && (object.Equals((object) this._IsFrozen, (object) ((WIPMsgDefMgrChanges) obj)._IsFrozen) && object.Equals((object) this._MaintCDOType, (object) ((WIPMsgDefMgrChanges) obj)._MaintCDOType)) && (object.Equals((object) this._ObjectToChange, (object) ((WIPMsgDefMgrChanges) obj)._ObjectToChange) && object.Equals((object) this._Description, (object) ((WIPMsgDefMgrChanges) obj)._Description))) && base.Equals(obj);
    }

    public WIPMsgKeyChanges WIPMsgKeyItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgKeyItem), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges) this.PropertyGet(nameof (WIPMsgKeyItem));
      }
    }

    public WIPMsgLabelKeyChanges[] LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKeyChanges[]) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgOperationKeyChanges[] OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKeyChanges[]) this.PropertyGet(nameof (OperationKeys));
      }
    }

    public WIPMsgKeyChanges AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges) this.PropertyGet(nameof (AllKey));
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

    public WIPMsgDetailChanges WIPMsgDetailItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailItem), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges) this.PropertyGet(nameof (WIPMsgDetailItem));
      }
    }

    public Primitive<string> WIPMsgDetailBuf
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailBuf), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WIPMsgDetailBuf));
      }
    }

    public BaseObjectRef WIPMsgEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgEntity), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (WIPMsgEntity));
      }
    }

    public Primitive<int> WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WIPMsgType));
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

    public Primitive<string> MaintCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintCDOType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintCDOType));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
