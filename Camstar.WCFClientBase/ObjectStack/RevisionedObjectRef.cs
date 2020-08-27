// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectRef
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RevisionedObjectRef : BaseObjectRef
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "RevisionOfRecord")]
    public bool? RevisionOfRecord { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Revision")]
    public string Revision { get; set; }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && string.IsNullOrEmpty(this.Name);
      }
    }

    public RevisionedObjectRef()
    {
    }

    public RevisionedObjectRef(string name)
    {
      this.Name = name;
      this.RevisionOfRecord = new bool?(true);
    }

    public RevisionedObjectRef(string name, string revision)
    {
      this.Name = name;
      this.Revision = revision;
    }

    public RevisionedObjectRef(string name, string revision, string cDOTypeName)
      : this(name, revision)
    {
      this.CDOTypeName = cDOTypeName;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if ((object) (obj as RevisionedObjectRef) != null)
      {
        int num1 = string.Compare(this.Name, (obj as RevisionedObjectRef).Name, StringComparison.CurrentCultureIgnoreCase) == 0 & string.Compare(this.Revision, (obj as RevisionedObjectRef).Revision, StringComparison.CurrentCultureIgnoreCase) == 0 ? 1 : 0;
        bool? revisionOfRecord1 = this.RevisionOfRecord;
        bool? revisionOfRecord2 = (obj as RevisionedObjectRef).RevisionOfRecord;
        int num2 = revisionOfRecord1.GetValueOrDefault() == revisionOfRecord2.GetValueOrDefault() & revisionOfRecord1.HasValue == revisionOfRecord2.HasValue ? 1 : 0;
        flag = (num1 & num2) != 0;
      }
      return flag;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(RevisionedObjectRef ref1, RevisionedObjectRef ref2)
    {
      return object.Equals((object) ref1, (object) ref2);
    }

    public static bool operator !=(RevisionedObjectRef ref1, RevisionedObjectRef ref2)
    {
      return !(ref1 == ref2);
    }

    public override string ToString()
    {
      string str = string.Empty;
      if (!string.IsNullOrEmpty(this.Name))
        str = this.Name;
      if (!string.IsNullOrEmpty(this.Revision))
        str = str + ":" + this.Revision;
      return str;
    }
  }
}
