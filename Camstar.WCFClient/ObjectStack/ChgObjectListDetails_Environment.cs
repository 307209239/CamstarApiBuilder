// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgContainerObjectListDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgRevObjectListDetails_Environment))]
  [KnownType(typeof (ChgNamedObjectListDetails_Environment))]
  [Serializable]
  public class ChgObjectListDetails_Environment : ChangeAttributeDetails_Environment
  {
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049473, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListDetails_Environment_NewObjects")]
    protected Environment _NewObjects;

    public Environment NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
