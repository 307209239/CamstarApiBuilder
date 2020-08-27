// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStart_Info
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
  public class BatchStart_Info : Start_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Info_Details")]
    protected BatchStartDetails_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Info_IncludeFulfillledOrders")]
    protected Info _IncludeFulfillledOrders;

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public BatchStartDetails_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (BatchStartDetails_Info) this.PropertyGet(nameof (Details));
      }
    }

    public Info IncludeFulfillledOrders
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeFulfillledOrders), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeFulfillledOrders));
      }
    }
  }
}
