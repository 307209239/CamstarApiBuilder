// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NotificationTargetMaint_Environment
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
  public class NotificationTargetMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_Environment_ObjectChanges")]
    [Metadata("Used as a working area during NotificationTarget maintenance\r\n", "NotificationTargetChanges", false, false, false, "NotificationTargetChanges", 1048873, true, false, false, null)]
    protected NotificationTargetChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_Environment_ObjectToChange")]
    [Metadata("A Notification Target is used to define the recipient of a message that originates during the processing of a transaction. An e-mail message is a typical example. The Notification Target describes the mechanism for delivering the message (e-mail, page, fax, system alert, etc.) and any additional details that are required for a particular delivery mechanism.", "NotificationTarget", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NotificationTargetMaint_Environment_ObjectListInquiry")]
    [Metadata("A Notification Target is used to define the recipient of a message that originates during the processing of a transaction. An e-mail message is a typical example. The Notification Target describes the mechanism for delivering the message (e-mail, page, fax, system alert, etc.) and any additional details that are required for a particular delivery mechanism.", "NotificationTarget", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public NotificationTargetChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NotificationTargetChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
