// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateDisposition
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
  public class PlanTemplateDisposition : PlanTemplate
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDisposition_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is PlanTemplateDisposition && object.Equals((object) this._Name, (object) ((PlanTemplateDisposition) obj)._Name) && base.Equals(obj);
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
