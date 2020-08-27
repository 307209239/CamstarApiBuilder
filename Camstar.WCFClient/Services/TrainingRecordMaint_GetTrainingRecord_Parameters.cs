// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingRecordMaint_GetTrainingRecord_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TrainingRecordMaint_GetTrainingRecord_Parameters : TrainingRecordMaint_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRequirement")]
    protected string _TrainingRequirement;

    public string TrainingRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRequirement), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (TrainingRequirement));
      }
    }
  }
}
