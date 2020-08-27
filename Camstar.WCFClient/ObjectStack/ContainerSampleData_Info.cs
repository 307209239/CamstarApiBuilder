// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSampleData_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (LotSampleData_Info))]
  [Serializable]
  public class ContainerSampleData_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_Instructions")]
    protected Info _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_AQLRejectReasons")]
    protected Info _AQLRejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_InspectionLevel")]
    protected Info _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_AQLLevel")]
    protected Info _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SampleTestStatus")]
    protected Info _SampleTestStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SamplingPlan")]
    protected Info _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SampleType")]
    protected Info _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_InspectAllContQty")]
    protected Info _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_TotalSamplesRequired")]
    protected Info _TotalSamplesRequired;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_AllowedRejects")]
    protected Info _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_Rejects")]
    protected Info _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_CompletedSamples")]
    protected Info _CompletedSamples;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_InspectAllQtyOnFailure")]
    protected Info _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_PassedSamples")]
    protected Info _PassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SampleTestRevision")]
    protected Info _SampleTestRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Info_SampleTestName")]
    protected Info _SampleTestName;

    public Info Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instructions));
      }
    }

    public Info AQLRejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLRejectReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AQLRejectReasons));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public Info AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public Info SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Info SampleTestStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTestStatus));
      }
    }

    public Info SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Info SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleType));
      }
    }

    public Info InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectAllContQty));
      }
    }

    public Info TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public Info AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public Info Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejects));
      }
    }

    public Info CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletedSamples));
      }
    }

    public Info InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public Info PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public Info SampleTestRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTestRevision));
      }
    }

    public Info SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
