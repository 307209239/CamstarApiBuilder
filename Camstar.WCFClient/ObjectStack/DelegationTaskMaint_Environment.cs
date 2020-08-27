// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskMaint_Environment
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
  public class DelegationTaskMaint_Environment : SubentityMaintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskMaint_Environment_ObjectToChange")]
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTask", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Delegation Task is used to configure a delegation task from an assignee to a target employee by date period\r\n", "DelegationTaskChanges", false, false, false, "DelegationTaskChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskMaint_Environment_ObjectChanges")]
    protected DelegationTaskChanges_Environment _ObjectChanges;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public DelegationTaskChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DelegationTaskChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
