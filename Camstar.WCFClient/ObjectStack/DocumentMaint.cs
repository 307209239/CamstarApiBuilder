// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocumentMaint
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
  public class DocumentMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_ObjectChanges")]
    protected DocumentChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_DocumentRevision")]
    protected Primitive<string> _DocumentRevision;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_DocumentName")]
    protected Primitive<string> _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_DocumentProxy")]
    protected RevisionedObjectRef _DocumentProxy;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "DocumentMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is DocumentMaint && object.Equals((object) this._ObjectChanges, (object) ((DocumentMaint) obj)._ObjectChanges) && (object.Equals((object) this._DocumentRevision, (object) ((DocumentMaint) obj)._DocumentRevision) && object.Equals((object) this._DocumentName, (object) ((DocumentMaint) obj)._DocumentName)) && (object.Equals((object) this._DocumentProxy, (object) ((DocumentMaint) obj)._DocumentProxy) && object.Equals((object) this._ObjectToChange, (object) ((DocumentMaint) obj)._ObjectToChange) && (object.Equals((object) this._BaseToChange, (object) ((DocumentMaint) obj)._BaseToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((DocumentMaint) obj)._ObjectListInquiry))) && base.Equals(obj);
    }

    public DocumentChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DocumentChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<string> DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentRevision));
      }
    }

    public Primitive<string> DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DocumentName));
      }
    }

    public RevisionedObjectRef DocumentProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentProxy), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DocumentProxy));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
