// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetailChanges_Info
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
  public class WIPMsgDetailChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_LITCListCDO")]
    protected Info _LITCListCDO;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_WIPMsg")]
    protected Info _WIPMsg;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_WIPMsgPassword")]
    protected Info _WIPMsgPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_SendNotification")]
    protected Info _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_RelevantServiceType")]
    protected Info _RelevantServiceType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_WriteToHistory")]
    protected Info _WriteToHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_TextVariables")]
    protected Info _TextVariables;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_LITCListField")]
    protected Info _LITCListField;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_PasswordRequired")]
    protected Info _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_StopProcessing")]
    protected Info _StopProcessing;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_CreateDateGMT")]
    protected Info _CreateDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_TriggerAction")]
    protected Info _TriggerAction;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_AcknowledgmentRequired")]
    protected Info _AcknowledgmentRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_NotificationText")]
    protected Info _NotificationText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_NotificationTargets")]
    protected Info _NotificationTargets;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_ChangeStatus")]
    protected Info _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_ContactInfo")]
    protected Info _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_Document")]
    protected Info _Document;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_MsgText")]
    protected Info _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_RelevantServiceName")]
    protected Info _RelevantServiceName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Info_MsgAction")]
    protected Info _MsgAction;

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
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

    public Info LITCListCDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListCDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LITCListCDO));
      }
    }

    public Info WIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsg), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsg));
      }
    }

    public Info WIPMsgPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgPassword));
      }
    }

    public Info SendNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendNotification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SendNotification));
      }
    }

    public Info RelevantServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelevantServiceType));
      }
    }

    public Info WriteToHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (WriteToHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WriteToHistory));
      }
    }

    public Info TextVariables
    {
      [param: In] set
      {
        this.PropertySet(nameof (TextVariables), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TextVariables));
      }
    }

    public Info LITCListField
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListField), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LITCListField));
      }
    }

    public Info PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info StopProcessing
    {
      [param: In] set
      {
        this.PropertySet(nameof (StopProcessing), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StopProcessing));
      }
    }

    public Info CreateDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateDateGMT));
      }
    }

    public Info TriggerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriggerAction));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info AcknowledgmentRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgmentRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AcknowledgmentRequired));
      }
    }

    public Info NotificationText
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotificationText));
      }
    }

    public Info NotificationTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTargets), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotificationTargets));
      }
    }

    public Info ChangeStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeStatus));
      }
    }

    public Info ContactInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactInfo));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Document));
      }
    }

    public Info MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MsgText));
      }
    }

    public Info RelevantServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelevantServiceName));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
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

    public Info MsgAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MsgAction));
      }
    }
  }
}
