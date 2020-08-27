// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StopTimer
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
  public class StopTimer : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_TimerId")]
    protected Primitive<string> _TimerId;
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_Container")]
    protected new ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is StopTimer && object.Equals((object) this._TimerId, (object) ((StopTimer) obj)._TimerId) && (object.Equals((object) this._Comments, (object) ((StopTimer) obj)._Comments) && object.Equals((object) this._Container, (object) ((StopTimer) obj)._Container)) && base.Equals(obj);
    }

    public Primitive<string> TimerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerId));
      }
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
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
  }
}
