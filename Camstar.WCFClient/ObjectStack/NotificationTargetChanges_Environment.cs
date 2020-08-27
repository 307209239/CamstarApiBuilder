// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationTargetChanges_Environment
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
  public class NotificationTargetChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Method of delivery:\r\n\r\n1 = E-Mail", "DeliveryMethodEnum", false, false, true, "Integer", 1048908, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_Environment_DeliveryMethod")]
    protected Environment _DeliveryMethod;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_Environment_ObjectToChange")]
    [Metadata("A Notification Target is used to define the recipient of a message that originates during the processing of a transaction. An e-mail message is a typical example. The Notification Target describes the mechanism for delivering the message (e-mail, page, fax, system alert, etc.) and any additional details that are required for a particular delivery mechanism.", "NotificationTarget", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050069, false, false, false, null)]
    protected new Environment _Name;

    public Environment DeliveryMethod
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
  }
}
