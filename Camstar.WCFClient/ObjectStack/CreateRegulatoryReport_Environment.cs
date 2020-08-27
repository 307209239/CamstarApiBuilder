// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReport_Environment
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
  public class CreateRegulatoryReport_Environment : RecordDecisionTree_Environment
  {
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, true, "NamedObjectRef", 1051719, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Environment_DecisionTree")]
    protected new Environment _DecisionTree;
    [Metadata("Regulatory Report Detail", "RegulatoryReportDetail", false, false, false, "RegulatoryReportDetail", 1051733, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Environment_RegulatoryReportDetails")]
    protected RegulatoryReportDetail_Environment _RegulatoryReportDetails;
    [Metadata("Regulatory Agency", "RegulatoryAgency", false, true, false, "NamedObjectRef", 1051723, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_Environment_RegulatoryAgency")]
    protected Environment _RegulatoryAgency;

    public new Environment DecisionTree
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTree), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecisionTree));
      }
    }

    public RegulatoryReportDetail_Environment RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail_Environment) this.PropertyGet(nameof (RegulatoryReportDetails));
      }
    }

    public Environment RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }
  }
}
