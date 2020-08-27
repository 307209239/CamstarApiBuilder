// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReportHistory_Environment
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
  public class CreateRegulatoryReportHistory_Environment : RecordDecisionTreeHistory_Environment
  {
    [Metadata("Regulatory Agency", "RegulatoryAgency", false, false, true, "NamedObjectRef", 1051723, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_Environment_RegulatoryAgency")]
    protected Environment _RegulatoryAgency;
    [Metadata("Regulatory Report History Detail", "RegulatoryReportHistoryDetail", false, false, true, "RegulatoryReportHistoryDetail", 1051734, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_Environment_RegulatoryReportHistoryDetails")]
    protected RegulatoryReportHistoryDetail_Environment _RegulatoryReportHistoryDetails;

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

    public RegulatoryReportHistoryDetail_Environment RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail_Environment) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
      }
    }
  }
}
