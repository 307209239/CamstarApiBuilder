// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgNamedObjectListDetails_Environment
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
  public class ChgNamedObjectListDetails_Environment : ChgObjectListDetails_Environment
  {
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1049473, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgNamedObjectListDetails_Environment_NewObjects")]
    protected new Environment _NewObjects;

    public new Environment NewObjects
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
