// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChklstResponseHistDtl
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
  public class ExecuteChklstResponseHistDtl : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseHistDtl_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseHistDtl_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseHistDtl_Response")]
    protected Primitive<string> _Response;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChklstResponseHistDtl_ResponseValue")]
    protected Primitive<int> _ResponseValue;

    public override bool Equals(object obj)
    {
      return obj is ExecuteChklstResponseHistDtl && object.Equals((object) this._ExportImportKey, (object) ((ExecuteChklstResponseHistDtl) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((ExecuteChklstResponseHistDtl) obj)._HistoryId) && object.Equals((object) this._Response, (object) ((ExecuteChklstResponseHistDtl) obj)._Response)) && object.Equals((object) this._ResponseValue, (object) ((ExecuteChklstResponseHistDtl) obj)._ResponseValue) && base.Equals(obj);
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

    public Primitive<int> ResponseValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResponseValue));
      }
    }
  }
}
