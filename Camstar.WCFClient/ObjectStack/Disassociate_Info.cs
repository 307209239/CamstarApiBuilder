// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Disassociate_Info
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
  public class Disassociate_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Info_DisassociateCandidate")]
    protected Info _DisassociateCandidate;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Info_DisassociateAll")]
    protected Info _DisassociateAll;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Info_ChildContainers")]
    protected Info _ChildContainers;

    public Info DisassociateCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateCandidate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisassociateCandidate));
      }
    }

    public Info DisassociateAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateAll), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisassociateAll));
      }
    }

    public Info ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainers));
      }
    }
  }
}
