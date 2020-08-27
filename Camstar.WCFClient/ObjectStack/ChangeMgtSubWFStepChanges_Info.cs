// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtSubWFStepChanges_Info
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
  public class ChangeMgtSubWFStepChanges_Info : BPSubWorkflowStepChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSubWFStepChanges_Info_SubWorkflow")]
    protected new Info _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtSubWFStepChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public new Info SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubWorkflow));
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
  }
}
