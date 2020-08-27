// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmailReminderChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PackageApprovalReminderChanges_Environment))]
  [KnownType(typeof (ContentCollabReminderChanges_Environment))]
  [Serializable]
  public class EmailReminderChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Details for an ChangeMgtSettings that is used to determine if an email will be sent.", "EmailReminder", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_ListItemToChange")]
    [Metadata("E-mail reminder changes", "EmailReminderChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, true, false, "NamedObjectRef", 1053036, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_EMailMessage")]
    protected Environment _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_DaysBeforeDue")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778441, false, false, false, null)]
    protected Environment _DaysBeforeDue;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_IsRepeatDaily")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778446, false, false, false, "0")]
    protected Environment _IsRepeatDaily;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778440, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_DaysAfterDue")]
    protected Environment _DaysAfterDue;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 16778447, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment DaysBeforeDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysBeforeDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DaysBeforeDue));
      }
    }

    public Environment IsRepeatDaily
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRepeatDaily), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRepeatDaily));
      }
    }

    public Environment DaysAfterDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysAfterDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DaysAfterDue));
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
