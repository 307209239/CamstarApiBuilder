// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmailReminderChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContentCollabReminderChanges_Info))]
  [KnownType(typeof (PackageApprovalReminderChanges_Info))]
  [Serializable]
  public class EmailReminderChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_EMailMessage")]
    protected Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_DaysBeforeDue")]
    protected Info _DaysBeforeDue;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_IsRepeatDaily")]
    protected Info _IsRepeatDaily;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_DaysAfterDue")]
    protected Info _DaysAfterDue;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info DaysBeforeDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysBeforeDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DaysBeforeDue));
      }
    }

    public Info IsRepeatDaily
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRepeatDaily), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRepeatDaily));
      }
    }

    public Info DaysAfterDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysAfterDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DaysAfterDue));
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
