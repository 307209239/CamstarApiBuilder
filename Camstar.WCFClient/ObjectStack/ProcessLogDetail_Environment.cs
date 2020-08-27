// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessLogDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CollaborationLogDetail_Environment))]
  [Serializable]
  public class ProcessLogDetail_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessLogDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
