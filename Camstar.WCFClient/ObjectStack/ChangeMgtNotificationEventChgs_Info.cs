// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtNotificationEventChgs_Info
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
  public class ChangeMgtNotificationEventChgs_Info : NotificationEventChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Info_EMailMessage")]
    protected new Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Info_NotificationType")]
    protected new Info _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtNotificationEventChgs_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

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

    public new Info EMailMessage
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

    public new Info NotificationType
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
  }
}
