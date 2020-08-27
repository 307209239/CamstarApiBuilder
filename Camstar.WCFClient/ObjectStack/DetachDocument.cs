// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachDocument
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
  public class DetachDocument : AttachDocument
  {
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_ObjectType")]
    protected new Enumeration<ObjectTypeEnum, int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_AttachmentType")]
    protected new Enumeration<AttachmentTypeEnum, int> _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_InstanceRevision")]
    protected new Primitive<string> _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_IsDetached")]
    protected new Primitive<bool> _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_InstanceName")]
    protected new Primitive<string> _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_AttachedDocument")]
    protected new RevisionedObjectRef _AttachedDocument;

    public override bool Equals(object obj)
    {
      return obj is DetachDocument && object.Equals((object) this._ObjectType, (object) ((DetachDocument) obj)._ObjectType) && (object.Equals((object) this._AttachmentType, (object) ((DetachDocument) obj)._AttachmentType) && object.Equals((object) this._InstanceRevision, (object) ((DetachDocument) obj)._InstanceRevision)) && (object.Equals((object) this._IsDetached, (object) ((DetachDocument) obj)._IsDetached) && object.Equals((object) this._InstanceName, (object) ((DetachDocument) obj)._InstanceName) && object.Equals((object) this._AttachedDocument, (object) ((DetachDocument) obj)._AttachedDocument)) && base.Equals(obj);
    }

    public new Enumeration<ObjectTypeEnum, int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Enumeration<ObjectTypeEnum, int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Enumeration<AttachmentTypeEnum, int> AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Enumeration<AttachmentTypeEnum, int>) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public new Primitive<string> InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public new Primitive<bool> IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDetached));
      }
    }

    public new Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }

    public new RevisionedObjectRef AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (AttachedDocument));
      }
    }
  }
}
