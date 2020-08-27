// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleTestChanges_Environment
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
  public class SampleTestChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("A User Code Object Group that represents a group of LossReasons.", "LossReasonGroup", false, false, false, "NamedObjectRef", 1053143, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_AQLRejectReasons")]
    protected Environment _AQLRejectReasons;
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053126, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_DecreaseByRejectCountReason")]
    protected Environment _DecreaseByRejectCountReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_DefaultPEDescription")]
    [Metadata("Instruction", "", false, false, false, "String", 1053129, false, false, false, null)]
    protected Environment _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_Instructions")]
    [Metadata("Instruction", "", false, false, false, "String", 1051642, false, false, false, null)]
    protected Environment _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_DefaultFailureMode")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1053128, false, false, true, null)]
    protected Environment _DefaultFailureMode;
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053144, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_DecreaseBySampleSizeReason")]
    protected Environment _DecreaseBySampleSizeReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_SampleType")]
    [Metadata("Used to identify the Sample Test type associated with a Product Sampling Plan.\r\nCounted= 1\r\nMeasured = 2", "SampleTypeEnum", false, true, false, "Integer", 1053100, false, false, true, null)]
    protected Environment _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_ObjectToChange")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1051146, false, false, true, null)]
    protected Environment _SubClassification;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTestBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, true, null)]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_SampleDataPoints")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, false, false, "RevisionedObjectRef", 1053130, false, true, true, null)]
    protected Environment _SampleDataPoints;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053131, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_ScrapCountedRejectsByReason")]
    protected Environment _ScrapCountedRejectsByReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_AllowMoveOnFailure")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053124, false, false, false, "0")]
    protected Environment _AllowMoveOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053132, false, false, false, null)]
    protected new Environment _Name;

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

    public Environment DecreaseByRejectCountReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseByRejectCountReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecreaseByRejectCountReason));
      }
    }

    public Environment DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultPEDescription));
      }
    }

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

    public Environment DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

    public Environment DecreaseBySampleSizeReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseBySampleSizeReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecreaseBySampleSizeReason));
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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public Environment SampleDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoints), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleDataPoints));
      }
    }

    public Environment ScrapCountedRejectsByReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapCountedRejectsByReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScrapCountedRejectsByReason));
      }
    }

    public Environment AllowMoveOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMoveOnFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowMoveOnFailure));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
