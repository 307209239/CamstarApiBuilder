// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Defect_Info
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
  public class Defect_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_Qty2Inspected")]
    protected Info _Qty2Inspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_ServiceDetails")]
    protected DefectDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_IssueActualsHistory")]
    protected IssueActualsHistory_Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_ContainersInspected")]
    protected Info _ContainersInspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_QtyInspected")]
    protected Info _QtyInspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Info_ContainerLevelInspected")]
    protected Info _ContainerLevelInspected;

    public Info Qty2Inspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Inspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Inspected));
      }
    }

    public DefectDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DefectDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public IssueActualsHistory_Info IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Info) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Info ContainersInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainersInspected));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info QtyInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyInspected));
      }
    }

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Info ContainerLevelInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelInspected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevelInspected));
      }
    }
  }
}
