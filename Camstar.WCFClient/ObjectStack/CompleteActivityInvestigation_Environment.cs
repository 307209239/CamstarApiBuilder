// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvestigation_Environment
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
  public class CompleteActivityInvestigation_Environment : CompleteActivity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Environment_ProcessObject")]
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, true, false, "NamedSubentityRef", 1050968, false, false, false, null)]
    protected new Environment _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Environment_Activity")]
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, true, "NamedSubentityRef", 1050968, false, false, false, null)]
    protected new Environment _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Environment_Failures")]
    [Metadata("Failure Details", "FailureDetails", false, false, false, "FailureDetails", 1051064, false, true, false, null)]
    protected FailureDetails_Environment _Failures;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Environment_ProcessObjectDetails")]
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, true, "ActivityInvestigation", 1051538, false, false, false, null)]
    protected ActivityInvestigation_Environment _ProcessObjectDetails;

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Environment Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activity));
      }
    }

    public FailureDetails_Environment Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureDetails_Environment) this.PropertyGet(nameof (Failures));
      }
    }

    public ActivityInvestigation_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityInvestigation_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
