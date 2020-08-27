// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailNotificationChanges_Environment
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
  public class EMailNotificationChanges_Environment : NotificationTargetChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_Recipient")]
    [Metadata("E-mail Address", "", false, true, false, "String", 1049599, false, false, false, null)]
    protected Environment _Recipient;
    [Metadata("E-mail Address", "", false, false, false, "String", 1049907, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_Sender")]
    protected Environment _Sender;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_ObjectToChange")]
    [Metadata("A subclass of a NotificationTarget that sends its information by e-mail.", "EMailNotification", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050070, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_DeliveryMethod")]
    [Metadata("Method of delivery:\r\n\r\n1 = E-Mail", "DeliveryMethodEnum", false, false, true, "Integer", 1048908, false, false, true, "1")]
    protected new Environment _DeliveryMethod;
    [DataMember(EmitDefaultValue = false, Name = "EMailNotificationChanges_Environment_EMailProfile")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049598, false, false, false, null)]
    protected Environment _EMailProfile;

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

    public Environment Sender
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sender), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sender));
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

    public new Environment DeliveryMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryMethod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeliveryMethod));
      }
    }

    public Environment EMailProfile
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailProfile), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailProfile));
      }
    }
  }
}
