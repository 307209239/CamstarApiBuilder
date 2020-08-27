// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDetailChanges_Environment
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
  public class WIPMsgDetailChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_HoldReason")]
    protected Environment _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_ObjectToChange")]
    [Metadata("A WIPMsgDetails object contains the basic definition of a single WIP Message.  It contains the unresolved text and any processing options and message configuration.", "WIPMsgDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_LITCListCDO")]
    [Metadata("Changes CDO for WIPMsgKey.", "WIPMsgKeyChanges", false, false, false, "SubentityRef", 1049365, false, false, false, null)]
    protected Environment _LITCListCDO;
    [Metadata("This object contains the resolved message and values used to acknowledge the message during processing.  It is a temporary object created during the GetWIPMsgs function.", "WIPMsg", false, false, false, "SubentityRef", 1049063, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_WIPMsg")]
    protected Environment _WIPMsg;
    [Metadata("Password", "", false, false, false, "PasswordFieldType", 1049064, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_WIPMsgPassword")]
    protected Environment _WIPMsgPassword;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048757, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_SendNotification")]
    protected Environment _SendNotification;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_RelevantServiceType")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049841, false, false, false, null)]
    protected Environment _RelevantServiceType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048747, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_WriteToHistory")]
    protected Environment _WriteToHistory;
    [Metadata("Generic String", "", false, false, false, "String", 1048933, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_TextVariables")]
    protected Environment _TextVariables;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049366, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_LITCListField")]
    protected Environment _LITCListField;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_PasswordRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048754, false, false, false, "0")]
    protected Environment _PasswordRequired;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_EffectiveFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048744, false, false, false, null)]
    protected Environment _EffectiveFromDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049059, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_CreationDate")]
    protected Environment _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_StopProcessing")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048755, false, false, false, "0")]
    protected Environment _StopProcessing;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049364, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_CreateDateGMT")]
    protected Environment _CreateDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_TriggerAction")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048756, false, false, false, "0")]
    protected Environment _TriggerAction;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_EffectiveThruDate")]
    protected Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_AcknowledgmentRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048752, false, false, false, "0")]
    protected Environment _AcknowledgmentRequired;
    [Metadata("Message text.", "", false, false, false, "String", 1048759, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_NotificationText")]
    protected Environment _NotificationText;
    [Metadata("A Notification Target is used to define the recipient of a message that originates during the processing of a transaction. An e-mail message is a typical example. The Notification Target describes the mechanism for delivering the message (e-mail, page, fax, system alert, etc.) and any additional details that are required for a particular delivery mechanism.", "NotificationTarget", false, false, false, "NamedObjectRef", 1048758, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_NotificationTargets")]
    protected Environment _NotificationTargets;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, false, "SubentityRef", 1048970, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_ChangeStatus")]
    protected Environment _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_ContactInfo")]
    [Metadata("Message text.", "", false, false, false, "String", 1049058, false, false, false, null)]
    protected Environment _ContactInfo;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected Environment _Name;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 1048606, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_Document")]
    protected Environment _Document;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_MsgText")]
    [Metadata("Message text.", "", false, true, false, "String", 1048746, false, false, false, null)]
    protected Environment _MsgText;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049411, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_RelevantServiceName")]
    protected Environment _RelevantServiceName;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_Status")]
    protected Environment _Status;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDetailChanges_Environment_MsgAction")]
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nAn Action Definition is a mechanism for providing all of the information required to invoke an action (i.e., launch a CLF) as part of a transaction. Examples of where this might be used include:\r\n\r\n- Trigger corrective action through a Cell Control application\r\n- Activating a WIP Message in order to stop a given process\r\n- Sending a notification message to a specific Notification Target", "ActionDefinition_V4", false, false, true, "NamedObjectRef", 1049061, false, false, true, null)]
    protected Environment _MsgAction;

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

    public Environment LITCListCDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListCDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LITCListCDO));
      }
    }

    public Environment WIPMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsg), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsg));
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

    public Environment LITCListField
    {
      [param: In] set
      {
        this.PropertySet(nameof (LITCListField), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LITCListField));
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

    public Environment CreateDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreateDateGMT));
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

    public Environment NotificationText
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotificationText));
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

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
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
