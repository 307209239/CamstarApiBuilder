// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DecisionTreeHistoryDetail
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
  public class DecisionTreeHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Response")]
    protected Primitive<string> _Response;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_Question")]
    protected Primitive<string> _Question;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is DecisionTreeHistoryDetail && object.Equals((object) this._Sequence, (object) ((DecisionTreeHistoryDetail) obj)._Sequence) && (object.Equals((object) this._Response, (object) ((DecisionTreeHistoryDetail) obj)._Response) && object.Equals((object) this._Question, (object) ((DecisionTreeHistoryDetail) obj)._Question)) && (object.Equals((object) this._ExportImportKey, (object) ((DecisionTreeHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((DecisionTreeHistoryDetail) obj)._HistoryId)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<string> Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Response));
      }
    }

    public Primitive<string> Question
    {
      [param: In] set
      {
        this.PropertySet(nameof (Question), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Question));
      }
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
