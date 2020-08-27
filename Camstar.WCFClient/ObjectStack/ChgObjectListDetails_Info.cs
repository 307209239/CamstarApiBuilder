// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgRevObjectListDetails_Info))]
  [KnownType(typeof (ChgNamedObjectListDetails_Info))]
  [KnownType(typeof (ChgContainerObjectListDetails_Info))]
  [Serializable]
  public class ChgObjectListDetails_Info : ChangeAttributeDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListDetails_Info_NewObjects")]
    protected Info _NewObjects;

    public Info NewObjects
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
