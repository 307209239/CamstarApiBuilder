// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectLotSamplingDataHistory_Environment
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
  public class CollectLotSamplingDataHistory_Environment : CollectSamplingDataHistory_Environment
  {
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingDataHistory_Environment_SamplingLot")]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingDataHistory_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    protected Environment _MfgOrder;

    public Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
