// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventChecklist_Environment
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
  public class UpdateEventChecklist_Environment : UpdateEventDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventChecklist_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }
  }
}
