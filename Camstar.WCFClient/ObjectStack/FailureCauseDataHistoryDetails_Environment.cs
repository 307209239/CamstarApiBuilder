// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDataHistoryDetails_Environment
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
  public class FailureCauseDataHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Environment_Cause")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1052091, false, false, false, null)]
    protected Environment _Cause;
    [Metadata("FaliurePlan Data History Detail", "FailurePlanDataHistoryDetails", false, false, true, "FailurePlanDataHistoryDetails", 1052099, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Environment_FailurePlanHistoryDetails")]
    protected FailurePlanDataHistoryDetails_Environment _FailurePlanHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Environment_RootCauseConfirmed")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051704, false, false, false, "0")]
    protected Environment _RootCauseConfirmed;

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

    public FailurePlanDataHistoryDetails_Environment FailurePlanHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanHistoryDetails), (object) value);
      }
      get
      {
        return (FailurePlanDataHistoryDetails_Environment) this.PropertyGet(nameof (FailurePlanHistoryDetails));
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
