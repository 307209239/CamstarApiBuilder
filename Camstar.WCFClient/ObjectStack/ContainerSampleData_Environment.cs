// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSampleData_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (LotSampleData_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerSampleData_Environment : Subentity_Environment
  {
    [Metadata("Instruction", "", false, false, true, "String", 1051642, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_Instructions")]
    protected Environment _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_AQLRejectReasons")]
    [Metadata("A User Code Object Group that represents a group of LossReasons.", "LossReasonGroup", false, false, true, "NamedObjectRef", 1053125, false, false, false, null)]
    protected Environment _AQLRejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1053133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_InspectionLevel")]
    protected Environment _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_AQLLevel")]
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, true, "NamedObjectRef", 1053105, false, false, false, null)]
    protected Environment _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SampleTest")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, true, "RevisionedObjectRef", 1053111, false, false, false, null)]
    protected Environment _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SampleTestStatus")]
    [Metadata("SampleStatus", "SampleStatusEnum", false, false, true, "String", 1053163, false, false, false, null)]
    protected Environment _SampleTestStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SamplingPlan")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, true, "RevisionedObjectRef", 1053112, false, false, false, null)]
    protected Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SampleType")]
    [Metadata("Used to identify the Sample Test type associated with a Product Sampling Plan.\r\nCounted= 1\r\nMeasured = 2", "SampleTypeEnum", false, false, true, "Integer", 1053100, false, false, false, null)]
    protected Environment _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_InspectAllContQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777737, false, false, false, "0")]
    protected Environment _InspectAllContQty;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053164, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_TotalSamplesRequired")]
    protected Environment _TotalSamplesRequired;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053160, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_AllowedRejects")]
    protected Environment _AllowedRejects;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053150, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_Rejects")]
    protected Environment _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_CompletedSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053161, false, false, false, null)]
    protected Environment _CompletedSamples;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777738, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_InspectAllQtyOnFailure")]
    protected Environment _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_PassedSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053151, false, false, false, null)]
    protected Environment _PassedSamples;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1053162, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SampleTestRevision")]
    protected Environment _SampleTestRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSampleData_Environment_SampleTestName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053132, false, false, false, null)]
    protected Environment _SampleTestName;

    public Environment Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instructions));
      }
    }

    public Environment AQLRejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLRejectReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AQLRejectReasons));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public Environment AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public Environment SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Environment SampleTestStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTestStatus));
      }
    }

    public Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Environment SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleType));
      }
    }

    public Environment InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAllContQty));
      }
    }

    public Environment TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public Environment AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public Environment Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejects));
      }
    }

    public Environment CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletedSamples));
      }
    }

    public Environment InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public Environment PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public Environment SampleTestRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTestRevision));
      }
    }

    public Environment SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
