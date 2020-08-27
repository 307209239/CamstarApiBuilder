// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtNotificationEventChgs_Environment
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
  public class ChangeMgtNotificationEventChgs_Environment : NotificationEventChanges_Environment
  {
    [Metadata("Details for Change Mgt Application to configure Notification Events.", "ChangeMgtNotificationEventChgs", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, true, false, "NamedObjectRef", 1051744, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Environment_EMailMessage")]
    protected new Environment _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Environment_NotificationType")]
    [Metadata("The type of actions that will cause an EMail to be sent.", "NotificationTypeEnum", false, true, false, "Integer", 1051759, false, false, true, null)]
    protected new Environment _NotificationType;
    [Metadata("Details for Change Mgt Application to configure Notification Events.", "ChangeMgtNotificationEvent", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

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

    public new Environment EMailMessage
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

    public new Environment NotificationType
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
  }
}
