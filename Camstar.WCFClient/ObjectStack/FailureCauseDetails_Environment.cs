// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDetails_Environment
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
  public class FailureCauseDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Environment_Cause")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1051703, false, false, true, null)]
    protected Environment _Cause;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Failure Plan Details", "FailurePlanDetails", false, false, false, "FailurePlanDetails", 1052145, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Environment_FailurePlans")]
    protected FailurePlanDetails_Environment _FailurePlans;
    [Metadata("One of the causes of the failure.", "FailureCauseData", false, false, false, "SubentityRef", 1052094, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Environment_FailureCauseData")]
    protected Environment _FailureCauseData;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051704, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Environment_RootCauseConfirmed")]
    protected Environment _RootCauseConfirmed;

    public Environment Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Cause));
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

    public FailurePlanDetails_Environment FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanDetails_Environment) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public Environment FailureCauseData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureCauseData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureCauseData));
      }
    }

    public Environment RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RootCauseConfirmed));
      }
    }
  }
}
