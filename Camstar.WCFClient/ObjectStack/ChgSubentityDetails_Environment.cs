// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgSubentityDetails_Environment
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
  public class ChgSubentityDetails_Environment : ChgObjectDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgSubentityDetails_Environment_NewObject")]
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.", "Subentity", false, false, false, "SubentityRef", 1049474, false, false, false, null)]
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
