// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportTargetDetail
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
  public class ExportTargetDetail : ExportImportStatus
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_FolderLocation")]
    protected Primitive<string> _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_DeliveryOption")]
    protected Enumeration<TargetSystemDeliveryOptionEnum, int> _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_ExportImportTargetId")]
    protected Primitive<int> _ExportImportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_ExportImportHeaderId")]
    protected Primitive<int> _ExportImportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "ExportTargetDetail_ExportImportName")]
    protected Primitive<string> _ExportImportName;

    public override bool Equals(object obj)
    {
      return obj is ExportTargetDetail && object.Equals((object) this._FolderLocation, (object) ((ExportTargetDetail) obj)._FolderLocation) && (object.Equals((object) this._DeliveryOption, (object) ((ExportTargetDetail) obj)._DeliveryOption) && object.Equals((object) this._ExportImportTargetId, (object) ((ExportTargetDetail) obj)._ExportImportTargetId)) && (object.Equals((object) this._ExportImportHeaderId, (object) ((ExportTargetDetail) obj)._ExportImportHeaderId) && object.Equals((object) this._ExportImportName, (object) ((ExportTargetDetail) obj)._ExportImportName)) && base.Equals(obj);
    }

    public Primitive<string> FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public Enumeration<TargetSystemDeliveryOptionEnum, int> DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Enumeration<TargetSystemDeliveryOptionEnum, int>) this.PropertyGet(nameof (DeliveryOption));
      }
    }

    public Primitive<int> ExportImportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportTargetId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportImportTargetId));
      }
    }

    public Primitive<int> ExportImportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportHeaderId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportImportHeaderId));
      }
    }

    public Primitive<string> ExportImportName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportName));
      }
    }
  }
}
