// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetailChanges
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
  public class WIPMsgDetailChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_LITCListCDO")]
    protected SubentityRef _LITCListCDO;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_WIPMsg")]
    protected SubentityRef _WIPMsg;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_WIPMsgPassword")]
    protected PasswordFieldType _WIPMsgPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_SendNotification")]
    protected Primitive<bool> _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_RelevantServiceType")]
    protected Primitive<int> _RelevantServiceType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_WriteToHistory")]
    protected Primitive<bool> _WriteToHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_TextVariables")]
    protected Primitive<string> _TextVariables;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_LITCListField")]
    protected Primitive<int> _LITCListField;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_PasswordRequired")]
    protected Primitive<bool> _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_StopProcessing")]
    protected Primitive<bool> _StopProcessing;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_CreateDateGMT")]
    protected Primitive<DateTime> _CreateDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_TriggerAction")]
    protected Primitive<bool> _TriggerAction;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_AcknowledgmentRequired")]
    protected Primitive<bool> _AcknowledgmentRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_NotificationText")]
    protected Primitive<string> _NotificationText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_NotificationTargets")]
    protected NamedObjectRef[] _NotificationTargets;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_ChangeStatus")]
    protected SubentityRef _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_ContactInfo")]
    protected Primitive<string> _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Document")]
    protected RevisionedObjectRef _Document;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_MsgText")]
    protected Primitive<string> _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_RelevantServiceName")]
    protected Primitive<string> _RelevantServiceName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_MsgAction")]
    protected NamedObjectRef _MsgAction;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgDetailChanges && object.Equals((object) this._HoldReason, (object) ((WIPMsgDetailChanges) obj)._HoldReason) && (object.Equals((object) this._ObjectToChange, (object) ((WIPMsgDetailChanges) obj)._ObjectToChange) && object.Equals((object) this._LITCListCDO, (object) ((WIPMsgDetailChanges) obj)._LITCListCDO)) && (object.Equals((object) this._WIPMsg, (object) ((WIPMsgDetailChanges) obj)._WIPMsg) && object.Equals((object) this._WIPMsgPassword, (object) ((WIPMsgDetailChanges) obj)._WIPMsgPassword) && (object.Equals((object) this._SendNotification, (object) ((WIPMsgDetailChanges) obj)._SendNotification) && object.Equals((object) this._RelevantServiceType, (object) ((WIPMsgDetailChanges) obj)._RelevantServiceType))) && (object.Equals((object) this._WriteToHistory, (object) ((WIPMsgDetailChanges) obj)._WriteToHistory) && object.Equals((object) this._TextVariables, (object) ((WIPMsgDetailChanges) obj)._TextVariables) && (object.Equals((object) this._LITCListField, (object) ((WIPMsgDetailChanges) obj)._LITCListField) && object.Equals((object) this._PasswordRequired, (object) ((WIPMsgDetailChanges) obj)._PasswordRequired)) && (object.Equals((object) this._EffectiveFromDate, (object) ((WIPMsgDetailChanges) obj)._EffectiveFromDate) && object.Equals((object) this._CreationDate, (object) ((WIPMsgDetailChanges) obj)._CreationDate) && (object.Equals((object) this._StopProcessing, (object) ((WIPMsgDetailChanges) obj)._StopProcessing) && object.Equals((object) this._CreateDateGMT, (object) ((WIPMsgDetailChanges) obj)._CreateDateGMT)))) && (object.Equals((object) this._TriggerAction, (object) ((WIPMsgDetailChanges) obj)._TriggerAction) && object.Equals((object) this._EffectiveThruDate, (object) ((WIPMsgDetailChanges) obj)._EffectiveThruDate) && (object.Equals((object) this._AcknowledgmentRequired, (object) ((WIPMsgDetailChanges) obj)._AcknowledgmentRequired) && object.Equals((object) this._NotificationText, (object) ((WIPMsgDetailChanges) obj)._NotificationText)) && (this.CompareArrays((Array) this._NotificationTargets, (Array) ((WIPMsgDetailChanges) obj)._NotificationTargets) && object.Equals((object) this._ChangeStatus, (object) ((WIPMsgDetailChanges) obj)._ChangeStatus) && (object.Equals((object) this._ContactInfo, (object) ((WIPMsgDetailChanges) obj)._ContactInfo) && object.Equals((object) this._Name, (object) ((WIPMsgDetailChanges) obj)._Name))) && (object.Equals((object) this._Document, (object) ((WIPMsgDetailChanges) obj)._Document) && object.Equals((object) this._MsgText, (object) ((WIPMsgDetailChanges) obj)._MsgText) && (object.Equals((object) this._RelevantServiceName, (object) ((WIPMsgDetailChanges) obj)._RelevantServiceName) && object.Equals((object) this._Status, (object) ((WIPMsgDetailChanges) obj)._Status)) && (object.Equals((object) this._IsFrozen, (object) ((WIPMsgDetailChanges) obj)._IsFrozen) && object.Equals((object) this._MsgAction, (object) ((WIPMsgDetailChanges) obj)._MsgAction)))) && base.Equals(obj);
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
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

    public SubentityRef LITCListCDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListCDO), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LITCListCDO));
      }
    }

    public SubentityRef WIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsg), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (WIPMsg));
      }
    }

    public PasswordFieldType WIPMsgPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgPassword), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (WIPMsgPassword));
      }
    }

    public Primitive<bool> SendNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendNotification), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SendNotification));
      }
    }

    public Primitive<int> RelevantServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RelevantServiceType));
      }
    }

    public Primitive<bool> WriteToHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (WriteToHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (WriteToHistory));
      }
    }

    public Primitive<string> TextVariables
    {
      [param: In] set
      {
        this.PropertySet(nameof (TextVariables), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TextVariables));
      }
    }

    public Primitive<int> LITCListField
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListField), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LITCListField));
      }
    }

    public Primitive<bool> PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Primitive<bool> StopProcessing
    {
      [param: In] set
      {
        this.PropertySet(nameof (StopProcessing), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (StopProcessing));
      }
    }

    public Primitive<DateTime> CreateDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreateDateGMT));
      }
    }

    public Primitive<bool> TriggerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerAction), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriggerAction));
      }
    }

    public Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Primitive<bool> AcknowledgmentRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgmentRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AcknowledgmentRequired));
      }
    }

    public Primitive<string> NotificationText
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NotificationText));
      }
    }

    public NamedObjectRef[] NotificationTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTargets), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NotificationTargets));
      }
    }

    public SubentityRef ChangeStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatus), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ChangeStatus));
      }
    }

    public Primitive<string> ContactInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactInfo), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContactInfo));
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

    public RevisionedObjectRef Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Document));
      }
    }

    public Primitive<string> MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MsgText));
      }
    }

    public Primitive<string> RelevantServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RelevantServiceName));
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

    public NamedObjectRef MsgAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAction), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MsgAction));
      }
    }
  }
}
