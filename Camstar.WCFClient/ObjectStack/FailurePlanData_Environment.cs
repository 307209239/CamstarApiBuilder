// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanData_Environment
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
  public class FailurePlanData_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, true, "NamedSubentityRef", 1051188, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Environment_Plan")]
    protected Environment _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Environment_PlanType")]
    [Metadata("The usage of the plan for the cause of the failure.", "FailurePlanTypeEnum", false, false, true, "Integer", 1051706, false, false, false, null)]
    protected Environment _PlanType;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Plan));
      }
    }

    public Environment PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlanType));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
