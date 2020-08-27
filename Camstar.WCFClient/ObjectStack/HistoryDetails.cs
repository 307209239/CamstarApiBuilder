// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (AuditTrail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ParametricDetail))]
  [KnownType(typeof (BusinessRuleParameterValues))]
  [KnownType(typeof (ServiceHistoryDetail))]
  [KnownType(typeof (BusinessRuleExecutionHistory))]
  [KnownType(typeof (StartHistoryDetail))]
  [KnownType(typeof (ServiceHistorySummary))]
  [KnownType(typeof (AuditTrailHeader))]
  [Serializable]
  public class HistoryDetails : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HistoryDetails_HistoryId")]
    protected BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is HistoryDetails && object.Equals((object) this._DisplayName, (object) ((HistoryDetails) obj)._DisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((HistoryDetails) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((HistoryDetails) obj)._HistoryId)) && base.Equals(obj);
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
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

    public BaseObjectRef HistoryId
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
