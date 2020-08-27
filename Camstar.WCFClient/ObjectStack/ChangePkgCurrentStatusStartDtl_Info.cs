// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePkgCurrentStatusStartDtl_Info
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
  public class ChangePkgCurrentStatusStartDtl_Info : TrackObjCurrentStatusStartDtls_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_Info_Workflow")]
    protected new Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePkgCurrentStatusStartDtl_Info_SpecStep")]
    protected new Info _SpecStep;

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

    public new Info SpecStep
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
  }
}
