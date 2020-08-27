// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRequirementChanges_Info
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
  public class TrainingRequirementChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_ExpirationDate")]
    protected Info _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_ExpirationPeriod")]
    protected Info _ExpirationPeriod;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_Trainers")]
    protected Info _Trainers;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_SOPDoc")]
    protected Info _SOPDoc;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirementChanges_Info_Name")]
    protected new Info _Name;

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

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Info ExpirationPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationPeriod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExpirationPeriod));
      }
    }

    public Info Trainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Trainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Trainers));
      }
    }

    public Info SOPDoc
    {
      [param: In] set
      {
        this.PropertySet(nameof (SOPDoc), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SOPDoc));
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
