// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureHistoryDetail_Environment
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
  public class EventFailureHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_FailureSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1051065, false, false, true, null)]
    protected Environment _FailureSeverity;
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050450, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_FailureType")]
    protected Environment _FailureType;
    [Metadata("Comments", "", false, false, true, "String", 1052964, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051064, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_FailureMode")]
    protected Environment _FailureMode;
    [Metadata("EventFailureCauseHistoryDetail", "EventFailureCauseHistoryDetail", false, false, true, "EventFailureCauseHistoryDetail", 1052966, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_EventFailureCauseHistoryDetails")]
    protected EventFailureCauseHistoryDetail_Environment _EventFailureCauseHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Environment_Description")]
    protected Environment _Description;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public EventFailureCauseHistoryDetail_Environment EventFailureCauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseHistoryDetail_Environment) this.PropertyGet(nameof (EventFailureCauseHistoryDetails));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
