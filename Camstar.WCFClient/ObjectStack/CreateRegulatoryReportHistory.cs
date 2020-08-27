// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReportHistory
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
  public class CreateRegulatoryReportHistory : RecordDecisionTreeHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_RegulatoryAgency")]
    protected NamedObjectRef _RegulatoryAgency;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReportHistory_RegulatoryReportHistoryDetails")]
    protected RegulatoryReportHistoryDetail[] _RegulatoryReportHistoryDetails;

    public override bool Equals(object obj)
    {
      return obj is CreateRegulatoryReportHistory && object.Equals((object) this._RegulatoryAgency, (object) ((CreateRegulatoryReportHistory) obj)._RegulatoryAgency) && this.CompareArrays((Array) this._RegulatoryReportHistoryDetails, (Array) ((CreateRegulatoryReportHistory) obj)._RegulatoryReportHistoryDetails) && base.Equals(obj);
    }

    public NamedObjectRef RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }

    public RegulatoryReportHistoryDetail[] RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail[]) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
      }
    }
  }
}
