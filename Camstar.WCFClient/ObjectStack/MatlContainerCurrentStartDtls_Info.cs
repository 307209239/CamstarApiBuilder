// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MatlContainerCurrentStartDtls_Info
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
  public class MatlContainerCurrentStartDtls_Info : CurrentStatusStartDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Info_WorkflowStep")]
    protected new Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "MatlContainerCurrentStartDtls_Info_Workflow")]
    protected new Info _Workflow;

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public new Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public new Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }
  }
}
