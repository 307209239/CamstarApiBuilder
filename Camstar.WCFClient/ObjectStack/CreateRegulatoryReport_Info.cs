// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReport_Info
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
  public class CreateRegulatoryReport_Info : RecordDecisionTree_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Info_DecisionTree")]
    protected new Info _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Info_RegulatoryReportDetails")]
    protected RegulatoryReportDetail_Info _RegulatoryReportDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Info_RegulatoryAgency")]
    protected Info _RegulatoryAgency;

    public new Info DecisionTree
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTree), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionTree));
      }
    }

    public RegulatoryReportDetail_Info RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail_Info) this.PropertyGet(nameof (RegulatoryReportDetails));
      }
    }

    public Info RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }
  }
}
