// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachDocument_Info
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
  public class DetachDocument_Info : AttachDocument_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_ObjectType")]
    protected new Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_AttachmentType")]
    protected new Info _AttachmentType;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_InstanceRevision")]
    protected new Info _InstanceRevision;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_IsDetached")]
    protected new Info _IsDetached;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_InstanceName")]
    protected new Info _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "DetachDocument_Info_AttachedDocument")]
    protected new Info _AttachedDocument;

    public new Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Info AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public new Info InstanceRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceRevision));
      }
    }

    public new Info IsDetached
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDetached), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDetached));
      }
    }

    public new Info InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceName));
      }
    }

    public new Info AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachedDocument));
      }
    }
  }
}
