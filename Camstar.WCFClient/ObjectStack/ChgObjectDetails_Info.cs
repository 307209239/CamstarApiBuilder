// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgContainerDetails_Info))]
  [KnownType(typeof (ChgRevObjectDetails_Info))]
  [KnownType(typeof (ChgNamedObjectDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgSubentityDetails_Info))]
  [Serializable]
  public class ChgObjectDetails_Info : ChangeAttributeDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectDetails_Info_NewObject")]
    protected Info _NewObject;

    public Info NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
