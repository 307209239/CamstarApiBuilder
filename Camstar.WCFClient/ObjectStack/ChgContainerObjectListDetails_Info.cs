// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerObjectListDetails_Info
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
  public class ChgContainerObjectListDetails_Info : ChgObjectListDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerObjectListDetails_Info_NewObjects")]
    protected new Info _NewObjects;

    public new Info NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
