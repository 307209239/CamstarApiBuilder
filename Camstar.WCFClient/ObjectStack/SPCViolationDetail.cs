// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCViolationDetail
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
  public class SPCViolationDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_DataPoint")]
    protected SubentityRef _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_RuleViolated")]
    protected Primitive<string> _RuleViolated;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_CustomSPCDataId")]
    protected Primitive<string> _CustomSPCDataId;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_ViolationName")]
    protected Primitive<string> _ViolationName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_CollectedDataValue")]
    protected Primitive<string> _CollectedDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_DerivedChartDataValue")]
    protected Primitive<string> _DerivedChartDataValue;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_LCL")]
    protected Primitive<double> _LCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_UCL")]
    protected Primitive<double> _UCL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_ChartVariable")]
    protected Primitive<string> _ChartVariable;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_ParametricDataID")]
    protected Primitive<string> _ParametricDataID;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_CL")]
    protected Primitive<double> _CL;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_DataPointName")]
    protected Primitive<string> _DataPointName;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_FailureAction")]
    protected Primitive<string> _FailureAction;
    [DataMember(EmitDefaultValue = false, Name = "SPCViolationDetail_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;

    public override bool Equals(object obj)
    {
      return obj is SPCViolationDetail && object.Equals((object) this._DataPoint, (object) ((SPCViolationDetail) obj)._DataPoint) && (object.Equals((object) this._RuleViolated, (object) ((SPCViolationDetail) obj)._RuleViolated) && object.Equals((object) this._CustomSPCDataId, (object) ((SPCViolationDetail) obj)._CustomSPCDataId)) && (object.Equals((object) this._ViolationName, (object) ((SPCViolationDetail) obj)._ViolationName) && object.Equals((object) this._HoldReason, (object) ((SPCViolationDetail) obj)._HoldReason) && (object.Equals((object) this._CollectedDataValue, (object) ((SPCViolationDetail) obj)._CollectedDataValue) && object.Equals((object) this._Container, (object) ((SPCViolationDetail) obj)._Container))) && (object.Equals((object) this._DerivedChartDataValue, (object) ((SPCViolationDetail) obj)._DerivedChartDataValue) && object.Equals((object) this._LCL, (object) ((SPCViolationDetail) obj)._LCL) && (object.Equals((object) this._UCL, (object) ((SPCViolationDetail) obj)._UCL) && object.Equals((object) this._ChartVariable, (object) ((SPCViolationDetail) obj)._ChartVariable)) && (object.Equals((object) this._ParametricDataID, (object) ((SPCViolationDetail) obj)._ParametricDataID) && object.Equals((object) this._CL, (object) ((SPCViolationDetail) obj)._CL) && (object.Equals((object) this._Resource, (object) ((SPCViolationDetail) obj)._Resource) && object.Equals((object) this._DataPointName, (object) ((SPCViolationDetail) obj)._DataPointName)))) && (object.Equals((object) this._FailureAction, (object) ((SPCViolationDetail) obj)._FailureAction) && object.Equals((object) this._ResourceStatusCode, (object) ((SPCViolationDetail) obj)._ResourceStatusCode)) && base.Equals(obj);
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
