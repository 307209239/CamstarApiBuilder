// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EndCollaboration
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
  public class EndCollaboration : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "EndCollaboration_CollaboratorRole")]
    protected NamedObjectRef _CollaboratorRole;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaboration_Collaborator")]
    protected NamedObjectRef _Collaborator;

    public override bool Equals(object obj)
    {
      return obj is EndCollaboration && object.Equals((object) this._CollaboratorRole, (object) ((EndCollaboration) obj)._CollaboratorRole) && object.Equals((object) this._Collaborator, (object) ((EndCollaboration) obj)._Collaborator) && base.Equals(obj);
    }

    public NamedObjectRef CollaboratorRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaboratorRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CollaboratorRole));
      }
    }

    public NamedObjectRef Collaborator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Collaborator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Collaborator));
      }
    }
  }
}
