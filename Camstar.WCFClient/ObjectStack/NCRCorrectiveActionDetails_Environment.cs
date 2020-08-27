// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCorrectiveActionDetails_Environment
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
  public class NCRCorrectiveActionDetails_Environment : NCRCommentsDetails_Environment
  {
    [Metadata("Notes/Comments", "", false, false, false, "String", 1050433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCorrectiveActionDetails_Environment_Comments")]
    protected new Environment _Comments;

    public new Environment Comments
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
