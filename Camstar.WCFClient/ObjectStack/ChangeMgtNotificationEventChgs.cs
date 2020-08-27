// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtNotificationEventChgs
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
  public class ChangeMgtNotificationEventChgs : NotificationEventChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_EMailMessage")]
    protected new NamedObjectRef _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_NotificationType")]
    protected new Enumeration<NotificationTypeEnum, int> _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is ChangeMgtNotificationEventChgs && object.Equals((object) this._ListItemToChange, (object) ((ChangeMgtNotificationEventChgs) obj)._ListItemToChange) && (object.Equals((object) this._EMailMessage, (object) ((ChangeMgtNotificationEventChgs) obj)._EMailMessage) && object.Equals((object) this._NotificationType, (object) ((ChangeMgtNotificationEventChgs) obj)._NotificationType)) && object.Equals((object) this._ObjectToChange, (object) ((ChangeMgtNotificationEventChgs) obj)._ObjectToChange) && base.Equals(obj);
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

    public new NamedObjectRef EMailMessage
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

    public new Enumeration<NotificationTypeEnum, int> NotificationType
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
  }
}
