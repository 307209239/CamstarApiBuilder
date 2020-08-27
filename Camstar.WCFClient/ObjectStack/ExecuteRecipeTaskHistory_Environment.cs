// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTaskHistory_Environment
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
  public class ExecuteRecipeTaskHistory_Environment : ExecuteTaskHistory_Environment
  {
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, true, "NamedObjectRef", 1049467, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_IssueDifferenceReason")]
    protected Environment _IssueDifferenceReason;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_ElectronicProcedure")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    protected new Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_MaterialContainer")]
    [Metadata("Material Container", "MaterialContainer", false, false, true, "ContainerRef", 1051878, false, false, false, null)]
    protected Environment _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051807, false, false, false, null)]
    protected Environment _Carrier;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051888, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTaskHistory_Environment_CompleteTaskForBatch")]
    protected Environment _CompleteTaskForBatch;

    public Environment IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public new Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Environment MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public Environment CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
