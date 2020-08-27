// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTree_Environment
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
  public class RecordDecisionTree_Environment : QualityTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Environment_Result")]
    [Metadata("Comments", "", false, false, false, "String", 1051730, false, false, false, null)]
    protected Environment _Result;
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, false, "NamedObjectRef", 1051719, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Environment_DecisionTree")]
    protected Environment _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Environment_ServiceDetails")]
    [Metadata("Decision Tree Detail", "DecisionTreeDetail", false, false, false, "DecisionTreeDetail", 1049843, false, true, false, null)]
    protected DecisionTreeDetail_Environment _ServiceDetails;

    public Environment Result
    {
      [param: In] set
      {
        this.PropertySet(nameof (Result), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Result));
      }
    }

    public Environment DecisionTree
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

    public DecisionTreeDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DecisionTreeDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
