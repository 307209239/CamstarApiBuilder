// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStart_Environment
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
  public class BatchStart_Environment : Start_Environment
  {
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Environment_Container")]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Environment_Details")]
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "BatchStartDetails", false, true, false, "BatchStartDetails", 1049090, true, false, false, null)]
    protected BatchStartDetails_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Environment_IncludeFulfillledOrders")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051845, false, false, false, "0")]
    protected Environment _IncludeFulfillledOrders;

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

    public BatchStartDetails_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (BatchStartDetails_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public Environment IncludeFulfillledOrders
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeFulfillledOrders), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeFulfillledOrders));
      }
    }
  }
}
