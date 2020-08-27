// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLogDetail_Info
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
  public class EventLogDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_CommentType")]
    protected Info _CommentType;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_EventLog")]
    protected Info _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_CreationDateGMT")]
    protected Info _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_Employee")]
    protected Info _Employee;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Info_Comments")]
    protected Info _Comments;

    public Info CommentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CommentType));
      }
    }

    public Info EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventLog));
      }
    }

    public Info CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Employee));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
