// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentSetChanges
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
  public class DocumentSetChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_DocumentEntryItem")]
    protected DocumentEntryChanges _DocumentEntryItem;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_DocumentEntries")]
    protected DocumentEntryChanges[] _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is DocumentSetChanges && object.Equals((object) this._DocumentEntryItem, (object) ((DocumentSetChanges) obj)._DocumentEntryItem) && (this.CompareArrays((Array) this._DocumentEntries, (Array) ((DocumentSetChanges) obj)._DocumentEntries) && object.Equals((object) this._Name, (object) ((DocumentSetChanges) obj)._Name)) && object.Equals((object) this._ObjectToChange, (object) ((DocumentSetChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public DocumentEntryChanges DocumentEntryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntryItem), (object) value);
      }
      get
      {
        return (DocumentEntryChanges) this.PropertyGet(nameof (DocumentEntryItem));
      }
    }

    public DocumentEntryChanges[] DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntryChanges[]) this.PropertyGet(nameof (DocumentEntries));
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
  }
}
