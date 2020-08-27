// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsTxn_Environment
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
  public class DocAttachmentsTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Environment_DocDetail")]
    [Metadata("Attached Document Service Details", "AttachedDocDetail", false, false, false, "AttachedDocDetail", 1051129, true, false, false, null)]
    protected AttachedDocDetail_Environment _DocDetail;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Environment_Attachments")]
    [Metadata("Document Attachments", "DocAttachments", false, false, false, "DocAttachments", 1051144, false, false, false, null)]
    protected DocAttachments_Environment _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Environment_AttachmentsLocation")]
    [Metadata("URL", "", false, false, false, "String", 1051149, false, false, false, null)]
    protected Environment _AttachmentsLocation;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Environment_TrackableOwner")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051446, false, false, false, null)]
    protected Environment _TrackableOwner;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051143, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsTxn_Environment_AttachmentsOwner")]
    protected Environment _AttachmentsOwner;

    public AttachedDocDetail_Environment DocDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocDetail), (object) value);
      }
      get
      {
        return (AttachedDocDetail_Environment) this.PropertyGet(nameof (DocDetail));
      }
    }

    public DocAttachments_Environment Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments_Environment) this.PropertyGet(nameof (Attachments));
      }
    }

    public Environment AttachmentsLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentsLocation));
      }
    }

    public Environment TrackableOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableOwner));
      }
    }

    public Environment AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }
  }
}
