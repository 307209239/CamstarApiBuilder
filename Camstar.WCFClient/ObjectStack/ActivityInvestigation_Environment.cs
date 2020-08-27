// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigation_Environment
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
  public class ActivityInvestigation_Environment : Activity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_Environment_NewProcessObjects")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "NamedSubentityRef", 1052253, false, true, false, null)]
    protected Environment _NewProcessObjects;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_Environment_Failures")]
    [Metadata("Failure data related to a quality object.", "FailureData", false, false, true, "FailureData", 1051077, false, true, false, null)]
    protected FailureData_Environment _Failures;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigation_Environment_Name")]
    protected new Environment _Name;

    public Environment NewProcessObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewProcessObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewProcessObjects));
      }
    }

    public FailureData_Environment Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureData_Environment) this.PropertyGet(nameof (Failures));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
