// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchStart
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
  public class BatchStart : Start
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_Details")]
    protected BatchStartDetails _Details;
    [DataMember(EmitDefaultValue = false, Name = "BatchStart_IncludeFulfillledOrders")]
    protected Primitive<bool> _IncludeFulfillledOrders;

    public override bool Equals(object obj)
    {
      return obj is BatchStart && object.Equals((object) this._Container, (object) ((BatchStart) obj)._Container) && (object.Equals((object) this._Details, (object) ((BatchStart) obj)._Details) && object.Equals((object) this._IncludeFulfillledOrders, (object) ((BatchStart) obj)._IncludeFulfillledOrders)) && base.Equals(obj);
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public BatchStartDetails Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (BatchStartDetails) this.PropertyGet(nameof (Details));
      }
    }

    public Primitive<bool> IncludeFulfillledOrders
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeFulfillledOrders), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeFulfillledOrders));
      }
    }
  }
}
