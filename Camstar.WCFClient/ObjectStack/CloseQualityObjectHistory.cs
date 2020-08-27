// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseQualityObjectHistory
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
  public class CloseQualityObjectHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_CloseDescription")]
    protected Primitive<string> _CloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "CloseQualityObjectHistory_NonconformanceNumber")]
    protected Primitive<string> _NonconformanceNumber;

    public override bool Equals(object obj)
    {
      return obj is CloseQualityObjectHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CloseQualityObjectHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((CloseQualityObjectHistory) obj)._ExportImportKey) && object.Equals((object) this._QualityResolutionCode, (object) ((CloseQualityObjectHistory) obj)._QualityResolutionCode)) && (object.Equals((object) this._HistoryId, (object) ((CloseQualityObjectHistory) obj)._HistoryId) && object.Equals((object) this._CloseDescription, (object) ((CloseQualityObjectHistory) obj)._CloseDescription) && object.Equals((object) this._NonconformanceNumber, (object) ((CloseQualityObjectHistory) obj)._NonconformanceNumber)) && base.Equals(obj);
    }

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
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

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
      }
    }

    public Primitive<string> NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NonconformanceNumber));
      }
    }
  }
}
