// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchDispense_Environment
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
  public class BatchDispense_Environment : ComponentIssue_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    protected new Environment _Carrier;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, true, false, "ContainerRef", 1051854, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_Batch")]
    protected Environment _Batch;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_Container")]
    [Metadata("Material Container", "MaterialContainer", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_MasterRecipe")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    protected Environment _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_UseMaterialFromBatch")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051821, false, false, false, "1")]
    protected Environment _UseMaterialFromBatch;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050229, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_BatchRecipeName")]
    protected Environment _BatchRecipeName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_BatchProductName")]
    protected Environment _BatchProductName;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected new Environment _Operation;

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

    public new Environment Carrier
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

    public Environment Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Batch));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public Environment UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Environment BatchRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchRecipeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchRecipeName));
      }
    }

    public Environment BatchProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchProductName));
      }
    }

    public new Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
