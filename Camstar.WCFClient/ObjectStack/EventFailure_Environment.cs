// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailure_Environment
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
  public class EventFailure_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_FailureSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, true, "NamedObjectRef", 1051065, false, false, false, null)]
    protected Environment _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_FailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050450, false, false, false, null)]
    protected Environment _FailureType;
    [Metadata("Comments", "", false, false, true, "String", 1052964, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_FailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, true, "NamedObjectRef", 1051064, false, false, false, null)]
    protected Environment _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_Causes")]
    [Metadata("Identifies a failure cause for an Event.", "EventFailureCause", false, false, true, "EventFailureCause", 1052942, false, true, false, null)]
    protected EventFailureCause_Environment _Causes;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051081, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailure_Environment_Description")]
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

    public EventFailureCause_Environment Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (EventFailureCause_Environment) this.PropertyGet(nameof (Causes));
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
