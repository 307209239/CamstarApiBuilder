// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackObjCurrentStatusStartDtls_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangePkgCurrentStatusStartDtl_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TrackObjCurrentStatusStartDtls_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_Info_SpecStep")]
    protected Info _SpecStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackObjCurrentStatusStartDtls_Info_WorkflowStep")]
    protected Info _WorkflowStep;

    public Info Workflow
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

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public Info SpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecStep));
      }
    }

    public Info WorkflowStep
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
  }
}
