// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgrChanges_Environment
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
  public class WIPMsgDefMgrChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_WIPMsgKeyItem")]
    [Metadata("Changes CDO for WIPMsgKey.", "WIPMsgKeyChanges", false, false, false, "WIPMsgKeyChanges", 1049363, true, false, false, null)]
    protected WIPMsgKeyChanges_Environment _WIPMsgKeyItem;
    [Metadata("Changes CDO for WIPMsgLabelKey.", "WIPMsgLabelKeyChanges", false, false, false, "WIPMsgLabelKeyChanges", 1048887, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_LabelKeys")]
    protected WIPMsgLabelKeyChanges_Environment _LabelKeys;
    [Metadata("Changes CDO for WIPMsgOperationKey.", "WIPMsgOperationKeyChanges", false, false, false, "WIPMsgOperationKeyChanges", 1048889, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_OperationKeys")]
    protected WIPMsgOperationKeyChanges_Environment _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_AllKey")]
    [Metadata("Changes CDO for WIPMsgKey.", "WIPMsgKeyChanges", false, false, false, "WIPMsgKeyChanges", 1049498, true, false, false, null)]
    protected WIPMsgKeyChanges_Environment _AllKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("Changes CDO for WIPMsgDetail.", "WIPMsgDetailChanges", false, false, false, "WIPMsgDetailChanges", 1049362, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_WIPMsgDetailItem")]
    protected WIPMsgDetailChanges_Environment _WIPMsgDetailItem;
    [Metadata("Generic String", "", false, false, false, "String", 1049361, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_WIPMsgDetailBuf")]
    protected Environment _WIPMsgDetailBuf;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_WIPMsgEntity")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048890, false, false, false, null)]
    protected Environment _WIPMsgEntity;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_WIPMsgType")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048891, false, false, false, null)]
    protected Environment _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_MaintCDOType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048888, false, false, false, null)]
    protected Environment _MaintCDOType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_ObjectToChange")]
    [Metadata("Attached to an instance of a modeling entity, this contains the messages that apply to the entity.  When asked to supply its WIP Messages, a modeling entity will ask its WIPMsgDefMgr to supply a list of WIP Messages that have been filtered to include only the messages that apply to the current circumstances (step, operation and label).\r\nThe WIPMsgDefMgr will check the AllKey WIPMsgKey (which contains a message that applies to all steps) if specified, and run through the entries in the OperationKeys and LabelKeys lists and filter each message found.", "WIPMsgDefMgr", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgrChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;

    public WIPMsgKeyChanges_Environment WIPMsgKeyItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgKeyItem), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges_Environment) this.PropertyGet(nameof (WIPMsgKeyItem));
      }
    }

    public WIPMsgLabelKeyChanges_Environment LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKeyChanges_Environment) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgOperationKeyChanges_Environment OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKeyChanges_Environment) this.PropertyGet(nameof (OperationKeys));
      }
    }

    public WIPMsgKeyChanges_Environment AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKeyChanges_Environment) this.PropertyGet(nameof (AllKey));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public WIPMsgDetailChanges_Environment WIPMsgDetailItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailItem), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Environment) this.PropertyGet(nameof (WIPMsgDetailItem));
      }
    }

    public Environment WIPMsgDetailBuf
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetailBuf), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgDetailBuf));
      }
    }

    public Environment WIPMsgEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgEntity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgEntity));
      }
    }

    public Environment WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment MaintCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintCDOType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintCDOType));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
