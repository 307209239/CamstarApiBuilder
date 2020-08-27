// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdate_Info
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
  public class NCRUpdate_Info : NCRTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_ServiceDetails")]
    protected NCRDefectDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_ServiceDetail")]
    protected NCRUpdateDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_NonconformanceReport")]
    protected new Info _NonconformanceReport;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_NCRDefectHistoryDetails")]
    protected NCRDefectHistoryDetails_Info _NCRDefectHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_IssueActualsHistory")]
    protected IssueActualsHistory_Info _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdate_Info_Factory")]
    protected new Info _Factory;

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

    public NCRUpdateDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRUpdateDetail_Info) this.PropertyGet(nameof (ServiceDetail));
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

    public NCRDefectHistoryDetails_Info NCRDefectHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectHistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Info) this.PropertyGet(nameof (NCRDefectHistoryDetails));
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
  }
}
