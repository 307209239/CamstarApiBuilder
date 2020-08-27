// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgr
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
  public class WIPMsgDefMgr : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_LabelKeys")]
    protected WIPMsgLabelKey[] _LabelKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_AllKey")]
    protected WIPMsgKey _AllKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_OperationKeys")]
    protected WIPMsgOperationKey[] _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_WIPMsgType")]
    protected Primitive<int> _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_WIPMsgEntity")]
    protected BaseObjectRef _WIPMsgEntity;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgDefMgr && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((WIPMsgDefMgr) obj)._ESigHistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((WIPMsgDefMgr) obj)._ExportImportKey) && this.CompareArrays((Array) this._LabelKeys, (Array) ((WIPMsgDefMgr) obj)._LabelKeys)) && (object.Equals((object) this._AllKey, (object) ((WIPMsgDefMgr) obj)._AllKey) && object.Equals((object) this._DisplayName, (object) ((WIPMsgDefMgr) obj)._DisplayName) && (this.CompareArrays((Array) this._OperationKeys, (Array) ((WIPMsgDefMgr) obj)._OperationKeys) && object.Equals((object) this._WIPMsgType, (object) ((WIPMsgDefMgr) obj)._WIPMsgType))) && (object.Equals((object) this._WIPMsgEntity, (object) ((WIPMsgDefMgr) obj)._WIPMsgEntity) && object.Equals((object) this._IsFrozen, (object) ((WIPMsgDefMgr) obj)._IsFrozen) && object.Equals((object) this._Description, (object) ((WIPMsgDefMgr) obj)._Description)) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public WIPMsgLabelKey[] LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKey[]) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgKey AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKey) this.PropertyGet(nameof (AllKey));
      }
    }

    public new Primitive<string> DisplayName
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

    public WIPMsgOperationKey[] OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKey[]) this.PropertyGet(nameof (OperationKeys));
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
