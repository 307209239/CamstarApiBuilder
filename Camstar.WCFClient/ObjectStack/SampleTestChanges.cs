// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleTestChanges
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
  public class SampleTestChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_AQLRejectReasons")]
    protected NamedObjectRef _AQLRejectReasons;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_DecreaseByRejectCountReason")]
    protected NamedObjectRef _DecreaseByRejectCountReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_DefaultPEDescription")]
    protected Primitive<string> _DefaultPEDescription;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Instructions")]
    protected Primitive<string> _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_DefaultFailureMode")]
    protected NamedObjectRef _DefaultFailureMode;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_DecreaseBySampleSizeReason")]
    protected NamedObjectRef _DecreaseBySampleSizeReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_SampleType")]
    protected Enumeration<SampleTypeEnum, int> _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_SampleDataPoints")]
    protected RevisionedObjectRef[] _SampleDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_ScrapCountedRejectsByReason")]
    protected Primitive<bool> _ScrapCountedRejectsByReason;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_AllowMoveOnFailure")]
    protected Primitive<bool> _AllowMoveOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "SampleTestChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SampleTestChanges && object.Equals((object) this._AQLRejectReasons, (object) ((SampleTestChanges) obj)._AQLRejectReasons) && (object.Equals((object) this._DecreaseByRejectCountReason, (object) ((SampleTestChanges) obj)._DecreaseByRejectCountReason) && object.Equals((object) this._DefaultPEDescription, (object) ((SampleTestChanges) obj)._DefaultPEDescription)) && (object.Equals((object) this._Instructions, (object) ((SampleTestChanges) obj)._Instructions) && object.Equals((object) this._DefaultFailureMode, (object) ((SampleTestChanges) obj)._DefaultFailureMode) && (object.Equals((object) this._DecreaseBySampleSizeReason, (object) ((SampleTestChanges) obj)._DecreaseBySampleSizeReason) && object.Equals((object) this._SampleType, (object) ((SampleTestChanges) obj)._SampleType))) && (object.Equals((object) this._ObjectToChange, (object) ((SampleTestChanges) obj)._ObjectToChange) && object.Equals((object) this._SubClassification, (object) ((SampleTestChanges) obj)._SubClassification) && (object.Equals((object) this._Base, (object) ((SampleTestChanges) obj)._Base) && object.Equals((object) this._Classification, (object) ((SampleTestChanges) obj)._Classification)) && (this.CompareArrays((Array) this._SampleDataPoints, (Array) ((SampleTestChanges) obj)._SampleDataPoints) && object.Equals((object) this._ScrapCountedRejectsByReason, (object) ((SampleTestChanges) obj)._ScrapCountedRejectsByReason) && (object.Equals((object) this._AllowMoveOnFailure, (object) ((SampleTestChanges) obj)._AllowMoveOnFailure) && object.Equals((object) this._Name, (object) ((SampleTestChanges) obj)._Name)))) && base.Equals(obj);
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

    public NamedObjectRef DecreaseByRejectCountReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseByRejectCountReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DecreaseByRejectCountReason));
      }
    }

    public Primitive<string> DefaultPEDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPEDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultPEDescription));
      }
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

    public NamedObjectRef DefaultFailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultFailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultFailureMode));
      }
    }

    public NamedObjectRef DecreaseBySampleSizeReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecreaseBySampleSizeReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DecreaseBySampleSizeReason));
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

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public RevisionedObjectRef[] SampleDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoints), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (SampleDataPoints));
      }
    }

    public Primitive<bool> ScrapCountedRejectsByReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapCountedRejectsByReason), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ScrapCountedRejectsByReason));
      }
    }

    public Primitive<bool> AllowMoveOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMoveOnFailure), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowMoveOnFailure));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
