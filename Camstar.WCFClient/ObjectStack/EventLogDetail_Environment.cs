// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLogDetail_Environment
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
  public class EventLogDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_CommentType")]
    [Metadata("Comment Type for Production Event Log", "CommentType", false, false, false, "NamedObjectRef", 1052953, false, false, true, null)]
    protected Environment _CommentType;
    [Metadata("Identifies a Log for an Event.", "EventLog", false, false, false, "SubentityRef", 1052956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_EventLog")]
    protected Environment _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_CreationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052951, false, false, false, null)]
    protected Environment _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_CreationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049059, false, false, false, null)]
    protected Environment _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, true, null)]
    protected Environment _Employee;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049480, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLogDetail_Environment_Comments")]
    protected Environment _Comments;

    public Environment CommentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CommentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CommentType));
      }
    }

    public Environment EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventLog));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Employee));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
