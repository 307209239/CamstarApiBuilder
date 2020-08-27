// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTree_Info
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
  public class RecordDecisionTree_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Info_Result")]
    protected Info _Result;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Info_DecisionTree")]
    protected Info _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Info_ServiceDetails")]
    protected DecisionTreeDetail_Info _ServiceDetails;

    public Info Result
    {
      [param: In] set
      {
        this.PropertySet(nameof (Result), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Result));
      }
    }

    public Info DecisionTree
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

    public DecisionTreeDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DecisionTreeDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
