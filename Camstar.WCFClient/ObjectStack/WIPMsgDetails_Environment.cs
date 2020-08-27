// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetails_Environment
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
  public class WIPMsgDetails_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Password", "", false, false, true, "PasswordFieldType", 1049064, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_WIPMsgPassword")]
    protected Environment _WIPMsgPassword;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_HoldReason")]
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, true, "NamedObjectRef", 1048800, false, false, true, null)]
    protected Environment _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_IsEnabled")]
    [Metadata("Determines, based on Status and Effective From and Thru dates whether a CDO should be considered for processing.\r\nIf a field is not found within the CDO, a positive result is assumed.", "", false, false, true, "Boolean", 1049431, false, false, false, "1")]
    protected Environment _IsEnabled;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_EffectiveThruDateGMT")]
    protected Environment _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_WriteToHistory")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048747, false, false, false, "0")]
    protected Environment _WriteToHistory;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048754, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_PasswordRequired")]
    protected Environment _PasswordRequired;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049057, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_AcknowledgmentRequired")]
    protected Environment _AcknowledgmentRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_StopProcessing")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048755, false, false, false, "0")]
    protected Environment _StopProcessing;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048757, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_SendNotification")]
    protected Environment _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049027, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_TriggerAction")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048756, false, false, false, "0")]
    protected Environment _TriggerAction;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_EffectiveFromDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049026, false, false, false, null)]
    protected Environment _EffectiveFromDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048744, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_EffectiveFromDate")]
    protected Environment _EffectiveFromDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16779312, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_DocumentBrowseMode")]
    protected Environment _DocumentBrowseMode;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049841, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_RelevantServiceType")]
    protected Environment _RelevantServiceType;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049059, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_CreationDate")]
    protected Environment _CreationDate;
    [Metadata("String to be evaluated to produce a value at run-time.", "", false, false, true, "String", 1048933, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_TextVariables")]
    protected Environment _TextVariables;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_Document")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, true, "RevisionedObjectRef", 1048606, false, false, false, null)]
    protected Environment _Document;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_MsgText")]
    [Metadata("Message text.", "", false, false, true, "String", 1048746, false, false, false, null)]
    protected Environment _MsgText;
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, false, true, "String", 1051057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_DocumentIdentifier")]
    protected Environment _DocumentIdentifier;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1049411, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_RelevantServiceName")]
    protected Environment _RelevantServiceName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_NotificationTargets")]
    [Metadata("A Notification Target is used to define the recipient of a message that originates during the processing of a transaction. An e-mail message is a typical example. The Notification Target describes the mechanism for delivering the message (e-mail, page, fax, system alert, etc.) and any additional details that are required for a particular delivery mechanism.", "NotificationTarget", false, false, true, "NamedObjectRef", 1048758, false, true, false, null)]
    protected Environment _NotificationTargets;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_ChangeStatus")]
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "SubentityRef", 1048970, false, false, false, null)]
    protected Environment _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Message text.", "", false, false, true, "String", 1049058, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_ContactInfo")]
    protected Environment _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetails_Environment_MsgAction")]
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nAn Action Definition is a mechanism for providing all of the information required to invoke an action (i.e., launch a CLF) as part of a transaction. Examples of where this might be used include:\r\n\r\n- Trigger corrective action through a Cell Control application\r\n- Activating a WIP Message in order to stop a given process\r\n- Sending a notification message to a specific Notification Target", "ActionDefinition_V4", false, false, true, "NamedObjectRef", 1049061, false, false, false, null)]
    protected Environment _MsgAction;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment WIPMsgPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgPassword));
      }
    }

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Environment IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Environment EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Environment WriteToHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (WriteToHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WriteToHistory));
      }
    }

    public Environment PasswordRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (PasswordRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PasswordRequired));
      }
    }

    public Environment AcknowledgmentRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcknowledgmentRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AcknowledgmentRequired));
      }
    }

    public Environment StopProcessing
    {
      [param: In] set
      {
        this.PropertySet(nameof (StopProcessing), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StopProcessing));
      }
    }

    public Environment SendNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SendNotification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SendNotification));
      }
    }

    public Environment EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Environment TriggerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriggerAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriggerAction));
      }
    }

    public Environment EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Environment EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Environment DocumentBrowseMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentBrowseMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentBrowseMode));
      }
    }

    public Environment RelevantServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelevantServiceType));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment TextVariables
    {
      [param: In] set
      {
        this.PropertySet(nameof (TextVariables), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TextVariables));
      }
    }

    public Environment Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Document));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment MsgText
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MsgText));
      }
    }

    public Environment DocumentIdentifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentIdentifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentIdentifier));
      }
    }

    public Environment RelevantServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelevantServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelevantServiceName));
      }
    }

    public Environment NotificationTargets
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationTargets), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotificationTargets));
      }
    }

    public Environment ChangeStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangeStatus));
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

    public Environment ContactInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactInfo));
      }
    }

    public Environment MsgAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (MsgAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MsgAction));
      }
    }
  }
}
