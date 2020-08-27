// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintContainerLabel_Info
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
  public class ReprintContainerLabel_Info : ReprintLabel_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_LabelHistorySummary")]
    protected new Info _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_CurrentContainerStatus")]
    protected CurrentContainerStatus_Info _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_Carrier")]
    protected Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_LabelCount")]
    protected new Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ReprintContainerLabel_Info_Operation")]
    protected Info _Operation;

    public new Info LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public CurrentContainerStatus_Info CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Info) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public new Info LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelCount));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info Container
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

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
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

    public Info Operation
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
  }
}
