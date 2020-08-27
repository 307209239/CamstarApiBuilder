// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageApprovalReminderChanges_Environment
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
  public class PackageApprovalReminderChanges_Environment : EmailReminderChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_Environment_ObjectToChange")]
    [Metadata("Details for an ChangeMgtSettings that is used to determine if an email for Package Approval Reminders will be sent.", "PackageApprovalReminder", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Recipient of the Package Approval Reminders\r\n1 = Owner\r\n2 = Approvers\r\n3 = Approver Escalation Recipients", "PkgApprovalEnum", false, true, false, "Integer", 1049599, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_Environment_Recipient")]
    protected Environment _Recipient;
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_Environment_ListItemToChange")]
    [Metadata("PackageApprovalReminder changes", "PackageApprovalReminderChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 16778447, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PackageApprovalReminderChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

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

    public Environment Recipient
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipient), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Recipient));
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

    public new Environment IsFrozen
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
