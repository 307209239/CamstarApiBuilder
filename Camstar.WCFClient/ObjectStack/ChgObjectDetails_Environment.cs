// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgRevObjectDetails_Environment))]
  [KnownType(typeof (ChgContainerDetails_Environment))]
  [KnownType(typeof (ChgNamedObjectDetails_Environment))]
  [KnownType(typeof (ChgSubentityDetails_Environment))]
  [Serializable]
  public class ChgObjectDetails_Environment : ChangeAttributeDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectDetails_Environment_NewObject")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049474, false, false, false, null)]
    protected Environment _NewObject;

    public Environment NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
