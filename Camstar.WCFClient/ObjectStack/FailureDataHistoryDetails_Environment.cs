// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDataHistoryDetails_Environment
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
  public class FailureDataHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Environment_FailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1052090, false, false, false, null)]
    protected Environment _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Environment_FailureSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, true, "NamedObjectRef", 1051065, false, false, false, null)]
    protected Environment _FailureSeverity;
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, true, "NamedObjectRef", 1051064, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Environment_FailureMode")]
    protected Environment _FailureMode;
    [Metadata("FailureCause DataHistory Details", "FailureCauseDataHistoryDetails", false, false, true, "FailureCauseDataHistoryDetails", 1052100, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Environment_CauseHistoryDetails")]
    protected FailureCauseDataHistoryDetails_Environment _CauseHistoryDetails;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Environment_Description")]
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

    public FailureCauseDataHistoryDetails_Environment CauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseHistoryDetails), (object) value);
      }
      get
      {
        return (FailureCauseDataHistoryDetails_Environment) this.PropertyGet(nameof (CauseHistoryDetails));
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
