// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttrDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerMaintDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgContainerAttrDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("This is the history detail object of the ChgContainerAttribute service.", "ChgContainerAttrHistDetail", false, false, false, "SubentityRef", 1050289, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrDetail_Environment_PreHistoryDetail")]
    protected Environment _PreHistoryDetail;

    public Environment PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreHistoryDetail));
      }
    }
  }
}
