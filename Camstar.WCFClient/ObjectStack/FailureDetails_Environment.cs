// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDetails_Environment
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
  public class FailureDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1050450, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_FailureType")]
    protected Environment _FailureType;
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051064, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_FailureMode")]
    protected Environment _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_FailureSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1051065, false, false, false, null)]
    protected Environment _FailureSeverity;
    [Metadata("Failure Cause Details", "FailureCauseDetails", false, false, false, "FailureCauseDetails", 1052254, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_Causes")]
    protected FailureCauseDetails_Environment _Causes;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_FailureData")]
    [Metadata("Failure data related to a quality object.", "FailureData", false, false, false, "SubentityRef", 1052096, false, false, false, null)]
    protected Environment _FailureData;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Environment_Description")]
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

    public FailureCauseDetails_Environment Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (FailureCauseDetails_Environment) this.PropertyGet(nameof (Causes));
      }
    }

    public Environment FailureData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureData));
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
