// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BaseObjectRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerRef))]
  [KnownType(typeof (NamedObjectRef))]
  [KnownType(typeof (RevisionedObjectRef))]
  [KnownType(typeof (SubentityRef))]
  [KnownType(typeof (NamedSubentityRef))]
  [Serializable]
  public class BaseObjectRef : DCObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ID")]
    public string ID { get; set; }

    public BaseObjectRef()
    {
    }

    public BaseObjectRef(string id)
    {
      this.ID = id;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as BaseObjectRef) != null)
        flag = string.Compare(this.ID, (obj as BaseObjectRef).ID, StringComparison.CurrentCultureIgnoreCase) == 0;
      return flag;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(BaseObjectRef ref1, BaseObjectRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(BaseObjectRef ref1, BaseObjectRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && string.IsNullOrEmpty(this.ID);
      }
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!string.IsNullOrEmpty(this.ID))
        str = this.ID;
      return str;
    }
  }
}
