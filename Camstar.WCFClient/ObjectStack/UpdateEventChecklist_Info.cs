// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventChecklist_Info
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
  public class UpdateEventChecklist_Info : UpdateEventDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventChecklist_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }
  }
}
