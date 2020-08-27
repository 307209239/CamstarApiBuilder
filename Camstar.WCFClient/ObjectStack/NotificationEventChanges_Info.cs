// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationEventChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangeMgtNotificationEventChgs_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NotificationEventChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_EMailMessage")]
    protected Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_NotificationType")]
    protected Info _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_EMailDistribution")]
    protected Info _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_AppendConciergeMsg")]
    protected Info _AppendConciergeMsg;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_AssigneeOnly")]
    protected Info _AssigneeOnly;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Info NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NotificationType));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public Info AppendConciergeMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendConciergeMsg), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AppendConciergeMsg));
      }
    }

    public Info AssigneeOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeOnly));
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
  }
}
