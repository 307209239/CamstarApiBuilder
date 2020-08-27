// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCreate_Info
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
  public class NCRCreate_Info : NCRTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_ServiceDetails")]
    protected NCRDefectDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NCRFailureType")]
    protected Info _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NCRFailureCodeGroup")]
    protected Info _NCRFailureCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NonconformanceReport")]
    protected new Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NCRFailureCodes")]
    protected Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_RelatedNonconformance")]
    protected Info _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_IssueActualsHistory")]
    protected IssueActualsHistory_Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_Factory")]
    protected new Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NCRComment")]
    protected Info _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRCreate_Info_NonconformanceName")]
    protected Info _NonconformanceName;

    public NCRDefectDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails_Info) this.PropertyGet(nameof (ServiceDetails));
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

    public Info NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public Info NCRFailureCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodeGroup));
      }
    }

    public Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
      }
    }

    public new Info NonconformanceReport
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

    public Info NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public Info RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RelatedNonconformance));
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

    public Info NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Info NonconformanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceName));
      }
    }
  }
}
