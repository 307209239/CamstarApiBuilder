// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueReasonChanges
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
  public class IssueReasonChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_ApplyToReq")]
    protected Primitive<bool> _ApplyToReq;
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is IssueReasonChanges && object.Equals((object) this._ObjectToChange, (object) ((IssueReasonChanges) obj)._ObjectToChange) && (object.Equals((object) this._ApplyToReq, (object) ((IssueReasonChanges) obj)._ApplyToReq) && object.Equals((object) this._Name, (object) ((IssueReasonChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> ApplyToReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyToReq), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApplyToReq));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
