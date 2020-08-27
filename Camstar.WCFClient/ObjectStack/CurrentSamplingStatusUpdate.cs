// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentSamplingStatusUpdate
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
  public class CurrentSamplingStatusUpdate : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_NewInspectionLevel")]
    protected NamedObjectRef _NewInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_ServiceDetails")]
    protected Camstar.WCF.ObjectStack.SamplingCurrentStatus[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_SamplingCurrentStatus")]
    protected Camstar.WCF.ObjectStack.SamplingCurrentStatus[] _SamplingCurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_NewSampleRateCounterValue")]
    protected Primitive<int> _NewSampleRateCounterValue;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_ResetInspectionLevel")]
    protected Primitive<bool> _ResetInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "CurrentSamplingStatusUpdate_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is CurrentSamplingStatusUpdate && object.Equals((object) this._NewInspectionLevel, (object) ((CurrentSamplingStatusUpdate) obj)._NewInspectionLevel) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((CurrentSamplingStatusUpdate) obj)._ServiceDetails) && this.CompareArrays((Array) this._SamplingCurrentStatus, (Array) ((CurrentSamplingStatusUpdate) obj)._SamplingCurrentStatus)) && (object.Equals((object) this._NewSampleRateCounterValue, (object) ((CurrentSamplingStatusUpdate) obj)._NewSampleRateCounterValue) && object.Equals((object) this._TrackableObject, (object) ((CurrentSamplingStatusUpdate) obj)._TrackableObject) && (object.Equals((object) this._ResetInspectionLevel, (object) ((CurrentSamplingStatusUpdate) obj)._ResetInspectionLevel) && object.Equals((object) this._Product, (object) ((CurrentSamplingStatusUpdate) obj)._Product))) && base.Equals(obj);
    }

    public NamedObjectRef NewInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewInspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NewInspectionLevel));
      }
    }

    public Camstar.WCF.ObjectStack.SamplingCurrentStatus[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.SamplingCurrentStatus[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Camstar.WCF.ObjectStack.SamplingCurrentStatus[] SamplingCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingCurrentStatus), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.SamplingCurrentStatus[]) this.PropertyGet(nameof (SamplingCurrentStatus));
      }
    }

    public Primitive<int> NewSampleRateCounterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewSampleRateCounterValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NewSampleRateCounterValue));
      }
    }

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Primitive<bool> ResetInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetInspectionLevel), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ResetInspectionLevel));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
