// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmailReminderChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContentCollabReminderChanges))]
  [KnownType(typeof (PackageApprovalReminderChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class EmailReminderChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_EMailMessage")]
    protected NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_DaysBeforeDue")]
    protected Primitive<int> _DaysBeforeDue;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_IsRepeatDaily")]
    protected Primitive<bool> _IsRepeatDaily;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_DaysAfterDue")]
    protected Primitive<int> _DaysAfterDue;
    [DataMember(EmitDefaultValue = false, Name = "EmailReminderChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is EmailReminderChanges && object.Equals((object) this._ObjectToChange, (object) ((EmailReminderChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((EmailReminderChanges) obj)._ListItemToChange) && object.Equals((object) this._EMailMessage, (object) ((EmailReminderChanges) obj)._EMailMessage)) && (object.Equals((object) this._DaysBeforeDue, (object) ((EmailReminderChanges) obj)._DaysBeforeDue) && object.Equals((object) this._IsRepeatDaily, (object) ((EmailReminderChanges) obj)._IsRepeatDaily) && (object.Equals((object) this._DaysAfterDue, (object) ((EmailReminderChanges) obj)._DaysAfterDue) && object.Equals((object) this._IsFrozen, (object) ((EmailReminderChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Primitive<int> DaysBeforeDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysBeforeDue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DaysBeforeDue));
      }
    }

    public Primitive<bool> IsRepeatDaily
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRepeatDaily), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRepeatDaily));
      }
    }

    public Primitive<int> DaysAfterDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DaysAfterDue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DaysAfterDue));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
