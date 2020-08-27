// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkStatusStartDetails_Info
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
  public class ReworkStatusStartDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_Info_ReEntryStep")]
    protected Info _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_Info_EndReworkStep")]
    protected Info _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_Info_ReworkReason")]
    protected Info _ReworkReason;

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
  }
}
