// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtApplicationChanges
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
  public class ChangeMgtApplicationChanges : ApplicationChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_ContentCollaborationReminders")]
    protected ContentCollabReminderChanges[] _ContentCollaborationReminders;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_PackageApprovalReminders")]
    protected PackageApprovalReminderChanges[] _PackageApprovalReminders;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_NotificationEvents")]
    protected ChangeMgtNotificationEventChgs[] _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_MaxWhereUsedInstances")]
    protected Primitive<int> _MaxWhereUsedInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtApplicationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtApplicationChanges && this.CompareArrays((Array) this._ContentCollaborationReminders, (Array) ((ChangeMgtApplicationChanges) obj)._ContentCollaborationReminders) && (this.CompareArrays((Array) this._PackageApprovalReminders, (Array) ((ChangeMgtApplicationChanges) obj)._PackageApprovalReminders) && this.CompareArrays((Array) this._NotificationEvents, (Array) ((ChangeMgtApplicationChanges) obj)._NotificationEvents)) && (object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtApplicationChanges) obj)._ObjectToChange) && object.Equals((object) this._MaxWhereUsedInstances, (object) ((ChangeMgtApplicationChanges) obj)._MaxWhereUsedInstances) && object.Equals((object) this._Name, (object) ((ChangeMgtApplicationChanges) obj)._Name)) && base.Equals(obj);
    }

    public ContentCollabReminderChanges[] ContentCollaborationReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentCollaborationReminders), (object) value);
      }
      get
      {
        return (ContentCollabReminderChanges[]) this.PropertyGet(nameof (ContentCollaborationReminders));
      }
    }

    public PackageApprovalReminderChanges[] PackageApprovalReminders
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageApprovalReminders), (object) value);
      }
      get
      {
        return (PackageApprovalReminderChanges[]) this.PropertyGet(nameof (PackageApprovalReminders));
      }
    }

    public ChangeMgtNotificationEventChgs[] NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (ChangeMgtNotificationEventChgs[]) this.PropertyGet(nameof (NotificationEvents));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> MaxWhereUsedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWhereUsedInstances), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxWhereUsedInstances));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
