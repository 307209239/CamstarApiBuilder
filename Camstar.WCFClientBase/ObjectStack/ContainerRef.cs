// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerRef : BaseObjectRef
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Level")]
    public NamedObjectRef Level { get; set; }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && string.IsNullOrEmpty(this.Name);
      }
    }

    public ContainerRef()
    {
    }

    public ContainerRef(string name)
    {
      this.Name = name;
    }

    public ContainerRef(string name, string level)
      : this(name)
    {
      this.Level = new NamedObjectRef(level);
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as ContainerRef) != null)
        flag = string.Compare(this.Name, (obj as ContainerRef).Name, StringComparison.CurrentCultureIgnoreCase) == 0 & this.Level == (obj as ContainerRef).Level;
      return flag;
    }

    public static bool operator ==(ContainerRef ref1, ContainerRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator !=(ContainerRef ref1, ContainerRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!string.IsNullOrEmpty(this.Name))
        str = this.Name;
      if (this.Level != (NamedObjectRef) null)
        str = str + "(" + this.Level.ToString() + ")";
      return str;
    }
  }
}
