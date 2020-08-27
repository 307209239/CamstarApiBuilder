// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventChecklist
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
  public class UpdateEventChecklist : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventChecklist_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventChecklist && object.Equals((object) this._ExecuteChecklist, (object) ((UpdateEventChecklist) obj)._ExecuteChecklist) && base.Equals(obj);
    }

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }
  }
}
