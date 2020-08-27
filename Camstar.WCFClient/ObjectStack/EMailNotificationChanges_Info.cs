// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailNotificationChanges_Info
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
  public class EMailNotificationChanges_Info : NotificationTargetChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_Recipient")]
    protected Info _Recipient;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_Sender")]
    protected Info _Sender;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_DeliveryMethod")]
    protected new Info _DeliveryMethod;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Info_EMailProfile")]
    protected Info _EMailProfile;

    public Info Recipient
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recipient), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Recipient));
      }
    }

    public Info Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sender));
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

    public new Info DeliveryMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryMethod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeliveryMethod));
      }
    }

    public Info EMailProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailProfile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailProfile));
      }
    }
  }
}
