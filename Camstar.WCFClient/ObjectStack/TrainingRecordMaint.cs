// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordMaint
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
  public class TrainingRecordMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_ObjectChanges")]
    protected TrainingRecordChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_TrainingRequirement")]
    protected RevisionedObjectRef _TrainingRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_StatusFilter")]
    protected NamedObjectRef _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is TrainingRecordMaint && object.Equals((object) this._ObjectChanges, (object) ((TrainingRecordMaint) obj)._ObjectChanges) && (object.Equals((object) this._TrainingRequirement, (object) ((TrainingRecordMaint) obj)._TrainingRequirement) && object.Equals((object) this._ObjectToChange, (object) ((TrainingRecordMaint) obj)._ObjectToChange)) && (object.Equals((object) this._StatusFilter, (object) ((TrainingRecordMaint) obj)._StatusFilter) && object.Equals((object) this._ParentDataObject, (object) ((TrainingRecordMaint) obj)._ParentDataObject)) && base.Equals(obj);
    }

    public TrainingRecordChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TrainingRecordChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public RevisionedObjectRef TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TrainingRequirement));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
