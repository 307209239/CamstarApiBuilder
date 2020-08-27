// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Assignment_Info
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
  public class Assignment_Info : ProcessObjectTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Info_CurrentRole")]
    protected Info _CurrentRole;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Info_CurrentAssignee")]
    protected Info _CurrentAssignee;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Info_Assignee")]
    protected Info _Assignee;

    public Info CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentRole));
      }
    }

    public Info AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Info CurrentAssignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentAssignee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentAssignee));
      }
    }

    public Info Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
