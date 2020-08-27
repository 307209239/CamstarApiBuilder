// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordMaint_Info
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
  public class TrainingRecordMaint_Info : SubentityMaintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Info_ObjectChanges")]
    protected TrainingRecordChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Info_TrainingRequirement")]
    protected Info _TrainingRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Info_StatusFilter")]
    protected Info _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;

    public TrainingRecordChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TrainingRecordChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingRequirement));
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

    public Info StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
