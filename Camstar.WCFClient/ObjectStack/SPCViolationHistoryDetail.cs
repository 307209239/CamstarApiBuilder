// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCViolationHistoryDetail
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
  public class SPCViolationHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ViolationName")]
    protected Primitive<string> _ViolationName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_DataPoint")]
    protected SubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_RuleViolated")]
    protected Primitive<string> _RuleViolated;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_CustomSPCDataId")]
    protected Primitive<string> _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_CollectedDataValue")]
    protected Primitive<string> _CollectedDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ParametricDataID")]
    protected Primitive<string> _ParametricDataID;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_DerivedChartDataValue")]
    protected Primitive<string> _DerivedChartDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_UCL")]
    protected Primitive<double> _UCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_LCL")]
    protected Primitive<double> _LCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ChartVariable")]
    protected Primitive<string> _ChartVariable;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_CL")]
    protected Primitive<double> _CL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_FailureAction")]
    protected Primitive<string> _FailureAction;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_DataPointName")]
    protected Primitive<string> _DataPointName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ContainerName")]
    protected Primitive<string> _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationHistoryDetail_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;

    public override bool Equals(object obj)
    {
      return obj is SPCViolationHistoryDetail && object.Equals((object) this._ViolationName, (object) ((SPCViolationHistoryDetail) obj)._ViolationName) && (object.Equals((object) this._DataPoint, (object) ((SPCViolationHistoryDetail) obj)._DataPoint) && object.Equals((object) this._RuleViolated, (object) ((SPCViolationHistoryDetail) obj)._RuleViolated)) && (object.Equals((object) this._ExportImportKey, (object) ((SPCViolationHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._CustomSPCDataId, (object) ((SPCViolationHistoryDetail) obj)._CustomSPCDataId) && (object.Equals((object) this._HoldReason, (object) ((SPCViolationHistoryDetail) obj)._HoldReason) && object.Equals((object) this._CollectedDataValue, (object) ((SPCViolationHistoryDetail) obj)._CollectedDataValue))) && (object.Equals((object) this._ParametricDataID, (object) ((SPCViolationHistoryDetail) obj)._ParametricDataID) && object.Equals((object) this._DerivedChartDataValue, (object) ((SPCViolationHistoryDetail) obj)._DerivedChartDataValue) && (object.Equals((object) this._HistoryId, (object) ((SPCViolationHistoryDetail) obj)._HistoryId) && object.Equals((object) this._Container, (object) ((SPCViolationHistoryDetail) obj)._Container)) && (object.Equals((object) this._UCL, (object) ((SPCViolationHistoryDetail) obj)._UCL) && object.Equals((object) this._LCL, (object) ((SPCViolationHistoryDetail) obj)._LCL) && (object.Equals((object) this._ChartVariable, (object) ((SPCViolationHistoryDetail) obj)._ChartVariable) && object.Equals((object) this._CL, (object) ((SPCViolationHistoryDetail) obj)._CL)))) && (object.Equals((object) this._Resource, (object) ((SPCViolationHistoryDetail) obj)._Resource) && object.Equals((object) this._FailureAction, (object) ((SPCViolationHistoryDetail) obj)._FailureAction) && (object.Equals((object) this._DataPointName, (object) ((SPCViolationHistoryDetail) obj)._DataPointName) && object.Equals((object) this._ContainerName, (object) ((SPCViolationHistoryDetail) obj)._ContainerName)) && (object.Equals((object) this._ResourceName, (object) ((SPCViolationHistoryDetail) obj)._ResourceName) && object.Equals((object) this._ResourceStatusCode, (object) ((SPCViolationHistoryDetail) obj)._ResourceStatusCode))) && base.Equals(obj);
    }

    public Primitive<string> ViolationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ViolationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ViolationName));
      }
    }

    public SubentityRef DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Primitive<string> RuleViolated
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleViolated), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RuleViolated));
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

    public Primitive<string> CustomSPCDataId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomSPCDataId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CustomSPCDataId));
      }
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Primitive<string> CollectedDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectedDataValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CollectedDataValue));
      }
    }

    public Primitive<string> ParametricDataID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataID));
      }
    }

    public Primitive<string> DerivedChartDataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedChartDataValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DerivedChartDataValue));
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<double> UCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UCL), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (UCL));
      }
    }

    public Primitive<double> LCL
    {
      [param: In] set
      {
        this.PropertySet(nameof (LCL), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LCL));
      }
    }

    public Primitive<string> ChartVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChartVariable), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ChartVariable));
      }
    }

    public Primitive<double> CL
    {
      [param: In] set
      {
        this.PropertySet(nameof (CL), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CL));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public Primitive<string> FailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureAction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FailureAction));
      }
    }

    public Primitive<string> DataPointName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataPointName));
      }
    }

    public Primitive<string> ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContainerName));
      }
    }

    public Primitive<string> ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceName));
      }
    }

    public NamedObjectRef ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }
  }
}
