// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSampleData
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (LotSampleData))]
  [Serializable]
  public class ContainerSampleData : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Instructions")]
    protected Primitive<string> _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_AQLRejectReasons")]
    protected NamedObjectRef _AQLRejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_InspectionLevel")]
    protected NamedObjectRef _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_AQLLevel")]
    protected NamedObjectRef _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SampleTestStatus")]
    protected Enumeration<SampleStatusEnum, string> _SampleTestStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SamplingPlan")]
    protected RevisionedObjectRef _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SampleType")]
    protected Enumeration<SampleTypeEnum, int> _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_InspectAllContQty")]
    protected Primitive<bool> _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_TotalSamplesRequired")]
    protected Primitive<int> _TotalSamplesRequired;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_AllowedRejects")]
    protected Primitive<int> _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Rejects")]
    protected Primitive<int> _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_CompletedSamples")]
    protected Primitive<int> _CompletedSamples;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_InspectAllQtyOnFailure")]
    protected Primitive<bool> _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_PassedSamples")]
    protected Primitive<int> _PassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SampleTestRevision")]
    protected Primitive<string> _SampleTestRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_SampleTestName")]
    protected Primitive<string> _SampleTestName;

    public override bool Equals(object obj)
    {
      return obj is ContainerSampleData && object.Equals((object) this._Instructions, (object) ((ContainerSampleData) obj)._Instructions) && (object.Equals((object) this._AQLRejectReasons, (object) ((ContainerSampleData) obj)._AQLRejectReasons) && object.Equals((object) this._ExportImportKey, (object) ((ContainerSampleData) obj)._ExportImportKey)) && (object.Equals((object) this._InspectionLevel, (object) ((ContainerSampleData) obj)._InspectionLevel) && object.Equals((object) this._AQLLevel, (object) ((ContainerSampleData) obj)._AQLLevel) && (object.Equals((object) this._SampleTest, (object) ((ContainerSampleData) obj)._SampleTest) && object.Equals((object) this._SampleTestStatus, (object) ((ContainerSampleData) obj)._SampleTestStatus))) && (object.Equals((object) this._SamplingPlan, (object) ((ContainerSampleData) obj)._SamplingPlan) && object.Equals((object) this._SampleType, (object) ((ContainerSampleData) obj)._SampleType) && (object.Equals((object) this._InspectAllContQty, (object) ((ContainerSampleData) obj)._InspectAllContQty) && object.Equals((object) this._TotalSamplesRequired, (object) ((ContainerSampleData) obj)._TotalSamplesRequired)) && (object.Equals((object) this._AllowedRejects, (object) ((ContainerSampleData) obj)._AllowedRejects) && object.Equals((object) this._Rejects, (object) ((ContainerSampleData) obj)._Rejects) && (object.Equals((object) this._CompletedSamples, (object) ((ContainerSampleData) obj)._CompletedSamples) && object.Equals((object) this._InspectAllQtyOnFailure, (object) ((ContainerSampleData) obj)._InspectAllQtyOnFailure)))) && (object.Equals((object) this._PassedSamples, (object) ((ContainerSampleData) obj)._PassedSamples) && object.Equals((object) this._SampleTestRevision, (object) ((ContainerSampleData) obj)._SampleTestRevision) && object.Equals((object) this._SampleTestName, (object) ((ContainerSampleData) obj)._SampleTestName)) && base.Equals(obj);
    }

    public Primitive<string> Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instructions));
      }
    }

    public NamedObjectRef AQLRejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLRejectReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AQLRejectReasons));
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

    public NamedObjectRef InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public NamedObjectRef AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public RevisionedObjectRef SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Enumeration<SampleStatusEnum, string> SampleTestStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestStatus), (object) value);
      }
      get
      {
        return (Enumeration<SampleStatusEnum, string>) this.PropertyGet(nameof (SampleTestStatus));
      }
    }

    public RevisionedObjectRef SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Enumeration<SampleTypeEnum, int> SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Enumeration<SampleTypeEnum, int>) this.PropertyGet(nameof (SampleType));
      }
    }

    public Primitive<bool> InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAllContQty));
      }
    }

    public Primitive<int> TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public Primitive<int> AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public Primitive<int> Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Rejects));
      }
    }

    public Primitive<int> CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompletedSamples));
      }
    }

    public Primitive<bool> InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public Primitive<int> PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public Primitive<string> SampleTestRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleTestRevision));
      }
    }

    public Primitive<string> SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
