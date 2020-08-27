// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EndCollaboration_Info
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
  public class EndCollaboration_Info : ProcessObjectTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EndCollaboration_Info_CollaboratorRole")]
    protected Info _CollaboratorRole;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaboration_Info_Collaborator")]
    protected Info _Collaborator;

    public Info CollaboratorRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollaboratorRole));
      }
    }

    public Info Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Collaborator));
      }
    }
  }
}
