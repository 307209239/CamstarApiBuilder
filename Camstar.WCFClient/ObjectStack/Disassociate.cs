// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Disassociate
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
  public class Disassociate : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_DisassociateCandidate")]
    protected ContainerRef _DisassociateCandidate;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_DisassociateAll")]
    protected Primitive<bool> _DisassociateAll;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_ChildContainers")]
    protected ContainerRef[] _ChildContainers;

    public override bool Equals(object obj)
    {
      return obj is Disassociate && object.Equals((object) this._DisassociateCandidate, (object) ((Disassociate) obj)._DisassociateCandidate) && (object.Equals((object) this._DisassociateAll, (object) ((Disassociate) obj)._DisassociateAll) && this.CompareArrays((Array) this._ChildContainers, (Array) ((Disassociate) obj)._ChildContainers)) && base.Equals(obj);
    }

    public ContainerRef DisassociateCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateCandidate), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (DisassociateCandidate));
      }
    }

    public Primitive<bool> DisassociateAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateAll), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisassociateAll));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }
  }
}
