// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Assignment
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
  public class Assignment : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Assignment_CurrentRole")]
    protected NamedObjectRef _CurrentRole;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_CurrentAssignee")]
    protected NamedObjectRef _CurrentAssignee;
    [DataMember(EmitDefaultValue = false, Name = "Assignment_Assignee")]
    protected NamedObjectRef _Assignee;

    public override bool Equals(object obj)
    {
      return obj is Assignment && object.Equals((object) this._CurrentRole, (object) ((Assignment) obj)._CurrentRole) && (object.Equals((object) this._AssigneeRole, (object) ((Assignment) obj)._AssigneeRole) && object.Equals((object) this._CurrentAssignee, (object) ((Assignment) obj)._CurrentAssignee)) && object.Equals((object) this._Assignee, (object) ((Assignment) obj)._Assignee) && base.Equals(obj);
    }

    public NamedObjectRef CurrentRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CurrentRole));
      }
    }

    public NamedObjectRef AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public NamedObjectRef CurrentAssignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentAssignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CurrentAssignee));
      }
    }

    public NamedObjectRef Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
