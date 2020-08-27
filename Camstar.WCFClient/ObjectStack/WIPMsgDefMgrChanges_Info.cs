// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgrChanges_Info
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
  public class WIPMsgDefMgrChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_WIPMsgKeyItem")]
    protected WIPMsgKeyChanges_Info _WIPMsgKeyItem;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_LabelKeys")]
    protected WIPMsgLabelKeyChanges_Info _LabelKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_OperationKeys")]
    protected WIPMsgOperationKeyChanges_Info _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_AllKey")]
    protected WIPMsgKeyChanges_Info _AllKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_ChangeHistory")]
    protected ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_WIPMsgDetailItem")]
    protected WIPMsgDetailChanges_Info _WIPMsgDetailItem;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_WIPMsgDetailBuf")]
    protected Info _WIPMsgDetailBuf;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_WIPMsgEntity")]
    protected Info _WIPMsgEntity;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_WIPMsgType")]
    protected Info _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_MaintCDOType")]
    protected Info _MaintCDOType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Info_Description")]
    protected Info _Description;

    public WIPMsgKeyChanges_Info WIPMsgKeyItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgKeyItem), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges_Info) this.PropertyGet(nameof (WIPMsgKeyItem));
      }
    }

    public WIPMsgLabelKeyChanges_Info LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKeyChanges_Info) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgOperationKeyChanges_Info OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKeyChanges_Info) this.PropertyGet(nameof (OperationKeys));
      }
    }

    public WIPMsgKeyChanges_Info AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges_Info) this.PropertyGet(nameof (AllKey));
      }
    }

    public ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public WIPMsgDetailChanges_Info WIPMsgDetailItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailItem), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Info) this.PropertyGet(nameof (WIPMsgDetailItem));
      }
    }

    public Info WIPMsgDetailBuf
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailBuf), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgDetailBuf));
      }
    }

    public Info WIPMsgEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgEntity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgEntity));
      }
    }

    public Info WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info MaintCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintCDOType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintCDOType));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
