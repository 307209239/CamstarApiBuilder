// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationEventChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeMgtNotificationEventChgs_Environment))]
  [Serializable]
  public class NotificationEventChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_EMailMessage")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, true, false, "NamedObjectRef", 1051744, false, false, true, null)]
    protected Environment _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_NotificationType")]
    [Metadata("The type of actions that will cause an EMail to be sent.", "NotificationTypeEnum", false, true, false, "Integer", 1051759, false, false, true, null)]
    protected Environment _NotificationType;
    [Metadata("Details for an Organization that is used to determine if an email will be sent.", "NotificationEventChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_ObjectToChange")]
    [Metadata("Details for an Organization that is used to determine if an email will be sent.", "NotificationEvent", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_EMailDistribution")]
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, false, "NamedObjectRef", 1051746, false, false, true, null)]
    protected Environment _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_AppendConciergeMsg")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051745, false, false, false, "0")]
    protected Environment _AppendConciergeMsg;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_AssigneeOnly")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051747, false, false, false, "0")]
    protected Environment _AssigneeOnly;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1051788, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Environment NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotificationType));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public Environment AppendConciergeMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendConciergeMsg), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AppendConciergeMsg));
      }
    }

    public Environment AssigneeOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeOnly));
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
  }
}
