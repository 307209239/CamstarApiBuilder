// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityDispHistory
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
  public class CompleteActivityDispHistory : CompleteActivityHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDispHistory_Disposition")]
    protected NamedObjectRef _Disposition;

    public override bool Equals(object obj)
    {
      return obj is CompleteActivityDispHistory && object.Equals((object) this._Disposition, (object) ((CompleteActivityDispHistory) obj)._Disposition) && base.Equals(obj);
    }

    public NamedObjectRef Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Disposition));
      }
    }
  }
}
