// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtApplicationChanges_Info
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
  public class ChangeMgtApplicationChanges_Info : ApplicationChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_ContentCollaborationReminders")]
    protected ContentCollabReminderChanges_Info _ContentCollaborationReminders;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_PackageApprovalReminders")]
    protected PackageApprovalReminderChanges_Info _PackageApprovalReminders;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_NotificationEvents")]
    protected ChangeMgtNotificationEventChgs_Info _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_MaxWhereUsedInstances")]
    protected Info _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Info_Name")]
    protected new Info _Name;

    public ContentCollabReminderChanges_Info ContentCollaborationReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentCollaborationReminders), (object) value);
      }
      get
      {
        return (ContentCollabReminderChanges_Info) this.PropertyGet(nameof (ContentCollaborationReminders));
      }
    }

    public PackageApprovalReminderChanges_Info PackageApprovalReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageApprovalReminders), (object) value);
      }
      get
      {
        return (PackageApprovalReminderChanges_Info) this.PropertyGet(nameof (PackageApprovalReminders));
      }
    }

    public ChangeMgtNotificationEventChgs_Info NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (ChangeMgtNotificationEventChgs_Info) this.PropertyGet(nameof (NotificationEvents));
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

    public Info MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Info Name
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
  }
}
