// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintContainerLabel
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
  public class ReprintContainerLabel : ReprintLabel
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_LabelHistorySummary")]
    protected new SubentityRef _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_CurrentContainerStatus")]
    protected CurrentContainerStatus _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Carrier")]
    protected NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_LabelCount")]
    protected new Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_HistoryId")]
    protected ContainerRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Factory")]
    protected new NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Operation")]
    protected NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is ReprintContainerLabel && object.Equals((object) this._LabelHistorySummary, (object) ((ReprintContainerLabel) obj)._LabelHistorySummary) && (object.Equals((object) this._CurrentContainerStatus, (object) ((ReprintContainerLabel) obj)._CurrentContainerStatus) && object.Equals((object) this._Carrier, (object) ((ReprintContainerLabel) obj)._Carrier)) && (object.Equals((object) this._LabelCount, (object) ((ReprintContainerLabel) obj)._LabelCount) && object.Equals((object) this._HistoryId, (object) ((ReprintContainerLabel) obj)._HistoryId) && (object.Equals((object) this._Container, (object) ((ReprintContainerLabel) obj)._Container) && object.Equals((object) this._WorkCenter, (object) ((ReprintContainerLabel) obj)._WorkCenter))) && (object.Equals((object) this._Factory, (object) ((ReprintContainerLabel) obj)._Factory) && object.Equals((object) this._Operation, (object) ((ReprintContainerLabel) obj)._Operation)) && base.Equals(obj);
    }

    public new SubentityRef LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public CurrentContainerStatus CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public new Primitive<int> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelCount));
      }
    }

    public ContainerRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public ContainerRef Container
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

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
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

    public NamedObjectRef Operation
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
  }
}
