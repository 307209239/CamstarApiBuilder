// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachDocument_Environment
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
  public class DetachDocument_Environment : AttachDocument_Environment
  {
    [Metadata("Enumeration used to identify what type of object a document is being attached to", "ObjectTypeEnum", false, false, false, "Integer", 16777526, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_ObjectType")]
    protected new Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_AttachmentType")]
    [Metadata("Enumeration used to indicate what type of document attachment will be perfomed:\r\n1 - Attach a new document that will not be reused (no Revision needed)\r\n2 - Attach a new document that will be reused (Revision must be provided)\r\n3 - Attach an existing document", "AttachmentTypeEnum", false, false, false, "Integer", 16777572, false, false, true, "3")]
    protected new Environment _AttachmentType;
    [Metadata("Generic String", "", false, false, false, "String", 1053078, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_InstanceRevision")]
    protected new Environment _InstanceRevision;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777556, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_IsDetached")]
    protected new Environment _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_InstanceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, true, null)]
    protected new Environment _InstanceName;
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, true, false, "RevisionedObjectRef", 16777569, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Environment_AttachedDocument")]
    protected new Environment _AttachedDocument;

    public new Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Environment AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public new Environment InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public new Environment IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDetached));
      }
    }

    public new Environment InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceName));
      }
    }

    public new Environment AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocument));
      }
    }
  }
}
