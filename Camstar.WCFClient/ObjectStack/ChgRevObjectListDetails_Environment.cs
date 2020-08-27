// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgRevObjectListDetails_Environment
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
  public class ChgRevObjectListDetails_Environment : ChgObjectListDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgRevObjectListDetails_Environment_NewObjects")]
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 1049473, false, true, false, null)]
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
