// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetails
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
  public class WIPMsgDetails : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_WIPMsgPassword")]
    protected PasswordFieldType _WIPMsgPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_IsEnabled")]
    protected Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_WriteToHistory")]
    protected Primitive<bool> _WriteToHistory;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_PasswordRequired")]
    protected Primitive<bool> _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_AcknowledgmentRequired")]
    protected Primitive<bool> _AcknowledgmentRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_StopProcessing")]
    protected Primitive<bool> _StopProcessing;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_SendNotification")]
    protected Primitive<bool> _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_TriggerAction")]
    protected Primitive<bool> _TriggerAction;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_DocumentBrowseMode")]
    protected Primitive<int> _DocumentBrowseMode;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_RelevantServiceType")]
    protected Primitive<int> _RelevantServiceType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_TextVariables")]
    protected Primitive<string> _TextVariables;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Document")]
    protected RevisionedObjectRef _Document;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Status")]
    protected Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_MsgText")]
    protected Primitive<string> _MsgText;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_DocumentIdentifier")]
    protected Primitive<string> _DocumentIdentifier;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_RelevantServiceName")]
    protected Primitive<string> _RelevantServiceName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_NotificationTargets")]
    protected NamedObjectRef[] _NotificationTargets;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_ChangeStatus")]
    protected SubentityRef _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_ContactInfo")]
    protected Primitive<string> _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_MsgAction")]
    protected NamedObjectRef _MsgAction;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgDetails && object.Equals((object) this._ExportImportKey, (object) ((WIPMsgDetails) obj)._ExportImportKey) && (object.Equals((object) this._WIPMsgPassword, (object) ((WIPMsgDetails) obj)._WIPMsgPassword) && object.Equals((object) this._HoldReason, (object) ((WIPMsgDetails) obj)._HoldReason)) && (object.Equals((object) this._IsEnabled, (object) ((WIPMsgDetails) obj)._IsEnabled) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((WIPMsgDetails) obj)._EffectiveThruDateGMT) && (object.Equals((object) this._WriteToHistory, (object) ((WIPMsgDetails) obj)._WriteToHistory) && object.Equals((object) this._PasswordRequired, (object) ((WIPMsgDetails) obj)._PasswordRequired))) && (object.Equals((object) this._AcknowledgmentRequired, (object) ((WIPMsgDetails) obj)._AcknowledgmentRequired) && object.Equals((object) this._StopProcessing, (object) ((WIPMsgDetails) obj)._StopProcessing) && (object.Equals((object) this._SendNotification, (object) ((WIPMsgDetails) obj)._SendNotification) && object.Equals((object) this._EffectiveThruDate, (object) ((WIPMsgDetails) obj)._EffectiveThruDate)) && (object.Equals((object) this._TriggerAction, (object) ((WIPMsgDetails) obj)._TriggerAction) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((WIPMsgDetails) obj)._EffectiveFromDateGMT) && (object.Equals((object) this._EffectiveFromDate, (object) ((WIPMsgDetails) obj)._EffectiveFromDate) && object.Equals((object) this._DocumentBrowseMode, (object) ((WIPMsgDetails) obj)._DocumentBrowseMode)))) && (object.Equals((object) this._RelevantServiceType, (object) ((WIPMsgDetails) obj)._RelevantServiceType) && object.Equals((object) this._CreationDate, (object) ((WIPMsgDetails) obj)._CreationDate) && (object.Equals((object) this._TextVariables, (object) ((WIPMsgDetails) obj)._TextVariables) && object.Equals((object) this._Document, (object) ((WIPMsgDetails) obj)._Document)) && (object.Equals((object) this._Status, (object) ((WIPMsgDetails) obj)._Status) && object.Equals((object) this._MsgText, (object) ((WIPMsgDetails) obj)._MsgText) && (object.Equals((object) this._DocumentIdentifier, (object) ((WIPMsgDetails) obj)._DocumentIdentifier) && object.Equals((object) this._RelevantServiceName, (object) ((WIPMsgDetails) obj)._RelevantServiceName))) && (this.CompareArrays((Array) this._NotificationTargets, (Array) ((WIPMsgDetails) obj)._NotificationTargets) && object.Equals((object) this._ChangeStatus, (object) ((WIPMsgDetails) obj)._ChangeStatus) && (object.Equals((object) this._IsFrozen, (object) ((WIPMsgDetails) obj)._IsFrozen) && object.Equals((object) this._ContactInfo, (object) ((WIPMsgDetails) obj)._ContactInfo)) && object.Equals((object) this._MsgAction, (object) ((WIPMsgDetails) obj)._MsgAction))) && base.Equals(obj);
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

    public Primitive<bool> IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Primitive<DateTime> EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDateGMT));
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

    public Primitive<DateTime> EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDateGMT));
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

    public Primitive<int> DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DocumentBrowseMode));
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

    public Primitive<string> DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentIdentifier));
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
