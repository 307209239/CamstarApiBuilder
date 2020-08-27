// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedObjectRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NamedObjectRef : BaseObjectRef
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

    public NamedObjectRef()
    {
    }

    public NamedObjectRef(string name)
    {
      this.Name = name;
    }

    public NamedObjectRef(string name, string cDOTypeName)
      : this(name)
    {
      this.CDOTypeName = cDOTypeName;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as NamedObjectRef) != null)
        flag = string.Compare(this.Name, (obj as NamedObjectRef).Name, StringComparison.CurrentCultureIgnoreCase) == 0;
      return flag;
    }

    public static bool operator ==(NamedObjectRef ref1, NamedObjectRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(NamedObjectRef ref1, NamedObjectRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!string.IsNullOrEmpty(this.Name))
        str = this.Name;
      return str;
    }

    public static string GetName(NamedObjectRef ndoRef)
    {
      return !(ndoRef != (NamedObjectRef) null) ? (string) null : ndoRef.Name;
    }
  }
}
