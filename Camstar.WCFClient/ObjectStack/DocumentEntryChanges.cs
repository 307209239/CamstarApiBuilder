// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentEntryChanges
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
  public class DocumentEntryChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentEntryChanges_Document")]
    protected RevisionedObjectRef _Document;

    public override bool Equals(object obj)
    {
      return obj is DocumentEntryChanges && object.Equals((object) this._Name, (object) ((DocumentEntryChanges) obj)._Name) && (object.Equals((object) this._Description, (object) ((DocumentEntryChanges) obj)._Description) && object.Equals((object) this._DocumentSet, (object) ((DocumentEntryChanges) obj)._DocumentSet)) && (object.Equals((object) this._ObjectToChange, (object) ((DocumentEntryChanges) obj)._ObjectToChange) && object.Equals((object) this._Document, (object) ((DocumentEntryChanges) obj)._Document)) && base.Equals(obj);
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef Document
    {
      [param: In] set
      {
        this.PropertySet(nameof (Document), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Document));
      }
    }
  }
}
