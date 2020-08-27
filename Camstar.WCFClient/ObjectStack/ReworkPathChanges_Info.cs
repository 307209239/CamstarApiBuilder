// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPathChanges_Info
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
  public class ReworkPathChanges_Info : PathChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Info_EndReworkStep")]
    protected Info _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Info_ReEntryStep")]
    protected Info _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Info_Steps")]
    protected StepChanges_Info _Steps;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPathChanges_Info_Name")]
    protected new Info _Name;

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

    public StepChanges_Info Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges_Info) this.PropertyGet(nameof (Steps));
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
