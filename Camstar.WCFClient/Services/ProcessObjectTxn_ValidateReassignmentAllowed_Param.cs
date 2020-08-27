// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTxn_ValidateReassignmentAllowed_Parameters
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
  public class ProcessObjectTxn_ValidateReassignmentAllowed_Parameters : ProcessObjectTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Assignee")]
    protected string _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "AssigneeRole")]
    protected string _AssigneeRole;

    public string Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Assignee));
      }
    }

    public string AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (AssigneeRole));
      }
    }
  }
}
