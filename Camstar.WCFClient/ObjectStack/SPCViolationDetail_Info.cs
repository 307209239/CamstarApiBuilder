﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCViolationDetail_Info
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
  public class SPCViolationDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_DataPoint")]
    protected Info _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_RuleViolated")]
    protected Info _RuleViolated;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_CustomSPCDataId")]
    protected Info _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_ViolationName")]
    protected Info _ViolationName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_CollectedDataValue")]
    protected Info _CollectedDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_DerivedChartDataValue")]
    protected Info _DerivedChartDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_LCL")]
    protected Info _LCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_UCL")]
    protected Info _UCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_ChartVariable")]
    protected Info _ChartVariable;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_ParametricDataID")]
    protected Info _ParametricDataID;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_CL")]
    protected Info _CL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_DataPointName")]
    protected Info _DataPointName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_FailureAction")]
    protected Info _FailureAction;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Info_ResourceStatusCode")]
    protected Info _ResourceStatusCode;

    public Info DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Info RuleViolated
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleViolated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RuleViolated));
      }
    }

    public Info CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public Info ViolationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ViolationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ViolationName));
      }
    }

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Info CollectedDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectedDataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollectedDataValue));
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

    public Info DerivedChartDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedChartDataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DerivedChartDataValue));
      }
    }

    public Info LCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (LCL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LCL));
      }
    }

    public Info UCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UCL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UCL));
      }
    }

    public Info ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public Info ParametricDataID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataID));
      }
    }

    public Info CL
    {
      [param: In] set
      {
        this.PropertySet(nameof (CL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CL));
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

    public Info DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointName));
      }
    }

    public Info FailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureAction));
      }
    }

    public Info ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }
  }
}
