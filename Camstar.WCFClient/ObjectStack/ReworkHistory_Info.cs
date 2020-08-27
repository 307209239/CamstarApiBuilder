// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TransferReworkHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ReworkHistory_Info : MoveHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_Info_ReEntryStep")]
    protected Info _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_Info_CumulativeReworkStepCount")]
    protected Info _CumulativeReworkStepCount;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ReworkHistory_Info_EndReworkStep")]
    protected Info _EndReworkStep;

    public Info ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public Info CumulativeReworkStepCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CumulativeReworkStepCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CumulativeReworkStepCount));
      }
    }

    public Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Info EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndReworkStep));
      }
    }
  }
}
