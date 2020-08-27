// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActualsSerial
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CompDistributeActualSerial))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ActualsSerial : IssueActuals
  {
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Qty2Issued")]
    protected new Primitive<double> _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_FromCarrier")]
    protected NamedObjectRef _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_FromBatch")]
    protected ContainerRef _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_ToContainer")]
    protected new ContainerRef _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_QtyIssued")]
    protected new Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_ToLocation")]
    protected new NamedSubentityRef _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_FromLocation")]
    protected NamedSubentityRef _FromLocation;
    [DataMember(EmitDefaultValue = false, Name = "ActualsSerial_Product")]
    protected new RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ActualsSerial && object.Equals((object) this._Qty2Issued, (object) ((ActualsSerial) obj)._Qty2Issued) && (object.Equals((object) this._FromCarrier, (object) ((ActualsSerial) obj)._FromCarrier) && object.Equals((object) this._FromBatch, (object) ((ActualsSerial) obj)._FromBatch)) && (object.Equals((object) this._FromContainer, (object) ((ActualsSerial) obj)._FromContainer) && object.Equals((object) this._ToContainer, (object) ((ActualsSerial) obj)._ToContainer) && (object.Equals((object) this._QtyIssued, (object) ((ActualsSerial) obj)._QtyIssued) && object.Equals((object) this._ToLocation, (object) ((ActualsSerial) obj)._ToLocation))) && (object.Equals((object) this._FromLocation, (object) ((ActualsSerial) obj)._FromLocation) && object.Equals((object) this._Product, (object) ((ActualsSerial) obj)._Product)) && base.Equals(obj);
    }

    public new Primitive<double> Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public NamedObjectRef FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public ContainerRef FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromBatch));
      }
    }

    public ContainerRef FromContainer
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

    public new Primitive<double> QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyIssued));
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

    public NamedSubentityRef FromLocation
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

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
