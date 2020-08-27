// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_ValidateTrainingRequirement_Parameters
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
  public class ShopFloor_ValidateTrainingRequirement_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecord")]
    protected string _TrainingRecord;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReq")]
    protected string _TrainingReq;

    public string TrainingRecord
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingRecord), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (TrainingRecord));
      }
    }

    public string TrainingReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReq), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (TrainingReq));
      }
    }
  }
}
