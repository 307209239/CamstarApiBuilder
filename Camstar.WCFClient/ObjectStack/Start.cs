// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Start
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
  public class Start : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Start_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Start_PrintQueue")]
    protected new NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "Start_Details")]
    protected StartDetails _Details;
    [DataMember(EmitDefaultValue = false, Name = "Start_CurrentStatusDetails")]
    protected CurrentStatusStartDetails _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "Start_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "Start_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "Start_UsingAttributes")]
    protected Primitive<bool> _UsingAttributes;
    [DataMember(EmitDefaultValue = false, Name = "Start_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Start_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "Start_Operation")]
    protected new NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Start_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;

    public override bool Equals(object obj)
    {
      return obj is Start && object.Equals((object) this._MfgProcessOverrides, (object) ((Start) obj)._MfgProcessOverrides) && (object.Equals((object) this._PrintQueue, (object) ((Start) obj)._PrintQueue) && object.Equals((object) this._Details, (object) ((Start) obj)._Details)) && (object.Equals((object) this._CurrentStatusDetails, (object) ((Start) obj)._CurrentStatusDetails) && object.Equals((object) this._SamplingLot, (object) ((Start) obj)._SamplingLot) && (object.Equals((object) this._Container, (object) ((Start) obj)._Container) && object.Equals((object) this._UsingAttributes, (object) ((Start) obj)._UsingAttributes))) && (object.Equals((object) this._UseDispatch, (object) ((Start) obj)._UseDispatch) && object.Equals((object) this._Factory, (object) ((Start) obj)._Factory) && (object.Equals((object) this._Operation, (object) ((Start) obj)._Operation) && object.Equals((object) this._MfgOrder, (object) ((Start) obj)._MfgOrder))) && base.Equals(obj);
    }

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public StartDetails Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (StartDetails) this.PropertyGet(nameof (Details));
      }
    }

    public CurrentStatusStartDetails CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (CurrentStatusStartDetails) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
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

    public Primitive<bool> UsingAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (UsingAttributes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UsingAttributes));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public new NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
