// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtApplicationChanges_Environment
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
  public class ChangeMgtApplicationChanges_Environment : ApplicationChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_ContentCollaborationReminders")]
    [Metadata("ContentCollaborationReminder changes", "ContentCollabReminderChanges", false, false, false, "ContentCollabReminderChanges", 16778468, false, true, false, null)]
    protected ContentCollabReminderChanges_Environment _ContentCollaborationReminders;
    [Metadata("PackageApprovalReminder changes", "PackageApprovalReminderChanges", false, false, false, "PackageApprovalReminderChanges", 16778470, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_PackageApprovalReminders")]
    protected PackageApprovalReminderChanges_Environment _PackageApprovalReminders;
    [Metadata("Details for Change Mgt Application to configure Notification Events.", "ChangeMgtNotificationEventChgs", false, false, false, "ChangeMgtNotificationEventChgs", 1051748, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_NotificationEvents")]
    protected ChangeMgtNotificationEventChgs_Environment _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_ObjectToChange")]
    [Metadata("Configuration settings specific to Change Management.", "ChangeMgtApplication", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778190, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_MaxWhereUsedInstances")]
    protected Environment _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053253, false, false, false, null)]
    protected new Environment _Name;

    public ContentCollabReminderChanges_Environment ContentCollaborationReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentCollaborationReminders), (object) value);
      }
      get
      {
        return (ContentCollabReminderChanges_Environment) this.PropertyGet(nameof (ContentCollaborationReminders));
      }
    }

    public PackageApprovalReminderChanges_Environment PackageApprovalReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageApprovalReminders), (object) value);
      }
      get
      {
        return (PackageApprovalReminderChanges_Environment) this.PropertyGet(nameof (PackageApprovalReminders));
      }
    }

    public ChangeMgtNotificationEventChgs_Environment NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (ChangeMgtNotificationEventChgs_Environment) this.PropertyGet(nameof (NotificationEvents));
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

    public Environment MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Environment Name
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
  }
}
