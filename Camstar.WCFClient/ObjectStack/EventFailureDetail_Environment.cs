// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureDetail_Environment
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
  public class EventFailureDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1050450, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_FailureType")]
    protected Environment _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_FailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051064, false, false, true, null)]
    protected Environment _FailureMode;
    [Metadata("Comments", "", false, false, false, "String", 1052964, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "SubentityRef", 1051070, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_EventFailure")]
    protected Environment _EventFailure;
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1051065, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_FailureSeverity")]
    protected Environment _FailureSeverity;
    [Metadata("Grouping mechanism for the FailureModes.  Identifies the possible FailureModes that can be assigned to an Event.", "FailureModeGroup", false, false, false, "NamedObjectRef", 1051035, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_FailureModeGroup")]
    protected Environment _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_EventFailureCauseDetails")]
    [Metadata("Identifies a failure cause for an Event.", "EventFailureCauseDetail", false, false, false, "EventFailureCauseDetail", 1052965, false, true, false, null)]
    protected EventFailureCauseDetail_Environment _EventFailureCauseDetails;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051081, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Environment_Description")]
    protected Environment _Description;

    public Environment FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureType));
      }
    }

    public Environment FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureMode));
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

    public Environment EventFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailure));
      }
    }

    public Environment FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public Environment FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public EventFailureCauseDetail_Environment EventFailureCauseDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseDetail_Environment) this.PropertyGet(nameof (EventFailureCauseDetails));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
