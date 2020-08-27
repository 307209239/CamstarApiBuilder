// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRequirementMaint
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
  public class TrainingRequirementMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_ObjectChanges")]
    protected TrainingRequirementChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;

    public override bool Equals(object obj)
    {
      return obj is TrainingRequirementMaint && object.Equals((object) this._ObjectToChange, (object) ((TrainingRequirementMaint) obj)._ObjectToChange) && (object.Equals((object) this._ObjectChanges, (object) ((TrainingRequirementMaint) obj)._ObjectChanges) && object.Equals((object) this._BaseToChange, (object) ((TrainingRequirementMaint) obj)._BaseToChange)) && base.Equals(obj);
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

    public TrainingRequirementChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TrainingRequirementChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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
  }
}
