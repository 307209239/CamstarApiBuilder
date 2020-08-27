// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReportHistory_Info
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
  public class CreateRegulatoryReportHistory_Info : RecordDecisionTreeHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_Info_RegulatoryAgency")]
    protected Info _RegulatoryAgency;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_Info_RegulatoryReportHistoryDetails")]
    protected RegulatoryReportHistoryDetail_Info _RegulatoryReportHistoryDetails;

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

    public RegulatoryReportHistoryDetail_Info RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail_Info) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
      }
    }
  }
}
