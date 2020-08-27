// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateRegulatoryReport
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
  public class CreateRegulatoryReport : RecordDecisionTree
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_DecisionTree")]
    protected new NamedObjectRef _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_RegulatoryReportDetails")]
    protected RegulatoryReportDetail[] _RegulatoryReportDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateRegulatoryReport_RegulatoryAgency")]
    protected NamedObjectRef _RegulatoryAgency;

    public override bool Equals(object obj)
    {
      return obj is CreateRegulatoryReport && object.Equals((object) this._DecisionTree, (object) ((CreateRegulatoryReport) obj)._DecisionTree) && (this.CompareArrays((Array) this._RegulatoryReportDetails, (Array) ((CreateRegulatoryReport) obj)._RegulatoryReportDetails) && object.Equals((object) this._RegulatoryAgency, (object) ((CreateRegulatoryReport) obj)._RegulatoryAgency)) && base.Equals(obj);
    }

    public new NamedObjectRef DecisionTree
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTree), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DecisionTree));
      }
    }

    public RegulatoryReportDetail[] RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail[]) this.PropertyGet(nameof (RegulatoryReportDetails));
      }
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
  }
}
