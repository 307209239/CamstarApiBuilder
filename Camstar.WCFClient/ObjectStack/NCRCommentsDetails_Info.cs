// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCommentsDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRPreventiveActionDetails_Info))]
  [KnownType(typeof (NCRCorrectiveActionDetails_Info))]
  [KnownType(typeof (NCRFailureInvestigationDetails_Info))]
  [Serializable]
  public class NCRCommentsDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCommentsDetails_Info_Comments")]
    protected Info _Comments;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
