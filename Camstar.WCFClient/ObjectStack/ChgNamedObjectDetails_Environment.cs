// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgNamedObjectDetails_Environment
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
  public class ChgNamedObjectDetails_Environment : ChgObjectDetails_Environment
  {
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1049475, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgNamedObjectDetails_Environment_NewObject")]
    protected new Environment _NewObject;

    public new Environment NewObject
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
