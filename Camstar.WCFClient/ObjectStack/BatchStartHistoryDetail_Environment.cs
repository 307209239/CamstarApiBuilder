// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStartHistoryDetail_Environment
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
  public class BatchStartHistoryDetail_Environment : StartHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Environment_MasterRecipe")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    protected Environment _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Environment_BatchStatus")]
    [Metadata("Status of a Batch.", "BatchStatusEnum", false, false, true, "Integer", 1051840, false, false, false, null)]
    protected Environment _BatchStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Environment_BatchComments")]
    [Metadata("Message text.", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _BatchComments;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStartHistoryDetail_Environment_Qty")]
    protected new Environment _Qty;

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

    public Environment BatchStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchStatus));
      }
    }

    public Environment BatchComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BatchComments));
      }
    }

    public new Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
