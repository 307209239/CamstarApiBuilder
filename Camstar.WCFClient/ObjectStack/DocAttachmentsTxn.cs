// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsTxn
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
  public class DocAttachmentsTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_DocDetail")]
    protected AttachedDocDetail _DocDetail;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Attachments")]
    protected DocAttachments _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_AttachmentsLocation")]
    protected Primitive<string> _AttachmentsLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_TrackableOwner")]
    protected BaseObjectRef _TrackableOwner;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_AttachmentsOwner")]
    protected BaseObjectRef _AttachmentsOwner;

    public override bool Equals(object obj)
    {
      return obj is DocAttachmentsTxn && object.Equals((object) this._DocDetail, (object) ((DocAttachmentsTxn) obj)._DocDetail) && (object.Equals((object) this._Attachments, (object) ((DocAttachmentsTxn) obj)._Attachments) && object.Equals((object) this._AttachmentsLocation, (object) ((DocAttachmentsTxn) obj)._AttachmentsLocation)) && (object.Equals((object) this._TrackableOwner, (object) ((DocAttachmentsTxn) obj)._TrackableOwner) && object.Equals((object) this._AttachmentsOwner, (object) ((DocAttachmentsTxn) obj)._AttachmentsOwner)) && base.Equals(obj);
    }

    public AttachedDocDetail DocDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocDetail), (object) value);
      }
      get
      {
        return (AttachedDocDetail) this.PropertyGet(nameof (DocDetail));
      }
    }

    public DocAttachments Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments) this.PropertyGet(nameof (Attachments));
      }
    }

    public Primitive<string> AttachmentsLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttachmentsLocation));
      }
    }

    public BaseObjectRef TrackableOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableOwner), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableOwner));
      }
    }

    public BaseObjectRef AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }
  }
}
