// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentityRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NamedSubentityRef : SubentityRef
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && string.IsNullOrEmpty(this.Name);
      }
    }

    public NamedSubentityRef()
    {
    }

    public NamedSubentityRef(string name)
    {
      this.Name = name;
    }

    public NamedSubentityRef(string name, BaseObjectRef parent)
      : this(name)
    {
      this.Parent = parent;
    }

    public NamedSubentityRef(string name, BaseObjectRef parent, string cDOTypeName)
      : this(name, parent)
    {
      this.CDOTypeName = cDOTypeName;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as NamedSubentityRef) != null)
        flag = string.Equals(this.Name, (obj as NamedSubentityRef).Name) && object.Equals((object) this.Parent, (object) (obj as SubentityRef).Parent);
      return flag;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(NamedSubentityRef ref1, NamedSubentityRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(NamedSubentityRef ref1, NamedSubentityRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override string ToString()
    {
      return this.Name + "{" + base.ToString() + "}";
    }
  }
}
