// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsTxn_Info
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
  public class DocAttachmentsTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Info_DocDetail")]
    protected AttachedDocDetail_Info _DocDetail;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Info_Attachments")]
    protected DocAttachments_Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Info_AttachmentsLocation")]
    protected Info _AttachmentsLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Info_TrackableOwner")]
    protected Info _TrackableOwner;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Info_AttachmentsOwner")]
    protected Info _AttachmentsOwner;

    public AttachedDocDetail_Info DocDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocDetail), (object) value);
      }
      get
      {
        return (AttachedDocDetail_Info) this.PropertyGet(nameof (DocDetail));
      }
    }

    public DocAttachments_Info Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments_Info) this.PropertyGet(nameof (Attachments));
      }
    }

    public Info AttachmentsLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentsLocation));
      }
    }

    public Info TrackableOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableOwner));
      }
    }

    public Info AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }
  }
}
