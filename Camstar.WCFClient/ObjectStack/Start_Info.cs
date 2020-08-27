// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Start_Info
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
  public class Start_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_Details")]
    protected StartDetails_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_CurrentStatusDetails")]
    protected CurrentStatusStartDetails_Info _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_SamplingLot")]
    protected Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_UsingAttributes")]
    protected Info _UsingAttributes;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_Operation")]
    protected new Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Start_Info_MfgOrder")]
    protected new Info _MfgOrder;

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public new Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public StartDetails_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (StartDetails_Info) this.PropertyGet(nameof (Details));
      }
    }

    public CurrentStatusStartDetails_Info CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (CurrentStatusStartDetails_Info) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

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

    public Info UsingAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (UsingAttributes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UsingAttributes));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public new Info MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
