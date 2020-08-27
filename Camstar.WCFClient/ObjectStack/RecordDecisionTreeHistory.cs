// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTreeHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CreateRegulatoryReportHistory))]
  [Serializable]
  public class RecordDecisionTreeHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Result")]
    protected Primitive<string> _Result;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_DecisionTree")]
    protected NamedObjectRef _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_HistoryDetails")]
    protected DecisionTreeHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is RecordDecisionTreeHistory && object.Equals((object) this._ExportImportKey, (object) ((RecordDecisionTreeHistory) obj)._ExportImportKey) && (object.Equals((object) this._Result, (object) ((RecordDecisionTreeHistory) obj)._Result) && object.Equals((object) this._DecisionTree, (object) ((RecordDecisionTreeHistory) obj)._DecisionTree)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((RecordDecisionTreeHistory) obj)._HistoryDetails) && object.Equals((object) this._HistoryId, (object) ((RecordDecisionTreeHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
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

    public DecisionTreeHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DecisionTreeHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
