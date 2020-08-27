// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprocessActivity
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
  public class ReprocessActivity : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprocessActivity_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;

    public override bool Equals(object obj)
    {
      return obj is ReprocessActivity && object.Equals((object) this._ProcessObject, (object) ((ReprocessActivity) obj)._ProcessObject) && base.Equals(obj);
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }
  }
}
