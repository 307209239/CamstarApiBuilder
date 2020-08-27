// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTree
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
  public class RecordDecisionTree : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_Result")]
    protected Primitive<string> _Result;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_DecisionTree")]
    protected NamedObjectRef _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTree_ServiceDetails")]
    protected DecisionTreeDetail[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is RecordDecisionTree && object.Equals((object) this._Result, (object) ((RecordDecisionTree) obj)._Result) && (object.Equals((object) this._DecisionTree, (object) ((RecordDecisionTree) obj)._DecisionTree) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((RecordDecisionTree) obj)._ServiceDetails)) && base.Equals(obj);
    }

    public Primitive<string> Result
    {
      [param: In] set
      {
        this.PropertySet(nameof (Result), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Result));
      }
    }

    public NamedObjectRef DecisionTree
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

    public DecisionTreeDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DecisionTreeDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
