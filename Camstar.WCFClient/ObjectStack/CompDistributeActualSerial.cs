// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeActualSerial
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
  public class CompDistributeActualSerial : ActualsSerial
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_FromContainer")]
    protected new ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_ToContainer")]
    protected new ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_FromLocation")]
    protected new NamedSubentityRef _FromLocation;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_ToLocation")]
    protected new NamedSubentityRef _ToLocation;

    public override bool Equals(object obj)
    {
      return obj is CompDistributeActualSerial && object.Equals((object) this._FromContainer, (object) ((CompDistributeActualSerial) obj)._FromContainer) && (object.Equals((object) this._ToContainer, (object) ((CompDistributeActualSerial) obj)._ToContainer) && object.Equals((object) this._FromLocation, (object) ((CompDistributeActualSerial) obj)._FromLocation)) && object.Equals((object) this._ToLocation, (object) ((CompDistributeActualSerial) obj)._ToLocation) && base.Equals(obj);
    }

    public new ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public new ContainerRef ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ToContainer));
      }
    }

    public new NamedSubentityRef FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromLocation));
      }
    }

    public new NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }
  }
}
