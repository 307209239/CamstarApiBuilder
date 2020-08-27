// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SubentityRef : BaseObjectRef
  {
    [DataMember(EmitDefaultValue = false, Name = "Parent")]
    public BaseObjectRef Parent { get; set; }

    public SubentityRef()
    {
    }

    public SubentityRef(string id)
    {
      this.ID = id;
    }

    public SubentityRef(string id, BaseObjectRef parent)
      : this(id)
    {
      this.Parent = parent;
    }

    public SubentityRef(string id, BaseObjectRef parent, string cDOTypeName)
      : this(id, parent)
    {
      this.CDOTypeName = cDOTypeName;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as SubentityRef) != null)
        flag = base.Equals(obj) && object.Equals((object) this.Parent, (object) (obj as SubentityRef).Parent);
      return flag;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(SubentityRef ref1, SubentityRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(SubentityRef ref1, SubentityRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!string.IsNullOrEmpty(this.ID))
        str = this.ID;
      if (this.Parent != (BaseObjectRef) null)
        str = str + "{" + this.Parent.ToString() + "}";
      return str;
    }
  }
}
