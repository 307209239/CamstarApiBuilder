// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetNCRs_Info
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
  public class GetNCRs_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_NonconformanceReports")]
    protected NonconformanceReport_Info _NonconformanceReports;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_NCRFailureCode")]
    protected Info _NCRFailureCode;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_NonconformanceReport")]
    protected Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_CreateDateEnd")]
    protected Info _CreateDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_IncludeClosedNCRs")]
    protected Info _IncludeClosedNCRs;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_CreateDateBegin")]
    protected Info _CreateDateBegin;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_Workcenter")]
    protected Info _Workcenter;
    [DataMember(EmitDefaultValue = false, Name = "GetNCRs_Info_ChargeToWorkflow")]
    protected Info _ChargeToWorkflow;

    public NonconformanceReport_Info NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (NonconformanceReport_Info) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Info NCRFailureCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCode));
      }
    }

    public Info NonconformanceReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceReport));
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

    public Info CreateDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateEnd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateDateEnd));
      }
    }

    public Info IncludeClosedNCRs
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeClosedNCRs), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeClosedNCRs));
      }
    }

    public Info CreateDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateDateBegin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreateDateBegin));
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

    public Info Workcenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workcenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workcenter));
      }
    }

    public Info ChargeToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToWorkflow));
      }
    }
  }
}
