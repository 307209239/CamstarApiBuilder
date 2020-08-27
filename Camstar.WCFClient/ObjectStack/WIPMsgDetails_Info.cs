// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetails_Info
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
  public class WIPMsgDetails_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_WIPMsgPassword")]
    protected Info _WIPMsgPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_IsEnabled")]
    protected Info _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_WriteToHistory")]
    protected Info _WriteToHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_PasswordRequired")]
    protected Info _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_AcknowledgmentRequired")]
    protected Info _AcknowledgmentRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_StopProcessing")]
    protected Info _StopProcessing;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_SendNotification")]
    protected Info _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_TriggerAction")]
    protected Info _TriggerAction;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_DocumentBrowseMode")]
    protected Info _DocumentBrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_RelevantServiceType")]
    protected Info _RelevantServiceType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_TextVariables")]
    protected Info _TextVariables;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_Document")]
    protected Info _Document;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_MsgText")]
    protected Info _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_DocumentIdentifier")]
    protected Info _DocumentIdentifier;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_RelevantServiceName")]
    protected Info _RelevantServiceName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_NotificationTargets")]
    protected Info _NotificationTargets;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_ChangeStatus")]
    protected Info _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_ContactInfo")]
    protected Info _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Info_MsgAction")]
    protected Info _MsgAction;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public Info IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Info EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDateGMT));
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

    public Info EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDateGMT));
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

    public Info DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentBrowseMode));
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

    public Info DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentIdentifier));
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
