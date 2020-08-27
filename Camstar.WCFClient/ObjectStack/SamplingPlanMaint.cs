// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanMaint
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
  public class SamplingPlanMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanMaint_ObjectChanges")]
    protected SamplingPlanChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is SamplingPlanMaint && object.Equals((object) this._BaseToChange, (object) ((SamplingPlanMaint) obj)._BaseToChange) && (object.Equals((object) this._ObjectToChange, (object) ((SamplingPlanMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SamplingPlanMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ObjectChanges, (object) ((SamplingPlanMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
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

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public SamplingPlanChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SamplingPlanChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
