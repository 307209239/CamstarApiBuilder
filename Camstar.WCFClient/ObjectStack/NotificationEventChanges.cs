// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationEventChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChangeMgtNotificationEventChgs))]
  [Serializable]
  public class NotificationEventChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_EMailMessage")]
    protected NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_NotificationType")]
    protected Enumeration<NotificationTypeEnum, int> _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_EMailDistribution")]
    protected NamedObjectRef _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_AppendConciergeMsg")]
    protected Primitive<bool> _AppendConciergeMsg;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_AssigneeOnly")]
    protected Primitive<bool> _AssigneeOnly;
    [DataMember(EmitDefaultValue = false, Name = "NotificationEventChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NotificationEventChanges && object.Equals((object) this._EMailMessage, (object) ((NotificationEventChanges) obj)._EMailMessage) && (object.Equals((object) this._NotificationType, (object) ((NotificationEventChanges) obj)._NotificationType) && object.Equals((object) this._ListItemToChange, (object) ((NotificationEventChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((NotificationEventChanges) obj)._ObjectToChange) && object.Equals((object) this._EMailDistribution, (object) ((NotificationEventChanges) obj)._EMailDistribution) && (object.Equals((object) this._AppendConciergeMsg, (object) ((NotificationEventChanges) obj)._AppendConciergeMsg) && object.Equals((object) this._AssigneeOnly, (object) ((NotificationEventChanges) obj)._AssigneeOnly))) && object.Equals((object) this._IsFrozen, (object) ((NotificationEventChanges) obj)._IsFrozen) && base.Equals(obj);
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

    public Enumeration<NotificationTypeEnum, int> NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Enumeration<NotificationTypeEnum, int>) this.PropertyGet(nameof (NotificationType));
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

    public NamedObjectRef EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public Primitive<bool> AppendConciergeMsg
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendConciergeMsg), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AppendConciergeMsg));
      }
    }

    public Primitive<bool> AssigneeOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AssigneeOnly));
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
