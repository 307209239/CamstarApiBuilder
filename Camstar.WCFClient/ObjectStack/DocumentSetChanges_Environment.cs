// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentSetChanges_Environment
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
  public class DocumentSetChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Environment_DocumentEntryItem")]
    [Metadata("Changes CDO for DocumentEntry.", "DocumentEntryChanges", false, false, false, "DocumentEntryChanges", 1049795, true, false, false, null)]
    protected DocumentEntryChanges_Environment _DocumentEntryItem;
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Environment_DocumentEntries")]
    [Metadata("Changes CDO for DocumentEntry.", "DocumentEntryChanges", false, true, false, "DocumentEntryChanges", 1048894, false, true, false, null)]
    protected DocumentEntryChanges_Environment _DocumentEntries;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050061, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocumentSetChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public DocumentEntryChanges_Environment DocumentEntryItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntryItem), (object) value);
      }
      get
      {
        return (DocumentEntryChanges_Environment) this.PropertyGet(nameof (DocumentEntryItem));
      }
    }

    public DocumentEntryChanges_Environment DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntryChanges_Environment) this.PropertyGet(nameof (DocumentEntries));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
