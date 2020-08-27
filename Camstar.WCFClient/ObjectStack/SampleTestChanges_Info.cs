// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleTestChanges_Info
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
  public class SampleTestChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_AQLRejectReasons")]
    protected Info _AQLRejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_DecreaseByRejectCountReason")]
    protected Info _DecreaseByRejectCountReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_DefaultPEDescription")]
    protected Info _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_Instructions")]
    protected Info _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_DefaultFailureMode")]
    protected Info _DefaultFailureMode;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_DecreaseBySampleSizeReason")]
    protected Info _DecreaseBySampleSizeReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_SampleType")]
    protected Info _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_SampleDataPoints")]
    protected Info _SampleDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_ScrapCountedRejectsByReason")]
    protected Info _ScrapCountedRejectsByReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_AllowMoveOnFailure")]
    protected Info _AllowMoveOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Info_Name")]
    protected new Info _Name;

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

    public Info DecreaseByRejectCountReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseByRejectCountReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecreaseByRejectCountReason));
      }
    }

    public Info DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultPEDescription));
      }
    }

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

    public Info DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

    public Info DecreaseBySampleSizeReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseBySampleSizeReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecreaseBySampleSizeReason));
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

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info SampleDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoints), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleDataPoints));
      }
    }

    public Info ScrapCountedRejectsByReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapCountedRejectsByReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScrapCountedRejectsByReason));
      }
    }

    public Info AllowMoveOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMoveOnFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowMoveOnFailure));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
