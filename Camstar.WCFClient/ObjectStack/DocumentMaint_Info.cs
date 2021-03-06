﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentMaint_Info
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
  public class DocumentMaint_Info : RevisionedObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_ObjectChanges")]
    protected DocumentChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_DocumentRevision")]
    protected Info _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_DocumentName")]
    protected Info _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_DocumentProxy")]
    protected Info _DocumentProxy;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_BaseToChange")]
    protected new Info _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;

    public DocumentChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DocumentChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Info DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentName));
      }
    }

    public Info DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentProxy));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
