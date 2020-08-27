// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLogDetail
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
  public class EventLogDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_CommentType")]
    protected NamedObjectRef _CommentType;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_EventLog")]
    protected SubentityRef _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Employee")]
    protected NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Comments")]
    protected Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is EventLogDetail && object.Equals((object) this._CommentType, (object) ((EventLogDetail) obj)._CommentType) && (object.Equals((object) this._EventLog, (object) ((EventLogDetail) obj)._EventLog) && object.Equals((object) this._CreationDateGMT, (object) ((EventLogDetail) obj)._CreationDateGMT)) && (object.Equals((object) this._CreationDate, (object) ((EventLogDetail) obj)._CreationDate) && object.Equals((object) this._Employee, (object) ((EventLogDetail) obj)._Employee) && object.Equals((object) this._Comments, (object) ((EventLogDetail) obj)._Comments)) && base.Equals(obj);
    }

    public NamedObjectRef CommentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CommentType));
      }
    }

    public SubentityRef EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventLog));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
